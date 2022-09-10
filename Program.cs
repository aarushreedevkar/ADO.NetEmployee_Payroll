namespace EmployeePayRoll
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the EmployeePayroll");
            EmployeeModel model = new EmployeeModel();
            employeeRepo repo= new employeeRepo();
            model.EmployeeName = "Bruce";
            model.PhoneNumber = "2532235815";
            model.Address = "Banglore";
            model.Department = "Hr";
            model.Gender = 'M';
            model.BasicPay = 22000;
            model.Deduction = 1500;
            model.Tax = 300;
            model.NetPay = 2500.00;
            model.City = "Banglore";
            model.country = "India";
            repo.AddEmployee(model);



        }
    }
}
