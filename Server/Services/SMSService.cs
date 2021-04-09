using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Threading.Tasks;


namespace SOS.FMS.Server.Services
{
    public static class SMSService
    {
        public static async Task SendSMS(string notification, string number = "923035650720,923320555190,923007187948,9230755532555")
        {
           if(notification!=null && number != null)
            {
                HttpClient Http = new HttpClient();
                var response = await Http.GetAsync($"http://smsgateway.com.crimson.mysitehosted.com/api/sendsms?msisdn=923226264201&password=9088&to={number}&text={notification}&mask=SOS&urdu=0");
                if (number.Substring(0, 1) == "0")
                {
                    number = number.Substring(1);
                }

                if (number.Substring(0, 2) == "92")
                {
                    number = number.Substring(2);
                }

                if (number.Substring(0, 1) == "3")
                {
                }
            }
        }

        public static void SendMail(string title, string notification, string emailAddress)
        {
            if(notification!=null && emailAddress != null)
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                    mail.Priority = MailPriority.High;
                    SmtpServer.UseDefaultCredentials = false;
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("waqastaahir@gmail.com", "Boeing747 7");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;

                    mail = new MailMessage();
                    Guid EmpId = Guid.NewGuid();
                    mail.From = new MailAddress("waqastaahir@gmail.com");
                    mail.To.Add(emailAddress);
                    mail.Subject = title;
                    mail.Body = notification;

                    SmtpServer.Send(mail);

                }
                catch (Exception ex)
                {
                    string exception = ex.ToString();
                }

            }

        }
    }
}
