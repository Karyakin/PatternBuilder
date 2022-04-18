using Reporter.Interfaces.IHouseBuilder;

namespace Reporter.Implementations.HouseBuilder;

public class HouseBuilderDirector
{
    private readonly IHouseBuilder _builder;

    public HouseBuilderDirector(IHouseBuilder builder)
    {
        _builder = builder;
    }

    public void Build()
    {
        _builder
            .BuildeRoof()
            .BuildeWall();
    }
}