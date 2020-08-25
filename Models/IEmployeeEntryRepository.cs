using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_API_Assignment.Models
{
    public interface IEmployeeEntryRepository
    {
        EmployeeEntry Create(EmployeeEntry entry);
        EmployeeEntry Find(int id);
        bool Contains(int id);
         IEnumerable<EmployeeEntry> List();
        EmployeeEntry Update(int id,EmployeeEntry Entry);
        void Delete(int id);

    }
}
