using Builder.Core.Services;
using LK.Shared.Enums;
using Microsoft.AspNetCore.Mvc;
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

    [HttpGet("GetCultureInformation")]
    public Dictionary<string, string>? GetCultureInformation(CultureEnum cultureType)
    {
        return _patternService.GetCultureInformation(cultureType);
    }
}