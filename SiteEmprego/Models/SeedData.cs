using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SiteEmprego.Models
{
    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.EnsureCreated();

            var u1 = new Usuario{
                 Cidade = "sumare",
                            Estado = "pr",
                            Email = "fcadi@uol",
                            Nome = "claudinei",
                            Password = "12345",

            };

            var u2 = new Usuario{
                 Cidade = "sumare",
                            Estado = "pr",
                            Email = "fcadi@uol",
                            Nome = "claudinei",
                            Password = "12345",
            };

            var u3 = new Usuario{
                 Cidade = "sumare",
                            Estado = "pr",
                            Email = "fcadi@uol",
                            Nome = "claudinei",
                            Password = "12345"
            };




            if (!context.Vagas.Any())
            {
                context.Vagas.AddRange(
                    new Vaga
                    {
                        Titulo = "vaga 1",
                        Descricao = "descricao 3",
                        Cidade = "campinas",
                        Estado = "sp",
                        Salario = 123.8f,
                        QtdCandidados = 15,
                        Usuario = u1
                    },
                    new Vaga
                    {
                        Titulo = "vaga 1",
                        Descricao = "descricao 3",
                        Cidade = "campinas",
                        Estado = "sp",
                        QtdCandidados = 29,
                        Salario = 123.8f,
                        Usuario = u2

                    },
                    new Vaga
                    {
                        Titulo = "vaga 1",
                        Descricao = "descricao 3",
                        Cidade = "campinas",
                        Estado = "sp",
                        Salario = 123.8f,
                        QtdCandidados = 34,
                        Usuario = u1
                        

                    },
                    new Vaga
                    {
                        Titulo = "vaga 1",
                        Descricao = "descricao 3",
                        Cidade = "campinas",
                        Estado = "sp",
                        QtdCandidados = 74,
                        Salario = 123.8f,
                        Usuario = u2
                   

                    }
                    );
                context.SaveChanges();
            }

            if(!context.Curriculos.Any()){
                context.Curriculos.AddRange(
                    new Curriculo{
                        Titulo = "curiculo 1",
                        Descricao = "corpo curriculo 1",
                        Cidade = "Campianss",
                        Estado = "MG",
                        Salario = 1234.6f,
                        CriadoEm = DateTime.Now,
                        Usuario = u1
                    },
                          new Curriculo{
                        Titulo = "curiculo 1",
                        Descricao = "corpo curriculo 1",
                        Cidade = "Campianss",
                        Estado = "MG",
                        Salario = 1234.6f,
                        CriadoEm = DateTime.Now,
                        Usuario = u1
                    },
                          new Curriculo{
                        Titulo = "curiculo 1",
                        Descricao = "corpo curriculo 1",
                        Cidade = "Campianss",
                        Estado = "MG",
                        Salario = 1234.6f,
                        CriadoEm = DateTime.Now,
                          Usuario = u2
                    },
                          new Curriculo{
                        Titulo = "curiculo 1",
                        Descricao = "corpo curriculo 1",
                        Cidade = "Campianss",
                        Estado = "MG",
                        Salario = 1234.6f,
                        CriadoEm = DateTime.Now,
                         Usuario = u1},

                          new Curriculo{
                        Titulo = "curiculo 1",
                        Descricao = "corpo curriculo 1",
                        Cidade = "Campianss",
                        Estado = "MG",
                        Salario = 1234.6f,
                        CriadoEm = DateTime.Now,
                          Usuario = u3
                    }
                );
                  context.SaveChanges();
            }
        }
    }
}
