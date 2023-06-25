using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.Base;

[ApiController]
[Route("[controller]")]
public class APIControllerBase<TChildController, TService> : ControllerBase
{
    protected readonly TService _patternService;
    protected readonly ILogger<TChildController> _logger;

    public APIControllerBase(
        TService patternService,
        ILogger<TChildController> logger)
    {
        _patternService = patternService;
        _logger = logger;
    }
}