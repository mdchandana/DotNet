
using IrrigationOldDbModelProject.IrrigationOldDbModel;
using IrrigationWebSystem.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IrrigationOldDbModelProject
{


    class Program
    {
        static void Main(string[] args)
        {
            var newContext = new AppDbContext();
            var oldContext = new EIrrigationOldDbContext();

            

            
            try
            {

                //Saving employeePositions-----------------------------------------------                

                foreach (var empPosition in oldContext.EmployeePositions)
                {
                    IrrigationWebSystem.ApplicationCore.DomainEntities.EmployeePosition positionObj = new IrrigationWebSystem.ApplicationCore.DomainEntities.EmployeePosition();
                    positionObj.Position = empPosition.EmppPosition;
                    positionObj.PositionCode = empPosition.EmppPositionCode;

                    newContext.EmployeePositions.Add(positionObj);

                }
                newContext.SaveChanges();
                Console.WriteLine("Employees positions saved..");
                //-----------------------------------------------------------------------







                //Saving employee -------------------------------------------------------                

                foreach (var empOld in oldContext.Employees)
                {
                    IrrigationWebSystem.ApplicationCore.DomainEntities.Employee newEmployeeObj = new IrrigationWebSystem.ApplicationCore.DomainEntities.Employee();

                    newEmployeeObj.Nic = empOld.EmpNic;
                    newEmployeeObj.EmpNumber = empOld.EmpNumber;
                    newEmployeeObj.PersonalFileNumber = empOld.EmpPersonalFileNumber;
                    newEmployeeObj.NameWithInitial = empOld.EmpNameWithInitial;
                    newEmployeeObj.SurName = empOld.EmpSurName;
                    newEmployeeObj.FullName = empOld.EmpFullName;
                    newEmployeeObj.Address = empOld.EmpAddress;
                    newEmployeeObj.Gender = empOld.EmpGender;
                    newEmployeeObj.Image = empOld.EmpImage;

                    //bellow line of code doesn't work..
                    //since still not generated a Employee Id , By EF ... It is generating after calle `saveChanges()`                      

                    //newEmployeeObj.ImageName = newEmployeeObj.Id + ".jpg";   


                    newEmployeeObj.CivilStatus = empOld.EmpCivilStatus;
                    newEmployeeObj.AppointmentDate = empOld.EmpAppointmentDate;
                    newEmployeeObj.BasicSalary = empOld.EmpBasicSalary;
                    newEmployeeObj.CurrentlyWorkingStatus = empOld.EmpStatus;
                    newEmployeeObj.DateOfBirth = empOld.EmpDateOfBirth;
                    newEmployeeObj.Email = empOld.EmpEmail;
                    newEmployeeObj.AchievedClass = empOld.EmpAchievedClass;

                    //Saving Emp positionID-------------------------------------------------------------
                    //OldDb having EmpPosition.. new Db having positionId...
                    //so we have to map and save corresponding positionId to EmployeeTable
                    var positionId = (from position in newContext.EmployeePositions.ToList()
                                      where position.Position == empOld.EmpPosition
                                      select position.Id).FirstOrDefault();


                    newEmployeeObj.EmployeePositionId = positionId;
                    //----------------------------------------------------------------------------------

                    newContext.Employees.Add(newEmployeeObj);
                    newContext.SaveChanges();
                    


                    //Saving Emp Contacts----------------------------------------------------------------
                    var EmpContact = new IrrigationWebSystem.ApplicationCore.DomainEntities.EmployeeContact()
                    {
                        EmployeeId = newEmployeeObj.Id,
                        Contact = empOld.EmpContact1
                    };
                    newContext.EmployeeContacts.Add(EmpContact);
                    newContext.SaveChanges();
                }
                Console.WriteLine("Employees and Contacts saved..");




                //Saving Leave -------------------------------------------------------
                foreach (var leaveOld in oldContext.EmployeeLeaves)
                {
                    var empLeaveNew = new IrrigationWebSystem.ApplicationCore.DomainEntities.EmployeeLeave();

                    //Employee Id for leave..
                    //we have to find , mapping New Employee tbl and old EmpLeave 
                    var empIdForLeave = (from emp in newContext.Employees.ToList()
                                         where emp.EmpNumber == leaveOld.EmpNumber
                                         select emp.Id).FirstOrDefault();


                    empLeaveNew.EmployeeId = empIdForLeave;
                    empLeaveNew.LeaveDate = leaveOld.EmplLeaveDate;
                    empLeaveNew.Type = leaveOld.EmplType;
                    empLeaveNew.leaveFullOrHalfDay = leaveOld.EmplLeaveFullOrHalfDay;                   

                    newContext.EmployeeLeaves.Add(empLeaveNew);                  
                    
                }
                //-----------------------------------------------------------------------
                newContext.SaveChanges();
                Console.WriteLine("Employee leave saved");





            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message + " " + ex.StackTrace);
            }

            //-----------------------------------------------------------------------






            Console.ReadKey();
        }
    }




}
