using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.ComponentModel;
namespace LoassSolu.Common
{
    public class EmailSends
    {
        public static String Send(string email, string title, string body, string emailtype)
        {
            MailMessage mail = new MailMessage();
            SmtpClient client = new SmtpClient(emailtype);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("248968499@qq.com", "itqutabxvfyobice");

            MailAddress from = new MailAddress("248968499@qq.com", "zhangkang", Encoding.UTF8);//初始化发件人  

            MailAddress to = new MailAddress(email, "", Encoding.UTF8);//初始化收件人  

            //设置邮件内容  
            MailMessage message = new MailMessage(from, to);
            message.Body = title;
            message.BodyEncoding = Encoding.Default;
            message.Subject = body;
            message.SubjectEncoding = Encoding.Default;
            message.IsBodyHtml = true;

            //发送邮件  
            try
            {
                client.Send(message);
                return "{ \"code\":1,\"msg\":\"发送成功\"}";
            }
            catch (InvalidOperationException iex)
            {
                return "{ \"code\":1,\"msg\":\"" + iex.Message + "\"}";

            }
            catch (Exception ex)
            {
                return "{ \"code\":1,\"msg\":\"" + ex.Message + "\"}";
            }
        }
    }
}
