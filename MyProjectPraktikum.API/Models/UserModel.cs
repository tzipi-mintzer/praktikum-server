using MyProjectPraktikum.Common.DTOs;

namespace MyProjectPraktikum.API.Models
{

    public class UserModel
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tz { get; set; }
        public DateTime BirthDate { get; set; }
        public EGenderDTO Gender { get; set; }
        public EHMODTO HMO { get; set; }
    }
}
