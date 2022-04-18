using Reporter.Interfaces.IEmployeeBuilder;
using Reporter.Models;
using Reporter.Models.Employees;

namespace Reporter.Implementations.EmployeeBuilder;

public class FluentEmployeeReportBuilder : IFluentEmployeeReportBuilder
{
    private EmployeeReport _employeeReport;// объект отчета
    private readonly IEnumerable<Employee> _employees;

    public FluentEmployeeReportBuilder( IEnumerable<Employee> employees)
    {
        _employees = employees;
        _employeeReport = new EmployeeReport();
    }
    
    public IFluentEmployeeReportBuilder BuildHeader()
    {
        _employeeReport.Header =
            $"EMPLOYEES REPORT ON DATE {DateTime.Now}\n-----------------------------------------------------------------\n";
        return this;
    }

    public IFluentEmployeeReportBuilder BuildBody()
    {
        _employeeReport.Body =
            string.Join(Environment.NewLine, _employees.Select(z =>
                $"Employee: {z.Name}\t\tSalary: {z.Salary}"
            ));
        return this;
    }

    public IFluentEmployeeReportBuilder BuildFooter()
    {
        _employeeReport.Footer = 
            "\n-----------------------------------------------------------------\n";
        _employeeReport.Footer += $"TOTAL EMPLOYEES: {_employees.Count()}, " +
                                  $"TOTAL SALARY: {_employees.Sum(x => x.Salary)}$";
        return this;

    }

    public EmployeeReport GetReport()
    {
        EmployeeReport employeeReport = _employeeReport;
        _employeeReport = new EmployeeReport();
        return employeeReport;
    }
}