using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Security;

namespace PlaygroundReservations.Models
{

    public class ChangePasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Текуща парола")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} трябва да е най-малко {2} символа.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Нова парола")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Потвърди паролата")]
        [Compare("NewPassword", ErrorMessage = "Новата парола и паролата за потвържение не съвпадат.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginModel
    {
        [Required]
        [Display(Name = "Ел. поща")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Парола")]
        public string Password { get; set; }

        [Display(Name = "Запомни ме?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterModel
    {
        //[Required]
        //[Display(Name = "User name")]
        //public string UserName { get; set; }

        [Display(Name="Тип потребител")]
        [Required(ErrorMessage = "Моля, изберете тип на акаунта")]
        public int UserTypeId { get; set; }
        [Display(Name = "Тип потребител")]
        public UserType UserType
        {
            get { return (UserType)UserTypeId; }
            set
            {
                UserTypeId = (int)value;
            }
        }


        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Ел. поща")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} трябва де е най-малко {2} символа.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Парола")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Потвърди парола")]
        [Compare("Password", ErrorMessage = "Паролата и потвърждението не съвпадат")]
        public string ConfirmPassword { get; set; }
    }
}
