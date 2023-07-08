using AbstractFactory.Core.Models.Clients;
using AbstractFactory.Core.Models.Factories;
using AbstractFactory.Core.Models.FactoryAbstracts;
using AbstractFactory.Core.Models.Responses;
using AbstractFactory.Core.Services;
using LK.Shared.Enums;

namespace AbstractFactory.Infrastructure.Services;

public class AbstractFactoryService : IAbstractFactoryService
{
    public CultureResponse? GetCulture(CultureEnum cultureType)
    {
        CultureFactory cultureFactory;

        switch (cultureType)
        {
            case CultureEnum.enGB:
                cultureFactory = new EngFactory();
                break;
            case CultureEnum.viVN:
                cultureFactory = new VietFactory();
                break;
            default:
                return null;
        }

        Culture culture = new(cultureFactory);
        return culture.GetCulture();
    }
}