using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.ViewModels
{
    public static class LeaveTempListExtensions
    {
        private const string leaveTempListKey = "leaveTempList";
        public static List<EmployeeLeaveVM> GetLeaveTempListFromSession(this ISession session)
        {
            return session.GetObjectFromJson<List<EmployeeLeaveVM>>(leaveTempListKey)
                    ?? new List<EmployeeLeaveVM>();
        }

        public static void SaveLeaveTempListToSession(this ISession session,List<EmployeeLeaveVM> leaveTempList)
        {
            session.SetObjectAsJson(leaveTempListKey, leaveTempList);
        }
    }
}
