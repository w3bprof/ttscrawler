using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Data.Sql;
using NCrawler.Extensions;
using NCrawler.HtmlProcessor;
using NCrawler.LanguageDetection.Google;
using NCrawler.Interfaces;
using NCrawler.Demo.Extensions;
using NCrawler.MP3Processor;
using System.Data;
//using System.Data.Extracting;

namespace NCrawler.Demo
{
    #region Nested type: DumperStep

    /// <summary>
    /// Custom pipeline step, to dump url to console
    /// </summary>
    internal class Mp3ZingDumperStep : IPipelineStep
    {                
        ZetaCrawlerEntities db;

        public Mp3ZingDumperStep()
        {
            db = new ZetaCrawlerEntities();
        }

        #region IPipelineStep Members

        /// <summary>
        /// </summary>
        /// <param name="crawler">
        /// The crawler.
        /// </param>
        /// <param name="propertyBag">
        /// The property bag.
        /// </param>
        public void Process(Crawler crawler, PropertyBag propertyBag)
        {
            CultureInfo contentCulture = (CultureInfo)propertyBag["LanguageCulture"].Value;
            string cultureDisplayValue = "N/A";
            if (!contentCulture.IsNull())
            {
                cultureDisplayValue = contentCulture.DisplayName;
            }

            TextExtraction t = new TextExtraction();

            lock (this)
            {
                Mp3ZingItem item = new Mp3ZingItem();                
                item.Url = propertyBag.Step.Uri.ToString();

                if (item.Url.StartsWith("http://mp3.zing.vn/mp3/nghe-bai-hat"))
                {
                    item.Text = propertyBag.Text.IsNull() ? "" : propertyBag.Text;
                    item.Title = propertyBag.Title;
                    item.Length = propertyBag.Text.IsNull() ? 0 : propertyBag.Text.Length;
                    item.ContentType = propertyBag.ContentType;
                    item.ContentEncoding = propertyBag.ContentEncoding;
                    item.Depth = propertyBag.Step.Depth;
                    //item.CultureDisplayValue = cultureDisplayValue;
                    string[] strSplit = {"|"};
                    item.Subject = propertyBag.Title.Split(strSplit, StringSplitOptions.None)[0];

                    db.AddToMp3ZingItem(item);
                }               
                

                //if (item.Url.StartsWith("http://bidvportal.vn/eDocman"))
                //{
                //    item.Title = propertyBag.Title;


                //    string strTarget = t.GetMinimumString(propertyBag.Text, "Chi tiết văn bản", "Nội dung văn bản");
                //    item.Text = strTarget;

                //    string strNgayPhatHanh = t.GetMinimumString(strTarget, "Ngày phát hành", "Số đi");
                //    item.NgayPhatHanh = strNgayPhatHanh.Replace(' ', '/');

                //    string strSubject = t.GetMinimumString(strTarget, "Trích yếu", "Độ khẩn");
                //    item.Subject = strSubject;

                //    item.ContentEncoding = propertyBag.ContentEncoding;
                //    item.ContentType = propertyBag.ContentType;
                //    item.Length = propertyBag.Text.IsNull() ? 0 : propertyBag.Text.Length;
                //    item.Depth = propertyBag.Step.Depth;
                //    //item.CultureDisplayValue = cultureDisplayValue;                       

                //    string[] strSplit = { "/" };
                //    int day = int.Parse(item.NgayPhatHanh.Split(strSplit, StringSplitOptions.None)[0]);
                //    int month = int.Parse(item.NgayPhatHanh.Split(strSplit, StringSplitOptions.None)[1]);
                //    int year = int.Parse(item.NgayPhatHanh.Split(strSplit, StringSplitOptions.None)[2]);

                //    if ((DateTime.Now.Year == year) && (DateTime.Now.Month == month) && (DateTime.Now.Day == day))
                //    {
                //        db.AddToItems(item);
                //    }
                //}
            }

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("=====================================================");
                Console.WriteLine(ex.Message);
            }
        }

        #endregion
    }

    #endregion
    
}
