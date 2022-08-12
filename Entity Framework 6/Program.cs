using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Entity_Framework_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Model1())
            {
                //Create new and save a object
                /*Console.WriteLine("Empid: ");
                var empId = Console.ReadLine();
                Console.WriteLine("Name: ");
                var name = Console.ReadLine();
                Console.WriteLine("Salary: ");
                var salary = Console.ReadLine();

                var objects = new Object1 { EmpId = empId, Name = name, Salary = Convert.ToInt32(salary) };
                db.Object1.Add(objects);
                db.SaveChanges();*/
                // Display all Blogs from the database
                var query = from b in db.Object1
                            orderby b.Salary descending
                            select b;

                //string queryString = string.Format(@"SELECT TOP {0} EmpId,Name,Salary FROM Object1 ORDER BY Salary DESC ", paramValue);

                //print
                Console.WriteLine("All Object1 in the database:");
                foreach (var obj in query)
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}",obj.EmpId, obj.Name,obj.Salary);
                }
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();

            }





        }
    }
}
