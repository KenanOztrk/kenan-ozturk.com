using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KenanOzturk.Models
{
    public class Email
    {

        public string Baslik { get; set; }
        public string Icerik { get; set; }
        [Required]
        public string AdSoyad { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        public string Mail { get; set; }

    }
}
