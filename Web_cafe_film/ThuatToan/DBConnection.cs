﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Web_cafe_film.ThuatToan
{
    public class DBConnection
    {
        private string name;
        private string strCon;
        public DBConnection()
        {
            strCon = ConfigurationManager.ConnectionStrings["DBConnect"].ConnectionString;

           // strCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnect"].ConnectionString);

        }

        public SqlConnection getConnection()
        {
            return new SqlConnection(strCon);
        }


    }
}