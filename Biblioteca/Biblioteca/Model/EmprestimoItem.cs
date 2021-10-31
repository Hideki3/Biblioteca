using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Biblioteca.Model
{
    [Table("emprestimoitem")]
    class EmprestimoItem
    {
        private int codEmprestimo;
        private int codExemplar;
        private int dataRetirada;
        private int dataDevolucaoPrevista;
        private int dataDevolucaoRealizada;
        private int status;

        private Exemplar exemplar;

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
        [Key]
        [Column("codexemplar")]
        public int CodExemplar
        {
            get
            {
                return this.codExemplar;
            }
            set
            {
                this.codExemplar = value;
            }
        }
        [Column("dataretirada")]
        public int DataRetirada
        {
            get
            {
                return this.dataRetirada;
            }
            set
            {
                this.dataRetirada = value;
            }
        }
        [Column("datadevolucaoprevista")]
        public int DataDevolucaoPrevista
        {
            get
            {
                return this.dataDevolucaoPrevista;
            }
            set
            {
                this.dataDevolucaoPrevista = value;
            }
        }
        [Column("datadevolucaorealizada")]
        public int DataDevolucaoRealizada
        {
            get
            {
                return this.dataDevolucaoRealizada;
            }
            set
            {
                this.dataDevolucaoRealizada = value;
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
        public Exemplar Exemplar
        {
            get
            {
                return this.exemplar;
            }
            set
            {
                this.exemplar = value;
            }
        }
        public EmprestimoItem(Exemplar exemplar, int dataRetirada, int dataDevolucaoPrevista, int dataDevolucaoRealizada, int status)
        {
            this.Exemplar = exemplar;
            this.DataRetirada = dataRetirada;
            this.DataDevolucaoPrevista = dataDevolucaoPrevista;
            this.DataDevolucaoRealizada = dataDevolucaoRealizada;
            this.Status = status;
        }
        public EmprestimoItem() { }
    }
}
