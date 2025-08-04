using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ZaffyStore
{
    public class Sessao
    {
        public string nome;
        public string email;
        public string senha;

        private string Nome {
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

        private Usuarios usuario = new Usuarios();

        


        List<Usuarios> listLogados = new List<Usuarios>();

        
        




    }
}
