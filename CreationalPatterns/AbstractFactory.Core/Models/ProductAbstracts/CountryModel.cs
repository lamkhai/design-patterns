using AbstractFactory.Core.Models.Responses;

namespace AbstractFactory.Core.Models.ProductAbstracts;

public abstract class CountryModel
{
    public abstract string Capital { get; set; }

    public abstract string Name { get; set; }

    public virtual CultureResponse Has(LanguageModel language)
    {
        return new CultureResponse()
        {
            Name = GetType().Name,
            Country = this,
            Language = language,
        };
    }
}