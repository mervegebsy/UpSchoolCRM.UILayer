using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UpSchoolCRM.UILayer.Models
{
    public class UserSignUpModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen adını giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyadını giriniz")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen mailinizi giriniz")]
        [EmailAddress(ErrorMessage ="Lütfen geçerli bir mail adresi giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen telefonunuzu giriniz")]
        public string Phonenumber { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor tekrar deneyiniz")]
        public string ConfirmPassword { get; set; }

    }
}
