
using CRUDTWO.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDTWO.Data
{
    public class Database : DbContext

    {
        public Database(DbContextOptions<Database> options) : base(options)
        {

        }
    }
   

}
