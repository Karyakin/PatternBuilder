using Reporter.Models.Burger;

namespace Reporter.Interfaces.IBurgerBuilder;

public interface IBigMacBuilder
{
    IBigMacBuilder BuildName();
    IBigMacBuilder BuildSize();
    IBigMacBuilder BuildCheese();
    IBigMacBuilder BuildPickles();
    BigMac CreateBigMac();
}