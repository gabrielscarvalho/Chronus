using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chronos.Model
{
    public class Data
    {

        protected Dictionary<string, string> data = new Dictionary<string,string>();

        /**
         * Retorna uma informação passaando sua chave.
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       13/06/2012
         * @param       string key A chave do campo
         * @param       string defaultValue Caso não encontre, deve retornar o que ?
         * @return      string
         */
        public string getData(string key, string defaultValue)
        {
            if (this.hasData(key))
            {
                return this.data[key];
            }
            return defaultValue;
        }

        /**
       * Retorna todos os dados recebidos.
       * @author      Gabriel Santos Carvalho
       * @version     1.0
       * @since       13/06/2012
       * @return      Dictionary<string, string>
       */
        public Dictionary<string, string> getCollectedData()
        {
            return this.data;
        }

        /**
         * Seta uma informação.
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       13/06/2012
         * @param       string key A chave do campo
         * @param       string value O valor do campo
         * @return      Data
         */
        public Data setData(string key, string value)
        {
            this.data.Add(key, value);
            return this;
        }

        /**
         * Verifica se nos dados guardados, existe a informação com o indice passado.
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       13/06/2012
         * @param       string key Qual chave buscamos ?
         * @return      bool
         */
        public bool hasData(string key)
        {
            return this.data.ContainsKey(key);
        }
    }
}