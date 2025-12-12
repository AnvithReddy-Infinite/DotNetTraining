using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adotnetprj
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // THE ADO.NET ASSESSMENT FOR CONNECTED AND DISCONNECTED ARCHITECTURE IS DONE BELOW, AND BELOW IS ONLY PROGRAM.CS CODE,
            // FOR MAIN CODES REFER EduTrackConnectedDemo.cs AND EduTrackDisConnectedDemo.cs FILES RESPECTIVELY.

            // Connected Architectiure assignment - EduTrack database section
            EduTrackConnectedDemo demo = new EduTrackConnectedDemo();

            // Task 2.1 – Display all courses
            // demo.ShowAllCourses();

            // Task 2.2 – Add a new student
            //demo.AddNewStudent();

            // Task 2.3 – Search students by department
            //demo.SearchStudentsByDepartment();

            // Task 2.4 – Display enrolled courses for a student
            //demo.ShowEnrolledCoursesForStudent();

            // Task 2.5 – Update grade
            //demo.UpdateGrade();

            // Stored procedure call – Get courses by semester
            demo.ShowCoursesBySemester();


            // DisConnected Architecture assignment - EduTrack database section
            //EduTrackDisConnectedDemo dDemo = new EduTrackDisConnectedDemo();

            // Task 3.1 – Load Students and Courses into DataSet
            //dDemo.LoadStudentsAndCourses();

            // Task 3.2 – Modify course credits 
            //dDemo.ModifyCourseCredits();

            //Task 3.3 – Insert a new course
            //dDemo.InsertNewCourse();

            // Task 3.4 – Delete a student 
            //dDemo.DeleteStudent();

            Console.ReadLine();

            // THE ADO.NET ASSESSMENT FOR CONNECTED AND DISCONNECTED ARCHITECTURE IS DONE ABOVE, AND ABOVE IS ONLY PROGRAM.CS CODE,
            // FOR MAIN CODES REFER EduTrackConnectedDemo.cs AND EduTrackDisConnectedDemo.cs FILES RESPECTIVELY.



/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



            // THESE ARE THE EXAMPLES TAUGHT IN THE CLASS AND ALSO PRACTICE ASSIGNMENTS FOR LINQ, CONNECTED AND DISCONNECTED ARCHITECTURE.


            // Movies with Query Expression assignment
            //LinqDemo l = new LinqDemo();
            //l.Demo1();
            //l.Demo2();
            //l.Demo3();
            //l.Demo4();

            //LinqMovies lm = new LinqMovies();
            //lm.MovieLinq();


            // Products with Lambda Expression assignment
            //LinqProductsLambda lp = new LinqProductsLambda();
            //lp.SecondHighestPrice();
            //lp.Top3Highest();
            //lp.SumPriceContainsO();
            //lp.ProductsEndingWithE();
            //lp.GroupByQtyMaxPrice();
            //lp.MinPriceProduct();
            //lp.AveragePrice();
            //lp.RunAll();



            //arrays a=new arrays();
            //a.show1();
            //a.show2();
            //a.show3();
            //a.show4();
            //a.show7();
            //a.show8();
            //a.show9();

            // EXAMPLES TAUGHT IN CLASS FOR CONNECTED ARCHITECTURE
            //connecteddemo ob = new connecteddemo();
            //ob.ShowEmployee();
            // ob.AddEmployee();
            // ob.DeleteEmployee();
            //ob.UpdateEmployee();
            //ob.showprocedure();
            //ob.EmpTransaction();
            //Console.ReadLine();


            // EXAMPLES TAUGHT IN CLASS FOR DISCONNECTED ARCHITECTURE
            //DisconnectedDemo dob = new DisconnectedDemo();
            //dob.ShowAllEmployee();
            //dob.SearchEmployee();
            //dob.AddEmployee();
            //dob.DeleteEmployee();
            //dob.UpdateEmployee();
            //dob.FilterEmployee();
            //dob.StoreinXML();
            //dob.changes();
            // DISCONNECTED ARCHITECTURE ASSIGNMENT TASKS
            //dob.ShowAllEmployeeAndDepartment();
            //dob.DataViewFilterAndSort();
            //dob.ShowTotalTablesInDataSet();
            //dob.CopyReaderToDataTable();
            //dob.MergeCustomersAndOrders();
            //dob.Readxmldata();
            // Console.ReadLine();


            //////////////////////////////////////

            // CONNECTED ARCHITECTURE ASSIGNMENT TASKS
            SqlConnection con = new SqlConnection(
                "Integrated Security=true; database=ShopDB; server=ICS-LT-1ZZYBB4\\SQLEXPRESS");

            try
            {
                con.Open();
                Console.WriteLine("Connection Opened Successfully.");

                connecteddemo ob = new connecteddemo(con);

                // Task-1
                // ob.GetTransactions();

                // Task-2
                //ob.GetCommonRecords();

                // Task-3
                // ob.InsertRecordsusingtrans();

                // Task-4
                //ob.InsertAndFetchIdentity();

                // Task-5
                //ob.ShowMultiResult();

                // Task-6
                 //ob.GetEmployeeDetailsUsingSP();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error while opening connection: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                    Console.WriteLine("Connection Closed.");
                }
            }

            //Console.ReadLine();


        }
    }
}
