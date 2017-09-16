/// <summary>
/// Program Name: 		Email automation result to client
/// Creation Date:		18 Aug 2017
/// Programmer:		    Nandkumar
/// Company:			Periscope for VIEVU
/// Copyright Information: ©
///
///
/// DESCRIPTION:		this class allow to send email with attachments using SMTP client smtp.gmail.com"
///
/// CALLER REQUIREMENT:	 After automation test execution result should be sent Via Email
///
/// MODULE NAME:		Email.cs
///
/// NOTES:
///
/// HISTORY:			0.001 – Initial Writing
///
/// REVISION:			0.001
///
/// REVISION PROGRAMMER
///
/// REVISION DATE
///
/// <summary>



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;


namespace VievU.Email
{
    class Email
    {

        public static void Sendemail()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("nandperiscope@gmail.com");
           //mail.To.Add("kamal.wod@periscope-tech.com");
           mail.To.Add("nand.kumar@periscope-tech.com");
            mail.To.Add("Charles.Wolfred@vievu.com");
            //mail.To.Add("sumit.arora@periscope-tech.com");
            //mail.To.Add("kiran.kumar@periscope-tech.com");
            mail.Subject = "Vievu Automation Test Result";
            mail.Body = "Please find attached Autmation test result HTML file";
            System.Net.Mail.Attachment  attachment = new System.Net.Mail.Attachment("D:\\Automation - Doc\\Vievuautomationresult.html");
            mail.Attachments.Add(attachment);
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("nandperiscope@gmail.com", "periscope123");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
            
        }

    }
}
