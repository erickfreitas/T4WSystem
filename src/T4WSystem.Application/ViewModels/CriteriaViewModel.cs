using System.ComponentModel.DataAnnotations;

namespace T4WSystem.Application.ViewModels
{
    public class CriteriaViewModel
    {
        [Required(ErrorMessage = "Informe o Destino")]
        public int DestinationId { get; set; }

        [Required(ErrorMessage = "Informe o Número de noites")]
        public int NumNights { get; set; }

        [Required(ErrorMessage = "Informe a Data de Checkin")]
        public string CheckinDate { get; set; }
        public string MainPaxCountryCodeNationality { get; set; }

        [Required(ErrorMessage = "Informe o número de adultos")]
        public int NumAdults { get; set; }
        public int[] ChildAges { get; set; }

        [Required(ErrorMessage = "Informe a quantidade de quartos")]
        public int Quantity { get; set; }

        public CriteriaViewModel()
        {
            MainPaxCountryCodeNationality = "BR";
        }
    }
}
