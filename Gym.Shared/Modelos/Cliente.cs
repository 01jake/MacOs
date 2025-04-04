using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Shared.Modelos
{
   public class Cliente
    {
        public int Id { get; set; }
        [Required]
        [StringLength(8, ErrorMessage = "Nombre length can't be more than 8.")]
        public string Nombre { get; set; }
        [Required]
        [StringLength(8, ErrorMessage = "Debes de ingresar tu apellido")]
        public string Apellido { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string Telefono { get; set; }
        
       
        public bool Estado { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public int Contraseña { get; set; }




    }
}
