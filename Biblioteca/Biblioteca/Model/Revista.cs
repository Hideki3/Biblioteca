using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Model
{
    class Revista : Exemplar
    {
        private String editora;

        [Column("editora")] // mapeamento de colunas no BD
        public String Editora
        {
            get
            {
                return this.editora;
            }
            set
            {
                this.editora = value;
            }
        }
        // Sobrescrita do método ToString() para o objeto Produto 
        public override string ToString()
        {
            return this.Editora;
        }
    }
}
