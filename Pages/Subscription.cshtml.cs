using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using CryptoCanuck.Models;

namespace CryptoCanuck.Pages
{
    public class SubscriptionModel : PageModel{

        public void OnPostSubscribe(string email){
            using (SqlConnection myConn = new SqlConnection(Program.da.cs)){
                SqlCommand addEmail = new SqlCommand
                {
                    Connection = myConn
                };
                myConn.Open();

            
                addEmail.Parameters.AddWithValue("@email", email);
                addEmail.Parameters.AddWithValue("@user_id", 1);

                addEmail.CommandText = ("[spAddEmail]");
                addEmail.CommandType = System.Data.CommandType.StoredProcedure;

                addEmail.ExecuteNonQuery(); // run spAddEmail
                addEmail.Parameters.Clear(); // clear it
            } // using
        } // Subscribe

        public void OnPostUnsubscribe(string emailToUnsubscribe){
            using (SqlConnection myConn = new SqlConnection(Program.da.cs)){
                SqlCommand removeEmail = new SqlCommand{
                    Connection = myConn
                };
                myConn.Open();
 
                removeEmail.Parameters.AddWithValue("@email", emailToUnsubscribe);

                removeEmail.CommandText = ("[spRemoveEmail]"); // WHERE statement takes the emailToUnsubscribe as @email
                removeEmail.CommandType = System.Data.CommandType.StoredProcedure;

                removeEmail.ExecuteNonQuery(); // run spRemoveEmail
                removeEmail.Parameters.Clear(); // clear it

            } // using
        } // Unsubscribe
    } // Subscription Class
} // namespace