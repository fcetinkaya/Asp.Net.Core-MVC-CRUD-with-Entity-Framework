using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreMVC_CRUD.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [DisplayName("Full Name")]
        [Required(ErrorMessage ="This field is required.")]
        public string FullName { get; set; }
        [DisplayName("Emp. Name")]
        public string EmpCode { get; set; }

        public string Position { get; set; }
        [DisplayName("Office Location")]
        public string OfficeLocation { get; set; }


    }
}
