using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Zuzu;
using Dapper;


namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
            var connect = new SqlConnection(ConnectionString);

            string wher = "Select* From Users ";
            string join =
                "Select Users.UserName, Records.Bet, Records.Win From Records Inner Join  Users On Users.UserID = Records.UserID";

            IEnumerable<User> result = connect.Query<User>(wher);
            IEnumerable<dynamic> res = connect.Query(join);
            

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(wher);
            Console.ReadLine();
        }


        
        


    }


}
    

