using Reporter.Models;

namespace Reporter.Interfaces;

public interface IFluentEmployeeReportBuilder // сдесь главное, чтобы на каждом этапе возвращалась реализация интерфейса строителя
{
    IFluentEmployeeReportBuilder BuildHeader();
    IFluentEmployeeReportBuilder BuildBody();
    IFluentEmployeeReportBuilder BuildFooter();

    EmployeeReport GetReport();
}