using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Data.Entity;
using System.Data.EntityModel;
using System.Data.Sql;
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
    internal class ASPNETObjectDumperStep : IPipelineStep
    {
        ZetaCrawlerEntities db;

        public ASPNETObjectDumperStep()
        {
            db = new ZetaCrawlerEntities();            
        }

        #region IPipelineStep Members

        public bool IsDuplicate(string url)
        {
            var p = from q in db.ASPNETObjects
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
                ASPNETObject item = new ASPNETObject();                                
                item.OriginalUrl = propertyBag.Step.Uri.ToString();

                if (!IsDuplicate(item.OriginalUrl))
                {
                    item.Title = propertyBag.Title;
                    item.StatusDescription = propertyBag.StatusDescription;
                    item.ResponseUri = propertyBag.ResponseUri.ToString();
                    item.Text = null;
                    item.Depth = propertyBag.Step.Depth;
                    item.LastModified = propertyBag.LastModified;
                    item.OriginalReferrerUrl = propertyBag.OriginalReferrerUrl.ToString();
                    item.Server = propertyBag.Server;                                                            
                    //Clean the text field is null                    
                    db.AddToASPNETObjects(item);                    
                    item.ContentEncoding = propertyBag.ContentEncoding;
                    item.ContentType = propertyBag.ContentType;
                    item.IsToEmail = false;
                    item.Summary = propertyBag.Title;

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