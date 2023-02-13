using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectPraktikum.Common.DTOs
{
    public enum EHMODTO { makabi, meuchedet, klalit, leumit }
    public enum EGenderDTO { male, female }
    public class UserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tz { get; set; }
        public DateTime BirthDate { get; set; }
        public EGenderDTO Gender { get; set; }
        public EHMODTO HMO { get; set; }
    }
}
