using Reporter.Interfaces.IEmployeeBuilder;

namespace Reporter.Implementations.EmployeeBuilder;

public class FluentEmployeeReportDirector
{
    private readonly IFluentEmployeeReportBuilder _builder;

    public FluentEmployeeReportDirector(IFluentEmployeeReportBuilder builder)
    {
        _builder = builder;
    }

    public void Build()// сдесь можно компоновать в любой последовательности и количесвте
    {
        _builder
            .BuildHeader()
            .BuildBody()
            .BuildFooter();
    }
}