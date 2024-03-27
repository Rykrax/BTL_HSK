using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BTL_HSK_ver_1
{
    internal class Modify
    {
        public Modify() { }

        public List<Account> Accounts(string query)
        {
            List<Account> acc = new List<Account>();
            using(SqlConnection sql = ConnectData.GetSqlConnection())
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Connection = sql;

                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    acc.Add(new Account(reader.GetString(0), reader.GetString(1)));
                }
            }
            return acc;
        }

        public void Command(string query)
        {
            using (SqlConnection sql = ConnectData.GetSqlConnection())
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Connection = sql;
                cmd.ExecuteNonQuery();
                sql.Close();
            }
        }
    }
}
