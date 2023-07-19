using Prototype.Core.Abstracts;

namespace Prototype.Core.Concretes;

public class Color : ColorPrototype
{
    public string Id { get; set; }
    public int Red { get; }
    public int Green { get; }
    public int Blue { get; }

    public Color(string id, int red, int green, int blue)
    {
        Id = id;
        Red = red;
        Green = green;
        Blue = blue;
    }

    public override ColorPrototype Clone()
    {
        var result = (Color)this.MemberwiseClone();
        result.Id += " Cloned";
        return result;
    }
}