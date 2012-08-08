using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net.Mail;
using System.Net.Mime;
using System.IO;
using System.Xml;
using System.Threading;

namespace formemail_demo
{
    public class emailHelper
    {
        public static bool check_email(string email)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            bool bcheck_to = regex.IsMatch(email);
            if (bcheck_to)
                return true;
            else
                return false;
        }
        //welcome new BOOKING MANAGER
        public static string set_template1(string strHotenguoidungmoi,string strTK, string email)
        {
            XmlTextReader reader = new XmlTextReader(@"template\template1.xml");
            string content = "";
            string subject = "";
            while (reader.Read())
            {
                switch (reader.LocalName)
                {
                        case "subject": subject = reader.ReadString();
                        break;
                    case "h": content = content + reader.ReadString() + strHotenguoidungmoi + " " + "\r\n";
                        break;
                    case "h1": content = content + reader.ReadString() + "\r\n";
                        break;
                    case "h2": content = content + reader.ReadString() + strTK + "\r\n";
                        break;
                    case "h3": content = content + reader.ReadString() + strTK + "\r\n";
                        break;
                    case "h4": content = content + reader.ReadString() + "\r\n";
                        break;
                    case "h5": content = content + reader.ReadString() + "\r\n";
                        break;
                }
                // add current user at here
                //content = content + username

                //set email and store to database
                email Email = new email();
                if (!Email.set_mailadress(email))
                    return "Email is invalid";
                else
                {
                    Email.subject = subject;
                    Email.body = content;
                    Email.to_address = email;
                    //store to database or send it.
                }
            }
            reader.Close();
            return content;
        }
        //notify booking room successfully
        public static string set_template2(string strtennguoinhan, string strphong, string strthoigian, string email)
        {
            XmlTextReader reader = new XmlTextReader(@"template\template2.xml");
            string content = "";
            string subject = "";
            while (reader.Read())
            {
                switch (reader.LocalName)
                {
                    case "subject": subject = reader.ReadString();
                        break;
                    case "h": content = content + reader.ReadString() + strtennguoinhan + " " + "\r\n";
                        break;
                    case "h1": content = content + reader.ReadString() + "\r\n";
                        break;
                    case "h2": content = content + reader.ReadString() + strphong + "\r\n";
                        break;
                    case "h3": content = content + reader.ReadString() + strthoigian + "\r\n";
                        break;
                    case "h4": content = content + reader.ReadString() + "\r\n";
                        break;
                    case "h5": content = content + reader.ReadString() + "\r\n";
                        break;
                }
                // add current user at here
                //content = content + username

                //set email and store to database
                email Email = new email();
                if (!Email.set_mailadress(email))
                    return "Email is invalid";
                else
                {
                    Email.subject = subject;
                    Email.body = content;
                    Email.to_address = email;
                    //store to database or send it.
                }
            }
            reader.Close();
            return content;
        }
        //notify booking room was accepted
        public static string set_template3(string strtennguoinhan, string strphong, string strthoigian, string email)
        {
            XmlTextReader reader = new XmlTextReader(@"template\template3.xml");
            string content = "";
            string subject = "";
            while (reader.Read())
            {
                switch (reader.LocalName)
                {
                    case "subject": subject = reader.ReadString();
                        break;
                    case "h": content = content + reader.ReadString() + strtennguoinhan + " " + "\r\n";
                        break;
                    case "h1": content = content + reader.ReadString() + "\r\n";
                        break;
                    case "h2": content = content + reader.ReadString() + strphong + "\r\n";
                        break;
                    case "h3": content = content + reader.ReadString() + strthoigian + "\r\n";
                        break;
                    case "h4": content = content + reader.ReadString() + "\r\n";
                        break;
                    case "h5": content = content + reader.ReadString() + "\r\n";
                        break;
                }
                // add current user at here
                //content = content + username

                //set email and store to database
                email Email = new email();
                if (!Email.set_mailadress(email))
                    return "Email is invalid";
                else
                {
                    Email.subject = subject;
                    Email.body = content;
                    Email.to_address = email;
                    //store to database or send it.
                }
            }
            reader.Close();
            return content;
        }
        //notify booking room was be canceled.
        public static string set_template4(string strtennguoinhan, string strphong, string strthoigian, string email)
        {
            XmlTextReader reader = new XmlTextReader(@"template\template4.xml");
            string content = "";
            string subject = "";
            while (reader.Read())
            {
                switch (reader.LocalName)
                {
                    case "subject": subject = reader.ReadString();
                        break;
                    case "h": content = content + reader.ReadString() + strtennguoinhan + " " + "\r\n";
                        break;
                    case "h1": content = content + reader.ReadString() + "\r\n";
                        break;
                    case "h2": content = content + reader.ReadString() + strphong + "\r\n";
                        break;
                    case "h3": content = content + reader.ReadString() + strthoigian + "\r\n";
                        break;
                    case "h4": content = content + reader.ReadString() + "\r\n";
                        break;
                    case "h5": content = content + reader.ReadString() + "\r\n";
                        break;
                }
                // add current user at here
                //content = content + username

                //set email and store to database
                email Email = new email();
                if (!Email.set_mailadress(email))
                    return "Email is invalid";
                else
                {
                    Email.subject = subject;
                    Email.body = content;
                    Email.to_address = email;
                    //store to database or send it.
                }
            }
            reader.Close();
            return content;
        }
        //notify change booking information
        public static string set_template5(string strtennguoinhan, string strphong, string strthoigian, string email)
        {
            XmlTextReader reader = new XmlTextReader(@"template\template5.xml");
            string content = "";
            string subject = "";
            while (reader.Read())
            {
                switch (reader.LocalName)
                {
                    case "subject": subject = reader.ReadString();
                        break;
                    case "h": content = content + reader.ReadString() + strtennguoinhan + " " + "\r\n";
                        break;
                    case "h1": content = content + reader.ReadString() + "\r\n";
                        break;
                    case "h2": content = content + reader.ReadString() + strphong + "\r\n";
                        break;
                    case "h3": content = content + reader.ReadString() + strthoigian + "\r\n";
                        break;
                    case "h4": content = content + reader.ReadString() + "\r\n";
                        break;
                    case "h5": content = content + reader.ReadString() + "\r\n";
                        break;
                }
                // add current user at here
                //content = content + username

                //set email and store to database
                email Email = new email();
                if (!Email.set_mailadress(email))
                    return "Email is invalid";
                else
                {
                    Email.subject = subject;
                    Email.body = content;
                    Email.to_address = email;
                    //store to database or send it.
                }
            }
            reader.Close();
            return content;
        }
        //send email
        public static void send_mail(email Email)
        {
            string email ="";
            string password ="";
            XmlTextReader reader = new XmlTextReader(@"email config\config.xml");

            while (reader.Read())
            {
                if (reader.LocalName == "email")
                    email = reader.ReadString();
                else if (reader.LocalName == "password")
                    password = reader.ReadString();
            }

            MailMessage mailmess = new MailMessage();
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;

            client.Credentials = new System.Net.NetworkCredential(email, password);
            client.EnableSsl = true;

            mailmess.From = new MailAddress(email);
            mailmess.To.Add(Email.to_address);
            mailmess.Subject = Email.subject;
            mailmess.Body = Email.body;

            client.Send(mailmess);
            
        }
        public static void send_list()
        {
            List<email> Email = new List<email> { }; // read from database - not have database class 
            foreach (email mail in Email)
            {
                send_mail(mail);
            }
        }
        public static void send_multithread()
        {
            Thread Run = new Thread(new ThreadStart(send_list));
            Run.Start();
        }
    } 
    //class email
    public class email
    {
        public string to_address { get; set; }
        public string subject { get; set; }
        public string body { get; set; }
        public email(){}

        //set email adress
        public bool set_mailadress(string mail)
        {
            if (emailHelper.check_email(mail))
            {
                to_address = mail;
                return true;
            }
            else
                return false;
        }
    }
    
}
