/// <summary>
/// Program Name: 		Database connection and Insert/update/read operation
/// Creation Date:		15 Aug 2017
/// Programmer:		    Nandkumar
/// Company:			Periscope for VIEVU
/// Copyright Information: ©
///
///
/// DESCRIPTION:		This class allow calling method to performe database insert operation using pre-definded method parameters
///
/// CALLER REQUIREMENT:	 Caller should pass all the method parameters.
///
/// MODULE NAME:		Dbconnection.cs
///
/// NOTES:
///
/// HISTORY:			0.001 – Initial Writing
///
/// REVISION:			0.001
///
/// REVISION PROGRAMMER
///
/// REVISION DATE
///
/// <summary>




using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace VievU.DBConnection
{
    class Dbconnection
    {
        //connect Db method accept below method parameters
        public static void connectdb(String Module, String Submodule , String Testcase,String Username, String Password, String inputdata, String Actualresult, String Expectedresult, String Status, String Testcasetype    )
        {
            //inserteddate variable store current datetime;
            String inserteddate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            //Sql connection string to connect database
                SqlConnection con = new SqlConnection(@"Data Source = LAPTOP-IOEIKJE0\SQLEXPRESS; Initial Catalog = Vievurepo; User ID = sa; Password = periscope123 ;Integrated Security=False");
            //cmd  insert query
            SqlCommand cmd = new SqlCommand("INSERT INTO Vievuresultrepo (Module, Submodule,Testcase,Username,Password,inputdata,Actualresult,Expectedresult,Status,Testcasetype,inserteddate) VALUES('"+Module+"','"+Submodule+"','"+Testcase+"','"+Username+"','"+Password+"','"+inputdata+"','"+Actualresult+"','"+Expectedresult+"','"+Status+"','"+Testcasetype+"','"+inserteddate+"')", con);
                con.Open();
            //below command Execute the insert operation in database
                cmd.ExecuteNonQuery();
            //closing the connection
                con.Close();
         
        }


    }
}
