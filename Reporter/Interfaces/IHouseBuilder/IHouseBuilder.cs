using Reporter.Models.Employees;

namespace Reporter.Interfaces.IHouseBuilder;

public interface IHouseBuilder
{
    IHouseBuilder BuildeRoof();
    IHouseBuilder BuildeWall();

    House GetHouse();
}