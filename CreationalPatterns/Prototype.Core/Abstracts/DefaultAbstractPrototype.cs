namespace Prototype.Core.Abstracts;

public abstract class DefaultAbstractPrototype
{
    private readonly string _text;

    public DefaultAbstractPrototype(string text)
    {
        _text = text;
    }

    public string Text
    {
        get { return _text; }
    }

    public abstract DefaultAbstractPrototype Clone();
}