using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Almacen
{
    class Categoria
    {
        public int id_categoria { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre no debe tener mas de 50 caracteres, ni menos de 3 caracteres")]
        public string nombre { get; set; }
        [StringLength(256)]
        public string descripcion { get; set; }
        public bool condicion { get; set; }
    }
}
