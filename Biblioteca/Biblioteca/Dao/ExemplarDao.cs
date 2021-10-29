using Biblioteca.Context;
using Biblioteca.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.Dao
{
    /* As classes Dao são responsáveis pelos CRUDs. Nessas classes também são implementadas as regras de negócio do sistema 
    
        C - create
        R - read
        U - update
        D - delete
     */
    class ExemplarDao : ControllerBase
    {
        /* readonly: modificador que permite a atribuição de valores apenas na declaração ou dentro de um construtor */
        private readonly AppDBContext context;

        /* Construtor */
        public ExemplarDao(AppDBContext context)
        {
            this.context = context;
        }

        /* Recupera todos os exemplares da base de dados */
        public List<Exemplar> GetAll()
        {
            return context.exemplar.ToList(); /* operações sobre a lista "exemplar" e não sobre as tabelas do banco +/- isso */
        }

        /* Adiciona um exemplar */
        public Exemplar Save(Exemplar exemplar)
        {
            exemplar.CodigoRegistro = this.Sequencia();

            context.exemplar.Add(exemplar);
            context.SaveChanges(); /* commit das alterações */

            /* Retorna o exemplar adicionado */
            return this.GetById(exemplar.CodigoRegistro);
        }
        /* Atualiza um exemplar */
        public Exemplar Update(Exemplar exemplar)
        {
            context.exemplar.Update(exemplar);
            context.SaveChanges(); /* commit das alterações */

            /* Retorna o exemplar atualizado */
            return this.GetById(exemplar.CodigoRegistro);
        }
        /* Remove um exemplar */
        public bool Remove(Exemplar exemplar)
        {
            context.exemplar.Remove(exemplar);
            context.SaveChanges(); /* commit das alterações */

            return true;
        }

        /* Recupera um exemplar específico */
        public Exemplar GetById(int codigoRegistro)
        {
            /* Uso do Linq para realizar a filtragem */
            var exemplar = context.exemplar.Where(exemp => exemp.CodigoRegistro == codigoRegistro).FirstOrDefault();
            return exemplar;
        }
        /* Gera chave primária */
        private int Sequencia()
        {
            int seq = context.exemplar.Max(exemp => exemp.CodigoRegistro);

            if (seq == 0)
            {
                return 1;
            }

            return seq += 1;
        }

    }
}
