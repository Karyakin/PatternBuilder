using Reporter.Models.Transport;

namespace Reporter.Interfaces.ITransport;

public interface IAutomobileBuilder
{
    void BuildBrand();
    void BuildModel();
    void BuildDateOfManufacture();

    Automobile GetAutomobile();
}