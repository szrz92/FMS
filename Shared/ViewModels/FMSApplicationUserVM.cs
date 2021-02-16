using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.ViewModels
{
    public class FMSApplicationUserVM
    {
        [Required(ErrorMessage = "Please enter username")]
        public string UserName { get { return Email; } }
        [Required(ErrorMessage = "Please enter email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email format not valid")]
        [EmailAddress (ErrorMessage = "Email format not valid")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$", ErrorMessage = "Password must be between 8 and 15 characters and contain one uppercase letter, one lowercase letter, one digit and one special character.")]
        public string Password { get; set; }
        [Required (ErrorMessage = "Please confirm password")]
        [Compare ("Password", ErrorMessage = "Password and Confirm Password must match")]
        public string ConfirmPassword { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required (ErrorMessage = "Please select user")]
        public string Id { get; set; }
        [Required]
        public List<string> Roles { get; set; }
        [Required]
        public string Department { get; set; }
        [Required(ErrorMessage = "User must have a role")]
        public string UserRoles
        {

            get
            {
                if (Roles == null)
                {
                    return "";
                }
                if (Roles.Count() > 0)
                {
                    string r = "";
                    foreach (var role in Roles)
                    {
                        if (role == Roles.LastOrDefault())
                        {
                            r += role;
                        }
                        else
                        {
                            r += role + ",";
                        }
                    }
                    return r;
                }
                else
                {
                    return "";
                }

            }
        }
        public string UserRoleNames
        {

            get
            {
                if (Roles == null)
                {
                    return "";
                }
                if (Roles.Count() > 0)
                {
                    string r = "";
                    foreach (var role in Roles)
                    {
                        if (role == Roles.LastOrDefault())
                        {
                            r += Enums.Roles.GetRoleNameById(role);
                        }
                        else
                        {
                            r += Enums.Roles.GetRoleNameById(role) + ",";
                        }
                    }
                    return r;
                }
                else
                {
                    return "";
                }

            }
        }
    }
}
