using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JqueryAjax.Models
{
    public class CustomEmpRankingValidator : ValidationAttribute
    {
        
        public List<EmpRanking> EmpRankings { get; set; }

        //Default Generated method
        //protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        //{
        //    return base.IsValid(value, validationContext);
        //}


        protected override ValidationResult IsValid(object rank, ValidationContext validationContext)
        {


            ///we can convert object we are recieving to int
            //int rankfromContext = (int)rank;  


            EmpRanking empRankingObj = new EmpRanking();
            EmpRankings = empRankingObj.GetAllEmpRankings();

            

            if (EmpRankings.Contains(rank))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Please select a valid Emp Rank. Eg : 1.1,2.1,3.1,4.1,5.1");
            }
        }
    }
}
