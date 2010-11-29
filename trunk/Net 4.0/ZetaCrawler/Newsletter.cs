using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ZetaCrawler
{
    public class Newsletter
    {
        private ZetaCrawlerEntities _db;

        public Newsletter()
        {
            _db = new ZetaCrawlerEntities();
        }
        
        public static string BuildNewsletter()
        {
            string str = "<b>Newsletter </b><br /><br />";

            foreach (string tmp in GetNewsToday())
            {
                str += tmp;
            }

            return str;
        }


        public static List<string> GetNewsToday()
        {
            List<string> tmp = new List<string>();
            TextExtraction t = new TextExtraction();

            ZetaCrawlerEntities db = new ZetaCrawlerEntities();

            string[] strSplit = { "/" };

            var pBIDV = from q in db.BIDVObjects
                    where ((q.IsToEmail == false) && (q.LastModified.Value.Day == DateTime.Now.Day))
                    select q;                                    
            
            foreach (var item in pBIDV)
            {
                tmp.Add("<br />" + "[" + item.LastModified.ToString() + "] " + "<b>" + t.GetBetween2Words("Trích yếu: ", "Độ khẩn", item.Summary) + "</b><br />Xem chi tiết : " + item.OriginalUrl + "<br />");
                item.IsToEmail = true;
            }

            var pASPNET = from q in db.ASPNETObjects
                    where ((q.IsToEmail == false) &&(q.LastModified.Value.Day == DateTime.Now.Day) )
                    select q;

            foreach (var item in pASPNET)
            {
                tmp.Add("<br />" + "[" + item.LastModified.ToString() + "] " + "<b>" + item.Summary + "</b><br />Xem chi tiết : " + item.OriginalUrl + "<br />");
                item.IsToEmail = true;
            }

            db.SaveChanges();
            return tmp;
        }        
    }
}
