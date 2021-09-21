using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaChocolate.Models
{
    public class Chocolate
    {
        public Guid Id { get; set; }

        [Required]
        public string Marca { get; set; }

        [Required]
        public string Sabor { get; set; }

        [Required]
        public  int Quantidade { get; set; }

        
        public string LinkImagem { get; set; }

        public Chocolate()
        {
            Id = Guid.NewGuid();
        }
    }
}
