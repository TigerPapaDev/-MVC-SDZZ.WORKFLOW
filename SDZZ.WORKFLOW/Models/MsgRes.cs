using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace SDZZ.WORKFLOW.Models
{
    public class MsgRes
    {
        public int msgId { get; set; }
        [Required]
        public string msgResUrl { get; set; }
    }
    public class MsgResDBContext : DbContext
    {
        public DbSet<MsgRes> megReses { get; set; }
    }
}