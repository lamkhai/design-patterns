using AbstractFactory.Core.Factories.Abstracts;
using AbstractFactory.Core.Factories.Concretes;
using AbstractFactory.Core.Models;
using AbstractFactory.Core.Services;
using LK.Shared.Enums;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Controllers.Base;

namespace WebAPI.Controllers.CreationalPatterns;

public class AbstractFactoryController : APIControllerBase<AbstractFactoryController, IAbstractFactoryService>
{
    public AbstractFactoryController(
        IAbstractFactoryService patternService,
        ILogger<AbstractFactoryController> logger)
        : base(
            patternService,
            logger)
    {
    }

    [HttpGet("GetLanguageCountry")]
    public LanguageCountryModel? GetLanguageCountry(CultureEnum cultureType)
    {
        AbstractCultureFactory cultureFactory;

        switch (cultureType)
        {
            case CultureEnum.enGB:
                cultureFactory = new ConcreteEngFactory();
                break;
            case CultureEnum.viVN:
                cultureFactory = new ConcreteVietFactory();
                break;
            default:
                return null;
        }

        return _patternService.GetLanguageCountry(cultureFactory);
    }
}