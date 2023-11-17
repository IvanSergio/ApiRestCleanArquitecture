using SchoolAdministrator.Core.Entities;
using SchoolAdministrator.Core.Interfaces.Repositories;
using SchoolAdministrator.Infraestructure.Data;

namespace SchoolAdministrator.Infraestructure.Repositories
{
  public class SchoolRepository : BaseRepository<School>, ISchoolRepository
  {
    public SchoolRepository(AppDbContext context) : base(context)
    {

    }
  }
}
