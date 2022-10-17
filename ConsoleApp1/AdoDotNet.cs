using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class AdoDotNet
    {
        static void Main(string[] args)
        {
            string connectionstring = "server=DESKTOP-PUTO0NO\\SQLEXPRESS;Database = HR; Integrated Security=true";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from employees", con);
            SqlDataReader Reader = cmd.ExecuteReader();
            Reader.Read();
            Console.WriteLine(Reader["employee_id"]+" "+Reader[2]);
          
        }
    }
    class AdoinsertEmp
    {
        static void Main(string[] args)
        {
            string connectionstring = "server=DESKTOP-PUTO0NO\\SQLEXPRESS;Database = wipro2; Integrated Security=true";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into book values(@bid,@bnm,@pr,@aid)", con);
            Console.WriteLine("Enter book id");
            int bookid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter bookname");
            string booknm = Console.ReadLine();
            Console.WriteLine("Enter book price");
            int bookpr = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter author id");
            int aid = int.Parse(Console.ReadLine());
            cmd.Parameters.AddWithValue("@bid", bookid);
            cmd.Parameters.AddWithValue("@bnm", booknm);
            cmd.Parameters.AddWithValue("@pr", bookpr);
            cmd.Parameters.AddWithValue("@aid", aid);
            int c = cmd.ExecuteNonQuery();
            if(c>0)
                Console.WriteLine("Record inserted Successfully");


        }
    }
    class DemoUpdate
    {
        static void Main(string[] args)
        {
            string connectionstring = "server=DESKTOP-PUTO0NO\\SQLEXPRESS;Database = wipro2; Integrated Security=true";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(connectionstring);
                con.Open();
                SqlCommand cmd = new SqlCommand("update book set price=@pr where bookid=@bid", con);
                Console.WriteLine("Enter book id");
                int bookid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter book price");
                int bookpr = int.Parse(Console.ReadLine());
                cmd.Parameters.AddWithValue("@pr", bookpr);
                cmd.Parameters.AddWithValue("@bid", bookid);
                int c = cmd.ExecuteNonQuery();
                Console.WriteLine("Records Updated:" + c);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }

        }
    

