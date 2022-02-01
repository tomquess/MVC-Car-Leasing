using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_Project.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Numer Rejestracji")]
        [Required(ErrorMessage = "Podaj numer rejestracji auta")]
       // [StringLength(3, MinimumLength = 2, ErrorMessage = "Kod kraju musi mieć od 2 do 3 znaków")]
        public string NrRejestracji { get; set; }

        [Required(ErrorMessage = "Podaj model auta")]
        public string Model { get; set; }

        [Display(Name = "Rok Produkcji")]
        [DisplayFormat(DataFormatString = "{0: yyyy}", ApplyFormatInEditMode = true)]
        public DateTime RokProdukcji { get; set; }

        [Display(Name = "Stan Gotowości")]
        public string StanGotowosci { get; set; }

    }
}