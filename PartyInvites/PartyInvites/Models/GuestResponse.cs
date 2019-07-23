using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please enter your name (Lütfen adınızı giriniz)")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter your email (Lütfen mail adresi giriniz)")]
        [RegularExpression(".+\\@.+\\..+")]//regular expression ekledik
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your Phone number (Lütfen telefon no giriniz)")]
        public string  Phone { get; set; }
        [Required(ErrorMessage = "Please specify whether you will attend (Lütfen Katilip katilmayacagınızı belirtiniz)")]
        public bool? WillAttend { get; set; }

    }

}
