#nullable disable

namespace npk.back.Models;

public class Person
{
  public int Id { get; set; }
  public string FirstName { get; set; }
  public string LastName { get; set; }
  //Пришлось для даты использовать string, иначе фильтры работают некоректно
  public string DateOfBirth { get; set; }
  public int Height { get; set; }
}
