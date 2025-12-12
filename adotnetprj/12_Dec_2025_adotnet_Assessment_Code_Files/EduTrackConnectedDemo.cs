using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace adotnetprj
{

    // CONNECTED ARCHITECTURE ASSIGNMENT SECTION, DATE: 12-12-2025
    internal class EduTrackConnectedDemo
    {
        private readonly SqlConnection _con;

        public EduTrackConnectedDemo()
        {
            _con = new SqlConnection("Integrated Security=true;Database=EduTrackDB;Server=ICS-LT-1ZZYBB4\\SQLEXPRESS");
        }


        // Task 2.1 – Display all courses
        public void ShowAllCourses()
        {
            try
            {
                if (_con.State != ConnectionState.Open)
                    _con.Open();

                string query = "SELECT CourseId, CourseName, Credits, Semester FROM Courses";

                SqlCommand cmd = new SqlCommand(query, _con);

                SqlDataReader dr = cmd.ExecuteReader();  
                Console.WriteLine("CourseId  CourseName                 Credits  Semester");
                Console.WriteLine("========================================================");

                while (dr.Read())
                {
                    int courseId = (int)dr["CourseId"];
                    string name = dr["CourseName"].ToString();
                    int credits = (int)dr["Credits"];
                    string sem = dr["Semester"].ToString();

                    Console.WriteLine($"{courseId,-8} {name,-25} {credits,-7} {sem}");
                }

                dr.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error in ShowAllCourses: " + ex.Message);
            }
        }



        // Task 2.2 – Add a new student parameterized query
        public void AddNewStudent()
        {
            try
            {
                if (_con.State != ConnectionState.Open)
                    _con.Open();

                Console.WriteLine("Enter Full Name:");
                string fullName = Console.ReadLine();

                Console.WriteLine("Enter Email:");
                string email = Console.ReadLine();

                Console.WriteLine("Enter Department:");
                string department = Console.ReadLine();

                Console.WriteLine("Enter Year Of Study (number):");
                int yearOfStudy = Convert.ToInt32(Console.ReadLine());

                string query = @"INSERT INTO Students(FullName,Email,Department,YearOfStudy)
                         VALUES(@FullName,@Email,@Department,@YearOfStudy)";

                SqlCommand cmd = new SqlCommand(query, _con);

                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Department", department);
                cmd.Parameters.AddWithValue("@YearOfStudy", yearOfStudy);

                int rows = cmd.ExecuteNonQuery();  

                Console.WriteLine($"Student inserted successfully. Rows affected = {rows}");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error in AddNewStudent: " + ex.Message);
            }
        }


        // Task 2.3 – Search students by department
        public void SearchStudentsByDepartment()
        {
            try
            {
                if (_con.State != ConnectionState.Open)
                    _con.Open();

                Console.WriteLine("Enter Department to search (e.g. Computer Science):");
                string dept = Console.ReadLine();

                string query = @"SELECT StudentId, FullName, Email, Department, YearOfStudy
                         FROM Students
                         WHERE Department = @Department";

                SqlCommand cmd = new SqlCommand(query, _con);
                cmd.Parameters.AddWithValue("@Department", dept);

                SqlDataReader dr = cmd.ExecuteReader();

                Console.WriteLine("Students in Department: " + dept);
                Console.WriteLine("StudentId  FullName                   Email                        Year");
                Console.WriteLine("=========================================================================");

                bool any = false;

                while (dr.Read())
                {
                    any = true;
                    int id = (int)dr["StudentId"];
                    string name = dr["FullName"].ToString();
                    string email = dr["Email"].ToString();
                    int year = (int)dr["YearOfStudy"];

                    Console.WriteLine($"{id,-10} {name,-25} {email,-28} {year}");
                }

                if (!any)
                {
                    Console.WriteLine("No students found for this department.");
                }

                dr.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error in SearchStudentsByDepartment: " + ex.Message);
            }
        }


        //Task 2.4 – Display enrolled courses for a student
        public void ShowEnrolledCoursesForStudent()
        {
            try
            {
                if (_con.State != ConnectionState.Open)
                    _con.Open();

                Console.WriteLine("Enter StudentId to view enrollments:");
                int studentId = Convert.ToInt32(Console.ReadLine());

                string query = @"
            SELECT c.CourseName,
                   c.Credits,
                   e.EnrollDate,
                   e.Grade
            FROM Enrollments e
            INNER JOIN Courses c ON e.CourseId = c.CourseId
            WHERE e.StudentId = @StudentId";

                SqlCommand cmd = new SqlCommand(query, _con);
                cmd.Parameters.AddWithValue("@StudentId", studentId);

                SqlDataReader dr = cmd.ExecuteReader();

                Console.WriteLine("Course Name              | Credits | Enroll Date      | Grade");
                Console.WriteLine("=================================================================");

                bool any = false;

                while (dr.Read())
                {
                    any = true;
                    string courseName = dr["CourseName"].ToString();
                    int credits = (int)dr["Credits"];
                    DateTime enrollDate = Convert.ToDateTime(dr["EnrollDate"]);
                    string grade = dr["Grade"] == DBNull.Value ? "-" : dr["Grade"].ToString();

                    Console.WriteLine($"{courseName,-24} | {credits,-7} | {enrollDate:yyyy-MM-dd HH:mm} | {grade}");
                }

                if (!any)
                {
                    Console.WriteLine("No enrollments found for this student.");
                }

                dr.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error in ShowEnrolledCoursesForStudent: " + ex.Message);
            }
        }


        // Task 2.5 – Update grade (Connected Mode) 
        public void UpdateGrade()
        {
            try
            {
                if (_con.State != ConnectionState.Open)
                    _con.Open();

                Console.WriteLine("Enter EnrollmentId to update grade:");
                int enrollmentId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Grade (A/B/C/D/F):");
                string grade = Console.ReadLine();

                string query = @"UPDATE Enrollments
                         SET Grade = @Grade
                         WHERE EnrollmentId = @EnrollmentId";

                SqlCommand cmd = new SqlCommand(query, _con);
                cmd.Parameters.AddWithValue("@Grade", grade);
                cmd.Parameters.AddWithValue("@EnrollmentId", enrollmentId);

                int rows = cmd.ExecuteNonQuery();  

                if (rows > 0)
                {
                    Console.WriteLine("Grade updated successfully. Rows affected = " + rows);
                }
                else
                {
                    Console.WriteLine("No record found for given EnrollmentId.");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error in UpdateGrade: " + ex.Message);
            }
        }

        // Stored Procedure Call stored procedure: usp_GetCoursesBySemester @semester
        public void ShowCoursesBySemester()
        {
            try
            {
                if (_con.State != ConnectionState.Open)
                    _con.Open();

                Console.WriteLine("Enter Semester (e.g. Sem1, Sem2, Sem3):");
                string sem = Console.ReadLine();

                SqlCommand cmd = new SqlCommand("usp_GetCoursesBySemester", _con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@semester", sem);

                SqlDataReader dr = cmd.ExecuteReader();

                Console.WriteLine($"Courses for Semester: {sem}");
                Console.WriteLine("CourseId  CourseName                 Credits  Semester");
                Console.WriteLine("=======================================================");

                bool any = false;

                while (dr.Read())
                {
                    any = true;
                    int id = (int)dr["CourseId"];
                    string name = dr["CourseName"].ToString();
                    int credits = (int)dr["Credits"];
                    string semester = dr["Semester"].ToString();

                    Console.WriteLine($"{id,-8} {name,-25} {credits,-7} {semester}");
                }

                if (!any)
                {
                    Console.WriteLine("No courses found for this semester.");
                }

                dr.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error in ShowCoursesBySemester: " + ex.Message);
            }
        }



    }
}

