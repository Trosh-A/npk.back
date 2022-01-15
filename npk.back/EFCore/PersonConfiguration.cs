using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using npk.back.Models;

namespace npk.back.EFCore;

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
  public void Configure(EntityTypeBuilder<Person> builder)
  {
    builder.HasKey(p => p.Id);
    builder.Property(p => p.FirstName).HasMaxLength(128).IsRequired();
    builder.Property(p => p.LastName).HasMaxLength(128).IsRequired();
    builder.HasData(PersonsGenerator.Generate(800));
  }
}
