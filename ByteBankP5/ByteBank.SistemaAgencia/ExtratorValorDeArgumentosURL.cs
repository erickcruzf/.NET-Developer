using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get; }

        public ExtratorValorDeArgumentosURL(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("O argumento url não pode ser nulo ou vazio.", nameof(url));
            }
            
            int indiceInterrogação = url.IndexOf("?") + 1;

            _argumentos = url.Substring(indiceInterrogação);

            URL = url;
        }
        
        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToLower();
            string argumentoEmCaixaBaixa = _argumentos.ToLower();

            string termo = nomeParametro + "="; //  moedaDestino=
            int indiceTermo = argumentoEmCaixaBaixa.IndexOf(termo);

            string resultado = _argumentos.Substring(indiceTermo + termo.Length);
            int indiceEComercial = resultado.IndexOf("&");

            if (indiceEComercial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceEComercial);
            //int indiceParametro = _argumentos.IndexOf();
        }
    }
}
