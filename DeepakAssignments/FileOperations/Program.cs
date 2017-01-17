using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


namespace FileOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\deepak.kumar\Desktop\A.log"))
                {
                    string line;
                    
                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File not found");
            }
            
            MailMessage mail = new MailMessage();
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("dk9513@gmail.com");
            mail.To.Add("shubham.goel@optimusinfo.com");
            mail.Subject = "Test Mail";
            mail.Body = "This is a test email";

            smtpClient.Port = 587;
            smtpClient.Credentials= new System.Net.NetworkCredential("dk9513@gmail.com", "9780256037");
            smtpClient.EnableSsl = true;
            smtpClient.Send(mail);
            Console.WriteLine("Message Send");
            Console.ReadKey();
          /*  FileStream F = new FileStream(@"C:\Users\deepak.kumar\Desktop\A.log", FileMode.Open, FileAccess.Read, FileShare.Read);
            F.Position = 0;
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }
            F.Close();
            Console.ReadKey();*/
     
        }
    }
}
