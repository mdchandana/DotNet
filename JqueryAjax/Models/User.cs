using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JqueryAjax.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }


        public List<User> GetAllUsers()
        {
            return new List<User>()
            {
                new User(){UserName="sidath"},
                new User(){UserName="chandana"},
                new User(){UserName="yasiru"}
            };
        }

    }
}
