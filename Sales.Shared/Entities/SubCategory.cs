using System.ComponentModel.DataAnnotations;

namespace Sales.Shared.Entities
{
    public class SubCategory
    {
        public int Id { get; set; }

        [Display(Name = "SubCategoria")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no piuede tener mas de {1} caractéres")]

        public string Name { get; set; } = null!;

        public Category? Category { get; set; }
        public int CategoryId { get; set; }
    }
}
