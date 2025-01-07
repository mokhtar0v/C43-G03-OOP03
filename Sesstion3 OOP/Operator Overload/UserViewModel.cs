using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesstion3_OOP.Operator_Overload
{
    //viewmodel : class that represents the data that will be rendered in a view [HTML]
    class UserViewModel
    {
        public int Id { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public static explicit operator UserViewModel(User user)
        {
            string[] names = user.FullName?.Split(" ");
            return new UserViewModel()
            {
                Id = user?.Id ?? 0,
                FName = names.Length > 0 ? names[0] : string.Empty,
                LName = names.Length > 1 ? names[0] : string.Empty,
                Email = user?.Email,
                Password = user?.Password
            };
        }

    }
}
