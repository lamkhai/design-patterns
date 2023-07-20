using FactoryMethod.Core.Abstracts.Products;

namespace FactoryMethod.Core.Abstracts.Creators;

public abstract class ContinentModel
{
    private List<CountryModel> _countries = new List<CountryModel>();

    public ContinentModel()
    {
        CreateCountries();
    }

    public List<CountryModel> Countries
    {
        get { return _countries; }
    }

    public abstract void CreateCountries();
}