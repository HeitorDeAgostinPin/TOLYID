using Microsoft.EntityFrameworkCore;

namespace TOLYID.BANCO
{
    public partial class App : Application
    {
        public static AppDbContext DbContext { get; set; }

        public App()
        {
    

            DbContext = new AppDbContext();
            DbContext.Database.EnsureCreated();

           
        }
    }
}
