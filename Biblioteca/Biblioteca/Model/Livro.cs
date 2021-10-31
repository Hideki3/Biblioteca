using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Model
{
    [Table("livro")] // mapeamento de Tabelas oriundas de herança da classe Exemplar no BD
    class Livro : Exemplar
    {
        private int edicao;
        private int qtdPag;

        [Column("edicao")] // mapeamento de colunas no BD
        public int Edicao
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

        public Livro (String nome, String area, int codRegistro, int codTipoExemplar, int edicao, int qtdPag) : base (nome, area, codRegistro, codTipoExemplar)
        {
            this.Edicao = edicao;
            this.QtdPag = qtdPag;
        }

    }
}
