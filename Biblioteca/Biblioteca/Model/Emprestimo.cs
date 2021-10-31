using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Biblioteca.Model
{
    [Table("emprestimo")]
    class Emprestimo
    {
        private int codEmprestimo;
        private int codPessoa;
        private int status;
        private Pessoa pessoa;

        private List<EmprestimoItem> emprestimoItens = new List<EmprestimoItem>();

        [Key]
        [Column("codemprestimo")]
        public int CodEmprestimo
        {
            get
            {
                return this.codEmprestimo;
            }
            set
            {
                this.codEmprestimo = value;
            }
        }
        [Column("codpessoa")]
        public int CodPessoa
        {
            get
            {
                return this.codPessoa;
            }
            set
            {
                this.codPessoa = value;
            }
        }
        [Column("status")]
        public int Status
        {
            get
            {
                return this.status;
            }
            set
            {
                this.status = value;
            }
        }
        [NotMapped]
        public Pessoa Pessoa
        {
            get
            {
                return this.pessoa;
            }
            set
            {
                this.pessoa = value;
            }
        }
        [NotMapped]
        public List<EmprestimoItem> EmprestimoItems
        {
            get
            {
                return this.emprestimoItens;
            }
            set
            {
                this.emprestimoItens = value;
            }
        }
        public Emprestimo ( int codEmprestimo, int codPessoa, int status, Pessoa pessoa, List<EmprestimoItem> emprestimoItems)
        {
            this.CodEmprestimo = codEmprestimo;
            this.CodPessoa = codPessoa;
            this.Status = status;
            this.Pessoa = pessoa;
            this.EmprestimoItems = emprestimoItems;
        }
        public Emprestimo() { }
    }
}
