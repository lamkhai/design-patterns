using LK.Shared.Enums;

namespace Builder.Core.Services;

/// <summary>
/// The 'Director'
/// </summary>
public interface IBuilderService
{
    Dictionary<string, string>? GetCultureInformation(CultureEnum cultureType);
}