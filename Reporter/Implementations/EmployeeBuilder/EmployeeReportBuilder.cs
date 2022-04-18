using Reporter.Interfaces;
using Reporter.Interfaces.IEmployeeBuilder;
using Reporter.Models;
using Reporter.Models.Employees;

namespace Reporter.Implementations;

public class EmployeeReportBuilder : IEmployeeReportBuilder
{
    private EmployeeReport _employeeReport;// объект отчета
    private readonly IEnumerable<Employee> _employees;

    public EmployeeReportBuilder( IEnumerable<Employee> employees)
    {
        _employees = employees;
        _employeeReport = new EmployeeReport();
    }
    
    public void BuildHeader()
    {
        _employeeReport.Header =
            $"EMPLOYEES REPORT ON DATE {DateTime.Now}\n-----------------------------------------------------------------\n";
    }

    public void BuildBody()
    {
        _employeeReport.Body =
            string.Join(Environment.NewLine, _employees.Select(z =>
                $"Employee: {z.Name}\t\tSalary: {z.Salary}"
            ));
    }

    public void BuildFooter()
    {
        _employeeReport.Footer = 
            "\n-----------------------------------------------------------------\n";
        _employeeReport.Footer += $"TOTAL EMPLOYEES: {_employees.Count()}, " +
                                  $"TOTAL SALARY: {_employees.Sum(x => x.Salary)}$";

    }

    public EmployeeReport GetReport()
    {
        EmployeeReport employeeReport = _employeeReport;
        _employeeReport = new EmployeeReport();
        return employeeReport;
    }
}