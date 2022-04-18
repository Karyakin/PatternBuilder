using Reporter.Interfaces.IHouseBuilder;
using Reporter.Models.Employees;
using Reporter.Models.House;

namespace Reporter.Implementations.HouseBuilder;

public class HouseBuilder : IHouseBuilder
{
    private House _house;
    private readonly Roof _roof;
    private readonly Wall _wall;
    private readonly SwimmingPool _swimmingPool;

    public HouseBuilder(Roof roof, Wall wall, SwimmingPool swimmingPool)
    {
        _roof = roof;
        _wall = wall;
        _swimmingPool = swimmingPool;
        _house = new House();
    }
    
    public IHouseBuilder BuildRoof()
    {
        _house.Roof = _roof;
        return this;
    }

    public IHouseBuilder BuildWall()
    {
        _house.Wall = _wall;

        return this;
    }

    public IHouseBuilder BuildSwimmingPool()
    {
        _house.SwimmingPool = _swimmingPool;
        return this;
    }

    public House GetHouse()
    {
        House house = _house;
        _house = new House();
        return house;
    }
}