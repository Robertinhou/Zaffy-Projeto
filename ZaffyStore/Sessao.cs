using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaffyStore
{
   
    public class Sessao
    {
        public string nome;
        public string email;
        public string senha;

        private string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string Senha
        {
            get { return senha; }
            set { senha = value; }
        }


        public List<Usuarios> listaLogados = new List<Usuarios>();
            







    }
    
}
