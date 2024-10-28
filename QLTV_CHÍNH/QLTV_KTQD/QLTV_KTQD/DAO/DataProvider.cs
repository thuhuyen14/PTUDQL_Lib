using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLTV_KTQD.DAO
{
    public class DataProvider
    {
        // private string connectionSTR = "Data Source=DESKTOP-1AMUFBN\\SQLEXPRESS;Initial Catalog=QLTV_PTUD;Integrated Security=True";
        //  public void ExecuteQuery(string query)
        //   {
        //  SqlConnection conn = new SqlConnection();
        //  conn.Open();
        //  SqlCommand cmd = new SqlCommand(query, conn);
        //  DataTable dt = new DataTable();
        //  SqlDataAdapter da = new SqlDataAdapter(cmd);
        //  da.Fill(dt);
        //  string sql, constr;
        //  conn.Close();
        // }

        private static DataProvider instance; //ctrl+R+E

        //để duy nhất 1 dataprovider tồn tại
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private DataProvider() { }

        string connectionSTR = "Data Source=DESKTOP-1AMUFBN\\SQLEXPRESS;Initial Catalog=QLTV_PTUD;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(dt);

                connection.Close();
            }

            return dt;
        }


        //trả ra số dòng thành công 
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }


        //trả về cái thành công -- 1 dòng
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }

        public SqlDataReader ExecuteReader(string query, object[] parameter = null)
        {
            SqlDataReader data;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = query;
                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    command.CommandType = CommandType.Text;

                    data = command.ExecuteReader();
                }

            }

            return data;
        }


    }
}

        
