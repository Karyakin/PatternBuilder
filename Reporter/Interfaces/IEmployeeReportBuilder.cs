using Reporter.Models;

namespace Reporter.Interfaces;

public interface IEmployeeReportBuilder
{
    void BuildHeader();
    void BuildBody();
    void BuildFooter();

    EmployeeReport GetReport();
}