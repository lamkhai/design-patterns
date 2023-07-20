namespace FactoryMethod.Core.Abstracts;

public abstract class DefaultAbstractProduct
{
    public abstract string Name { get; set; }

    public virtual string? Type { get; set; }
}