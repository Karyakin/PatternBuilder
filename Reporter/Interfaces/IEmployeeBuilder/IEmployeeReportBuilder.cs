using Reporter.Models;
using Reporter.Models.Employees;

namespace Reporter.Interfaces.IEmployeeBuilder;

public interface IEmployeeReportBuilder
{
    void BuildHeader();
    void BuildBody();
    void BuildFooter();

    EmployeeReport GetReport();
}