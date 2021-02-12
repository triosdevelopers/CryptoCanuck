using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace CryptoCanuck.Pages
{
    public class NewsletterModel : PageModel
    {   
        public string RecentNews;
        public void OnGet() {} // OnGet()
        
    
        public void GetRecentMessage(){
            using (SqlConnection myConn = new SqlConnection(Program.da.cs)){
                SqlCommand getRecentMessage = new SqlCommand
                {
                    Connection = myConn
                };
                myConn.Open();

                getRecentMessage.CommandText = ("[spMostRecentMessage]");
                getRecentMessage.CommandType = System.Data.CommandType.StoredProcedure;

                RecentNews = getRecentMessage.ExecuteNonQuery().ToString();
                getRecentMessage.Parameters.Clear(); // clear it
            } // using
            
        } // SendItOut()
    }
}
