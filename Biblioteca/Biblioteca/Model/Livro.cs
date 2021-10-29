using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Model
{
    class Livro : Exemplar
    {
        private String edicao;
        private int qtdPag;

        [Column("edicao")] // mapeamento de colunas no BD
        public String Edicao
        {
            get
            {
                return this.edicao;
            }
            set
            {
                this.edicao = value;
            }
        }
        [Column("qtdPag")]
        public int QtdPag
        {
            get
            {
                return this.qtdPag;
            }
            set
            {
                this.qtdPag = value;
            }
        }

        // Sobrescrita do método ToString() para o objeto Produto 
        public override string ToString()
        {
            return this.Edicao + ", " + this.QtdPag;
        }
    }

}
