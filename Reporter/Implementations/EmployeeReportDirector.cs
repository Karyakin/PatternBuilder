using Reporter.Interfaces;

namespace Reporter.Implementations;

public class EmployeeReportDirector
{
    private readonly IEmployeeReportBuilder _builder;

    public EmployeeReportDirector(IEmployeeReportBuilder builder)
    {
        _builder = builder;
    }

    public void Build()// сдесь можно компоновать в любой последовательности и количесвте
    {
        _builder.BuildHeader();
        _builder.BuildBody();
        _builder.BuildFooter();
    }
}