﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SiteEmprego.Models
{
    [Table("tbl_usuario")]
    public class Usuario
    {
        [Key]
        public long IdUsuario { get; set; }
        [Required(ErrorMessage = "Campo nome é obrigatório!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo email é obrigatório!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo password é obrigatório!")]
        public string Password { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public DateTime CriadoEm { get; set; }
        public bool UsuarioAtivo { get; set; } = true;
        public LinkedList<Vaga> Vagas { get; set; }
        public LinkedList<Candidatura> Candidaturas { get; set; }

    }
}
