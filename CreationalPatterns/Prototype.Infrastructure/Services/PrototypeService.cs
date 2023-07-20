using Prototype.Core.Concretes;
using Prototype.Core.Managers;
using Prototype.Core.Models.Responses;
using Prototype.Core.Services;

namespace Prototype.Infrastructure.Services;

public class PrototypeService : IPrototypeService
{
    public List<Color> CloneColors(Color color, int cloneTimes)
    {
        ColorManager colormanager = new();
        colormanager[color.Id] = color;

        var result = new List<Color>()
        {
            (Color)colormanager[color.Id],
        };

        var clonedColor = (Color)color.Clone();
        for (int i = 1; i <= cloneTimes; i++)
        {
            colormanager[clonedColor.Id] = clonedColor;
            result.Add((Color)colormanager[clonedColor.Id]);

            clonedColor = (Color)clonedColor.Clone();
        }

        return result;
    }

    public List<KeyValuePair<string, PersonResponse>> ClonePeople(Person person)
    {
        List<KeyValuePair<string, PersonResponse>> result = new();

        AddToList(result, "Original", person);

        Person p2 = person.ShallowClone();
        AddToList(result, "ShallowClone of Original", p2);

        Person p3 = person.DeepClone();
        AddToList(result, "DeepClone of Original", p3);

        person.PersonId.Id += 2;
        person.Age *= 2;
        person.BirthDate = DateTime.Now;
        person.Name += "(2)";

        AddToList(result, "After changed", person);
        AddToList(result, "ShallowClone after changed", p2);
        AddToList(result, "DeepClone after changed", p3);

        return result;
    }

    public DefaultConcretePrototype GetDefault(string text)
    {
        DefaultConcretePrototype firstInstance = new(text);
        DefaultConcretePrototype resultInstance = (DefaultConcretePrototype)firstInstance.Clone();
        return resultInstance;
    }

    private static void AddToList(List<KeyValuePair<string, PersonResponse>> list, string key, Person value)
    {
        var response = new PersonResponse()
        {
            Id = value.PersonId.Id,
            Age = value.Age,
            BirthDate = value.BirthDate,
            Name = value.Name,
        };
        list.Add(new KeyValuePair<string, PersonResponse>(key, response));
    }
}