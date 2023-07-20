using FactoryMethod.Core.Abstracts.Products;

namespace FactoryMethod.Core.Concretes.Products;

public class DefaultConcreteProductB : DefaultAbstractProduct
{
    public override string Name { get; set; } = "B";

    public override string? Type { get; set; } = "Basic";
}