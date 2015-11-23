using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace SDZZ.WORKFLOW.Models
{
    public class Msg
    {
        public int id { get; set; }
        [Required]
        public string title { get; set; }
        public string contents { get; set; }

    }
    public class MsgDBContext : DbContext
    {
        public DbSet<Msg> msgs { get; set; }
    }

}