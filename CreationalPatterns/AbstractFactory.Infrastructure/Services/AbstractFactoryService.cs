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
                cultureFactory = new EngFactoryModel();
                break;
            case CultureEnum.viVN:
                cultureFactory = new VietFactoryModel();
                break;
            default:
                return null;
        }

        CultureModel culture = new(cultureFactory);
        return culture.GetCulture();
    }
}