using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SiteEmprego.Models
{
   public class Curriculo {
        public long CurriculoId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public float Salario { get; set; }
        public int QdtEnviados { get; set; } = 0;
        public DateTime CriadoEm { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual LinkedList<Candidatura> Candidaturas { get; set; }
    }
}
