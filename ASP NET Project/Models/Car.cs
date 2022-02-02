using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_Project.Models
{
    public class Car
    {
        [Key]
        //poprawcie żeby działało
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        [Display(Name = "Numer Rejestracji")]
        [Required(ErrorMessage = "Podaj numer rejestracji auta")]
        [StringLength(9, MinimumLength = 7, ErrorMessage = "Numer rejestracji ma od 7 do 9 znaków")]

        // [StringLength(3, MinimumLength = 2, ErrorMessage = "Kod kraju musi mieć od 2 do 3 znaków")]
        public string NrRejestracji { get; set; }

        [Required(ErrorMessage = "Podaj model auta")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Nazwa modelu samochodu może mieć od 5 do ")]
        public string Model { get; set; }

        [Display(Name = "Rok Produkcji")]
        //[DisplayFormat(DataFormatString = "{0: yyyy}", ApplyFormatInEditMode = true)]
        [StringLength(4, MinimumLength = 4, ErrorMessage ="Rok musi się składać z 4 cyfr")]
        public int RokProdukcji { get; set; }

        [Display(Name = "Stan Techniczny")]
        public string StanGotowosci { get; set; }

    }
}