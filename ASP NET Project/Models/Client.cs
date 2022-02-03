using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_Project.Models
{
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Numer Dowodu")]
        [Required(ErrorMessage = "Podaj numer dowodu klienta")]
       // [StringLength(3, MinimumLength = 2, ErrorMessage = "Kod kraju musi mieć od 2 do 3 znaków")]
        public string NrDowodu { get; set; }

        [Required(ErrorMessage = "Podaj numer pesel klienta")]
        public string Pesel { get; set; }

        [Required(ErrorMessage = "Podaj imie klienta")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Podaj nazwisko klienta")]
        public string Nazwisko { get; set; }
    }
}