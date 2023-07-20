using FactoryMethod.Core.Abstracts;

namespace FactoryMethod.Core.Concretes;

public class DefaultConcreteCreatorB : DefaultAbstractCreator
{
    public override DefaultAbstractProduct FactoryMethod()
    {
        return new DefaultConcreteProductB();
    }
}