using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

namespace Chronos.Model 
{
    public class Orm : Model.Data
   {    
        /**
         * Contém o nome da tabela que a classe representa.
         * @var         string tableName
         */
        protected string tableName {get;}
        /**
         * Contém a chave primária dessa tabela
         * @var         string primaryKey
         */
        protected string primaryKey { get; }

        protected Model.Db db = new Model.Db();

        /**
         * Carrega um objeto na classe passando o ID.
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       13/06/2012
         * @param       int id O id do elemento
         * @return      Orm
         */
        public Orm load(int id)
        {
            string sql = "SELECT * FROM "+this.tableName+" WHERE "+this.primaryKey+"="+id;
            DataRow[] result = this.db.select(sql);
            
            return this;
        }


    }
}