using System;
using System.Collections.Generic;
using System.Text;
using Biblioteca.Model;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Context
{
    class AppDBContext : DbContext
    {
        private String host;
        private String dataBase;
        private String user;
        private String pass;

        public String Host {
            get { 
                return this.host;
            }
            set { 
                this.host = value; 
            } 
        }
        public String Database {
            get {
                return this.dataBase; 
            } 
            set { 
                this.dataBase = value;
            } 
        }
        public String User { 
            get {
                return this.user; 
            } 
            set { 
                this.user = value; 
            }
        }
        public String Pass {
            get { 
                return this.pass; 
            } 
            set {
                this.pass = value; 
            } 
        }

        public DbSet<Exemplar> exemplar { get; set; } // mapeamento: o nome do objeto precisa ser o mesmo nome da tabela no banco 


        // Construtor
        public AppDBContext( String host, String dataBase, String user, String pass)
        {
            this.Host = host;
            this.Database = dataBase;
            this.User = user;
            this.Pass = pass;
        }
        // Método responsável pela conexão com BD
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=" + this.Host + ";Database=" + this.Database + ";Username=" + this.User + ";Password=" + this.Pass);
    }
}
