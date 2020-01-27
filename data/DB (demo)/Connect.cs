using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace data.DB__demo_
{
    public static class Connect
    {
        static string connString = @"Data Source= DESKTOP-0LOB2O4; Initial Catalog= 
                        MyFirstACCESSDB; Persist Security Info=True;User ID=admin;Password=123456";

        public static SqlConnection connection = new SqlConnection(connString);
    }
}
