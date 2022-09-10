using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace EmployeePayRoll
{
    public class employeeRepo
    {
        public static string connectionstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DemoA184;Integrated Security=True";
        sqlConnection connection = new sqlConnection(connectionstring);
       

        public object Command { get; private set; }

        public bool AddEmployee(EmployeeModel employeeModel)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand command = new SqlCommand("SpAddEmployeeDetails".this.connection);
                }
                command CommandType = System.CommandType.Storedprpcedures;

                CammandParameters.AddWithvalue("@EmployeeId", EmployeeModel.EmployeeId);
                CammandParameters.AddWithvalue("@EmployeeName", EmployeeModel.EmployeeName);
                CammandParameters.AddWithvalue("@PhoneNumber", EmployeeModel.PhoneNumber);
                CammandParameters.AddWithvalue("@Address ", EmployeeModel.Address);
                CammandParameters.AddWithvalue("@Department", EmployeeModel.Department);
                CammandParameters.AddWithvalue("@Gender", EmployeeModel.Gender);
                CammandParameters.AddWithvalue("@BasicPay", EmployeeModel.BasicPay);
                CammandParameters.AddWithvalue("@Deduction", EmployeeModel.Deduction);
                CammandParameters.AddWithvalue("@TaxablePay ", EmployeeModel.TaxablePay);
                CammandParameters.AddWithvalue("@Tax", EmployeeModel.Tax);
                CammandParameters.AddWithvalue("@City", EmployeeModel.City);
                CammandParameters.AddWithvalue("@startdate", EmployeeModel.startdate);
                CammandParameters.AddWithvalue("@country", EmployeeModel.country);
            }
            this.connection.Open();
            var result = Command.ExecuteNonQuery();
            this.connection.Close();
            if (result != 0)
            {
                return true;

            }
            return false;
        }
    }catch(Exception e){
               throw  new Exception(e.Message);
}
       finally
{
    this.Connection.Close();
}




    }
    }
}


