using AbstractFactory.Core.Models.Responses;
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

    [HttpGet("GetCulture")]
    public CultureResponse? GetCulture(CultureEnum cultureType)
    {
        return _patternService.GetCulture(cultureType);
    }
}