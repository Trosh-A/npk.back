using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using npk.back.ModelBinders;
using npk.back.Repositories.Persons;
using System.Threading.Tasks;

namespace npk.back.Controllers;

[ApiController]
[Route("api/")]
public class PersonsController : ControllerBase
{
  private readonly ILogger<PersonsController> _logger;
  private readonly IPersonsRepo _personsRepo;

  public PersonsController(ILogger<PersonsController> logger, IPersonsRepo personsRepo)
  {
    _logger = logger;
    _personsRepo = personsRepo;
  }
  [HttpGet]
  public async Task<IActionResult> GetPersonsAsync([FromBody] DataSourceLoadOptions options)
  {
    _logger.LogInformation("Запрошен список пользователей.");
    if (options is null) return BadRequest("Ошибка обработки данных");
    return Ok(await _personsRepo.GetPersonsAsync(options));
  }
}