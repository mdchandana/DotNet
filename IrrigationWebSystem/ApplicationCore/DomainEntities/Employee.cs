using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IrrigationWebSystem.ApplicationCore.DomainEntities
{
    [Table("Employee")]
    public class Employee
    {       
        public int Id { get; set; }
        public string EmpNumber { get; set; }
        public string PersonalFileNumber { get; set; }
        public string Nic { get; set; }
        public string NameWithInitial { get; set; }
        public string SurName { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string CivilStatus { get; set; }
        public DateTime? AppointmentDate { get; set; }
        
        
        public string AchievedClass { get; set; }

        [Column(TypeName="decimal(18,2)")]
        public decimal? BasicSalary { get; set; }

        public string Email { get; set; }        

        public byte[] Image { get; set; }
        public string ImageName { get; set; }

        public string CurrentlyWorkingStatus { get; set; }

        public int EmployeePositionId { get; set; }
        public EmployeePosition EmployeePosition { get; set; }


        public List<EmployeeContact> GetEmployeeContacts { get; set; }
        public List<EmployeeLeave> EmployeeLeaves { get; set; }

    }
}
