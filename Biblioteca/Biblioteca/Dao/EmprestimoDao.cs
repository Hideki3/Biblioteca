using Biblioteca.Context;
using Biblioteca.Model;
using System.Collections.Generic;
using System.Linq;


namespace Biblioteca.Dao
{
    class EmprestimoDao
    {
        private readonly AppDBContext context;
        PessoaDao pessoaDao;
        EmprestimoItemDao emprestimoItemDao;

        public EmprestimoDao (AppDBContext context)
        {
            this.context = context;
            pessoaDao = new PessoaDao(context);
            emprestimoItemDao = new EmprestimoItemDao(context);
        }
        public List<Emprestimo> GetAll()
        {
            List<Emprestimo> emprestimos = context.emprestimo.Tolist();

            foreach (Emprestimo emprestimo in emprestimos)
            {
                emprestimo.Pessoa = pessoaDao.GetById(emprestimo.CodPessoa);
                emprestimo.EmprestimoItens = emprestimoItemDao.getEmprestimoItensByEmprestimo(emprestimo.CodEmprestimo);
            }
            return emprestimos;
        }
        public Emprestimo Save(Emprestimo emprestimo)
        {
            emprestimo.CodEmprestimo = this.Sequencia();
            context.emprestimo.Add(emprestimo);
            context.SaveChanges();

            return this.GetById(emprestimo.CodEmprestimo);
        }
        public Emprestimo Updata(Emprestimo emprestimo)
        {
            context.emprestimo.Update(emprestimo);
            context.SaveChanges();

            return this.GetById(emprestimo.CodEmprestimo);
        }
        public bool Remove(Emprestimo emprestimo)
        {
            context.emprestimo.Remove(emprestimo);
            context.SaveChanges();

            return true;
        }
        //Recupera um empréstimo específico
        public Emprestimo GetById(int codEmprestimo)
        {
            var emprestimo = context.emprestimo.Where(empr => empr.CodEmprestimo == codEmprestimo).FirstOrDefault();
            return emprestimo;
        }
        private int Sequencia()
        {
            int seq = context.emprestimo.Max(empr => empr.CodEmprestimo);

            if (seq == 0)
            {
                return 1;
            }

            return seq += 1;
        }

    }
}
