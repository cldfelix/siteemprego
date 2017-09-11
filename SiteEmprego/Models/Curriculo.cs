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
        public int Salario { get; set; }
        public DateTime CriadoEm { get; set; }
        public Usuario Usuario { get; set; }
        public List<Candidatura> Candidaturas { get; set; }
    }
}
