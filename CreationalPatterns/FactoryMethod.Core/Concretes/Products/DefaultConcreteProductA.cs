using FactoryMethod.Core.Abstracts.Products;

namespace FactoryMethod.Core.Concretes.Products;

public class DefaultConcreteProductA : DefaultAbstractProduct
{
    public override string Name { get; set; } = "A";
}