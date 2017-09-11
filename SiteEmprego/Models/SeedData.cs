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
                        Usuario = new Usuario
                        {
                            Cidade = "sumare",
                            Estado = "pr",
                            Email = "fcadi@uol",
                            Nome = "claudinei",
                            Password = "12345",
                           
                        }
                        
                    },
                    new Vaga
                    {
                        Titulo = "vaga 1",
                        Descricao = "descricao 3",
                        Cidade = "campinas",
                        Estado = "sp",
                        Salario = 123.8f,
                        Usuario = new Usuario
                        {
                            Cidade = "sumare",
                            Estado = "pr",
                            Email = "fcadi@uol",
                            Nome = "claudinei",
                            Password = "12345",

                        }

                    },
                    new Vaga
                    {
                        Titulo = "vaga 1",
                        Descricao = "descricao 3",
                        Cidade = "campinas",
                        Estado = "sp",
                        Salario = 123.8f,
                        Usuario = new Usuario
                        {
                            Cidade = "sumare",
                            Estado = "pr",
                            Email = "fcadi@uol",
                            Nome = "claudinei",
                            Password = "12345",

                        }

                    },
                    new Vaga
                    {
                        Titulo = "vaga 1",
                        Descricao = "descricao 3",
                        Cidade = "campinas",
                        Estado = "sp",
                        Salario = 123.8f,
                        Usuario = new Usuario
                        {
                            Cidade = "sumare",
                            Estado = "pr",
                            Email = "fcadi@uol",
                            Nome = "claudinei",
                            Password = "12345",

                        }

                    }
                    );

                context.SaveChanges();
            }
        }
    }
}
