using Builder.Core.Services;
using WebAPI.Controllers.Base;

namespace WebAPI.Controllers.CreationalPatterns;

public class BuilderController : APIControllerBase<BuilderController, IBuilderService>
{
    public BuilderController(
        IBuilderService patternService,
        ILogger<BuilderController> logger)
        : base(
            patternService,
            logger)
    {
    }
}