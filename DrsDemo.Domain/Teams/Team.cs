using DrsDemo.Domain.Common;
using DrsDemo.Domain.Countries;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrsDemo.Domain.Teams
{
    public class Team : EntityBase<Guid>
    {
        public Team()
        {

        }
        public Team(string name, Guid countryId)
        {
            Name = name;
            CountryId = countryId;
        }
        public string Name { get; set; }
        [ForeignKey("CountryId")]
        public Guid CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
