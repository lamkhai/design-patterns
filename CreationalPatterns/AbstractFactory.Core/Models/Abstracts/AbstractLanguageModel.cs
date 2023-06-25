namespace AbstractFactory.Core.Models.Abstracts;

public abstract class AbstractLanguageModel
{
    public abstract string Hello { get; set; }

    public virtual LanguageCountryModel Interact(AbstractCountryModel country)
    {
        return new LanguageCountryModel()
        {
            ConcreteName = GetType().Name,
            Country = country,
            Language = this,
        };
    }
}