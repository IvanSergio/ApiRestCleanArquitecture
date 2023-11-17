using SchoolAdministrator.Core.Interfaces.Repositories;
using SchoolAdministrator.Core.Interfaces;
using SchoolAdministrator.Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdministrator.Infraestructure.Data
{
  public class UnitOfWork : IUnitOfWork
  {
    private readonly AppDbContext _context;
    private SchoolRepository _schoolRepository;
    private ClassroomRepository _classroomRepository;

    public UnitOfWork(AppDbContext context)
    {
      this._context = context;
    }

    public ISchoolRepository SchoolRepository => _schoolRepository ??= new SchoolRepository(_context);

    public IClassroomRepository ClassroomRepository => _classroomRepository ??= new ClassroomRepository(_context);


    public async Task<int> CommitAsync()
    {
      return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
      _context.Dispose();
    }
  }
}
