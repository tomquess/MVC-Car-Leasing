using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_Project.Models
{
    public class Lending
    {
        [Key]
        public int Id { get; set; }

        // Foreign keys 
        [Display(Name = "Numer id auta")]
        public int CarId { get; set; }

        [ForeignKey("Id")]
        public virtual Car Cars { get; set; }

        // Foreign key 
        [Display(Name = "Numer id klienta")]
        public int ClientId { get; set; }

        [ForeignKey("Id")]
        public virtual Client Clients { get; set; }

        [Display(Name = "Data wypozyczenia")]
        [DisplayFormat(DataFormatString = "{0: yyyy-MMMM-dddd}", ApplyFormatInEditMode = true)]

        public DateTime DataWypozyczenia { get; set; }

        [Display(Name = "Data konca wynajmu")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: yyyy-MMMM-dddd}")]
        public DateTime DataKoncaWynajmu { get; set; }

        [Required(ErrorMessage = "Cena umowna")]
        public string Cena { get; set; }

    }
}