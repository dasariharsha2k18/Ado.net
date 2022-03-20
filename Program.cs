using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQLConnectionADO
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.connection();
            Console.ReadLine();
        }
        static void connection()
        {
            //Here we get escape sequence error so we keep two double slash
            string v = "Data Source=HARSHA-PC\\SQLEXPRESS;Initial Catalog=Employees;Integrated Security=true";
            SqlConnection con = new SqlConnection(v);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                Console.WriteLine("Connection has been created Successfully");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
