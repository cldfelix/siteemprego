using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SiteEmprego.Models
{
    [Table("tbl_candidatura")]
    public class Candidatura
    {
        [Key]
        public long Idcandidatura { get; set; }
        public Vaga Vaga { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime CriadoEm { get; set; }
        public bool CandidaturaAtiva { get; set; } = true;

    }
}
