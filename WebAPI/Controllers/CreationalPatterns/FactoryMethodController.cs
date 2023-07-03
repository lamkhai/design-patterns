using FactoryMethod.Core.Services;
using WebAPI.Controllers.Base;

namespace WebAPI.Controllers.CreationalPatterns;

public class FactoryMethodController : APIControllerBase<FactoryMethodController, IFactoryMethodService>
{
    public FactoryMethodController(
        IFactoryMethodService patternService,
        ILogger<FactoryMethodController> logger)
        : base(
            patternService,
            logger)
    {
    }
}