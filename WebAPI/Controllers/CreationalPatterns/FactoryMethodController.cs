using FactoryMethod.Core.Abstracts;
using FactoryMethod.Core.Models.Abstracts;
using FactoryMethod.Core.Services;
using LK.Shared.Enums;
using Microsoft.AspNetCore.Mvc;
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

    [HttpGet("GetCountries")]
    public List<CountryModel> GetCountries(ContinentEnum continentType)
    {
        return _patternService.GetCountries(continentType);
    }

    [HttpGet("GetDefault")]
    public List<DefaultAbstractProduct> GetDefault()
    {
        return _patternService.GetDefault();
    }
}