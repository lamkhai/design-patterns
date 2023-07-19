using Prototype.Core.Concretes;

namespace Prototype.Core.Services;

public interface IPrototypeService
{
    List<Color> CloneColors(Color color, int cloneTimes);


    DefaultConcretePrototype GetDefault(string text);
}