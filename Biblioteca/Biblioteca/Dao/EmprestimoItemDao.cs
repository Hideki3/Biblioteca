using System;
using System.Collections.Generic;
using System.Text;
using Biblioteca.Context;

namespace Biblioteca.Dao
{
    class EmprestimoItemDao
    {
        private readonly AppDBContext context;
        ExemplarDao exemplarDao;

        public EmprestimoItemDao(AppDBContext context)
        {
            this.context = context;
            exemplarDao = new ExemplarDao(context);
        }
        public List<EmprestimoItem> GetEmprestimoItemsByEmprestimo(int codEmprestimo)
        {
            List<EmprestimoItem> emprestimoItems = context.emprestimoItem.where(emit => emit.CodEmprestimo == codEmprestimo).ToList();

            foreach (EmprestimoItem emprestimoItem in emprestimoItems)
            {
                emprestimoItem.Exemplar = exemplarDao.GetById(emprestimoItem.CodExemplar);
            }

            return emprestimoItems;
        }
    }
}
