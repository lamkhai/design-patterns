using FactoryMethod.Core.Abstracts;

namespace FactoryMethod.Core.Concretes;

public class DefaultConcreteProductB : DefaultAbstractProduct
{
    public override string Name { get; set; } = "B";

    public override string? Type { get; set; } = "Basic";
}