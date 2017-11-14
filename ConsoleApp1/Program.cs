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
            IEnumerable<User> result = connect.Query<User>(wher);


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(wher);
            Console.ReadLine();
        }


        
        


    }


}
    

