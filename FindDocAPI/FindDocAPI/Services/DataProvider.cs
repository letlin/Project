using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FindDocAPI.Services
{
    public class DataProvider
    {
        // Chuoi ket noi den CSDL

        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
            private set { instance = value; }

        }

        #region cac thuoc tinh cua lop
        private String ConnectionString = @"Data Source=.\SQLExpress;Initial Catalog=ThatLac;Integrated Security=True";

        public String _ConnectionString
        {
            get { return ConnectionString; }
            set { ConnectionString = value; }
        }
        private SqlConnection Connection;

        public SqlConnection _Connection
        {
            get { return Connection; }
            set { Connection = value; }
        }
        #endregion



        #region cac phuong thuc cua lop
        // phuong thuc ket noi den csdl
        public void OpenConnect()
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                if (Connection.State == ConnectionState.Broken || Connection.State == ConnectionState.Closed)
                {
                    Connection.Open();
                }
            }

            catch (Exception ex)
            {
                
            }
        }

        //Phuong thuc dong ket noi den csdl
        public void CloseConnect()
        {
            try
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        // lay du lieu tren mot bang
        public DataTable LoadAllTable(String CommandString)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnect();
                SqlDataAdapter da = new SqlDataAdapter(CommandString, Connection);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                
            }
            //CloseConnect();
            return dt;
        }

        //phuong thuc update, insert, del du lieu
        public int ExcuteNonQuery(String str_Proc)
        {
            int kq = 0;
            OpenConnect();
            SqlCommand cmd = new SqlCommand(str_Proc, Connection);

            kq = cmd.ExecuteNonQuery();
            //CloseConnect();
            return kq;
        }
        public int ExcuteScaler(String str)
        {
            int kq = 0;

            try
            {
                OpenConnect();
                SqlCommand cmd = new SqlCommand(str, Connection);
                kq = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                
            }
            //CloseConnect();
            return kq;
        }


        #endregion
    }
}