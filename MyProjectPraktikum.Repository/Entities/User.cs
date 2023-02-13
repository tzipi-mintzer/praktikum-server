using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectPraktikum.Repository.Entities
{
    public enum EHMO { makabi, meuchedet, klalit, leumit }
    public enum EGender { male,female}
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tz { get; set; }
        public DateTime BirthDate { get; set; }
        public EGender Gender { get; set; }
        public EHMO HMO { get; set; }
        //public List<Child> Children { get; set; }=new List<Child>(){ };

    }
}
