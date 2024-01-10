using Microsoft.EntityFrameworkCore;

namespace WebAPI_Tutorial_3.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
    }
}
