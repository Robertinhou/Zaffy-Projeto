using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaffyStore
{
    public class Endereco
    {
        private string cep;
        private string logradouro;
        private string complemento;
        private string bairro;
        private string localidade;
        private string uf;

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }
        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Localidade
        {
            get { return localidade; }
            set { localidade = value; }
        }
        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }
    }
}
