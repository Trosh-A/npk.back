using DevExtreme.AspNet.Data.ResponseModel;
using npk.back.ModelBinders;
using System.Threading.Tasks;

namespace npk.back.Repositories.Persons;

public interface IPersonsRepo
{
  public Task<LoadResult> GetPersonsAsync(DataSourceLoadOptions loadOptions);
}
