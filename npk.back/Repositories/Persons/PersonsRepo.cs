using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using npk.back.EFCore;
using npk.back.ModelBinders;
using npk.back.Models;
using System.Threading.Tasks;

namespace npk.back.Repositories.Persons;

public class PersonsRepo : IPersonsRepo
{
  private readonly PersonsDbContext _ctx;
  public PersonsRepo(PersonsDbContext ctx)
  {
    _ctx = ctx;
  }
  public async Task<LoadResult> GetPersonsAsync(DataSourceLoadOptions loadOptions)
  {
    var resultPersons = _ctx.Persons;
    loadOptions.PrimaryKey = new[] { nameof(Person.Id) };
    loadOptions.PaginateViaPrimaryKey = true;
    return await DataSourceLoader.LoadAsync(resultPersons, loadOptions);
  }
}
