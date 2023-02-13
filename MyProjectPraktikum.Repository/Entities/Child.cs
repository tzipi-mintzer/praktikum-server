using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectPraktikum.Repository.Entities
{
    public class Child
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Tz { get; set; }

        [ForeignKey("User")]
        public int ParentId { get; set; }
      
    }
}
