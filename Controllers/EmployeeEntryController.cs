using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employee_API_Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employee_API_Assignment.Controllers
{
    [Route("/Employee-entries")]

    public class EmployeeEntryController : Controller
    {

        public IEmployeeEntryRepository entryRepository;
        public EmployeeEntryController(IEmployeeEntryRepository employeeEntryRepository)
        {
            this.entryRepository = employeeEntryRepository;
        }

        public IActionResult GetEmployees()
        {

            return View(entryRepository.List());
        }
        [HttpPost]
        public IActionResult Create([FromBody] EmployeeEntry employeeEntry)
        {
            var CreatedEmployee = entryRepository.Create(employeeEntry);
            return CreatedAtRoute("CreatedRoute", new { id = CreatedEmployee.EmpId }, CreatedEmployee);
        }
        [HttpGet("{id}", Name = "CreatedRoute")]
        public IActionResult Read(int id)
        {
            return entryRepository.Contains(id) ? (IActionResult)Ok(entryRepository.Find(id)) : NotFound();
        }
        [HttpGet]
        public IActionResult List()
        {
            return Ok(entryRepository.List());
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id,[FromBody]EmployeeEntry employee)
        {
            return entryRepository.Contains(id) ? (IActionResult)Ok(entryRepository.Update(id, employee)) : NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if(! entryRepository.Contains(id))
            {
                return NotFound();
            }
            entryRepository.Delete(id);
            return NoContent();
        }
       
    }
}
