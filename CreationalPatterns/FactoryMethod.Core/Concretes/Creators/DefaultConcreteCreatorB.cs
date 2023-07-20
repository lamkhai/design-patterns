using FactoryMethod.Core.Abstracts.Creators;
using FactoryMethod.Core.Abstracts.Products;
using FactoryMethod.Core.Concretes.Products;

namespace FactoryMethod.Core.Concretes.Creators;

public class DefaultConcreteCreatorB : DefaultAbstractCreator
{
    public override DefaultAbstractProduct FactoryMethod()
    {
        return new DefaultConcreteProductB();
    }
}