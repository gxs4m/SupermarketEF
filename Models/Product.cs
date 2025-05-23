﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketEF.Models
{
    public class Product
    {
        // [Key] -> Anotación si la propiedad no se llama Id, ejemplo ProductId
        public int Id { get; set; } // Será la llave primaria 
        public string Name { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; } //Será la llave foránea
        public Category Category { get; set; } //Propiedad de navegación    

    }
}
