using System;
using System.Collections.Generic;
namespace DapperDataAccessLayer
{
     public interface IDoctors
    {
       
        public void Insert();
        public void Insert(Doctors IN);
        public void Update(long No,Doctors Replace);
        public List<Doctors> GetAll();
        public List<Doctors> Delete(long no);

    }
}
