using Reporter.Interfaces.IHouseBuilder;
using Reporter.Models.Employees;
using Reporter.Models.House;

namespace Reporter.Implementations.HouseBuilder;

public class HouseBuilder : IHouseBuilder
{
    private House _house;
    private readonly Roof _roof;
    private readonly Wall _wall;

    public HouseBuilder(Roof roof, Wall wall)
    {
        _roof = roof;
        _wall = wall;
        _house = new House();
    }
    
    public IHouseBuilder BuildeRoof()
    {
        _house.Roof = _roof;
        return this;
    }

    public IHouseBuilder BuildeWall()
    {
        _house.Wall = _wall;

        return this;
    }

    public House GetHouse()
    {
        House house = _house;
        _house = new House();
        return house;
    }
}