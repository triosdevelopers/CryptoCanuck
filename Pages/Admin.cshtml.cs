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
            
        } // SendItOut()
    }
}
