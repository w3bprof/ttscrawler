
using System;
using System.Collections.Generic;
using System.Collections;
using System.Globalization;
using System.IO;
using NCrawler.Extensions;
using NCrawler.HtmlProcessor;
using NCrawler.LanguageDetection.Google;
using NCrawler.Interfaces;
using NCrawler.Demo.Extensions;
using NCrawler.MP3Processor;

namespace NCrawler.Demo
{
    class BIDVCrawlerDemo
    {        
        public static void Run()
        {
            NCrawlerModule.Setup();
            Console.Out.WriteLine("Simple crawl demo");

            //// Setup crawler to crawl http://ncrawler.codeplex.com
            //// with 1 thread adhering to robot rules, and maximum depth
            //// of 2 with 4 pipeline steps:
            ////	* Step 1 - The Html Processor, parses and extracts links, text and more from html
            ////  * Step 2 - Processes PDF files, extracting text
            ////  * Step 3 - Try to determine language based on page, based on text extraction, using google language detection
            ////  * Step 4 - Dump the information to the console, this is a custom step, see the DumperStep class

            using (Crawler c = new Crawler(new Uri("http://bidvportal.vn/"),
                new HtmlDocumentProcessor(), // Process html
                new iTextSharpPdfProcessor.iTextSharpPdfProcessor(), // Add PDF text extraction
                new GoogleLanguageDetection(), // Add language detection
                new Mp3FileProcessor(), // Add language detection
                new DumperStep())
            {
                // Custom step to visualize crawl
                MaximumThreadCount = 10,
                MaximumCrawlDepth = 2,
                ExcludeFilter = Program.ExtensionsToSkip,
            })
            {
                // Begin crawl
                c.Crawl();
            }

            try
            {
                EmailHelper.SendEmail();
            }
            catch (Exception ex)
            {
                Console.WriteLine("=====================================================");
                Console.WriteLine(ex.Message);
            }
        }
    }    
}