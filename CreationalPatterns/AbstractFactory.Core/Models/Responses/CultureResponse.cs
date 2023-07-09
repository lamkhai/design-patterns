using AbstractFactory.Core.Models.ProductAbstracts;

namespace AbstractFactory.Core.Models.Responses;

public class CultureResponse
{
    public string? Name { get; set; }

    public Country? Country { get; set; }

    public Language? Language { get; set; }
}