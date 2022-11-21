using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpSchoolCRM.UILayer.Models
{
    public class CustomIdentityValidator: IdentityErrorDescriber
    {
        //mevcutta olan yapının kurallarını değişirmek ve öyle kullanmak istiyorum override tanımı
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = $"Şifre en az { length} karakter olmalıdır"
            };
            
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = $"Şifrenizde en az  1 tane küçük karakter olmalıdır"
            };

        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PassWordRequiresUpper",
                Description = "Şifrenizde en az 1 tane büyük karakter olmalıdır"
            };
        }
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresDigit",
                Description = "Şifrenizde en az 1 tane sayı girişi yapın"
            };
           
        }
        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError()
            {
                Code = "DuplicateEmail",
                Description = $"İlgili mail adresi: {email} zaten sistemde mevcut, Lütfen farklı bir mail adresi giriniz"
            };
        }

        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError()
            {
                Code = "DuplicateEmail",
                Description = $"İlgili kullanıcı adı: {userName} zaten sistemde mevcut, lütfen farklı bir kullanıcı adı deneyiniz"
            }; 
        }

    }
}