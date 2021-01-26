
using IrrigationOldDbModelProject.IrrigationOldDbModel;
using IrrigationWebSystem.Data.Context;
using IrrigationWebSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IrrigationOldDbModelProject
{


    class Program
    {
        static void Main(string[] args)
        {
            //var newContext = new AppDbContext();
            //var oldContext = new EIrrigationOldDbContext();




            //try
            //{

            //    //Saving employeePositions-----------------------------------------------                

            //    foreach (var empPosition in oldContext.EmployeePositions)
            //    {
            //        IrrigationWebSystem.Models.DomainEntities.EmployeePosition positionObj = new IrrigationWebSystem.Models.DomainEntities.EmployeePosition();
            //        positionObj.Position = empPosition.EmppPosition;
            //        positionObj.PositionCode = empPosition.EmppPositionCode;

            //        newContext.EmployeePositions.Add(positionObj);

            //    }
            //    newContext.SaveChanges();
            //    Console.WriteLine("Employees positions saved..");
            //    //-----------------------------------------------------------------------







            //    //Saving employee -------------------------------------------------------                

            //    foreach (var empOld in oldContext.Employees)
            //    {
            //        IrrigationWebSystem.Models.DomainEntities.Employee newEmployeeObj = new IrrigationWebSystem.Models.DomainEntities.Employee();

            //        newEmployeeObj.Nic = empOld.EmpNic;
            //        newEmployeeObj.EmpNumber = empOld.EmpNumber;
            //        newEmployeeObj.PersonalFileNumber = empOld.EmpPersonalFileNumber;
            //        newEmployeeObj.NameWithInitial = empOld.EmpNameWithInitial;
            //        newEmployeeObj.SurName = empOld.EmpSurName;
            //        newEmployeeObj.FullName = empOld.EmpFullName;
            //        newEmployeeObj.Address = empOld.EmpAddress;


            //        if (empOld.EmpGender.Equals("පුරුෂ"))                //enums
            //            newEmployeeObj.Gender = Gender.Male;
            //        if (empOld.EmpGender.Equals("ස්ත්‍රී"))
            //            newEmployeeObj.Gender = Gender.FeMale;



            //        //        newEmployeeObj.Image = empOld.EmpImage;



            //        //bellow line of code doesn't work..
            //        //since still not generated a Employee Id , By EF ... It is generating after calle `saveChanges()`                      

            //        //newEmployeeObj.ImageName = newEmployeeObj.Id + ".jpg";   



            //        if (empOld.EmpCivilStatus.Equals("විවාහක"))                   //enums       
            //            newEmployeeObj.CivilStatus = CivilStatus.Married;
            //        if (empOld.EmpCivilStatus.Equals("අවිවාහක"))
            //            newEmployeeObj.CivilStatus = CivilStatus.UnMarried;




            //        newEmployeeObj.AppointmentDate = empOld.EmpAppointmentDate;
            //        newEmployeeObj.BasicSalary = empOld.EmpBasicSalary;

            //        newEmployeeObj.CurrentlyWorkingStatus = CurrentlyWorkingStatus.Working;    //enums

            //        newEmployeeObj.DateOfBirth = empOld.EmpDateOfBirth;
            //        newEmployeeObj.Email = empOld.EmpEmail;
            //        newEmployeeObj.ContactNumber = empOld.EmpContact1;

            //        newEmployeeObj.ClassMnGrade = ClassMnGrade.UnKnown;   //enums

            //        //Saving Emp positionID-------------------------------------------------------------
            //        //OldDb having EmpPosition.. new Db having positionId...
            //        //so we have to map and save corresponding positionId to EmployeeTable
            //        var positionId = (from position in newContext.EmployeePositions.ToList()
            //                          where position.Position == empOld.EmpPosition
            //                          select position.Id).FirstOrDefault();


            //        newEmployeeObj.EmployeePositionId = positionId;
            //        //----------------------------------------------------------------------------------

            //        newContext.Employees.Add(newEmployeeObj);
            //        newContext.SaveChanges();



            //        //        //Saving Emp Contacts----------------------------------------------------------------
            //        //        var EmpContact = new IrrigationWebSystem.Models.DomainEntities.EmployeeContact()
            //        //        {
            //        //            EmployeeId = newEmployeeObj.EmployeeId,
            //        //            Contact = empOld.EmpContact1
            //        //        };
            //        //        newContext.EmployeeContacts.Add(EmpContact);
            //        //        newContext.SaveChanges();
            //        //    }
            //        //    Console.WriteLine("Employees and Contacts saved..");




            //        ////Saving Leave -------------------------------------------------------
            //        //foreach (var leaveOld in oldContext.EmployeeLeaves)
            //        //{
            //        //    var empLeaveNew = new IrrigationWebSystem.Models.DomainEntities.EmployeeLeave();

            //        //    //Employee Id for leave..
            //        //    //we have to find , mapping New Employee tbl and old EmpLeave 
            //        //    var empIdForLeave = (from emp in newContext.Employees.ToList()
            //        //                         where emp.EmpNumber == leaveOld.EmpNumber
            //        //                         select emp.EmployeeId).FirstOrDefault();


            //        //    empLeaveNew.EmployeeId = empIdForLeave;
            //        //    empLeaveNew.LeaveDate = leaveOld.EmplLeaveDate;
            //        //    empLeaveNew.LeaveType= leaveOld.EmplType;
            //        //    empLeaveNew.HalfFullLeaveType = leaveOld.EmplLeaveFullOrHalfDay;                   

            //        //    newContext.EmployeeLeaves.Add(empLeaveNew);                  

            //        //}
            //        ////-----------------------------------------------------------------------
            //        //newContext.SaveChanges();
            //        //Console.WriteLine("Employee leave saved");                                       

            //    }
            //    Console.WriteLine("Employees are saved..");




            //    ////Saving MuruthawelaTank Level and Capacity ------------------------------

            //    foreach (var oldTankLevelAndCapacity in oldContext.WmWaterLevelCapacityMuruthawelaTanks)
            //    {
            //        IrrigationWebSystem.Models.DomainEntities.WmWaterLevelCapacityMuruthawelaTank wmWaterLevelCapacityMuruthawelaTankNew = new IrrigationWebSystem.Models.DomainEntities.WmWaterLevelCapacityMuruthawelaTank();

            //        wmWaterLevelCapacityMuruthawelaTankNew.WaterLevel = oldTankLevelAndCapacity.WlcmWaterLevel;
            //        wmWaterLevelCapacityMuruthawelaTankNew.capacity = oldTankLevelAndCapacity.WlcmCapacity.Value;
            //        newContext.Add(wmWaterLevelCapacityMuruthawelaTankNew);
            //        newContext.SaveChanges();
            //    }
            //    Console.WriteLine("waterlevel and capacity are saved..");


            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message + " " + ex.StackTrace);
            //}

            ////-----------------------------------------------------------------------




            ////Console.WriteLine("All are completed..");

            Console.ReadKey();
        }
    }




}
