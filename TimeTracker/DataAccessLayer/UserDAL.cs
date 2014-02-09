using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject;
using System.Data.SqlClient;
using System.Data;


namespace DataAccessLayer
{
    public class UserDAL
    {
        SqlConnection connection = null;

        public bool CreateUser(UserBO userBO)
        {
            connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TimeSheet;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("spcreateuser", connection);
            connection.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", userBO.Username);
            cmd.Parameters.AddWithValue("@password", userBO.Password);
            cmd.Parameters.AddWithValue("@email_id", userBO.EmailId);
            cmd.Parameters.AddWithValue("@phn_no", userBO.PhnNo);
            cmd.Parameters.AddWithValue("@role_name", userBO.RoleBO.RoleName);
            int count= cmd.ExecuteNonQuery();
            if (count > 0)
                return true;

            return false;

        }

    }
}
