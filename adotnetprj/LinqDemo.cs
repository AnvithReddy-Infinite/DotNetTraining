using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adotnetprj
{
    internal class LinqDemo
    {
        List<empdet> employees = new List<empdet>
     {
         new empdet { EmpId = 1, EmpName = "Aasritha", Salary = 30000, DateOfJoin = DateTime.Now.AddYears(-1), DeptId = 2 },
         new empdet { EmpId = 2, EmpName = "Akshay", Salary = 32000, DateOfJoin = DateTime.Now.AddYears(-2), DeptId = 2 },
         new empdet { EmpId = 3, EmpName = "Anvith Reddy", Salary = 35000, DateOfJoin = DateTime.Now.AddMonths(-10), DeptId = 3 },
         new empdet { EmpId = 4, EmpName = "ASHOK", Salary = 28000, DateOfJoin = DateTime.Now.AddYears(-1), DeptId = 1 },
         new empdet { EmpId = 5, EmpName = "Deepalakshmi", Salary = 36000, DateOfJoin = DateTime.Now.AddMonths(-6), DeptId = 4 },
         new empdet { EmpId = 6, EmpName = "Deepti", Salary = 36000, DateOfJoin = DateTime.Now.AddYears(-1), DeptId = 4 },
         new empdet { EmpId = 7, EmpName = "Dharani sri", Salary = 30000, DateOfJoin = DateTime.Now.AddYears(-3), DeptId = 1 },
         new empdet { EmpId = 8, EmpName = "Humera", Salary = 33000, DateOfJoin = DateTime.Now.AddMonths(-8), DeptId = 2 },
         new empdet { EmpId = 9, EmpName = "Kanishka", Salary = 31000, DateOfJoin = DateTime.Now.AddYears(-1), DeptId = 3 },
         new empdet { EmpId = 10, EmpName = "KEERTHANA", Salary = 30000, DateOfJoin = DateTime.Now.AddMonths(-4), DeptId = 4 },
         new empdet { EmpId = 11, EmpName = "Keerthi", Salary = 35000, DateOfJoin = DateTime.Now.AddMonths(-5), DeptId = 2 },
         new empdet { EmpId = 12, EmpName = "Keerthickragul", Salary = 36000, DateOfJoin = DateTime.Now.AddYears(-2), DeptId = 3 },
         new empdet { EmpId = 13, EmpName = "Logeshwaran", Salary = 28000, DateOfJoin = DateTime.Now.AddMonths(-9), DeptId = 1 },
         new empdet { EmpId = 14, EmpName = "Madavi", Salary = 30000, DateOfJoin = DateTime.Now.AddYears(-1), DeptId = 1 },
         new empdet { EmpId = 15, EmpName = "Manikanta", Salary = 31000, DateOfJoin = DateTime.Now.AddMonths(-7), DeptId = 2 },
         new empdet { EmpId = 16, EmpName = "Fatima", Salary = 29000, DateOfJoin = DateTime.Now.AddYears(-3), DeptId = 3 },
         new empdet { EmpId = 17, EmpName = "Nagamani", Salary = 35000, DateOfJoin = DateTime.Now.AddMonths(-6), DeptId = 2 },
         new empdet { EmpId = 18, EmpName = "Pooja", Salary = 30000, DateOfJoin = DateTime.Now.AddYears(-1), DeptId = 4 },
         new empdet { EmpId = 19, EmpName = "Hymavathi", Salary = 32000, DateOfJoin = DateTime.Now.AddYears(-2), DeptId = 1 },
         new empdet { EmpId = 20, EmpName = "Sairam Somaraju", Salary = 40000, DateOfJoin = DateTime.Now.AddMonths(-9), DeptId = 4 },
         new empdet { EmpId = 21, EmpName = "Sakthivel", Salary = 31000, DateOfJoin = DateTime.Now.AddMonths(-10), DeptId = 2 },
         new empdet { EmpId = 22, EmpName = "Usha sri", Salary = 29000, DateOfJoin = DateTime.Now.AddYears(-1), DeptId = 3 },
         new empdet { EmpId = 23, EmpName = "Waseef", Salary = 36000, DateOfJoin = DateTime.Now.AddMonths(-3), DeptId = 1 }
     };

        public void Demo1()
        {
            string[] stunames = { "aasritha", "monika", "usha", "anvith", "manu" };
            //show all names start with a 
            var res = from s in stunames
                      where s.StartsWith("a")
                      select s;
            foreach (var r in res)
            {
                Console.WriteLine(r);
            }
        }


        public void Demo2()
        {
            int[] nums = { 10, 11, 12, 13, 14 };
            var res = from i in nums
                      where i % 2 == 0 && i > 12
                      select i;
            foreach (var r in res)
            {
                Console.WriteLine(r);
            }
        }

        public void Demo3()
        {

            // arrays, lists, xml, database ....



            //===================================================================
            //write a linq query to display all details where name contains a 'K' 

            //var res = from t in employees
            //          where t.EmpName.Contains("K")
            //          select t;

            //===================================================================

            // write a linq query to display all empid between 8  23 and sort names in descending order


            // var res = from t in employees  where t.EmpId >8 && t.EmpId <=23 orderby t.EmpName descending  select t;


            //===================================================================
            // write a linq query to show only empid , empname, deptid


            //var res = from t in employees

            //          select new {Employeeid= t.EmpId,Employeename = t.EmpName, departmentid = t.DeptId};




            //foreach (var item in res)
            //{
            //    Console.WriteLine($"{item.Employeeid }  {item.Employeename}   {item.departmentid}");
            //}

            //===================================================================


            // how many rows are printed ?
            // 5 

            //var res = (from t in employees
            //          select t).ToList();   // this linq query is not executed here


            //employees.Add(new empdet { EmpId = 9, EmpName = "Kanishka", Salary = 31000, DateOfJoin = DateTime.Now.AddYears(-1), DeptId = 3 });
            //employees.Add(new empdet { EmpId = 20, EmpName = "Sairam Somaraju", Salary = 40000, DateOfJoin = DateTime.Now.AddMonths(-9), DeptId = 4 });


            //foreach (var item in res)// linq query is executed here
            //{
            //    Console.WriteLine($"{item.EmpId}  {item.EmpName}   {item.Salary}  {item.DateOfJoin}  {item.DeptId}");
            //}

            //===================================================================

            List<dept> departments = new List<dept>
     {
         new dept { DeptId = 1, DeptName = "HR" },
         new dept { DeptId = 2, DeptName = "IT" },
         new dept { DeptId = 3, DeptName = "Finance" },
         new dept { DeptId = 4, DeptName = "Training" }
     };

            // show me common records from both the table

            //var res = from t in employees
            //          from t1 in departments
            //          where t.DeptId == t1.DeptId
            //          select new {t.EmpId, t.DeptId,t.EmpName, t.Salary , t1.DeptName };


            var res = from t in employees
                      join t1 in departments
                      on t.DeptId equals t1.DeptId
                      select new { t.EmpId, t.DeptId, t.EmpName, t.Salary, t1.DeptName };



            foreach (var item in res)// linq query is executed here
            {
                Console.WriteLine($"{item.EmpId}  {item.EmpName}   {item.Salary}  {item.DeptId}  {item.DeptName}");
            }







        }


        public void Demo4()
        {
            //how lambda works?


            // query expression method 
            //var res = from t in employees
            //          where t.DeptId==1
            //          select t;


            // lambda expression method


            // var res = employees.Where(t => t.DeptId == 1);

            //=====================================================================================
            // most commonly used methods

            // take , skip , takewhile, skipwhile, order by , orderbydescending, thenby,thenbydecending

            // var res = employees.Take(3);// display top 3 records

            // var res = employees.Skip(3);//skips 1st 3 rows


            // var res = employees.TakeWhile(t => t.Salary != 31000);

            // var res = employees.SkipWhile(t => t.Salary != 31000);

            // supports chaning model


            // every method output will go as an input for next method
            // var res = employees.Take(8).Skip(8).TakeWhile(t => t.Salary > 20000);

            // select top 3 second highest salary 

            //  var res = employees.OrderByDescending(t => t.Salary).Take(4).Skip(1);


            var res = employees.OrderByDescending(t => t.Salary).Skip(1).Take(3);


            foreach (var item in res)// linq query is executed here
            {
                Console.WriteLine($"{item.EmpId}  {item.EmpName}   {item.Salary}  {item.DateOfJoin} {item.DeptId}");
            }




        }
    }
}
