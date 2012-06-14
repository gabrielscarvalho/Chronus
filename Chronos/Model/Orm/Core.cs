using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

namespace Chronos.Model.Orm
{
    public class Core : Model.Data
    {
        /**
         * Contém o nome da tabela que a classe representa.
         * @var         string tableName
         */
        protected string tableName;
        /**
         * Contém a chave primária dessa tabela
         * @var         string primaryKey
         */
        protected string primaryKey;

        /**
         * Guarda as colunas da tabela.
         * @var         string[] columns
         */
        protected string[] columns;

        /**
         * Armazena o ID do elemento carregado ou criado.
         * @var         int id
         */
        protected int id { get; set; }

        /**
         * Os dados preenchidos, existem no banco?
         * @var         bool exists
         */
        protected bool existsElement = false;
        
        protected Model.Db db = new Model.Db();

        /**
         * Carrega um objeto na classe passando o ID.
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       13/06/2012
         * @param       int id O id do elemento
         * @return      Orm
         */
        public Core load(int id)
        {
            string sql = "SELECT * FROM "+this.tableName+" WHERE "+this.primaryKey+"="+id;
            DataRow row = this.db.fetchRow(sql);


            if (row != null)
            {
                               
                string[] columns = db.__getColumnsLastSelect();

                this.columns = columns;

                
                foreach (string columnName in columns)
                {
                    this.setData(columnName,Convert.ToString(row[columnName]));
                }
                this.existsElement = true;
                this.id = id;
            }
            else
            {
                this.existsElement = false;
                    
            }
            return this;
        }

        /**
         * Os dados preenchidos existem no banco de dados?
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       13/06/2012
         * @return      bool
         */
        public bool exists()
        {
            return this.existsElement;

        }

        /**
         * Retorna as colunas da tabela.
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       13/06/2012
         * @return      array
         */
        public string[] getColumns()
        {
            if (this.columns.Length == 0)
            {

            }
            return this.columns;


        }

        public int save()
        {
            if (this.exists())
            {
                this.db.updateCommand(this.getCollectedData(), this.tableName, this.primaryKey + " = " + this.id);
            }
            else
            {
                this.id = this.db.insertCommand(this.getCollectedData(), this.tableName);
            }
            return this.id;
        }

        /**
         * Retorna o valor da chave primária.
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       13/06/2012
         * @return      int
         */
        public int getId()
        {
            return this.id;
        }
    

    }
}