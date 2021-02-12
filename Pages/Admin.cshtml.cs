using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace CryptoCanuck.Pages
{
    public class AdminModel : PageModel
    {
        public List<string> emails = new List<string>();
        MailMessage mailMessage = new MailMessage();
        SmtpClient _smtp = new SmtpClient();
        string teamsEmail;
        string teamsEmailPassword;
        string teamsEmailHost;
        int teamsEmailPort;

        public void OnGet() {} // OnGet()
    
        public void MessageUpdate(string message){
            using (SqlConnection myConn = new SqlConnection(Program.da.cs)){
                SqlCommand addMessage = new SqlCommand
                {
                    Connection = myConn
                };
                myConn.Open();

            
                addMessage.Parameters.AddWithValue("@message", message);
                addMessage.Parameters.AddWithValue("@id", 1);

                addMessage.CommandText = ("[spMessageUpdate]");
                addMessage.CommandType = System.Data.CommandType.StoredProcedure;

                addMessage.ExecuteNonQuery();
                addMessage.Parameters.Clear(); // clear it
            } // using
            
        } // MessageUpdate()

        public  List<string> GrabEmails(){
            SqlConnection myConn = new SqlConnection(Program.da.cs);
            myConn.Open();

            string query = "SELECT email FROM MailerList WHERE status = 'A'";
            SqlCommand results = new SqlCommand(query, myConn);

            using (SqlDataReader reader = results.ExecuteReader()){
                while (reader.Read())
                {
                    emails.Add(reader.GetString(0));
                }
            }// using

            myConn.Close();
            return emails;
        } // GrabEmails

        public void SendEmail(object sender, EventArgs e){
            //get the Settings from WEB.CONFIG file.

            teamsEmail = ConfigurationManager.AppSettings["emailsender"].ToString();
            teamsEmailPassword = ConfigurationManager.AppSettings["password"].ToString();
            teamsEmailHost = ConfigurationManager.AppSettings["smtpserver"].ToString();
            teamsEmailPort = Convert.ToInt16(ConfigurationManager.AppSettings["portnumber"]);

            Boolean emailIsSSL = Convert.ToBoolean(ConfigurationManager.AppSettings["IsSSL"]);


            //Getting Email Body Text for Newsletter path will need to be updated for whoever is using at this time.
            string FilePath = "C:\\Users\\allie\\Documents\\GitHub\\CryptoCanuck\\Pages\\NewsLetter.cshtml.cs";
            StreamReader str = new StreamReader(FilePath);
            string MailNews = str.ReadToEnd();
            str.Close();

            string subject = "New Newsletter Available!";

            GrabEmails();

            for(int i = 0; i < emails.Count; i++){

                // email to 
                mailMessage.To.Add(emails[i]);

                // body text IS html so true
                mailMessage.IsBodyHtml = true;

                // the teams email, email subject, email body
                mailMessage.From = new MailAddress(teamsEmail);
                mailMessage.Subject = subject;
                mailMessage.Body = MailNews;

                // Set SMTP, HOST server SMTP detail and PORT
                SmtpClient _smtp = new SmtpClient();
                _smtp.Host = teamsEmailHost;
                _smtp.Port = teamsEmailPort;

                // SSL --> True / False
                // Secure Sockets Layer encryption between server and client
                _smtp.EnableSsl = emailIsSSL;

                // Set Sender UserEmailID, Password
                NetworkCredential _network = new NetworkCredential(teamsEmail, teamsEmailPassword);
                _smtp.Credentials = _network;

                // Send the email we created
                _smtp.Send(mailMessage);
            }

        } // SendEmail
    }
}
