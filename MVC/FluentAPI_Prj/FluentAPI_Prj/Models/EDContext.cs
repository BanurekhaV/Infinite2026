using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FluentAPI_Prj.Models
{
    public class EDContext : DbContext
    {
        public EDContext() : base("name=edcontext"){ }

        public DbSet<Employee> Employees { get; set; }  
        public DbSet<Department> Departments { get; set; }

        //1. default object/property names with the netity name
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Employee>().MapToStoredProcedures();
        //}

        //2. User Names to storedprocedures
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().MapToStoredProcedures(sp => sp.Insert(
                 s => s.HasName("InsertEmployee", "dbo")).Update(
                 s => s.HasName("UpdateEmployee", "dbo")).Delete(
                 s => s.HasName("DeleteEmployee", "dbo")
                     ));
        }

        //3. map to custom stored procedures with parameters
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Employee>().MapToStoredProcedures(sp => sp.Insert(
        //        s => s.HasName("AddEmployee").Parameter(pm => pm.EName,"EName").
        //        Parameter(pm => pm.Salary,"Salary")).Update(
        //        s=>s.HasName("ModifyEmployee").Parameter(pm => pm.EName,"EName").
        //        Parameter(pm => pm.Salary, "Salary")).Delete(
        //        s=>s.HasName("RemoveEmployee").Parameter(pm=> pm.Id,"Id")));
        //}

        //4. stored procedures for all models
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Types().Configure(t => t.MapToStoredProcedures());
        //}

    }
}