using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Model
{
    class Exemplar
    {
        private String nome;
        private String area;
        private int codigoRegistro;

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
        [Column("codigoReg")] 
        public int CodigoRegistro
        {
            get
            {
                return this.codigoRegistro;
            }
            set
            {
                this.codigoRegistro = value;
            }
        }
        // Sobrescrita do método ToString() para o objeto Produto 
        public override string ToString()
        {
            return this.CodigoRegistro + ", " + this.Nome + ", " + this.Area;
        }

    }
}
