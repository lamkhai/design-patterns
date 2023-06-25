using AbstractFactory.Core.Models.Abstracts;

namespace AbstractFactory.Core.Models;

public class LanguageCountryModel
{
    public string? ConcreteName { get; set; }

    public AbstractCountryModel? Country { get; set; }

    public AbstractLanguageModel? Language { get; set; }
}