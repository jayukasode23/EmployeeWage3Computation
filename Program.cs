using EmployeeWage3Program;
Console.WriteLine("Welcome To Employee Wage Computation Program");

EmployeeCheck obj = new EmployeeCheck();
obj.CheckEmployeeAttendance();

DailyEmployeeWage obj1 = new DailyEmployeeWage();
obj1.CheckDailyEmployeeWage();

PartTimeEmpWage obj2 = new PartTimeEmpWage();
obj2.CheckEmployeePartTimeWage();

SwitchCaseStatement obj3 = new SwitchCaseStatement();
obj3.CheckDailyEmpWage();

EmployeeMonthWages obj4 = new EmployeeMonthWages();
obj4.CheckEmployeeMonthlyWage();

EmployeeTotalWages obj5 = new EmployeeTotalWages();
obj5.CheckEmployeeMonth();

RefactoreEmployeeWage employee = new RefactoreEmployeeWage();
employee.CheckComputeEmployeeWage();