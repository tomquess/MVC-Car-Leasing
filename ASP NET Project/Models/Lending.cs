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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Foreign keys 
        [Required]
        [Display(Name = "Numer id auta")]
        [ForeignKey("Cars")]
        public int CarId { get; set; }

        public virtual Car Cars { get; set; }

        // Foreign key 
        [Required]
        [Display(Name = "Numer id klienta")]
        [ForeignKey("Clients")]
        public int ClientId { get; set; }

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