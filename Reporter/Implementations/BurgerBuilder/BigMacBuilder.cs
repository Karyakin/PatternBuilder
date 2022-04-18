using Reporter.Interfaces.IBurgerBuilder;
using Reporter.Models.Burger;

namespace Reporter.Implementations.BurgerBuilder;

public class BigMacBuilder : IBigMacBuilder
{
    private BigMac _bigMac;
    private readonly IEnumerable<BigMac> _components;

    public BigMacBuilder(IEnumerable<BigMac> components)
    {
        _components = components;
        _bigMac = new BigMac();
    }
    
    public IBigMacBuilder BuildName()
    {
        _bigMac.Name = _components.Select(x => x.Name).ToString();
        return this;
    }

    public IBigMacBuilder BuildSize()
    {
        _bigMac.Size = _components
            .Select(x => x.Size)
            .ToString();
        return this;
    }

    public IBigMacBuilder BuildCheese()
    {
        _bigMac.Cheese = _components
            .Select(x => x.Cheese)
            .FirstOrDefault();
        return this;
    }

    public IBigMacBuilder BuildPickles()
    {
        _bigMac.Pickles = _components
            .Select(x => x.Pickles)
            .FirstOrDefault();
        return this;
    }

    public BigMac CreateBigMac()
    {
        var bigMac = _bigMac;
        _bigMac = new BigMac();
        return bigMac;
    }
}