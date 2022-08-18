using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_Product.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen isim değeri giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyisim değeri giriniz.")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adı giriniz.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen e-mail giriniz.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen parola giriniz.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen parolayı tekrar giriniz.")]
        [Compare("Password", ErrorMessage ="Lütfen şifrelerin eşleştiğinden emin olun!")]
        public string ConfirmPassword { get; set; }

    }
}
