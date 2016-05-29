using System.ComponentModel.DataAnnotations;

namespace Shop.Web.Models
{
    public class Cover
    {
        public int CoverId { get; set; }
        [Required(ErrorMessage = "Wybierz okładkę")]
        public CoverType Type { get; set; }
    }

    public enum CoverType { BROSZURA, TWARDA, MIĘKKA, SZYTA, WKLEJANA }
}