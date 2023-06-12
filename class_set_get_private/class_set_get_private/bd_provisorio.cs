using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_set_get_private
{
    internal class bd_provisorio
    {
        
        
            private String nome;
            private String rg;
            private int idade;

            public bd_provisorio() { }

            public bd_provisorio(String nome, String rg, int idade)
            {
                this.nome = nome;
                this.rg = rg;
                this.idade = idade;
            }

            public void setNome(String nome)
            {
                this.nome = nome;
            }

            public String getNome()
            {
                return this.nome;
            }

            public void setRg(String rg)
            {
                this.rg = rg;
            }

            public String getRg()
            {
                return this.rg;
            }

            public void setIdade(int idade)
            {
                this.idade = idade;
            }

            public int getIdade()
            {
                return this.idade;
            }
        }
    }

