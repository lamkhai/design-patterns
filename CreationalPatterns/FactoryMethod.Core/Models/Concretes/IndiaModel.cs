using FactoryMethod.Core.Models.Abstracts;

namespace FactoryMethod.Core.Models.Concretes;

/// <summary>
/// A 'ConcreteProduct' class
/// </summary>
public class IndiaModel : CountryModel
{
    public override string Name => "India";
}