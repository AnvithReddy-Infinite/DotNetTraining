using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adotnetprj
{
    internal class connecteddemo
    {
        private SqlConnection con;

        public connecteddemo(SqlConnection con)
        {
            this.con = con;
        }

        // EXAMPLES DURING CLASS
        public void ShowEmployee()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=ShopDB;server=ICS-LT-1ZZYBB4\\SQLEXPRESS");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from employee", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine($"{dr[0]}   {dr[1]}   {dr[2]}    {dr[3]}    {dr[4]}");
            }
            con.Close();
        }

        public void AddEmployee()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=ShopDB;server=ICS-LT-1ZZYBB4\\SQLEXPRESS");
            con.Open();

            Console.WriteLine("Enter Employee Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Salary:");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Date of Joining (yyyy-mm-dd):");
            string doj = Console.ReadLine();

            Console.WriteLine("Enter DeptNo:");
            int deptno = Convert.ToInt32(Console.ReadLine());

            SqlCommand cmd = new SqlCommand($"insert into Employee  values ('{name}',{salary} , '{doj}' , {deptno}  )", con);

            int rowaffected = cmd.ExecuteNonQuery();
            Console.WriteLine($"Total Records Inserted is: {rowaffected}");

            con.Close();
        }

        public void DeleteEmployee()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=ShopDB;server=ICS-LT-1ZZYBB4\\SQLEXPRESS");
            con.Open();

            Console.WriteLine("Enter Employee Id to Delete:");
            int empid = Convert.ToInt32(Console.ReadLine());

            string query = $"delete from employee where empid = {empid}";
            SqlCommand cmd = new SqlCommand(query, con);

            int rowaffected = cmd.ExecuteNonQuery();
            Console.WriteLine($"Total Records Deleted: {rowaffected}");

            con.Close();
        }

        public void UpdateEmployee()
        {
            Console.WriteLine("Enter empid to update:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter salary:");
            decimal sal = Convert.ToDecimal(Console.ReadLine());

            SqlConnection con = new SqlConnection("Integrated security=true;database=ShopDB;server=ICS-LT-1ZZYBB4\\SQLEXPRESS");
            con.Open();

            string query = $"update Employee set Salary = {sal} where Empid = {id}";
            SqlCommand cmd = new SqlCommand(query, con);

            int update = cmd.ExecuteNonQuery();
            Console.WriteLine($"The number of updated records is {update}");

            con.Close();
        }


        public void showprocedure()
        {//display all records from employee table
            SqlConnection con = new SqlConnection("Integrated security=true; database = infinitedb;server=ICS-LT-6YZYBB4\\SQLEXPRESS");

            con.Open();//creates a new connection

            //writes a command
            SqlCommand cmd = new SqlCommand("sp_getemp", con);//instead of passing paremater in this way we will use parameter class
            SqlParameter p1 = new SqlParameter("@d", 10);
            SqlParameter p2 = new SqlParameter("@sal", 1000);//create a parameter
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);//attaching parameter to procedure
            cmd.CommandType = CommandType.StoredProcedure;//represents type of command you are trying to execute
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())//run the loop only if record is found
            {
                //it reads row by row
                // Console.WriteLine(dr[0]);//prints only one column
                Console.WriteLine($"{dr[0]} {dr[1]} {dr[2]} {dr[3]} {dr[4]}");

            }
            con.Close();
        }
        public void EmpTransaction()
        {
            SqlTransaction tr = null;
            try
            {
                SqlConnection con = new SqlConnection("Integrated security=true; database = infinitedb;server=ICS-LT-6YZYBB4\\SQLEXPRESS");

                con.Open();//creates a new connection
                tr = con.BeginTransaction();
                //writes a command
                SqlCommand cmd1 = new SqlCommand("insert into one values (1,'raj')", con);
                SqlCommand cmd2 = new SqlCommand("insert into two values (1,'raj')", con);
                cmd1.Transaction = tr;
                cmd2.Transaction = tr;
                int rowaffected1 = cmd1.ExecuteNonQuery();
                int rowaffected2 = cmd2.ExecuteNonQuery();
                Console.WriteLine($"Total Records Inserted is {rowaffected1}");
                Console.WriteLine($"Total Records Inserted is {rowaffected2}");

                tr.Commit();
                con.Close();

            }
            catch (Exception ex)
            {
                tr.Rollback();
                Console.WriteLine("could not complete ... try again");
            }
        }


        // CONNECTED ARCHITECTURE ASSIGNMENT TASKS
        // TASK 1:  logic to display all records from Employees who date of join  between 2 dates using procedures 
        public void GetTransactions()
        {
            try
            {
                Console.WriteLine("Enter Start Date (yyyy-mm-dd):");
                DateTime d1 = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Enter End Date (yyyy-mm-dd):");
                DateTime d2 = Convert.ToDateTime(Console.ReadLine());

                SqlCommand cmd = new SqlCommand("sp_GetEmployeesBetweenDates", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@d1", d1));
                cmd.Parameters.Add(new SqlParameter("@d2", d2));

                SqlDataReader dr = cmd.ExecuteReader();

                Console.WriteLine("\nEmployees Between Given Dates:\n");

                while (dr.Read())
                {
                    Console.WriteLine($"{dr[0]}   {dr[1]}   {dr[2]}   {Convert.ToDateTime(dr[3]).ToString("yyyy-MM-dd")}   {dr[4]}");
                }

                dr.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error in GetTransactions: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid date format. Use yyyy-mm-dd");
            }
        }


        // TASK 2: logic to display common records from Employee and department based on id
        public void GetCommonRecords()
        {
            try
            {
                Console.WriteLine("Enter Department ID:");
                int deptId = Convert.ToInt32(Console.ReadLine());

                string query = @"SELECT e.EmpID, e.EmpName, e.Salary, e.DateOfJoin,
                                d.DeptID, d.DeptName
                         FROM Employee e
                         INNER JOIN Department d ON e.DeptID = d.DeptID
                         WHERE d.DeptID = @id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@id", deptId));

                SqlDataReader dr = cmd.ExecuteReader();

                Console.WriteLine($"\nCommon Records for DeptID {deptId}:\n");

                if (!dr.HasRows)
                {
                    Console.WriteLine("No records found.");
                }
                else
                {
                    while (dr.Read())
                    {
                        Console.WriteLine(
                            $"{dr[0]}   {dr[1]}   {dr[2]}   {Convert.ToDateTime(dr[3]).ToString("yyyy-MM-dd")}   {dr[4]}   {dr[5]}");
                    }
                }

                dr.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error in GetCommonRecords: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Department ID. Enter a valid number.");
            }
        }

        // TASK 3: logic to insert records into Employee table using transactions
        public void InsertRecordsusingtrans()
        {
            SqlTransaction tr = null;

            try
            {
                Console.WriteLine("Enter Department ID:");
                int deptId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Department Name:");
                string deptName = Console.ReadLine();

                Console.WriteLine("Enter Employee Name:");
                string empName = Console.ReadLine();

                Console.WriteLine("Enter Salary:");
                decimal salary = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter Date of Join (yyyy-mm-dd):");
                DateTime doj = Convert.ToDateTime(Console.ReadLine());

                tr = con.BeginTransaction();

                SqlCommand cmdDept = new SqlCommand(
                    "INSERT INTO Department (DeptID, DeptName) VALUES (@DeptID, @DeptName)",
                    con, tr);

                cmdDept.Parameters.Add(new SqlParameter("@DeptID", deptId));
                cmdDept.Parameters.Add(new SqlParameter("@DeptName", deptName));

                SqlCommand cmdEmp = new SqlCommand(
                    "INSERT INTO Employee (EmpName, Salary, DateOfJoin, DeptID) " +
                    "VALUES (@EmpName, @Salary, @DateOfJoin, @DeptID)",
                    con, tr);

                cmdEmp.Parameters.Add(new SqlParameter("@EmpName", empName));
                cmdEmp.Parameters.Add(new SqlParameter("@Salary", salary));
                cmdEmp.Parameters.Add(new SqlParameter("@DateOfJoin", doj));
                cmdEmp.Parameters.Add(new SqlParameter("@DeptID", deptId));

                int deptRows = cmdDept.ExecuteNonQuery();
                int empRows = cmdEmp.ExecuteNonQuery();

                tr.Commit();

                Console.WriteLine("\nTransaction Successful.");
                Console.WriteLine("Department rows inserted: " + deptRows);
                Console.WriteLine("Employee rows inserted: " + empRows);
            }
            catch (SqlException ex)
            {
                if (tr != null)
                {
                    tr.Rollback();
                }
                Console.WriteLine("\nTransaction Failed. Rolled back.");
                Console.WriteLine("SQL Error in InsertRecordsusingtrans: " + ex.Message);
            }
            catch (FormatException)
            {
                if (tr != null)
                {
                    tr.Rollback();
                }
                Console.WriteLine("\nInvalid input format. Transaction rolled back.");
            }
        }

        // TASK 4: logic to insert a record into Employee table and fetch the identity value generated
        public void InsertAndFetchIdentity()
        {
            try
            {
                Console.WriteLine("Enter Employee Name:");
                string empName = Console.ReadLine();

                Console.WriteLine("Enter Salary:");
                decimal salary = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter Date of Join (yyyy-mm-dd):");
                DateTime doj = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Enter DeptID:");
                int deptId = Convert.ToInt32(Console.ReadLine());

                // Insert command + fetch identity using SCOPE_IDENTITY()
                string insertQuery =
                    "INSERT INTO Employee (EmpName, Salary, DateOfJoin, DeptID) " +
                    "VALUES (@EmpName, @Salary, @DateOfJoin, @DeptID); " +
                    "SELECT CAST(SCOPE_IDENTITY() AS INT);";

                SqlCommand cmdInsert = new SqlCommand(insertQuery, con);
                cmdInsert.Parameters.Add(new SqlParameter("@EmpName", empName));
                cmdInsert.Parameters.Add(new SqlParameter("@Salary", salary));
                cmdInsert.Parameters.Add(new SqlParameter("@DateOfJoin", doj));
                cmdInsert.Parameters.Add(new SqlParameter("@DeptID", deptId));

                object result = cmdInsert.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                {
                    Console.WriteLine("Could not retrieve new identity value.");
                    return;
                }

                int newEmpId = Convert.ToInt32(result);
                Console.WriteLine($"\nNew Employee inserted with EmpID: {newEmpId}");

                // Validate by fetching again in a new command
                string selectQuery =
                    "SELECT EmpID, EmpName, Salary, DateOfJoin, DeptID " +
                    "FROM Employee WHERE EmpID = @EmpID";

                SqlCommand cmdSelect = new SqlCommand(selectQuery, con);
                cmdSelect.Parameters.Add(new SqlParameter("@EmpID", newEmpId));

                SqlDataReader dr = cmdSelect.ExecuteReader();

                Console.WriteLine("\nValidating the inserted record:\n");

                if (dr.Read())
                {
                    Console.WriteLine(
                        $"{dr[0]}   {dr[1]}   {dr[2]}   {Convert.ToDateTime(dr[3]).ToString("yyyy-MM-dd")}   {dr[4]}");
                }
                else
                {
                    Console.WriteLine("No record found for the new EmpID.");
                }

                dr.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error in InsertAndFetchIdentity: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter correct values.");
            }
        }

        // TASK 5: Multi-Result Reader with Joins 
        public void ShowMultiResult()
        {
            try
            {
                string query = @"
                    SELECT e.EmpID, e.EmpName, e.Salary, e.DateOfJoin, d.DeptName
                    FROM Employee e
                    INNER JOIN Department d ON e.DeptID = d.DeptID";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                Console.WriteLine("\nEmployee Details with Department Names:\n");
                while (dr.Read())
                {
                    Console.WriteLine(
                        $"{dr[0]}   {dr[1]}   {dr[2]}   {Convert.ToDateTime(dr[3]).ToString("yyyy-MM-dd")}   {dr[4]}");
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error in ShowMultiResult: " + ex.Message);
            }
        }

        // TASK 6: Get Employee Details Using Stored Procedure
        public void GetEmployeeDetailsUsingSP()
        {
            try
            {
                Console.WriteLine("Enter Employee ID:");
                int empId = Convert.ToInt32(Console.ReadLine());
                SqlCommand cmd = new SqlCommand("sp_GetEmployeeDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@EmpID", empId));
                SqlDataReader dr = cmd.ExecuteReader();
                Console.WriteLine($"\nDetails for Employee ID {empId}:\n");
                if (!dr.HasRows)
                {
                    Console.WriteLine("No records found.");
                }
                else
                {
                    while (dr.Read())
                    {
                        Console.WriteLine(
                            $"{dr[0]}   {dr[1]}   {dr[2]}   {Convert.ToDateTime(dr[3]).ToString("yyyy-MM-dd")}   {dr[4]}");
                    }
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error in GetEmployeeDetailsUsingSP: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Employee ID. Enter a valid number.");
            }

        }
    }
}


