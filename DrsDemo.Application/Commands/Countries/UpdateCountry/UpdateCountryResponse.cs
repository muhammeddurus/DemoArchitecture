using DrsDemo.Application.Common.HelperModels;

namespace DrsDemo.Application.Commands.Countries.UpdateCountry
{
    public class UpdateCountryResponse : IStatuResponse
    {
        public int Code { get; set; }
        public string Description { get; set; }
    }
}
