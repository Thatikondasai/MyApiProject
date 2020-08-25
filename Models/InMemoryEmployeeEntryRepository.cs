using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_API_Assignment.Models
{
    public class InMemoryEmployeeEntryRepository : IEmployeeEntryRepository
    {
        int id = 1;
        private readonly IDictionary<int, EmployeeEntry> pairs = new Dictionary<int, EmployeeEntry>();


        public bool Contains(int id) => pairs.ContainsKey(id);
        
        public EmployeeEntry Create(EmployeeEntry entry)
        {
            pairs.Add(id,entry);
            return entry;
        }

        public void Delete(int id) => pairs.Remove(id);
        

        public EmployeeEntry Find(int id) => pairs[id];


        public IEnumerable<EmployeeEntry> List() => pairs.Values.ToList();
        

        public EmployeeEntry Update(int id, EmployeeEntry Entry)
        {

            Entry.EmpId = id;
            pairs[id] = Entry;
            return Entry;
        }

    }
}
