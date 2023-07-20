using Prototype.Core.Concretes;
using Prototype.Core.Models.Responses;

namespace Prototype.Core.Services;

public interface IPrototypeService
{
    List<Color> CloneColors(Color color, int cloneTimes);

    List<KeyValuePair<string, PersonResponse>> ClonePeople(Person person);

    DefaultConcretePrototype GetDefault(string text);
}