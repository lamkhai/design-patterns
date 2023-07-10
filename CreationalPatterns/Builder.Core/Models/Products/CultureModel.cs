using LK.Shared.Enums;

namespace Builder.Core.Models.Products;

public class CultureModel
{
    private readonly CultureEnum _cultureType;
    private readonly Dictionary<string, string> _information = new();

    public CultureModel(CultureEnum cultureType)
    {
        _cultureType = cultureType;
    }

    public string this[string key]
    {
        get { return _information[key]; }
        set { _information[key] = value; }
    }

    public Dictionary<string, string> GetInformation()
    {
        var information = _information;
        information.Add("Culture Type", _cultureType.ToString());
        return information;
    }
}