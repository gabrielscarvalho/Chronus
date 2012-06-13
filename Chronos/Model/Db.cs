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


        /**
         * Conecta ao banco de dados.
         * @author       Gabriel Santos Carvalho
         * @version      1.0
         * @since        05/06/2012
         * @return       Db
         */
        protected void conectar()
        {

            
            string strConn = "Persist Security Info=False; server="+this.server+";database="+this.dataBase+";uid="+this.username;
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
         * Realiza uma consulta no banco de dados.
         * @author      Gabriel Santos Carvalho
         * @version     1.0
         * @since       06/06/2012
         * @param       string sql A consulta a ser realizada.
         * @return      DataRow
         */
        public DataRow[] select(string sql)
        {
            
            
            DataTable data = new DataTable();
            DataRow[] result;

            try
            {
                this.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, this.conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                
                da.Fill(data);
                result = data.Select();

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

            return result;
        }


        /**
       * Remove um registro do banco
       * @author          Gabriel
       * @version         1.0
       * @since           11/06/2012
       * @param           string table A tabela que iremos inserir
       * @param           Array data Os dados a serem inseridos. array(campo => valor)
       * @return          int id
       */
        public bool delete(string sql)
        {
            //Armazenamos a ultima query.


            DataTable data = new DataTable();
            bool apagou = false;

            try
            {
                this.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, this.conn);
                cmd.ExecuteNonQuery();
                apagou = true;
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
            return apagou;
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

            sql = "INSERT into " + table + "(" + fieldsList + ") VALUES (" + fieldValues + ");";





            return this.insert(sql);
        }


        /**
         * Retorna a ultima query executada.
         * @return          string
         */
        public string getLastExecutedQuery()
        {
            return this.lastQuery;
        }
    }


}