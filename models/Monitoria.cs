using System.ComponentModel.DataAnnotations;
namespace Frontend.Pages
{
    public partial class Monitoria
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Name { get; set; }
        [Required(ErrorMessage = "La facultad es requerida")]
        [StringLength(80)]
        public string faculty { get; set; }
        [Required(ErrorMessage = "El día es requerido")]
        public string day { get; set; }
        [Required(ErrorMessage = "La hora de inicio es requerida")]
        public string init { get; set; }
        [Required(ErrorMessage = "La hora de finalización requerida")]
        public string end { get; set; }
        [Required(ErrorMessage = "El numero de salón o link de la sala son requeridos")]
        public string livingRoom { get; set; }
        [Required(ErrorMessage = "La disponibilidad de cupos es requerida")]
        public int availableQuotas { get; set; }
        public int initialQuotas { get; set; }
        public string description { get; set; }

        public string[] students { get; set; }
        public string monitor { get; set; }
    }
}