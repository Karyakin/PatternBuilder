// See https://aka.ms/new-console-template for more information

using Reporter.Implementations;
using Reporter.Models;

List<Employee> employees = new()
{
    new Employee() {Name = "Ivan", Salary = 100},
    new Employee() {Name = "Boris", Salary = 300},
    new Employee() {Name = "Dima", Salary = 500}
};

var builder = new EmployeeReportBuilder(employees);
var director = new EmployeeReportDirector(builder);

director.Build();

var report = builder.GetReport();

//Console.WriteLine(report);
//Console.ReadKey();


var fluentBuilder = new FluentEmployeeReportBuilder(employees);
var fluentDirector = new FluentEmployeeReportDirector(fluentBuilder);

fluentDirector.Build();

var fluentReport = fluentBuilder.GetReport();

Console.WriteLine(fluentReport);
Console.ReadKey();