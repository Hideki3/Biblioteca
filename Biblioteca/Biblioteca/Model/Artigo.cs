using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Model
{
    class Artigo : Exemplar
    {
        private String conferencia;

        [Column("conferencia")] //mapeamento de colunas no BD
        public String Conferencia
        {
            get
            {
                return this.conferencia;
            }
            set
            {
                this.conferencia = value;
            }
        }
        // Sobrescrita do método ToString() para o objeto Produto 
        public override string ToString()
        {
            return this.Conferencia;
        }
    }
}
