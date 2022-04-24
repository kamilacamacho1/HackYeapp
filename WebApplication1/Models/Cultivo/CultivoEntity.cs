using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Cultivo
{
    public class CultivoEntity
    {
       
        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
