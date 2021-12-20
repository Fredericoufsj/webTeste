using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webTeste.Models
{
    public class Voo
    {
        [Key]
        public int Id_Voo { get; set; }
        [Required]
        public DateTime Data_Partida { get; set; }
        [Required]       
        public DateTime Data_Retorno { get; set; }
        [Required]
        public string Destino { get; set; }
        [ForeignKey("ClienteList")]
        public int Id_cliente { get; set; }
        public virtual Cliente ClienteList { get; set; }
    }
}
