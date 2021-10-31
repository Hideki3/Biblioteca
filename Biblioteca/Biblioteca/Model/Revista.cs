using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Model
{
    [Table("revista")] // mapeamento de Tabelas oriundas de herança da classe Exemplar no BD
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
        public Revista (String nome, String area, int codRegistro, int codTipoExemplar, String editora) : base(nome, area, codRegistro, codTipoExemplar)
        {
            this.Editora = editora;
        }
    }
}
