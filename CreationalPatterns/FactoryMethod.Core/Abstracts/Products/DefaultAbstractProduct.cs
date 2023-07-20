namespace FactoryMethod.Core.Abstracts.Products;

public abstract class DefaultAbstractProduct
{
    public abstract string Name { get; set; }

    public virtual string? Type { get; set; }
}