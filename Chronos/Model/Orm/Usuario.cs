using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chronos.Model.Orm
{
    public class Usuario : Model.Orm.Core
    {
        
        /**
         * Método construtor da classe.
         * É executada quando a classe é instanciada.
         * @since       13/06/2012
         * @version     1.0
         */
        public Usuario()
        {
            this.tableName = "usuario";
            this.primaryKey = "id";
        }

        /**
         * Retorna o campo: nome
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       13/06/2012
         * @return      string
         */
        public string getNome()
        {
            return this.getData("nome","");
        }

        /**
         * Seta o campo: nome
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       13/06/2012
         * @param       string nome
         * @return      Usuario
         */
        public Usuario setNome(string nome)
        {
            this.setData("nome", nome);
            return this;
        }

        /**
         * Retorna o campo: sobrenome
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       13/06/2012
         * @return      string
         */
        public string getSobrenome()
        {
            return this.getData("sobrenome", "");
        }

        /**
         * Seta o campo: sobrenome
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       13/06/2012
         * @param       string sobrenome
         * @return      Usuario
         */
        public Usuario setSobrenome(string sobrenome)
        {
            this.setData("sobrenome", sobrenome);
            return this;
        }

        /**
         * Retorna o campo: email
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       13/06/2012
         * @return      string
         */
        public string getEmail()
        {
            return this.getData("email","");
        }

        /**
         * Seta o campo:email
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       13/06/2012
         * @param       string email
         * @return      Usuario
         */
        public Usuario setEmail(string email)
        {
            this.setData("email", email);
            return this;
        }

        /**
         * Retorna o campo: status
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       13/06/2012
         * @return      string
         */
        public string getStatus()
        {
            return this.getData("status", "");
        }

        /**
         * Seta o campo:
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       13/06/2012
         * @param       string status
         * @return      Usuario
         */
        public Usuario setStatus(string status)
        {
            this.setData("status", status);
            return this;
        }

        /**
         * Retorna o campo: senha
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       13/06/2012
         * @return      string
         */
        public string getSenha()
        {
            return this.getData("senha", "");
        }

        /**
         * Seta o campo: senha
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       13/06/2012
         * @param       string senha
         * @return      Usuario
         */
        public Usuario setSenha(string senha)
        {
            this.setData("senha", senha);
            return this;
        }

        

    }
}