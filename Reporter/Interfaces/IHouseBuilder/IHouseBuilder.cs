using Reporter.Models.Employees;

namespace Reporter.Interfaces.IHouseBuilder;

public interface IHouseBuilder
{
    IHouseBuilder BuildRoof();
    IHouseBuilder BuildWall();
    IHouseBuilder BuildSwimmingPool();

    House GetHouse();
}