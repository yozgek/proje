﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;                                             

namespace Eczane
{
    class ConnectionString
    {
        public SqlConnection GetCon()
        {
            SqlConnection baglanti = new SqlConnection
            {
                ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ismet\OneDrive\Belgeler\dentaldb.mdf;Integrated Security=True;Connect Timeout=30"
            };
            return baglanti;
        }
    }
       
}
                                                                                                                                                                                                 