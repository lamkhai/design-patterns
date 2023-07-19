using Prototype.Core.Abstracts;

namespace Prototype.Core.Managers;

public class ColorManager
{
    private readonly Dictionary<string, ColorPrototype> colors = new();

    public ColorPrototype this[string key]
    {
        get { return colors[key]; }
        set { colors.Add(key, value); }
    }
}