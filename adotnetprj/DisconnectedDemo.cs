using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace adotnetprj
{
    internal class DisconnectedDemo
    {
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();// can hold the output (many output)
        SqlDataAdapter da;
        public void ShowAllEmployee()
        {
            // fill : run the query + store the output in dataset

            // display all employee records
            SqlConnection con = new SqlConnection("Integrated security=true;database=ShopDB;server=ICS-LT-1ZZYBB4\\SQLEXPRESS");
            // no need to open and close connection
            SqlDataAdapter da = new SqlDataAdapter("select * from employee", con);
            DataSet ds = new DataSet();// can hold the output (many output)
            da.Fill(ds, "emp");//now ds contains output of employee table
            DataTable dt = new DataTable();
            dt = ds.Tables["emp"];//now dt contains the output of emp

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine(dt.Rows[i][0]);
                Console.WriteLine(dt.Rows[i][0]);
                Console.WriteLine(dt.Rows[i][2]);
                Console.WriteLine(dt.Rows[i][3]);
                Console.WriteLine(dt.Rows[i][4]);
            }
        }

        public void SearchEmployee()
        {
            // search employee by id
            Console.WriteLine("enter the id");
            int id = int.Parse(Console.ReadLine());
            DataRow drr = dt.Rows.Find(id);// search happens from datatable not from database
            if (drr != null)
            {
                Console.WriteLine(drr[0]);
                Console.WriteLine(drr[1]);
                Console.WriteLine(drr[2]);
                Console.WriteLine(drr[3]);
                Console.WriteLine(drr[4]);
            }
            else
            {
                Console.WriteLine("No Such Key Exists!!");
            }


        }

        public void AddEmployee()
        {
            //new employee details
            //all crud operation are done by using datatable
            //dt.Rows.Count: total rows present in datatable
            //dt.Rows.Add: adding new rows
            //dt.Rows.Find: Search row by primary key
            //dt.Rows.Remove: delete existing row
            dt.Rows.Add(null, "Teja", 30000, "2023-10-25", 10);
            dt.Rows.Add(null, "Bhanu", 40000, "2020-1-12", 20);//a new rows is added to datatable
                                                               //how to update this changes to database?
            int rowsaffected = da.Update(dt);
            Console.WriteLine("total rows inserted is:" + rowsaffected);

        }
        public void DeleteEmployee()
        {
            //search a row which u want to delete
            Console.WriteLine("Enter id:");
            int id = int.Parse(Console.ReadLine());
            DataRow drr = dt.Rows.Find(id);//search happens from datatable not from database
            drr.Delete();//this will remove row from datatable
            int rowsaffected = da.Update(dt);
            Console.WriteLine("total rows Deleted is:" + rowsaffected);
        }
        public void UpdateEmployee()
        {
            Console.WriteLine("Enter id:");
            int id = int.Parse(Console.ReadLine());
            DataRow drr = dt.Rows.Find(id);//search happens from datatable not from database
            drr[2] = 65000;
            int rowsaffected = da.Update(dt);
            Console.WriteLine("total rows Updated is:" + rowsaffected);

        }
        public void FilterEmployee()
        {
            //how can u search non primary key column
            Console.WriteLine("Rows after filter is as follows");
            Console.WriteLine("=========================================");
            DataView dv = new DataView(dt);
            dv.RowFilter = "salary>50000 and Deptid=10";
            foreach (DataRowView item in dv)
            {
                Console.WriteLine(item[0]);
                Console.WriteLine(item[1]);
                Console.WriteLine(item[2]);
                Console.WriteLine(item[3]);
                Console.WriteLine(item[4]);
            }
        }

        public void StoreinXML()
        {


            // ds.ReadXml(); reads the xml file and stores in dataset
            // ds.WriteXml(); creates xml file and write all dataset records to xml

            // ds.WriteXml("d:\\employee.xml");

            dt.Rows.Add(null, "Raj1", 30000, "1-1-2000", 10);
            dt.Rows.Add(null, "vijay1", 31000, "1-1-2001", 20);// a new rows is added to datatable



            ds.WriteXml("d:\\employee1.xml", XmlWriteMode.DiffGram);// shows which rows inserted, deleted or updated
            Console.WriteLine("Created Successfully");


        }


        public void changes()
        {


            // 27 records in datatable
            // show me only those records from datatable where new changes has been taken place


            dt.Rows.Add(null, "Raj1", 30000, "1-1-2000", 10);
            dt.Rows.Add(null, "vijay1", 31000, "1-1-2001", 20);// a new rows is added to datatable
            Console.WriteLine("============================");
            Console.WriteLine("Following are new changes : ");
            if (ds.HasChanges())
            {
                DataSet newds = ds.GetChanges();// newds contains only 2 rows

                for (int i = 0; i < newds.Tables["emp"].Rows.Count; i++)
                {

                    Console.WriteLine(newds.Tables["emp"].Rows[i][0]);
                    Console.WriteLine(newds.Tables["emp"].Rows[i][1]);
                    Console.WriteLine(newds.Tables["emp"].Rows[i][2]);
                    Console.WriteLine(newds.Tables["emp"].Rows[i][3]);
                    Console.WriteLine(newds.Tables["emp"].Rows[i][4]);
                }

            }
            else
            {
                Console.WriteLine("No Changes has happened in datatable ");
            }
        }
        // ds.GetChanges


        // DISCONNECTED ARCHITECTURE ASSIGNMENT TASKS:
        // Task 1:Develop a code to print all record from Employee and Department

        public void ShowAllEmployeeAndDepartment()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=ShopDB;server=ICS-LT-1ZZYBB4\\SQLEXPRESS");

            DataSet ds = new DataSet();

            SqlDataAdapter daEmp = new SqlDataAdapter("select * from Employee", con);
            daEmp.Fill(ds, "emp");

            SqlDataAdapter daDept = new SqlDataAdapter("select * from Department", con);
            daDept.Fill(ds, "dept");

            Console.WriteLine("====== Employee Table ======");
            DataTable dtEmp = ds.Tables["emp"];
            for (int i = 0; i < dtEmp.Rows.Count; i++)
            {
                Console.WriteLine(dtEmp.Rows[i][0]);
                Console.WriteLine(dtEmp.Rows[i][1]);
                Console.WriteLine(dtEmp.Rows[i][2]);
                Console.WriteLine(dtEmp.Rows[i][3]);
                Console.WriteLine(dtEmp.Rows[i][4]);
                Console.WriteLine("-------------------------");
            }

            Console.WriteLine("\n====== Department Table ======");
            DataTable dtDept = ds.Tables["dept"];
            for (int i = 0; i < dtDept.Rows.Count; i++)
            {
                Console.WriteLine(dtDept.Rows[i][0]);
                Console.WriteLine(dtDept.Rows[i][1]);
                Console.WriteLine("-------------------------");
            }
        }

        // TASK 2: From a Employee Table: Create DataView having following conditions: Salary  > 47000; Department = 10; EmployeeName Starts with 'M'; Apply sorting.
        public void DataViewFilterAndSort()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=ShopDB;server=ICS-LT-1ZZYBB4\\SQLEXPRESS");

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT EmpID, EmpName, Salary, DateOfJoin, DeptID FROM Employee", con);
            da.Fill(dt);

            DataView dv = new DataView(dt);
            dv.RowFilter = "Salary > 47000 AND DeptID = 10 AND EmpName LIKE 'M%'";

            dv.Sort = "EmpName ASC";

            Console.WriteLine("\nFiltered & Sorted Employees:");
            Console.WriteLine("-----------------------------");

            if (dv.Count == 0)
            {
                Console.WriteLine("No matching records found.");
            }
            else
            {
                foreach (DataRowView row in dv)
                {
                    Console.WriteLine($"{row["EmpID"]}   {row["EmpName"]}   {row["Salary"]}   {Convert.ToDateTime(row["DateOfJoin"]).ToString("yyyy-MM-dd")}   {row["DeptID"]}");
                }
            }
        }


        // TASK 3: Write a code to print to show total no of tables present in dataset
        public void ShowTotalTablesInDataSet()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=ShopDB;server=ICS-LT-1ZZYBB4\\SQLEXPRESS");
            DataSet ds = new DataSet();

            new SqlDataAdapter("SELECT * FROM Employee", con).Fill(ds, "Employee");
            new SqlDataAdapter("SELECT * FROM Department", con).Fill(ds, "Department");

            Console.WriteLine("Total number of tables in the DataSet: " + ds.Tables.Count);
            Console.WriteLine("Tables in DataSet:");
            foreach (DataTable t in ds.Tables)
            {
                Console.WriteLine("- " + t.TableName);
            }
        }


        // TASK 4: Develop a code to copy data of SqlDataReader object To DataTable object and print all data using DataTable Object(use Department Table) Hint : use dt.Load()
        public void CopyReaderToDataTable()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=ShopDB;server=ICS-LT-1ZZYBB4\\SQLEXPRESS");
            SqlCommand cmd = new SqlCommand("SELECT DeptID, DeptName FROM Department", con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);    

            dr.Close();
            con.Close();

            Console.WriteLine("----- Departments -----");
            foreach (DataRow r in dt.Rows)
            {
                Console.WriteLine($"{r["DeptID"]}   {r["DeptName"]}");
            }
        }


        // TASK 5: Develop a code to display records from customers and orders .  a. Create ds1 object which stores customers details;
        // b. Create ds2 object which stores orders details c. Merge ds1 with ds2 using merge method and display records from both the table using ds1 

        public void MergeCustomersAndOrders()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=ShopDB;server=ICS-LT-1ZZYBB4\\SQLEXPRESS");

            DataSet ds1 = new DataSet();
            SqlDataAdapter daCust = new SqlDataAdapter("SELECT * FROM Customers", con);
            daCust.Fill(ds1, "Customers");

            DataSet ds2 = new DataSet();
            SqlDataAdapter daOrd = new SqlDataAdapter("SELECT * FROM Orders", con);
            daOrd.Fill(ds2, "Orders");

            ds1.Merge(ds2);

            Console.WriteLine("----- Customers (from ds1) -----");
            DataTable custTable = ds1.Tables["Customers"];
            if (custTable != null)
            {
                foreach (DataRow r in custTable.Rows)
                {
                    Console.WriteLine($"{r["CUSTID"]}  {r["CUSTNAME"]}  {r["age"]}  {r["CADDRESS"]}   {r["CPHONE"]}");
                }
            }
            else
            {
                Console.WriteLine("No Customers table found in ds1.");
            }

            Console.WriteLine("\n----- Orders (now in ds1 after merge) -----");
            DataTable ordTable = ds1.Tables["Orders"];
            if (ordTable != null)
            {
                foreach (DataRow r in ordTable.Rows)
                {
                    Console.WriteLine($"   {r["CUSTID"]} {r["ORDERID"]}  {Convert.ToDateTime(r["ORDERDATE"]).ToString("yyyy-MM-dd")}   {r["product"]}  {r["price"]}  {r["qty"]}");
                }
            }
            else
            {
                Console.WriteLine("No Orders table found in ds1.");
            }
        }

        // TASK 6: Develop a code to Read Data of Xml File (use ds.Read() Method) and print the same in console application
        public void Readxmldata()
        {
                       DataSet ds = new DataSet();
            ds.ReadXml("C:\\DotNetTraining\\customer.xml");
            DataTable dt = ds.Tables["cust"];
            foreach (DataRow r in dt.Rows)
            {
                Console.WriteLine($"{r["CUSTID"]}   {r["CUSTNAME"]}   {r["CUSTADDRESS"]}   {r["PHONE"]}");
            }
        }

    }
}


