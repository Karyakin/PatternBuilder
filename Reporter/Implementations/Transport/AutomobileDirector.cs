using Reporter.Interfaces.ITransport;

namespace Reporter.Implementations.Transport;

public class AutomobileDirector
{
    private readonly IAutomobileBuilder _builder;

    public AutomobileDirector(IAutomobileBuilder builder)
    {
        _builder = builder;
    }

    public void Build()
    {
        _builder.BuildBrand();
        _builder.BuildModel();
    }
    
}