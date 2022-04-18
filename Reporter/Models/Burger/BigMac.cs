using System.Text;

namespace Reporter.Models.Burger;

public class BigMac
{
    public string? Name { get; set; }
    public string? Size { get; set; }
    public bool Cheese { get; set; }
    public bool Pickles { get; set; }
    
    public override string ToString()
    {
        return new StringBuilder()
            .Append(Name)
            .Append(Size)
            .Append(Cheese)
            .Append(Pickles)
            .ToString();
    }
}