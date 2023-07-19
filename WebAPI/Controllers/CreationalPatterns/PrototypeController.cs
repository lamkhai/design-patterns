using Microsoft.AspNetCore.Mvc;
using Prototype.Core.Concretes;
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

    [HttpPost("CloneColors")]
    public List<Color> CloneColors([FromBody] Color color, int cloneTimes)
    {
        return _patternService.CloneColors(color, cloneTimes);
    }

    [HttpGet("GetDefault")]
    public IActionResult GetDefault(string text)
    {
        return Ok(_patternService.GetDefault(text));
    }
}