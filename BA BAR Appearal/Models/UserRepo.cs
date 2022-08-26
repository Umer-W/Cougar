using Microsoft.Data.SqlClient;
namespace BA_BAR_Appearal.Models
{
    public class UserRepo
    {
        public static void AddUser(User u)
        {
            string name = u.Name;
            string email = u.Email;
            int phone=u.Phone;
            string password = u.Password;   
            
            string constring = @"Data Source=(localdb)\ProjectModels;Initial Catalog=Accounts;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con=new SqlConnection(constring);
            con.Open();
            string query = $"Insert into AccountsTable (Name, Email, Phone, Password) values('{name}','{email}','{phone}','{password}')";
    
            SqlCommand cmd = new SqlCommand(query, con);

       

            cmd.ExecuteNonQuery();

            con.Close();


        }
        public static bool CheckUser(User u)
        {
            string constring = @"Data Source=(localdb)\ProjectModels;Initial Catalog=Accounts;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = $"select * from AccountsTable where Email='{u.Email}' and Password='{u.Password}'";
         
            SqlCommand cmd = new SqlCommand(query, con);

           

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
            con.Close();
        }
    }
}