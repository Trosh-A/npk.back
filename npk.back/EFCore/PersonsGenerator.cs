using Bogus;
using System.Collections.Generic;

namespace npk.back.EFCore;

public static class PersonsGenerator
{
  public static IEnumerable<Models.Person> Generate(int count)
  {
    var f = new Faker("ru");
    var persons = new List<Models.Person>();
    for (int i = 1; i <= count; i++)
    {
      var g = f.Person.Gender;
      persons.Add(new Models.Person()
      {
        Id = i,
        FirstName = f.Name.FirstName(g),
        LastName = f.Name.LastName(g),
        DateOfBirth = f.Date.PastDateOnly(20).ToString("o"),
        Height = f.Random.Number(150, 220)
      });
    }
    return persons;
  }
}
