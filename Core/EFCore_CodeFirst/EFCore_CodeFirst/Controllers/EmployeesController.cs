using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EFCore_CodeFirst.Models;
using EFCore_CodeFirst.Repositories;

namespace EFCore_CodeFirst.Controllers
{
    public class EmployeesController : Controller
    {
        //object for the context
        private readonly EFCoreCodeContext _context;

        //object for repository
        private readonly IGenericRepository<Employee> _repository;
        public EmployeesController(IGenericRepository<Employee> repository,EFCoreCodeContext context)
        {
            _repository = repository;
            _context = context;
        }

        // GET: Employees
        public async Task<IActionResult> Index()
        {
            //var eFCoreCodeContext = _context.Employees.Include(e => e.Department);
            //return View(await eFCoreCodeContext.ToListAsync());

            //with generic repository
            var employees = from emp in await _repository.GetAllAsync() // left side data source
                            join dept in _context.Departments.ToList()  // right side data source
                            on emp.DepartmentId equals dept.DepartmentId //inner join
                            into EmployeeDepartmentgroup //linq group
                            from departments in EmployeeDepartmentgroup.DefaultIfEmpty() //left outer join
                            select new Employee
                            {
                                EmployeeId = emp.EmployeeId,
                                DepartmentId = emp.DepartmentId,
                                EName = emp.EName,
                                Email = emp.Email,
                                Position = emp.Position,
                                Department = departments,
                            };
            return View(employees);
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var employee = await _context.Employees
            //    .Include(e => e.Department)
            //    .FirstOrDefaultAsync(m => m.EmployeeId == id);

            //with generic repository
            var employee = await _repository.GetByIdAsync(id);

            if (employee == null)
            {
                return NotFound();
            }
            employee.Department = await _context.Departments.FindAsync(employee.DepartmentId);

            return View(employee);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "DepartmentId", "DName");
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeId,EName,Email,Position,DepartmentId")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(employee);
                //await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));

                await _repository.InsertAsync(employee);

                await _repository.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "DepartmentId", "DName", employee.DepartmentId);
            return View(employee);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var employee = await _context.Employees.FindAsync(id);

            var employee = await _repository.GetByIdAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "DepartmentId", "DName", employee.DepartmentId);
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeId,EName,Email,Position,DepartmentId")] Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //_context.Update(employee);
                    //await _context.SaveChangesAsync();
                    await _repository.UpdateAsync(employee);
                    await _repository.SaveAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    //if (!EmployeeExists(employee.EmployeeId))
                    //{
                    //    return NotFound();
                    //}
                    //else
                    //{
                    //    throw;
                    //}

                    var emp = await _repository.GetByIdAsync(employee.EmployeeId);
                    if(emp == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "DepartmentId", "DName", employee.DepartmentId);
            return View(employee);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var employee = await _context.Employees
            //    .Include(e => e.Department)
            //    .FirstOrDefaultAsync(m => m.EmployeeId == id);

            var employee = await _repository.GetByIdAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            employee.Department = await _context.Departments.FindAsync(employee.DepartmentId);

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //var employee = await _context.Employees.FindAsync(id);

            var employee = _repository.GetByIdAsync(id);
            if (employee != null)
            {
                //_context.Employees.Remove(employee);
                await _repository.DeleteAsync(id);
                await _repository.SaveAsync();
            }

            ////await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.EmployeeId == id);
        }
    }
}
