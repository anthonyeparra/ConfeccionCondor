using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConfeccionCondor.Models.ViewModels
{
    public class ListEmployeesViewModel
    {
        public int Id { get; set; }
        
        public string documentType { get; set; }
        public string Documents { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime dateBirth { get; set; }
        public string Area { get; set; }

    }
}