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
        [StringLength(9, MinimumLength = 9, ErrorMessage = "Numer dowodu musi zawierać 9 znaków (bez odstępów)")]
        public string NrDowodu { get; set; }

        [Required(ErrorMessage = "Podaj numer pesel klienta")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "Numer pesel musi zawierać 11 cyfr")]
        public string Pesel { get; set; }

        [Required(ErrorMessage = "Podaj imie klienta")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Podaj nazwisko klienta")]
        public string Nazwisko { get; set; }
    }
}