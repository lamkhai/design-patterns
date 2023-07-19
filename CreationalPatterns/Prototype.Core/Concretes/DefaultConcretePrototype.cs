using Prototype.Core.Abstracts;

namespace Prototype.Core.Concretes;

public class DefaultConcretePrototype : DefaultAbstractPrototype
{
    public DefaultConcretePrototype(string text) : base(text)
    {
    }

    public override DefaultAbstractPrototype Clone()
    {
        return (DefaultAbstractPrototype)MemberwiseClone();
    }
}