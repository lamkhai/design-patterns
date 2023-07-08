using AbstractFactory.Core.Models.Responses;
using LK.Shared.Enums;

namespace AbstractFactory.Core.Services;

public interface IAbstractFactoryService
{
    CultureResponse? GetCulture(CultureEnum cultureType);
}