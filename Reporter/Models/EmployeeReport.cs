using System.Text;

namespace Reporter.Models;

public class EmployeeReport // продукт
{
    public string Header { get; set; }
    public string Body { get; set; }
    public string Footer { get; set; }

    public override string ToString()
    {
        return new StringBuilder()
            .Append(Header)
            .Append(Body)
            .Append(Footer)
            .ToString();
    }
}