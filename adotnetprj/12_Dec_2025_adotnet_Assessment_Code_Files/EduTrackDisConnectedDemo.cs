using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace adotnetprj
{
    internal class EduTrackDisConnectedDemo
    {
        private readonly string _conStr =
            "Integrated Security=true;Database=EduTrackDB;Server=ICS-LT-1ZZYBB4\\SQLEXPRESS";



        // Task 3.1 – Load Students and Courses into DataSet and display
        public void LoadStudentsAndCourses()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_conStr))
                {
                    DataSet ds = new DataSet();

                    SqlDataAdapter daStudents =
                        new SqlDataAdapter("SELECT StudentId, FullName, Email, Department, YearOfStudy FROM Students", con);

                    daStudents.Fill(ds, "Students"); 

                    SqlDataAdapter daCourses =
                        new SqlDataAdapter("SELECT CourseId, CourseName, Credits, Semester FROM Courses", con);

                    daCourses.Fill(ds, "Courses");   

                    Console.WriteLine("==== Students ====");
                    DataTable dtStudents = ds.Tables["Students"];
                    Console.WriteLine("StudentId  FullName                   Email                        Department              Year");
                    Console.WriteLine("==================================================================================================");

                    foreach (DataRow row in dtStudents.Rows)
                    {
                        Console.WriteLine(
                            $"{row["StudentId"],-10} {row["FullName"],-25} {row["Email"],-28} {row["Department"],-22} {row["YearOfStudy"]}");
                    }

                    Console.WriteLine();
                    Console.WriteLine("==== Courses ====");
                    DataTable dtCourses = ds.Tables["Courses"];
                    Console.WriteLine("CourseId  CourseName                 Credits  Semester");
                    Console.WriteLine("========================================================");

                    foreach (DataRow row in dtCourses.Rows)
                    {
                        Console.WriteLine(
                            $"{row["CourseId"],-8} {row["CourseName"],-25} {row["Credits"],-7} {row["Semester"]}");
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error in LoadStudentsAndCourses: " + ex.Message);
            }
        }



        // Task 3.2 Modify Course Credits and update database
        public void ModifyCourseCredits()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_conStr))
                {
                    string selectQuery = "SELECT CourseId, CourseName, Credits, Semester FROM Courses";

                    SqlDataAdapter da = new SqlDataAdapter(selectQuery, con);

                    SqlCommandBuilder cb = new SqlCommandBuilder(da);

                    DataSet ds = new DataSet();
                    da.Fill(ds, "Courses");

                    DataTable dtCourses = ds.Tables["Courses"];

                    Console.WriteLine("Current Courses:");
                    foreach (DataRow row in dtCourses.Rows)
                    {
                        Console.WriteLine($"{row["CourseId"],-3} {row["CourseName"],-25} Credits: {row["Credits"]}");
                    }

                    Console.WriteLine();
                    Console.WriteLine("Enter CourseId to update credits:");
                    int courseId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter new Credits value:");
                    int newCredits = Convert.ToInt32(Console.ReadLine());

                    DataRow[] rows = dtCourses.Select("CourseId = " + courseId);

                    if (rows.Length == 0)
                    {
                        Console.WriteLine("No course found with given CourseId.");
                        return;
                    }

                    rows[0]["Credits"] = newCredits;

                    int updated = da.Update(ds, "Courses");

                    Console.WriteLine($"Update completed. Rows updated in database = {updated}");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error in ModifyCourseCredits: " + ex.Message);
            }
        }


        //Task 3.3 – Insert a new course(Disconnected Mode)
        public void InsertNewCourse()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_conStr))
                {
                    string selectQuery = "SELECT CourseId, CourseName, Credits, Semester FROM Courses";

                    SqlDataAdapter da = new SqlDataAdapter(selectQuery, con);
                    SqlCommandBuilder cb = new SqlCommandBuilder(da); 

                    DataSet ds = new DataSet();
                    da.Fill(ds, "Courses");

                    DataTable dtCourses = ds.Tables["Courses"];

                    Console.WriteLine("Enter new Course Name:");
                    string courseName = Console.ReadLine();

                    Console.WriteLine("Enter Credits:");
                    int credits = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Semester (e.g. Sem1, Sem2):");
                    string semester = Console.ReadLine();

                    DataRow newRow = dtCourses.NewRow();
                    newRow["CourseName"] = courseName;
                    newRow["Credits"] = credits;
                    newRow["Semester"] = semester;

                    dtCourses.Rows.Add(newRow);

                    int inserted = da.Update(ds, "Courses");

                    Console.WriteLine($"Insert completed. Rows inserted in database = {inserted}");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error in InsertNewCourse: " + ex.Message);
            }
        }


        // Task 3.4 – Delete a student 
        public void DeleteStudent()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_conStr))
                {
                    SqlDataAdapter daStudents = new SqlDataAdapter(
                        "SELECT StudentId, FullName, Email, Department, YearOfStudy FROM Students", con);
                    SqlCommandBuilder cbStudents = new SqlCommandBuilder(daStudents);

                    DataSet ds = new DataSet();
                    daStudents.Fill(ds, "Students");
                    DataTable dtStudents = ds.Tables["Students"];

                    Console.WriteLine("Current Students:");
                    foreach (DataRow row in dtStudents.Rows)
                    {
                        Console.WriteLine($"{row["StudentId"],-3} {row["FullName"],-25} {row["Email"]}");
                    }

                    Console.WriteLine();
                    Console.WriteLine("Enter StudentId to delete :");
                    int studentId = Convert.ToInt32(Console.ReadLine());

                    SqlDataAdapter daEnroll = new SqlDataAdapter(
                        "SELECT EnrollmentId, StudentId, CourseId, EnrollDate, Grade FROM Enrollments", con);
                    SqlCommandBuilder cbEnroll = new SqlCommandBuilder(daEnroll);

                    daEnroll.Fill(ds, "Enrollments");
                    DataTable dtEnroll = ds.Tables["Enrollments"];

                    foreach (DataRow erow in dtEnroll.Select("StudentId = " + studentId))
                    {
                        erow.Delete();
                    }

                    DataRow[] srows = dtStudents.Select("StudentId = " + studentId);
                    if (srows.Length == 0)
                    {
                        Console.WriteLine("No student found with given StudentId.");
                        return;
                    }
                    srows[0].Delete();

                    int deletedEnroll = daEnroll.Update(ds, "Enrollments");
                    int deletedStudent = daStudents.Update(ds, "Students");

                    Console.WriteLine($"Deleted enrollments: {deletedEnroll}, deleted students: {deletedStudent}");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error in DeleteStudent: " + ex.Message);
            }
        }




    }
}

