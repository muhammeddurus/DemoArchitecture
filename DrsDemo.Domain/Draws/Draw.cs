using DrsDemo.Domain.Common;
using DrsDemo.Domain.Groups;
using DrsDemo.Domain.Teams;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrsDemo.Domain.Draws
{
    public class Draw : EntityBase<Guid>
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }
        [ForeignKey("GroupId")]
        public Guid GroupId { get; set; }

        public virtual Group Group { get; set; }
        [ForeignKey("TeamId")]
        public Guid TeamId { get; set; }

        public virtual Team Team { get; set; }
    }
}
