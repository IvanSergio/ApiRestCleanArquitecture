using SchoolAdministrator.Core.Entities;
using SchoolAdministrator.Core.Interfaces.Repositories;
using SchoolAdministrator.Infraestructure.Data;

namespace SchoolAdministrator.Infraestructure.Repositories
{
  public class ClassroomRepository : BaseRepository<Classroom>, IClassroomRepository
  {
    public ClassroomRepository(AppDbContext context) : base(context)
    {

    }
  }
}
