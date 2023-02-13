using System.ComponentModel.DataAnnotations.Schema;

namespace MyProjectPraktikum.API.Models
{

    public class ChildModel
    {
      
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Tz { get; set; }
        public int ParentId { get; set; }
    }
}
