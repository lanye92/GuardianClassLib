using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardianClassLib.Models
{
    public class DbToLast
    {
        public void Start()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MainDbContext, Configuration>());

        }



        public void CloseInit()
        {
            Database.SetInitializer<MainDbContext>(null);
        }
    }
}
