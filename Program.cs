﻿using SupermarketEF.Data;
using SupermarketEF.Models;

namespace SupermarketEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using SupermarketContext context = new SupermarketContext();
            //Se crea el objeto oilCategory de tipo Category
            Category oilCategory = new Category
            {
                Name = "Oil",
                Description = "Oil Category"
            };

            // Se agrega el objeto creado al contexto de la BD
            // Usando la propiedad Categories del contexto
            context.Categories.Add(oilCategory);

            // Se crea el objeto grainsCategory de tipo Category
            Category grainsCategory = new Category()
            {
                Name = "Grains",
                Description = "Grains Category"
            };

            /* Se agrega el objeto creado al contexto de la BD 
            context.Add(grainsCategory);

            // Se graban los cambios realizados al contexto
            context.SaveChanges(); */
            // Recupera la cateogira cuyo Name sea Grains
            var grainCategory = context.Categories
                .Where(c => c.Name == "Grains")
                .FirstOrDefault();
            if (grainCategory is Category)
            {
                grainCategory.Description = "New description applied";
                context.Remove(grainCategory);
            }
            context.SaveChanges();

            var categories = context.Categories.OrderBy(p => p.Name);
            foreach (var category in categories)
            {
                Console.WriteLine($"{category.Name} | {category.Description}");
            }
        }
    }
}
