using Reporter.Interfaces;

namespace Reporter.Implementations;

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