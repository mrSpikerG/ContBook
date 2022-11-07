using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_book
{
    class SingletoneDB
    {

        private static SingletoneDB _instance;
        private static SqlConnection con;
        private static string conStr;


        static SingletoneDB()
        {
        }

        private SingletoneDB()
        {
        }


        public static void InitConnection(string con)
        {
            conStr = con;
        }

        public static SingletoneDB GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SingletoneDB();
                con = new SqlConnection(conStr);
                con.Open();
            }
            return _instance;
        }

        public SqlConnection GetDBConnection()
        {
            
          //  if(con==null)
            return con;
        }
    }
}
