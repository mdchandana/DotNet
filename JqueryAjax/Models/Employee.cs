using JqueryAjax.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JqueryAjax.Models.DomainEntities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmpNumber { get; set; }
        public string PersonalFileNumber { get; set; }
        public string Nic { get; set; }

        [Required]
        public string NameWithInitial { get; set; }

        public string SurName { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public DateTime? DateOfBirth { get; set; }

        [Required]
        public Gender Gender { get; set; }             //enums

        [Required]
        public CivilStatus CivilStatus { get; set; }   //enums

        public DateTime? AppointmentDate { get; set; }


        public ClassMnGrade ClassMnGrade { get; set; }  //enums

        [Column(TypeName = "decimal(13,2)")]
        public decimal? BasicSalary { get; set; }

        public string ContactNumber { get; set; }

        public string Email { get; set; }

        //public byte[] Image { get; set; }
        public string ImageName { get; set; }

        public CurrentlyWorkingStatus CurrentlyWorkingStatus { get; set; }   //enums

        [Required]
        public int EmployeePositionId { get; set; }
        public EmployeePosition EmployeePosition { get; set; }



        //public List<EmployeeContact> EmployeeContacts { get; set; }
        //public List<EmployeeLeave> EmployeeLeaves { get; set; }


        //public List<Employee> Employees
        //{
        //    get
        //    {
        //        
        //    }
        //}



        //public List<Employee> GetEmployees()
        //{
        //    return new List<Employee>()
        //    {
        //         new Employee(){Id=2001,Name="Sidath",Address="Kamburupitiya"},
        //         new Employee(){Id=2016,Name="Chandana",Address="Dickwella"},
        //         new Employee(){Id=2047,Name="Yasiru",Address="JaEla"}
        //    };
        //}




    }
}
