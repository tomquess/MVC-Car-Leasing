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
        public string NrRejestracji { get; set; }
        public string Model { get; set; }
        public string RokProdukcji { get; set; }
        public string StanGotowosci { get; set; }
    }
}
