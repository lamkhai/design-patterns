using AbstractFactory.Core.Models.ProductAbstracts;

namespace AbstractFactory.Core.Models.Responses;

public class CultureResponse
{
    public string? Name { get; set; }

    public CountryModel? Country { get; set; }

    public LanguageModel? Language { get; set; }
}