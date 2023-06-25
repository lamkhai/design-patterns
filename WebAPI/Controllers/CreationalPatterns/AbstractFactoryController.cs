using AbstractFactory.Core.Factories.Abstracts;
using AbstractFactory.Core.Factories.Concretes;
using AbstractFactory.Core.Services;
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

    [HttpGet("Get")]
    public void Get()
    {
        AbstractCultureFactory cultureFactory = new ConcreteVietFactory();
        _patternService.Run(cultureFactory);

        cultureFactory = new ConcreteEngFactory();
        _patternService.Run(cultureFactory);
    }
}