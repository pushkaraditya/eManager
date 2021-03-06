namespace eManager.Web.Migrations
{
  using System;
  using System.Data.Entity;
  using System.Data.Entity.Migrations;
  using System.Linq;
  using eManager.Domain;
  using eManager.Web.Infrastructure;

  internal sealed class Configuration : DbMigrationsConfiguration<DepartmentDb>
  {
    public Configuration()
    {
      AutomaticMigrationsEnabled = true;
    }

    protected override void Seed(DepartmentDb context)
    {
      context.Departments.AddOrUpdate<Department>(d => d.Name,
        new Department { Name = "Engineering" },
        new Department { Name = "Sales" },
        new Department { Name = "Shipping" },
        new Department { Name = "Human Resources" }
        );
    }
  }
}