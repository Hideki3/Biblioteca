using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Context;
using Biblioteca.Dao;
using Biblioteca.Model;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        /* Objeto responsável pelo contexto da interação com os dados do banco de dados */
        AppDBContext context = new AppDBContext("localhost", "loja", "postgres", "unifcv");
        public Form1()
        {
            InitializeComponent();
        }
        // botão de listagem de exemplares
        private void button1_Click(object sender, EventArgs e)
        {
            /* Componente gráfico para caixas de diálogo */
            MessageBox.Show("Listagem de Exemplares", "título", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ExemplarDao exemplarDao = new ExemplarDao(context);
            List<Exemplar> exemplares = exemplarDao.GetAll();

            /* iteração sobre a lista de exemplares recuperados */
            foreach (Exemplar exemplar in exemplares)
            {
                MessageBox.Show(
                    exemplar.ToString(),         /* mensagem a ser exibida */
                    "Exemplares",                 /* título da caixa de dialogo */
                    MessageBoxButtons.OK,       /* botoes */
                    MessageBoxIcon.Information  /* ícone */
                );
            }
        }
        // botão para adicionar exemplares
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adicionar", "título", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Exemplar exemp = new Exemplar();
            exemp.Nome = "teste";
            exemp.Area = "nenhuma área";
            
            ExemplarDao exemplarDao = new ExemplarDao(context);
            Exemplar exemplar = exemplarDao.Save(exemp);

            MessageBox.Show(
                    exemplar.ToString(),         /* mensagem a ser exibida */
                    "Exemplar adicionado",       /* título da caixa de dialogo */
                    MessageBoxButtons.OK,       /* botoes */
                    MessageBoxIcon.Information  /* ícone */
                );
        }
        // botão para remover exemplar
        private void button3_Click(object sender, EventArgs e)
        {
            ExemplarDao exemplarDao = new ExemplarDao(context);

            /* Get exemplar com id 4 */
            Exemplar exemplar = exemplarDao.GetById(4);

            if (exemplar == null)
            {
                MessageBox.Show(
                    " Exemplar não existe. ", "Exemplar adicionado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                exemplarDao.Remove(exemplar); /* Remoção do exemplar */
            }
        }
    }
}
