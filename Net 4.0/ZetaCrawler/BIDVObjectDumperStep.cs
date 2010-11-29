using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Data.Sql;
using System.Linq;
using NCrawler.Extensions;
using NCrawler.HtmlProcessor;
using NCrawler.LanguageDetection.Google;
using NCrawler.Interfaces;
using NCrawler.Demo.Extensions;
using NCrawler.MP3Processor;
using System.Data;
using NCrawler;


namespace ZetaCrawler
{
    #region Nested type: DumperStep

    /// <summary>
    /// Custom pipeline step, to dump url to console
    /// </summary>
    internal class BIDVObjectDumperStep : IPipelineStep
    {
        ZetaCrawlerEntities db;

        public BIDVObjectDumperStep()
        {
            db = new ZetaCrawlerEntities();            
        }

        #region IPipelineStep Members

        public bool IsDuplicate(string url)
        {
            var p = from q in db.BIDVObjects
                    select q.OriginalUrl;

            return p.ToList().Contains(url);
        }

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
                BIDVObject item = new BIDVObject();                                
                item.OriginalUrl = propertyBag.Step.Uri.ToString();
                                 
                if (!IsDuplicate(item.OriginalUrl))
                {
                    item.Title = propertyBag.Title;
                    item.StatusDescription = propertyBag.StatusDescription;
                    item.ResponseUri = propertyBag.ResponseUri.ToString();
                    item.Text = propertyBag.Text;
                    item.Depth = propertyBag.Step.Depth;
                    item.LastModified = propertyBag.LastModified;
                    item.OriginalReferrerUrl = propertyBag.OriginalReferrerUrl.ToString();
                    item.Server = propertyBag.Server;
                    string description = t.GetBetween2Words("Chi tiết văn bản", "Xem toàn màn hình", item.Text.Replace("\r","  ").Replace("\n","  "));
                    item.Summary = t.RemoveWhiteSpace(description);
                    

                    string strNgayPhatHanh = t.GetBetween2Words("Ngày phát hành", "Số đi", item.Summary);
                    strNgayPhatHanh = strNgayPhatHanh.Replace(' ', '/').Remove(0, ("Ngày phát hành").Length);
                    string[] strSplit = { "/" };
                    int day = int.Parse(strNgayPhatHanh.Split(strSplit, StringSplitOptions.None)[1]);
                    int month = int.Parse(strNgayPhatHanh.Split(strSplit, StringSplitOptions.None)[2]);
                    int year = int.Parse(strNgayPhatHanh.Split(strSplit, StringSplitOptions.None)[3]);

                    
                    //Clean the text field is null
                    item.Text = null;
                    item.IsToEmail = false;

                    db.AddToBIDVObjects(item);

                    item.ContentEncoding = propertyBag.ContentEncoding;
                    item.ContentType = propertyBag.ContentType;
                    //item.Length = propertyBag.Text.IsNull() ? 0 : propertyBag.Text.Length;                    
                    //item.CultureDisplayValue = cultureDisplayValue;                                                                                                                           
                }                
            }

            try
            {
                db.SaveChanges();                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }            
        }        

        #endregion        
    }

    #endregion
}