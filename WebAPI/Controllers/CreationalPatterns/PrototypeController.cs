using Microsoft.AspNetCore.Mvc;
using Prototype.Core.Concretes;
using Prototype.Core.Models.Responses;
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

    [HttpPost("ClonePeople")]
    public List<KeyValuePair<string, PersonResponse>> ClonePeople([FromBody] Person person)
    {
        return _patternService.ClonePeople(person);
    }

    [HttpGet("GetDefault")]
    public IActionResult GetDefault(string text)
    {
        return Ok(_patternService.GetDefault(text));
    }
}