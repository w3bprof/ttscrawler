using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;



public class EmailNotify
{
    SmtpClient sClient = new SmtpClient();

    string smtpServer = "smtp.gmail.com";
    string smtpMailFrom = "taipm@bidc.vn";
    string smtpUser = "taipm@bidc.vn";
    string smtpPassword = "P@$$w0rd";
    int smtpPort = 587; // Port của Gmail

    public string SmtpServer
    {
        get { return smtpServer; }
        set { smtpServer = value; }
    }

    public string SmtpMailFrom
    {
        get { return smtpMailFrom; }
        set { smtpMailFrom = value; }
    }

    public string SmtpUser
    {
        set { smtpUser = value; }
    }

    public string SmtpPassword
    {
        set { smtpPassword = value; }
    }

    //port của smtpserver khi dùng gmail là 587 hoặc 465

    /// <summary>
    /// Port khi gửi mail với smtpserver của mail client, chỉ có thể truyền
    /// </summary>
    public int SmtpPort
    {
        get { return smtpPort; }
        set { smtpPort = value; }
    }

    /// <summary>
    /// Hàm gửi mail với mail client là gmail
    /// </summary>
    /// <param name="strMailTo">Mail muốn gửi đến</param>
    /// <param name="strMailSubject">Tựa đề mail</param>
    /// <param name="strContent">Nội dung mail</param>
    /// <param name="bolIsHTMLFormat">Định dang mail gửi đi là HTML hay Text</param>
    /// <returns>Trả về thông tin sau khi gửi là thanh công hay thất bại và lỗi khi thất bại.</returns>
    public int SendMail(string strMailTo, string strMailSubject, string strContent, bool bolIsHTMLFormat)
    {
        try
        {
            MailMessage objMail = new MailMessage();
            //reg xác lập tính hợp lệ của mail
            Regex reg = new Regex(@"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$");
            objMail.From = new MailAddress(smtpMailFrom);
            objMail.ReplyTo = new MailAddress(smtpMailFrom);

            if (reg.IsMatch(strMailTo))
            {
                objMail.To.Add(new MailAddress(strMailTo));
                objMail.Subject = strMailSubject;
                if (bolIsHTMLFormat)
                {
                    objMail.IsBodyHtml = true;
                    objMail.Body = string.Format("<html><head><title>{0}</title></head><body>{1}</body></html>", strMailSubject, strContent);
                }
                else
                {
                    objMail.IsBodyHtml = false;
                    objMail.Body = strContent;
                }
                objMail.BodyEncoding = System.Text.Encoding.UTF8;
                sClient = new SmtpClient();

                sClient.Host = smtpServer;
                sClient.Port = smtpPort;
                sClient.Credentials = new System.Net.NetworkCredential(smtpUser, smtpPassword);
                sClient.EnableSsl = true;
                sClient.Send(objMail);

                return 1;
            }
            else
            {
                return 0;
            }
        }
        catch
        {
            return -1;
        }
    }

    public int SendMail(List<string> contacts, string strMailSubject, string strContent, bool bolIsHTMLFormat)
    {
        foreach (string contact in contacts)
        {
            try
            {
                SendMail(contact, strMailSubject, strContent, bolIsHTMLFormat);
            }
            catch
            {
                return -1;
            }
        }
        return 1;
    }
}

  
