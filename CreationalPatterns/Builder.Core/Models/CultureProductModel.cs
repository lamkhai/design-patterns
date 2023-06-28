using LK.Shared.Enums;

namespace Builder.Core.Models;

/// <summary>
/// The 'Product'
/// </summary>
public class CultureProductModel
{
    private CultureEnum _cultureType;
    private Dictionary<string, string> _information = new Dictionary<string, string>();
    
    public CultureProductModel(CultureEnum cultureType)
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