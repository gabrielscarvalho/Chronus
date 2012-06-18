using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

namespace Chronos.Model
{
    public class Db
    {
        protected string server = "localhost";
        protected string username = "root";
        protected string password = "";
        protected string dataBase = "chronus";
        protected MySqlConnection conn;
        protected string lastQuery;
        protected DataTable dataTable = new DataTable();


        /**
         * Conecta ao banco de dados.
         * @author       Gabriel Santos Carvalho
         * @version      1.0
         * @since        05/06/2012
         * @return       Db
         */
        protected void conectar()
        {

            
            string strConn = "Persist Security Info=False; server="+this.server+";database="+this.dataBase+";uid="+this.username+";Allow Zero Datetime=true";
            //strConn = "Persist Security Info=False; server=localhost;database=teste;uid=root";

            MySqlConnection conn = new MySqlConnection(strConn);
            try
            {
                this.conn = conn;
                this.conn.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao conectar no banco de dados." + ex.Message);
            }

        }

        /**
       * Desconecta-se do banco de dados.
       * @author      Gabriel Santos Carvalho
       * @version     1.0
       * @since       06/06/2012
       * @param       string sql A consulta a ser realizada.
       * @return      void
       */
        protected void desconectar()
        {
            this.conn.Close();
        }

        /**
          * Executa um SQL
          * @author      Gabriel Santos Carvalho
          * @since       06/06/2012
          * @param       string sql A consulta a ser realizada.
          * @return      MysqlCommand
          */
        protected MySqlCommand initCommand(string sql)
        {
            this.conectar();
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            return cmd;
        }


        /**
       * Executa uma query sem resposta.
       * @author          Gabriel Santos Carvalho
       * @version         1.0
       * @since           11/06/2012
       * @param           string sql A consulta
       * @return          bool
       */
        public bool nonQuery(string sql)
        {
            //Armazenamos a ultima query.


            DataTable data = new DataTable();
            bool conseguiu = false;

            try
            {
                MySqlCommand cmd = this.initCommand(sql);
                cmd.ExecuteNonQuery();
                conseguiu = true;
                this.lastQuery = sql;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao executar uma query:" + ex.Message);
            }
            finally
            {
                this.desconectar();
            }
            return conseguiu;
        }



        /**
         * Realiza uma consulta no banco de dados.
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       06/06/2012
         * @param       string sql A consulta a ser realizada.
         * @return      DataRow
         */
        public DataRow[] fetchAll(string sql)
        {
            DataRow[] result;
            DataRow[] row = null;
            try
            {
                MySqlCommand cmd = this.initCommand(sql);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(this.dataTable);
                result = this.dataTable.Select();

                //Armazenamos a ultima query.
                this.lastQuery = sql;
            }
            catch (MySqlException ex)
           { 
                throw new Exception("Erro ao executar um SQL:" + ex.Message);
            }
            finally
            {
                this.desconectar();
            }

            if (result.Length > 0)
            {
                return result;
            }
            return row;
        }

        /**
        * Retorna uma linha do banco.
        * @author      Gabriel Santos Carvalho
        * @version     1.0
        * @since       06/06/2012
        * @param       string sql A consulta a ser realizada.
        * @return      DataRow
        */
        public DataRow fetchRow(string sql)
        {
            DataRow[] result;
            DataRow row = null;

            try
            {
                MySqlCommand cmd = this.initCommand(sql);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(this.dataTable);
                result = this.dataTable.Select();

                
                //Armazenamos a ultima query.
                this.lastQuery = sql;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao executar um SQL:" + ex.Message);
            }
            finally
            {
                this.desconectar();
            }

            if (result.Length > 0)
            {
                return result[0];
            }

            return row;

        }


        /**
         * Retorna as colunas do ultimo select executado.
         * @author          Gabriel Santos Carvalho
         * @version         1.0
         * @since           11/06/2012
         * @return      array
         */
        public string[] __getColumnsLastSelect()
        {
                    
            if (this.dataTable != null)
            {
                string[] columns = new string[this.dataTable.Columns.Count];

                int atual = 0;
                foreach (DataColumn column in this.dataTable.Columns)
                {
                   columns[atual] =  column.ColumnName;
                   atual++;
                }
                
                return columns;
            }
            throw new Exception("Você precisa executar um select para utilizar esse comando.");
        }


        
        /**
         * Insere um novo registro, retornando seu ID.
         * @author          Gabriel
         * @version         1.0
         * @since           11/06/2012
         * @param           string table A tabela que iremos inserir
         * @param           Array data Os dados a serem inseridos. array(campo => valor)
         * @return          int id
         */
        public int insert(string sql)
        {
            //Armazenamos a ultima query.
            int id;

            DataTable data = new DataTable();
            
            try
            {
                this.conectar();
                
                sql = sql + "select last_insert_id();";
                MySqlCommand cmd = new MySqlCommand(sql, this.conn);
                //cmd.ExecuteNonQuery();
                id = Convert.ToInt32(cmd.ExecuteScalar());
                this.lastQuery = sql;

            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao apagar um Registro:" + ex.Message);
            }
            finally
            {
                this.desconectar();
            }
            return id;
        }


        /**
         * Insere um novo registro.
         * @author          Gabriel Santos Carvalho
         * @version         1.0
         * @since           11/06/2012
         * @param           Dictionary fields (campo => valor)
         * @param           string table A tabela que terá a inserção.
         * @return          int id
         */
        public int insertCommand(Dictionary<string, string> fields, string table) {
          
            string sql = "", key = "", value = "", fieldsList = "", fieldValues = "";
            string separator = "";
            int column = 0;

            foreach (KeyValuePair<string, string> pair in fields.ToList())
            {
                if (column > 0)
                {
                    separator = ",";
                }
                key = pair.Key;
                value = pair.Value;

                fieldsList = fieldsList + separator + key;
                fieldValues = fieldValues + separator + '"' + value + '"';
                column++;
            }

            sql = "INSERT into " + table + " (" + fieldsList + ") VALUES (" + fieldValues + ");";

                       
            return this.insert(sql);
        }



        /**
         * Altera um registro.
         * @author          Gabriel Santos Carvalho
         * @version         1.0
         * @since           11/06/2012
         * @param           Dictionary fields (campo => valor)
         * @param           string table A tabela que terá a inserção.
         * @return          int id
         */
        public bool updateCommand(Dictionary<string, string> fields, string table, string where)
        {

            string sql = "", key = "", value = "", fieldValues = "";
            string separator = "";
            int column = 0;

            foreach (KeyValuePair<string, string> pair in fields.ToList())
            {
                if (column > 0)
                {
                    separator = ",";
                }
                key = pair.Key;
                value = pair.Value;

                
                fieldValues = fieldValues + separator + key +" = "+'"' + value + '"';
                column++;
            }

            sql = "UPDATE " + table + " SET "+fieldValues+" WHERE "+ where +";";


            return this.nonQuery(sql);
        }



        /**
         * Retorna a ultima query executada.
         * @author          Gabriel Santos Carvalho
         * @version         1.0
         * @since           11/06/2012
         * @return          string
         */
        public string getLastExecutedQuery()
        {
            return this.lastQuery;
        }
    }


}