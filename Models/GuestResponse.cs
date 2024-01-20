using System.ComponentModel.DataAnnotations;
//Se agrega el nombre del proyecto y la carpeta modelos
namespace PartyInvites.Models{
    public class GuestResponse {
        [Required(ErrorMessage = "Porfavor ingrese el nombre")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Porfavor ingrese el correo")]
        public string? Correo { get; set; }
        [Required(ErrorMessage = "Porfavor ingrese el telefono")]
        public string? Telefono { get; set; }
        [Required(ErrorMessage = "Iras o no?")]
        public bool? WillAttend { get; set; }
    }
}