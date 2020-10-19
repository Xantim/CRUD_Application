using System;
using System.ComponentModel.DataAnnotations;

namespace AS_CRUDelicious.Models
{
    public class Dish
    {
        [Key]
        public int DishID {get;set;}
        
        [Required]
        public string Name {get;set;}
        
        [Required]
        public string ChefName {get;set;}
        
        [Required]
        
        public int Calories {get;set;}

        [Required]
        public int Tastiness {get;set;}
        
        [Required]
        public string Description {get;set;}

        public DateTime CreatedAT {get;set;} = DateTime.Now;
        public DateTime UpdatedAT {get;set;} = DateTime.Now;
    }
}