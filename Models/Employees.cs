//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConfeccionCondor.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employees
    {
        public int id { get; set; }
        public int documentTypeId { get; set; }
        public string documents { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public System.DateTime dateBirth { get; set; }
        public string Area { get; set; }
        public int status { get; set; }
        public System.DateTime createAt { get; set; }
    
        public virtual DocumentType DocumentType { get; set; }
    }
}