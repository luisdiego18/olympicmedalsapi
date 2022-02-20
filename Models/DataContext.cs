using Microsoft.EntityFrameworkCore;

namespace olympicmedalsapi.Models
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Country> Countries {get; set;}

        //Add Country
        public Country AddCountry(Country country)
        {
            this.AddCountry(country);
            this.SaveChanges();
            return country;
        }

        //Delete Country
        public void DeleteCountry(Country country)
        {
            this.Remove(country);
            this.SaveChanges();
        }

    }

    
}