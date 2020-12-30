
using IrrigationOldDbModelProject.IrrigationOldDbModel;
using IrrigationWebSystem.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;

namespace IrrigationOldDbModelProject
{

    
    class Program
    {
        static void Main(string[] args)
        {
            var newContext = new AppDbContext();
            var oldContext = new EIrrigationOldDbContext();

            //Saving employeePositions-----------------------------------------------
            //var oldEmployees = oldContext.EmployeePositions;

            //foreach (var empPosition in oldContext.EmployeePositions)
            //{
            //    IrrigationWebSystem.ApplicationCore.DomainEntities.EmployeePosition positionObj = new IrrigationWebSystem.ApplicationCore.DomainEntities.EmployeePosition();
            //    positionObj.Position = empPosition.EmppPosition;
            //    positionObj.PositionCode = empPosition.EmppPositionCode;

            //    newContext.EmployeePositions.Add(positionObj);

            //}

            //newContext.SaveChanges();
            //-----------------------------------------------------------------------


            //Saving employeePositions-------------------------------STILL
            //var oldEmployees = oldContext.EmployeePositions;

            //foreach (var empPosition in oldContext.EmployeePositions)
            //{
            //    IrrigationWebSystem.ApplicationCore.DomainEntities.EmployeePosition positionObj = new IrrigationWebSystem.ApplicationCore.DomainEntities.EmployeePosition();
            //    positionObj.Position = empPosition.EmppPosition;
            //    positionObj.PositionCode = empPosition.EmppPositionCode;

            //    newContext.EmployeePositions.Add(positionObj);

            //}

            //newContext.SaveChanges();
            //-----------------------------------------------------------------------





            //Console.WriteLine("Hello world..." + oldContext.EmployeePositions);
            Console.ReadKey();
        }
    }




}
