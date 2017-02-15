using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using WebApiCrudOperations.Models;
using WebApiCrudOperations.Models.DTO;

namespace WebApiCrudOperations.Helpers
{
    public class Email
    {
        
        public static void SendEmail(ProjectDetailDTO project)
        {
             
            MailMessage mail = new MailMessage();
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("dk9513@gmail.com");
            mail.To.Add("shubham.goel@optimusinfo.com");
            mail.Subject = "New Project Created";

            string sowData = "";

            if (project.IsSOWSigned)
            {
                sowData = "<b>Is Project SOW Signed : </b> No <br><br>";
                sowData = sowData + "<b>SOW Approval Date : </b> N/A<br><br>";
            }
            else
            {
                sowData = "<b>Is Project SOW Signed : </b> Yes <br><br>";
                sowData = sowData + "<b>SOW Approval Date : </b>" + "-" + "<br><br>";
            }
            string emailFormed = "-";
            string emailBody = "<p style='font-family:courier'>" + emailFormed + "</p><div style='font-family:courier;text-align:left;border: 1px solid #000;margin:0px auto; padding:15px'><br>"
                + "<b>Project identification number : </b>" + project.Id + "<br><br>"
                + "<b>Name of Customer : </b>" + project.CustomerName + "<br><br>"
                + "<b>Customer Id : </b>" + "-" + "<br><br>"
                + "<b>Name of the project : </b>" + project.Name + "<br><br>"
                + "<b>Optimus Sales Contact : </b>" + project.SalesContactName+ "<br><br>"
                + "<b>Optimus Delivery Contact : </b>" + project.DeliveryContactName + "<br><br>"
                + sowData
                + "<b>SOW Start Date  : </b>" + "-" + "<br><br>"
                + "<b>SOW End Date : </b>" + "-" + "<br><br>"
                + "<b>Location where the signed SOW soft copy is saved : </b>" + "-" + "<br><br>"
                + "<b>Project scope summary : </b> " + "-" + "<br><br>"
                + "<b>Any project risks or implied customer commitments : </b>" + project.Risk + "<br><br>"
                + "<b>Project delivery contact name : </b>" + "-" + "<br><br>"
                + "<b>Project delivery contact email : </b>" + "-" + "<br><br>"
                + "<b>Project commercial contact name : </b>" + "-" + "<br><br>"
                + "<b>Project commercial contact email : </b>" + "-" + "<br><br>"
                + "<b>Project invoice contact name : </b>" + "-" + "<br><br>"
                + "<b>Project invoice contact email : </b>" + "-" + "<br><br>";

            mail.Body = emailBody;
            mail.IsBodyHtml = true;
            smtpClient.Port = 587;
            smtpClient.Credentials = new System.Net.NetworkCredential("dk9513@gmail.com", "9780256037");
            smtpClient.EnableSsl = true;
            smtpClient.Send(mail);

        }


    }
}