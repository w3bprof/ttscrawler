using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZetaCrawler
{
    public class BIDVMsg
    {
        ZetaCrawlerEntities db = new ZetaCrawlerEntities();

        public static string BuildEmailMsg()
        {
            string str = "<b>BIDV NEWS : AUTO UPDATE </b><br /><br />";

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

            var p = from q in db.BIDVObjects
                    where ((q.LastModified.Value.Day >= DateTime.Today.Day) && (q.LastModified.Value.Month == DateTime.Today.Month) && (q.LastModified.Value.Year == DateTime.Today.Year))
                    select q;

            foreach (var item in p)
            {                
                tmp.Add("<br />" + "[" + item.LastModified.ToString() + "] " + "<b>" + t.GetBetween2Words("Trích yếu: ", "Độ khẩn", item.Summary) + "</b><br />Xem chi tiết : " + item.OriginalUrl + "<br />");                
            }

            return tmp;
        }
    }
}
