using Reporter.Models;
using Reporter.Models.Employees;

namespace Reporter.Interfaces.IEmployeeBuilder;

public interface IFluentEmployeeReportBuilder // сдесь главное, чтобы на каждом этапе возвращалась реализация интерфейса строителя
{
    IFluentEmployeeReportBuilder BuildHeader();
    IFluentEmployeeReportBuilder BuildBody();
    IFluentEmployeeReportBuilder BuildFooter();

    EmployeeReport GetReport();
}