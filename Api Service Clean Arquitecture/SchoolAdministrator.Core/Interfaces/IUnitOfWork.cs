using SchoolAdministrator.Core.Interfaces.Repositories;

namespace SchoolAdministrator.Core.Interfaces
{
  public interface IUnitOfWork : IDisposable
    {
        ISchoolRepository SchoolRepository { get; }
        IClassroomRepository ClassroomRepository { get; }

        Task<int> CommitAsync();
    }
}
