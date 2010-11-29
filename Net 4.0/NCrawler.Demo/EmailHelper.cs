using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NCrawler.Demo
{
    public static class EmailHelper
    {
        public static void Mp3TopEmail()
        {
            SendGmail email = new SendGmail();

            try
            {
                email.SendMail("kieuchinh.phan@yahoo.com", "BẢNG XẾP HẠNG ÂM NHẠC", Mp3TopBuildEmail(), true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception has occurred: " + ex.Message);
            }
        }

        public static string Mp3TopBuildEmail()
        {
            string str = "<b>BẢNG XẾP HẠNG ÂM NHẠC</b><br /><br />";

            foreach (string tmp in GetMp3Top())
            {
                str += tmp;
            }

            return str;
        }

        public static List<string> GetMp3Top()
        {
            List<string> tmp = new List<string>();

            ZetaCrawlerEntities db = new ZetaCrawlerEntities();

            string[] strSplit = { "/" };

            foreach (var item in db.Mp3ZingItem)
            {
                //int day = int.Parse(item.NgayPhatHanh.Split(strSplit, StringSplitOptions.None)[0]);
                //int month = int.Parse(item.NgayPhatHanh.Split(strSplit, StringSplitOptions.None)[1]);
                //int year = int.Parse(item.NgayPhatHanh.Split(strSplit, StringSplitOptions.None)[2]);

                //if ((DateTime.Now.Year == year) && (DateTime.Now.Month == month) && (DateTime.Now.Day == day))
                //{
                //    tmp.Add("<br /><b>" + item.Subject + "</b><br />Xem chi tiết : " + item.Url + "<br />");
                //}

                tmp.Add("<br /><b>" + item.Subject + "</b><br />Xem chi tiết : " + item.Url + "<br />");
            }

            return tmp;
        }

            public static void SendEmail()
            {
                SendGmail email = new SendGmail();

                try
                {
                    email.SendMail("taipm@bidc.vn", "BIDV - TIN MỚI CẬP NHẬT", BuildEmailMsg(), true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An exception has occurred: " + ex.Message);
                }
            }
        
          
            public static string BuildEmailMsg()
            {
                string str = "<b>TIN MỚI TỪ BIDV TRONG NGÀY</b><br /><br />";

                foreach (string tmp in GetNewsToday())
                {
                    str += tmp;
                }

                return str;
            }

            public static List<string> GetNewsToday()
            {
                List<string> tmp = new List<string>();

                ZetaCrawlerEntities db = new ZetaCrawlerEntities();

                string[] strSplit = { "/" };

                //foreach (var item in db.obItems)
                //{
                //    int day = int.Parse(item.NgayPhatHanh.Split(strSplit, StringSplitOptions.None)[0]);
                //    int month = int.Parse(item.NgayPhatHanh.Split(strSplit, StringSplitOptions.None)[1]);
                //    int year = int.Parse(item.NgayPhatHanh.Split(strSplit, StringSplitOptions.None)[2]);

                //    if ((DateTime.Now.Year == year) && (DateTime.Now.Month == month) && (DateTime.Now.Day == day))
                //    {
                //        tmp.Add("<br /><b>" + item.Subject + "</b><br />Xem chi tiết : " + item.Url + "<br />");
                //    }
                //}

                return tmp;
            }
        }
}
