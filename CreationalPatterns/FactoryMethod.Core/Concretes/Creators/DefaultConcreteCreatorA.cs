using FactoryMethod.Core.Abstracts.Creators;
using FactoryMethod.Core.Abstracts.Products;
using FactoryMethod.Core.Concretes.Products;

namespace FactoryMethod.Core.Concretes.Creators;

public class DefaultConcreteCreatorA : DefaultAbstractCreator
{
    public override DefaultAbstractProduct FactoryMethod()
    {
        return new DefaultConcreteProductA();
    }
}