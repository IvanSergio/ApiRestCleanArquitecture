﻿using SchoolAdministrator.Core.Entities;

namespace SchoolAdministrator.Core.Interfaces.Services
{
  public interface IClassroomService
  {
    Task<Classroom> GetClassroomById(int id);
    Task<IEnumerable<Classroom>> GetAll();
    Task<Classroom> CreateClassroom(Classroom newClassroom);
    Task<Classroom> UpdateClassroom(int classroomToBeUpdatedId, Classroom newClassroomValues);
    Task DeleteClassroom(int classroomId);
  }
}
