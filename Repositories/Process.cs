using ConfeccionCondor.Models;
using ConfeccionCondor.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConfeccionCondor.Repositories
{
    public class Process
    {
        /// <summary>
        /// Obtengo todos los empleados
        /// </summary>
        /// <returns> lista de empleados</returns>
        public static List<ListEmployeesViewModel> getEmployees()
        {
            List<ListEmployeesViewModel> list;
            using (CondorEntities db = new CondorEntities())
            {
              list = (from d in db.Employees
                            join p in db.DocumentType on d.documentTypeId equals p.id
                            select new ListEmployeesViewModel
                            {
                                Id = d.id,
                                Name = d.name,
                                LastName = d.lastName,
                                documentType = p.description,
                                Documents = d.documents,
                                dateBirth = d.dateBirth,
                                Area = d.Area
                            }).ToList();
            }
                return list;
        }
        /// <summary>
        /// Creo empleados
        /// </summary>
        /// <returns> Retorno modelo de empleados</returns>
        public static Employees createEmployees(Employees modelEmployees)
        {
            using (CondorEntities db = new CondorEntities())
            {
                db.Employees.Add(modelEmployees);
                db.SaveChanges();
            }
            return modelEmployees;
        }
        /// <summary>
        /// Obtengo empleados por id
        /// </summary>
        /// <returns> Retorno modelo de empleados</returns>
        public static Employees getEmployesBydId(int id)
        {
            using (CondorEntities db = new CondorEntities())
            {
                Employees employees = db.Employees.Find(id);
                return employees;
            }
        }
        /// <summary>
        /// Edito empleados
        /// </summary>
        /// <returns> Retorno modelo de empleados</returns>
        public static Employees editEmployees(Employees modelEmployees)
        {
            using (CondorEntities db = new CondorEntities())
            {

                var oEmployees = db.Employees.Find(modelEmployees.id);
                oEmployees.name = modelEmployees.name;
                oEmployees.lastName = modelEmployees.lastName;
                oEmployees.documentTypeId = modelEmployees.documentTypeId;
                oEmployees.DocumentType = modelEmployees.DocumentType;
                oEmployees.dateBirth = modelEmployees.dateBirth;
                oEmployees.Area = modelEmployees.Area;

                db.Entry(oEmployees).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return modelEmployees;
        }
        /// <summary>
        /// Elimino empleados por id
        /// </summary>
        /// <returns> Retorno modelo de empleados</returns>
        public static Employees deteleEmployes(int id)
        {
            using (CondorEntities db = new CondorEntities())
            {
                var oEmployees = db.Employees.Find(id);
                db.Employees.Remove(oEmployees);
                db.SaveChanges();
                return oEmployees;
            }
        }

    }
}