using Microsoft.EntityFrameworkCore;

namespace AS_CRUDelicious.Models
{
    
    //the MyContext class represents a session with our MySQL
    //database allowing us to query for or save data
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }

        //MAKE SURE TO ADD YOUR MODELS HERE
        //<Dish> is the model, while Dishes is the Table
        public DbSet<Dish> Dishes {get;set;}

    }

}