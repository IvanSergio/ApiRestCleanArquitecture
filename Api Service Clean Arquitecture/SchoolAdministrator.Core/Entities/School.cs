using System.Collections.ObjectModel;

namespace SchoolAdministrator.Core.Entities
{
  public class School
  {
    public School()
    {
      Classrooms = new Collection<Classroom>();
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public ICollection<Classroom> Classrooms { get; set; }
  }
}
