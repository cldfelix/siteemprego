using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SiteEmprego.Models
{
    public class Candidatura
    {
        [Key]
        public long Idcandidatura { get; set; }
        public DateTime CriadoEm { get; set; } = DateTime.Now;
        public bool CandidaturaAtiva { get; set;} = true;
        [Required(ErrorMessage = "Id da vaga é obrigatória!")]
        public virtual Vaga Vaga { get; set; }
        [Required(ErrorMessage = "Id do usuário é obrigatório!")]
        public virtual Usuario Usuario { get; set; }
        [Required(ErrorMessage = "Id do currículo é obrigatório!")]
        public virtual Curriculo Curriculo { get; set; }
    }
}