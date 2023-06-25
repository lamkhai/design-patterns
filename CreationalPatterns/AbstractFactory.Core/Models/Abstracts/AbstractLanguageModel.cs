namespace AbstractFactory.Core.Models.Abstracts;

public abstract class AbstractLanguageModel
{
    public abstract string Hello { get; set; }

    public abstract void Interact(AbstractCountryModel country);
}