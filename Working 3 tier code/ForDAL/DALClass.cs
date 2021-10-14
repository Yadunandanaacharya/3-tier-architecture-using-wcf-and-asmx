using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFWithBLL;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ForDAL
{
    public class Class1
    {


        public string Insert(InsertUser user)
        {
            //string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            //SqlConnection con = new SqlConnection(cs);

            string msg;
            string CS = @"data source=(local)\SQLEXPRESS; database=Sample4; integrated security=SSPI";
            SqlConnection con = new SqlConnection(CS);
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into UserTab (Name,Email) values (@Name,@Email) ", con);
            cmd.Parameters.AddWithValue("@Name", user.Name);
            cmd.Parameters.AddWithValue("@Email", user.Email);

            int g = cmd.ExecuteNonQuery();
            if (g == 1)
            {
                msg = "Successfully Inserted";
            }
            else
            {
                msg = "Failed to insert";
            }
            return msg;

        }

        public gettestdata GetInfo()
        {
            gettestdata g = new gettestdata();

            //string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            //SqlConnection con = new SqlConnection(cs);
            string CS = @"data source=(local)\SQLEXPRESS; database=Sample4; integrated security=SSPI";
            SqlConnection con = new SqlConnection(CS);
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from UserTab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("mytab");
            da.Fill(dt);

            g.usertab = dt;
            return g;


        }

        public string Update(UpdateUser u)
        {
            string Message = "";
            string CS = @"data source=(local)\SQLEXPRESS; database=Sample4; integrated security=SSPI";
            SqlConnection con = new SqlConnection(CS);
            con.Open();
            SqlCommand cmd = new SqlCommand("update UserTab set Name=@Name, Email=@Email where UserID=@UserID", con);
            cmd.Parameters.AddWithValue("@UserID", u.UID);
            cmd.Parameters.AddWithValue("@Name", u.Name);
            cmd.Parameters.AddWithValue("@Email", u.Email);
            int res = cmd.ExecuteNonQuery();
            if (res == 1)
            {
                Message = "Success";
            }
            else
            {
                Message = "Fail";
            }
            return Message;

        }


        public string Delete(DeleteUser d)
        {
            string msg = "";
            string CS = @"data source=(local)\SQLEXPRESS; database=Sample4; integrated security=SSPI";
            SqlConnection con = new SqlConnection(CS);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete UserTab where UserID=@UserID", con);
            cmd.Parameters.AddWithValue("@UserID", d.UID);
            int res = cmd.ExecuteNonQuery();
            if (res == 1)
            {
                msg = "Success";
            }
            else
            {
                msg = "Fail";
            }
            return msg;
        }



    }
}
