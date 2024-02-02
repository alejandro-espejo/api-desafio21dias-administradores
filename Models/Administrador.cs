using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Xml;

namespace api_desafio21dias.Models
{
    [Table("materiais")]
    public partial class Administrador
    {
        #region Propriedades
        [Key]
        [Column("id")]
        public int Id { get; set; }
    
        [Column("nome", TypeName = "varchar")]
        [Required]
        [MaxLength(150)]
        public string Nome { get; set; }

        [Column("email", TypeName = "varchar")]
        [Required]
        [MaxLength(150)]
        public string Email { get; set; }

        [Column("senha", TypeName = "varchar")]
        [Required]
        [MaxLength(10)]
        public string Senha { get; set; }

        #endregion
    }
}
