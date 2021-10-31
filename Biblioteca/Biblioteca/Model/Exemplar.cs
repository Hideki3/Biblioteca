using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Model
{
    abstract class Exemplar
    {
        private String nome;
        private String area;
        private int codRegistro;
        private int codTipoExemplar;

        [Column("nome")] // mapeamento de colunas no BD
        [MaxLength(100)] // restrição de tamanho da String
        public String Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }
        }
        [Column("area")]
        public String Area
        {
            get
            {
                return this.area;
            }
            set
            {
                this.area = value;
            }
        }
        [Key] // Chave primária
        [Column("codregistro")] 
        public int CodRegistro
        {
            get
            {
                return this.codRegistro;
            }
            set
            {
                this.codRegistro = value;
            }
        }
        [Column("codtipoexemplar")]
        public int CodTipoExemplar
        {
            get
            {
                return this.codTipoExemplar;
            }
            set
            {
                this.codTipoExemplar = value;
            }
        }
        protected Exemplar(String nome, String area, int codRegistro, int codTipoExemplar)
        {
            this.Nome = nome;
            this.Area = area;
            this.CodRegistro = codRegistro;
            this.CodTipoExemplar = codTipoExemplar;
        }

    }
}
