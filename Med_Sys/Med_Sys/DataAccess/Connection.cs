﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Med_Sys.DataAccess
{
    class Connection
    {
        protected SqlConnection sqlconnection;
        private SqlCommand command;
<<<<<<< HEAD
        
=======


>>>>>>> akshika
        public Connection()
        {
            conOpen();
        }

        public void conOpen()
        {
<<<<<<< HEAD
            sqlconnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Dinal\Documents\GIThub\MedSys\Med_Sys\Med_Sys\Database1.mdf;Integrated Security=True");
            sqlconnection.Open();
        }

        public void conClose() 
=======
            sqlconnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user\Documents\MyGitHub\MedSys\Med_Sys\Med_Sys\Database1.mdf;Integrated Security=True;Connect Timeout=30");
            sqlconnection.Open();
        }

        public void conClose()
>>>>>>> akshika
        {
            sqlconnection.Close();
        }

        public SqlCommand getSqlCommand(string scom)
        {
            command = new SqlCommand(scom, sqlconnection);
            return command;
        }

        public SqlDataAdapter getSqlDataAdapter(string scom)
<<<<<<< HEAD
        { 
            SqlDataAdapter sqldataad = new SqlDataAdapter(scom, sqlconnection);
            return sqldataad;
        }
    
    }
    
}
=======
        {
            SqlDataAdapter sqldataad = new SqlDataAdapter(scom, sqlconnection);
            return sqldataad;
        }

    }

}
>>>>>>> akshika
