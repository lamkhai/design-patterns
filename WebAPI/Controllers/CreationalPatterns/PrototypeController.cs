using Prototype.Core.Services;
using WebAPI.Controllers.Base;

namespace WebAPI.Controllers.CreationalPatterns;

public class PrototypeController : APIControllerBase<PrototypeController, IPrototypeService>
{
    public PrototypeController(
        IPrototypeService patternService,
        ILogger<PrototypeController> logger)
        : base(
            patternService,
            logger)
    {
    }
}