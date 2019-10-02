using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class Program
    {
        public static string connectionString = @"Data Source=DESKTOP-NAVD66F\SA;Database=EmployeeManagement;uid=sa;password=007;Integrated Security=true";

        public static string sqlQuery = "";
        static void Main(string[] args)
        {
            Console.Write("=====How many oparetion you create please enter your number=====:");
            int userInput = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < userInput; i++)
            {
                Console.WriteLine("==========Please select any one keyword from this keyword========"+" Save, " + " List, " + " SelectById, " + " Update," + " Delete "+"=======");
                Console.Write("====Please enter your operation====:");
                string userOperationInput = Console.ReadLine();
                //==================Object initialize=====================//
                EmployeeClass Employee = new EmployeeClass();
                if (userOperationInput == "Save")    /*Data Insert*/
                {
                    Console.Write("Enter Employee Name :");
                    Employee.EmpName = Console.ReadLine();

                    Console.Write("Enter Emp_Type :");
                    Employee.Emp_Type = Console.ReadLine();

                    Console.Write("Enter Work_Type :");
                    Employee.Work_Type = Console.ReadLine();

                    Console.Write("Enter Weekend :");
                    Employee.Weekend = Console.ReadLine();

                    Console.Write("Enter Pay_Mode :");
                    Employee.Pay_Mode = Console.ReadLine();

                    Console.Write("Enter Employee Gender :");
                    Employee.Emp_Gender = Console.ReadLine();

                    Console.Write("Enter Employee Religion :");
                    Employee.Emp_Religion = Console.ReadLine();

                    Console.Write("Enter Floor :");
                    Employee.Floor = Console.ReadLine();

                    Console.Write("Enter Employee Line  :");
                    Employee.Line = Console.ReadLine();

                    Console.Write("Enter Employee Employee_code :");
                    Employee.Emp_Code = Console.ReadLine();

                    Console.Write("Enter Employee Designation :");
                    Employee.Designation = Console.ReadLine();

                    Console.Write("Enter Employee Emp_Card_No :");
                    Employee.Emp_Card_No = Console.ReadLine();

                    Console.Write("Enter Employee Emp_Birth_Date :");
                    Employee.Emp_Birth_Date = Console.ReadLine();

                    Console.Write("Enter Employee Emp_Joining_Date :");
                    Employee.Emp_Joining_Date = Console.ReadLine();

                    Console.Write("Enter Employee Shifting :");
                    Employee.Shifting = Console.ReadLine();

                    Console.Write("Enter Employee Shift_Name :");
                    Employee.Shift_Name = Console.ReadLine();

                    Console.Write("Enter Employee Bank_Acc_No :");
                    Employee.Bank_Acc_No = Console.ReadLine();

                    Console.Write("Enter Employee Groos_Salary :");
                    Employee.Groos_Salary = Int32.Parse(Console.ReadLine());


                    Console.Write("Enter Employee House Rent :");
                    Employee.HR = Int32.Parse(Console.ReadLine());

                    Console.Write("Enter Employee Basic sallary :");
                    Employee.BS = Int32.Parse(Console.ReadLine());

                    Console.Write("Enter Employee Food_Allowance :");
                    Employee.Food_Allowance = Int32.Parse(Console.ReadLine());

                    Console.Write("Enter Employee Transport :");
                    Employee.Transport = Int32.Parse(Console.ReadLine());

                    Console.Write("Enter Employee Medical Allowance :");
                    Employee.MA = Int32.Parse(Console.ReadLine());

                    EmployeeDataSave(Employee);
                }
                else if (userOperationInput == "List")   /*===============Employee list show============*/
                {
                    List<EmployeeClass> dt = new List<EmployeeClass>();

                    dt = prcGetEmployeelist();
                    foreach (var value in dt)
                    {
                        Console.WriteLine("Employee Id :" + value.EmpId);
                        Console.WriteLine("Employee Name :" + value.EmpName);
                        Console.WriteLine("Employee Emp_Type :" + value.Emp_Type);
                        Console.WriteLine("Employee Emp_Religion :" + value.Emp_Religion);
                        Console.WriteLine("Employee Emp_Gender :" + value.Emp_Gender);
                        Console.WriteLine("Employee Emp_Joining_Date :" + value.Emp_Joining_Date);
                        Console.WriteLine("Employee Emp_Birth_Date :" + value.Emp_Birth_Date);
                        Console.WriteLine("Employee Emp_Card_No :" + value.Emp_Card_No);
                        Console.WriteLine("Employee Floor :" + value.Floor);
                        Console.WriteLine("Employee Pay_Mode :" + value.Pay_Mode);
                        Console.WriteLine("Employee Shift_Name :" + value.Shift_Name);
                        Console.WriteLine("Employee Shifting :" + value.Shifting);
                        Console.WriteLine("Employee Weekend :" + value.Weekend);
                        Console.WriteLine("Employee Line :" + value.Line);
                        Console.WriteLine("Employee Groos_Salary :" + value.Groos_Salary);
                        Console.WriteLine("Employee MA :" + value.MA);
                        Console.WriteLine("Employee Food_Allowance :" + value.Food_Allowance);
                        Console.WriteLine("Employee HR :" + value.HR);
                        Console.WriteLine("Employee Emp_Code :" + value.Emp_Code);
                        Console.WriteLine("Employee Work_Type :" + value.Work_Type);
                        Console.WriteLine("Employee BS :" + value.BS);
                        Console.WriteLine("Employee Bank_Acc_No :" + value.Bank_Acc_No);
                        Console.WriteLine("Employee Designation :"+value.Designation);
                        Console.WriteLine("Employee Transport :"+value.Transport);
                }

            }
            else if (userOperationInput == "SelectById")
                {
                    Console.Write("==============Please SELECT id for Data show======================:");
                    int selectId = Int32.Parse(Console.ReadLine());                  
                    List<EmployeeClass> dt = new List<EmployeeClass>();
                    dt = GetDatabyId(selectId);
                    foreach (var value in dt)
                    {
                        Console.WriteLine("Employee Id :" + value.EmpId);
                        Console.WriteLine("Employee Name :" + value.EmpName);
                        Console.WriteLine("Employee Emp_Type :" + value.Emp_Type);
                        Console.WriteLine("Employee Emp_Religion :" + value.Emp_Religion);
                        Console.WriteLine("Employee Emp_Gender :" + value.Emp_Gender);
                        Console.WriteLine("Employee Emp_Joining_Date :" + value.Emp_Joining_Date);
                        Console.WriteLine("Employee Emp_Birth_Date :" + value.Emp_Birth_Date);
                        Console.WriteLine("Employee Emp_Card_No :" + value.Emp_Card_No);
                        Console.WriteLine("Employee Floor :" + value.Floor);
                        Console.WriteLine("Employee Pay_Mode :" + value.Pay_Mode);
                        Console.WriteLine("Employee Shift_Name :" + value.Shift_Name);
                        Console.WriteLine("Employee Shifting :" + value.Shifting);
                        Console.WriteLine("Employee Weekend :" + value.Weekend);
                        Console.WriteLine("Employee Line :" + value.Line);
                        Console.WriteLine("Employee Groos_Salary :" + value.Groos_Salary);
                        Console.WriteLine("Employee MA :" + value.MA);
                        Console.WriteLine("Employee Food_Allowance :" + value.Food_Allowance);
                        Console.WriteLine("Employee HR :" + value.HR);
                        Console.WriteLine("Employee Emp_Code :" + value.Emp_Code);
                        Console.WriteLine("Employee Work_Type :" + value.Work_Type);
                        Console.WriteLine("Employee BS :" + value.BS);
                        Console.WriteLine("Employee Bank_Acc_No :" + value.Bank_Acc_No);
                        Console.WriteLine("Employee Designation :"+value.Designation);
                        Console.WriteLine("Employee Transport :"+value.Transport);
                    }
                }
                else if (userOperationInput == "Update")    /*==================Data Insert================*/
                {
                    Console.Write("Enter EmployeeId :");
                    int EmpId = Int32.Parse(Console.ReadLine());

                    Console.Write("Enter Employee Name :");
                    Employee.EmpName = Console.ReadLine();

                    Console.Write("Enter Emp_Type :");
                    Employee.Emp_Type = Console.ReadLine();

                    Console.Write("Enter Work_Type :");
                    Employee.Work_Type = Console.ReadLine();

                    Console.Write("Enter Weekend :");
                    Employee.Weekend = Console.ReadLine();

                    Console.Write("Enter Pay_Mode :");
                    Employee.Pay_Mode = Console.ReadLine();

                    Console.Write("Enter Employee Gender :");
                    Employee.Emp_Gender = Console.ReadLine();

                    Console.Write("Enter Employee Religion :");
                    Employee.Emp_Religion = Console.ReadLine();

                    Console.Write("Enter Floor :");
                    Employee.Floor = Console.ReadLine();

                    Console.Write("Enter Employee Line  :");
                    Employee.Line = Console.ReadLine();

                    Console.Write("Enter Employee Employee_code :");
                    Employee.Emp_Code = Console.ReadLine();

                    Console.Write("Enter Employee Designation :");
                    Employee.Designation = Console.ReadLine();

                    Console.Write("Enter Employee Emp_Card_No :");
                    Employee.Emp_Card_No = Console.ReadLine();

                    Console.Write("Enter Employee Emp_Birth_Date :");
                    Employee.Emp_Birth_Date = Console.ReadLine();

                    Console.Write("Enter Employee Emp_Joining_Date :");
                    Employee.Emp_Joining_Date = Console.ReadLine();

                    Console.Write("Enter Employee Shifting :");
                    Employee.Shifting = Console.ReadLine();

                    Console.Write("Enter Employee Shift_Name :");
                    Employee.Shift_Name = Console.ReadLine();

                    Console.Write("Enter Employee Bank_Acc_No :");
                    Employee.Bank_Acc_No = Console.ReadLine();

                    Console.Write("Enter Employee Groos_Salary :");
                    Employee.Groos_Salary = Int32.Parse(Console.ReadLine());


                    Console.Write("Enter Employee House Rent :");
                    Employee.HR = Int32.Parse(Console.ReadLine());

                    Console.Write("Enter Employee Basic sallary :");
                    Employee.BS = Int32.Parse(Console.ReadLine());

                    Console.Write("Enter Employee Food_Allowance :");
                    Employee.Food_Allowance = Int32.Parse(Console.ReadLine());

                    Console.Write("Enter Employee Transport :");
                    Employee.Transport = Int32.Parse(Console.ReadLine());

                    Console.Write("Enter Employee Medical Allowance :");
                    Employee.MA = Int32.Parse(Console.ReadLine());

                    UpdateData(Employee,EmpId);
                }
                else
                {
                       Console.Write("============Please enter your Delete Id==========:");
                       int deleteId = Int32.Parse(Console.ReadLine());
                       EmployeeDelete(deleteId);
                }
           }
                      Console.Read();

      }

        //============================Employee Data Save ===========================//
        public static void EmployeeDataSave(EmployeeClass Employee)
        {
            SqlConnection Connection = new SqlConnection(connectionString);
            try
            {
                sqlQuery = "Insert into tbl_EmployeeInfo (EmpName, Emp_Type, Weekend, Work_Type, Pay_Mode, Emp_Gender, Emp_Religion, Floor, Line, Emp_Code, Emp_Card_No, Designation, Emp_Birth_Date, Emp_Joining_Date, Shifting, Shift_Name,Bank_Acc_No, Groos_Salary, HR, BS, Food_Allowance, Transport, MA)Values('" + Employee.EmpName + "','" + Employee.Emp_Type + "','" + Employee.Weekend + "','" + Employee.Work_Type + "','" + Employee.Pay_Mode + "','" + Employee.Emp_Gender + "','" + Employee.Emp_Religion + "','" + Employee.Floor + "','" + Employee.Line + "','" + Employee.Emp_Code + "','" + Employee.Emp_Card_No + "','" + Employee.Designation + "','" + Employee.Emp_Birth_Date + "','" + Employee.Emp_Joining_Date + "','" + Employee.Shifting + "','" + Employee.Shift_Name + "','" + Employee.Bank_Acc_No + "','" + Employee.Groos_Salary + "','" + Employee.HR + "','" + Employee.BS + "','" + Employee.Food_Allowance + "','" + Employee.Transport + "','" + Employee.MA + "')";
                SqlCommand cmd = new SqlCommand(sqlQuery, Connection);
                Connection.Open();
                int rowAffected = cmd.ExecuteNonQuery();
                if (rowAffected == 1)
                {
                    Console.WriteLine("===============Data Save Successfull===============");
                }
                else
                {
                    Console.WriteLine("==============Data Save Not Successfull==============");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Connection.Close();
            }

        }
        //=================Employee list Data Show======================//
        public static List<EmployeeClass> prcGetEmployeelist()
        {
            var EmployeeList = new List<EmployeeClass>();
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                sqlQuery = "SELECT * FROM tbl_EmployeeInfo";
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var Employee = new EmployeeClass();
                    Employee.EmpId = reader["EmpId"].ToString();
                    Employee.EmpName = reader["EmpName"].ToString();
                    Employee.Emp_Type = reader["Emp_Type"].ToString();
                    Employee.Work_Type = reader["Work_Type"].ToString();
                    Employee.Emp_Religion = reader["Emp_Religion"].ToString();
                    Employee.Emp_Gender = reader["Emp_Gender"].ToString();
                    Employee.Emp_Birth_Date = reader["Emp_Birth_Date"].ToString();
                    Employee.Emp_Joining_Date = reader["Emp_Joining_Date"].ToString();
                    Employee.Emp_Card_No = reader["Emp_Card_No"].ToString();
                    Employee.Emp_Code = reader["Emp_Code"].ToString();
                    Employee.Shifting = reader["Shifting"].ToString();
                    Employee.Shift_Name = reader["Shift_Name"].ToString();
                    Employee.Pay_Mode = reader["Pay_Mode"].ToString();
                    Employee.Groos_Salary = Convert.ToInt32(reader["Groos_Salary"]);
                    Employee.Bank_Acc_No = reader["Bank_Acc_No"].ToString();
                    Employee.BS = Convert.ToInt32(reader["BS"]);
                    Employee.Floor = reader["Floor"].ToString();
                    Employee.Line = reader["Line"].ToString();
                    Employee.Weekend = reader["Weekend"].ToString();
                    Employee.HR = Convert.ToInt32(reader["HR"]);
                    Employee.MA = Convert.ToInt32(reader["MA"]);
                    Employee.Transport = Convert.ToInt32(reader["Transport"]);
                    Employee.Food_Allowance = Convert.ToInt32(reader["Food_Allowance"]);
                    Employee.Designation = reader["Designation"].ToString();
                    EmployeeList.Add(Employee);
                }

            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return EmployeeList;
        }
        //=================Data Read one id selected====================//
        public static List<EmployeeClass> GetDatabyId(int id)
        {
            var EmployeeList = new List<EmployeeClass>();
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                sqlQuery = "SELECT * FROM tbl_EmployeeInfo Where EmpId =" + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var Employee = new EmployeeClass();
                    Employee.EmpId = reader["EmpId"].ToString();
                    Employee.EmpName = reader["EmpName"].ToString();
                    Employee.Emp_Type = reader["Emp_Type"].ToString();
                    Employee.Work_Type = reader["Work_Type"].ToString();
                    Employee.Emp_Religion = reader["Emp_Religion"].ToString();
                    Employee.Emp_Gender = reader["Emp_Gender"].ToString();
                    Employee.Emp_Birth_Date = reader["Emp_Birth_Date"].ToString();
                    Employee.Emp_Joining_Date = reader["Emp_Joining_Date"].ToString();
                    Employee.Emp_Card_No = reader["Emp_Card_No"].ToString();
                    Employee.Emp_Code = reader["Emp_Code"].ToString();
                    Employee.Shifting = reader["Shifting"].ToString();
                    Employee.Shift_Name = reader["Shift_Name"].ToString();
                    Employee.Pay_Mode = reader["Pay_Mode"].ToString();
                    Employee.Groos_Salary = Convert.ToInt32(reader["Groos_Salary"]);
                    Employee.Bank_Acc_No = reader["Bank_Acc_No"].ToString();
                    Employee.BS = Convert.ToInt32(reader["BS"]);
                    Employee.Floor = reader["Floor"].ToString();
                    Employee.Line = reader["Line"].ToString();
                    Employee.Weekend = reader["Weekend"].ToString();
                    Employee.HR = Convert.ToInt32(reader["HR"]);
                    Employee.MA = Convert.ToInt32(reader["MA"]);
                    Employee.Transport = Convert.ToInt32(reader["Transport"]);
                    Employee.Food_Allowance = Convert.ToInt32(reader["Food_Allowance"]);
                    Employee.Designation = reader["Designation"].ToString();
                    EmployeeList.Add(Employee);
                }


            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return EmployeeList;
        }

        //EmpId, EmpName, Emp_Type, Weekend, Work_Type, Pay_Mode, Emp_Gender, Emp_Religion, Floor, Line, Emp_Code, Emp_Card_No, Designation, Emp_Birth_Date, Emp_Joining_Date, Shifting, Shift_Name,Bank_Acc_No, Groos_Salary, HR, BS, Food_Allowance, Transport, MA
        //===================Start: Data Update mehtod====================//
        public static void UpdateData(EmployeeClass Employee, int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
        try
            {
                sqlQuery = "UPDATE tbl_EmployeeInfo SET EmpName ='" + Employee.EmpName + "',Emp_Type ='" + Employee.Emp_Type + "',Work_Type ='" + Employee.Work_Type + "',Emp_Religion ='" + Employee.Emp_Religion + "',Pay_Mode='" + Employee.Pay_Mode + "',Emp_Gender='" + Employee.Emp_Gender + "',Emp_Code='" + Employee.Emp_Code + "',Emp_Card_No='" + Employee.Emp_Card_No + "',Designation='" + Employee.Designation + "',Floor='" + Employee.Floor + "',Weekend='" + Employee.Weekend + "',Emp_Birth_Date='" + Employee.Emp_Birth_Date + "',Emp_Joining_Date='" + Employee.Emp_Joining_Date + "',Shifting='" + Employee.Shifting + "',Shift_Name='" + Employee.Shift_Name + "',Bank_Acc_No= '" + Employee.Bank_Acc_No + "',Line='" + Employee.Line + "',Groos_Salary='" + Employee.Groos_Salary + "',HR='" + Employee.HR + "',BS='" + Employee.BS + "',MA='" + Employee.MA + "',Food_Allowance='" + Employee.Food_Allowance + "',Transport = '" + Employee.Transport+"' Where EmpId = "+ id;
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                int rowAffected =cmd.ExecuteNonQuery();
                if (rowAffected == 1)
                {
                    Console.WriteLine("==============Data Update Successfull============");
                }
                else
                {
                    Console.WriteLine("=============Data Update Operation Unsuccessfull==============");
                }
            }
       catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }
       finally
            {
                connection.Close();
            }
        }
        //===================End: Data Update method==================//
        //================Start: Data delete method====================//
        public static void EmployeeDelete(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                sqlQuery = "DELETE FROM tbl_EmployeeInfo WHERE EmpId =" + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                connection.Open();
                int rowAffected = cmd.ExecuteNonQuery();
                if (rowAffected == 1)
                {
                    Console.WriteLine("=====================Data Successfully Delete====================");
                }
                else
                {
                    Console.WriteLine("====================Delete operation Unsuccessfull=================");
                }
            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
        //================End: Data delete method======================//

        //======================= Start : Error message Show method================//
        public static void ErrorMessage(string ex)
        {
            Console.WriteLine("=======================Start: Error Message=========================");
            Console.WriteLine(ex);
            Console.WriteLine("=======================End: Error Message====================");
        }
        //========================End : Error message Show method==================//


    }
}
