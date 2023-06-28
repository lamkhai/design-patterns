using Builder.Core.Models.Abstracts;
using Builder.Core.Models.Concretes;
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
        AbstractCultureBuilderModel cultureBuilder;

        switch (cultureType)
        {
            case CultureEnum.enGB:
                cultureBuilder = new ConcreteEnGBBuilderModel();
                break;
            case CultureEnum.viVN:
                cultureBuilder = new ConcreteViVNBuilderModel();
                break;
            default:
                return null;
        }

        _patternService.Construct(cultureBuilder);

        return cultureBuilder.Culture.GetInformation();
    }
}