using Prototype.Core.Concretes;
using Prototype.Core.Managers;
﻿using Prototype.Core.Services;

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

    public DefaultConcretePrototype GetDefault(string text)
    {
        DefaultConcretePrototype firstInstance = new(text);
        DefaultConcretePrototype resultInstance = (DefaultConcretePrototype)firstInstance.Clone();
        return resultInstance;
    }
{
}