using Reporter.Interfaces.ITransport;
using Reporter.Models.Transport;

namespace Reporter.Implementations.Transport;

public class AutomobileBuilder : IAutomobileBuilder
{

    private Automobile _automobile;
    private readonly IEnumerable<EngineEquipment> _engineEquipments;

    public AutomobileBuilder(IEnumerable<EngineEquipment> engineEquipments)
    {
        _engineEquipments = engineEquipments;
        _automobile = new Automobile();
    }
    
    
    public void BuildBrand()
    {
        _automobile.Brand = "BMW";
    }

    public void BuildModel()
    {
        _automobile.Model = "X6";
    }

    public void BuildDateOfManufacture()
    {
        _automobile.DateOfManufacture = DateTime.Today;
    }

    public Automobile GetAutomobile()
    {
        var automobile = _automobile;
        _automobile = new Automobile();
        return automobile;
    }
}