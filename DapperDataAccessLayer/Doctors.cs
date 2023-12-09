using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDataAccessLayer
{
    public class Doctors
    { 
        public string DoctorsName { get; set; }
        public long DoctorsID { get; set; }
        public long PassoutYear { get; set; }
        public string Qualification { get; set; }
        public long PhoneNumber { get; set; }
        public string Addresss { get; set; }
    }
}
