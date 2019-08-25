using System.ComponentModel.DataAnnotations;

namespace ProjectNBAGames.ViewModels
{
    public class PageFilterViewModel
    {
        [Range(1, int.MaxValue, ErrorMessage = "Numarul paginii trebuie sa fie pozitiv.")]
        public int? Page { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Numarul de elemente din pagina trebuie sa fie mai mare ca 0.")]
        public int? PageSize { get; set; }
    }
}