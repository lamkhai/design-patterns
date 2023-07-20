using FactoryMethod.Core.Abstracts;

namespace FactoryMethod.Core.Concretes;

public class DefaultConcreteProductA : DefaultAbstractProduct
{
    public override string Name { get; set; } = "A";
}