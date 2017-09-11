using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SiteEmprego.Models
{
    [Table("tbl_vaga")]
    public class Vaga
    {
        [Key]
        public long IdVaga { get; set; }
        [Required(ErrorMessage = "Título da vaga é um campo obrigatório!")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Descrição para a vaga é um campo obrigatório!")]
        public string Descricao { get; set; }
        public float Salario { get; set; }
        [Required(ErrorMessage = "Cidade da vaga é um campo obrigatório!")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Estado da vaga é um campo obrigatório!")]
        public string Estado { get; set; }
        public bool VagaAtiva { get; set; } = true;
        public DateTime CriadoEm { get; set; }
        public Usuario Usuario { get; set; }
        public LinkedList<Candidatura> Candidaturas { get; set; }

    }
}
