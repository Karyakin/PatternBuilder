using Reporter.Interfaces.IBurgerBuilder;

namespace Reporter.Implementations.BurgerBuilder;

public class BigMacDirector
{
    private readonly IBigMacBuilder _builder;

    public BigMacDirector(IBigMacBuilder builder)
    {
        _builder = builder;
    }

    public void Build()
    {
        _builder
            .BuildName()
            .BuildSize()
            .BuildCheese()
            .BuildPickles();
    }
}