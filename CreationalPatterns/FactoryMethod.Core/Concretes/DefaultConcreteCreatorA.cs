using FactoryMethod.Core.Abstracts;

namespace FactoryMethod.Core.Concretes;

public class DefaultConcreteCreatorA : DefaultAbstractCreator
{
    public override DefaultAbstractProduct FactoryMethod()
    {
        return new DefaultConcreteProductA();
    }
}