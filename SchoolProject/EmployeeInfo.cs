using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    interface EmployeeInfo
    {
        //EmpId, EmpName, Emp_Type, Weekend, Work_Type, Pay_Mode, Emp_Gender, Emp_Religion, Floor, Line, Emp_Code, Emp_Card_No, Designation, Emp_Birth_Date, Emp_Joining_Date, Shifting, Shift_Name, 
        //                 Bank_Acc_No, Groos_Salary, HR, BS, Food_Allowance, Transport, MA
         string EmpId { get; set; }
        string EmpName { get; set; }
        string Emp_Type { get; set; }
        string Weekend { get; set; }
        string Work_Type { get; set; }
        string Pay_Mode { get; set; }
        string Emp_Gender { get; set; }
        string Emp_Religion { get; set; }
        string Floor { get; set; }
        string Line { get; set; }
        string Emp_Code { get; set; }
        string Emp_Card_No { get; set; }
        string Designation { get; set; }
        string Emp_Birth_Date { get; set; }
        string Emp_Joining_Date { get; set; }
        string Shifting { get; set; }
        string Shift_Name { get; set; }
        string Bank_Acc_No { get; set; }
        float Groos_Salary { get; set; }
        float HR { get; set; }
        float BS { get; set; }
        float Food_Allowance { get; set; }
        float Transport { get; set; }
        float MA { get; set; }
    }
}
