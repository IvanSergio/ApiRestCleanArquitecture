﻿namespace SchoolAdministrator.Core.Entities
{
  public class Classroom
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }
    public int SchoolId { get; set; }
    public School School { get; set; }
  }
}
