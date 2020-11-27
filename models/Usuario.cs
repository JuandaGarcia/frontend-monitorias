using System.ComponentModel.DataAnnotations;
namespace Frontend.Pages
{
    public class Usuario
    {

        public string Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(50)]

        public string name { get; set; }
        [Required(ErrorMessage = "El programa es requerido")]

        public string career { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Correo no valido")]

        public string mail { get; set; }
        [Required(ErrorMessage = "La cedula es requerido")]


        public string code { get; set; }
        [Required(ErrorMessage = "La contraseña es requerido")]

        public string password { get; set; }

        public int roll { get; set; }






    }
}