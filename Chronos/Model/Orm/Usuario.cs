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
         * Retorna o campo: sexo
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       13/06/2012
         * @return      string
         */
        public string getSexo()
        {
            return this.getData("sexo","");
        }

        /**
         * Seta o campo:sexo
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       13/06/2012
         * @param       string email
         * @return      Usuario
         */
        public Usuario setSexo(string sexo)
        {
            if (sexo == "M" || sexo == "F")
            {
                this.setData("sexo", sexo);
                return this;
            }
            throw new Exception("O sexo "+sexo+" não esta mapeado.");
        }

        /**
             * Retorna o campo: nascimento
             * @author      Gabriel Santos Carvalho
             * @version     1.0
             * @since       13/06/2012
             * @return      string
             */
        public string getDataNascimento()
        {
            return this.getData("nascimento", "");
        }

        /**
         * Seta o campo:email
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       13/06/2012
         * @param       string dataNascimento
         * @return      Usuario
         */
        public Usuario setDataNascimento(string dataNascimento)
        {
            this.setData("nascimento", dataNascimento);
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
               * Retorna o campo: email
               * @author      Gabriel Santos Carvalho
               * @version     1.0
               * @since       13/06/2012
               * @return      string
               */
        public string getEmail()
        {
            return this.getData("email", "");
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

        /**
         * Retorna o campo: criado_em
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       13/06/2012
         * @return      string
         */
        public string getCriadoEm()
        {
            return this.getData("criado_em", "");
        }

        /**
         * Seta o campo: senha
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       13/06/2012
         * @param       string criado_em
         * @return      Usuario
         */
        public Usuario setCriadoEm(string criadoEm)
        {
            this.setData("criado_em", criadoEm);
            return this;
        }



        /**
         * Retorna o campo: alterado_em
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       13/06/2012
         * @return      string
         */
        public string getAlteradoEm()
        {
            return this.getData("alterado_em", "");
        }

        /**
         * Seta o campo: alterado_em
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       13/06/2012
         * @param       string alteradoEm
         * @return      Usuario
         */
        public Usuario setAlteradoEm(string alteradoEm)
        {
            this.setData("alterado_em", alteradoEm);
            return this;
        }

        /**
        * Retorna o campo: foto_perfil
        * @author      Gabriel Santos Carvalho
        * @version     1.0
        * @since       13/06/2012
        * @return      string
        */
        public string getFotoPerfil()
        {
            return this.getData("foto_perfil", "");
        }

        /**
         * Seta o campo: foto_perfil
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       13/06/2012
         * @param       string alteradoEm
         * @return      Usuario
         */
        public Usuario setFotoPerfil(string fotoPerfil)
        {
            this.setData("foto_perfil", fotoPerfil);
            return this;
        }


        

    }
}