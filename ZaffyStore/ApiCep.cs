using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ZaffyStore
{
    public class ApiCep
    {
        public static Endereco BuscarCep(string cep)
        {
            try
            {
                string url = $"https://viacep.com.br/ws/{cep}/json/";

                using (WebClient client = new WebClient())
                {
                    string json = client.DownloadString(url);
                    Endereco endereco = JsonConvert.DeserializeObject<Endereco>(json);
                    return endereco;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao retornar as informações de CEP : {ex.Message}", "Erro - buscar cep", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }
        }
    }
}
