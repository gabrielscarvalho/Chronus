using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace Chronos.Model
{
    public class Db
    {
        protected string server = "localhost";
        protected string username = "SYSDBA";
        protected string password = "masterkey";
        protected string dataBase = "F:/Gabriel/Fatec/Projetos/Chronus/Chronos/Chronos/App_Data/Chronus.fdb";
        protected FbConnection conn;
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
           
            string strConn = "User="+this.username+"; Password="+this.password+"; Database="+this.dataBase+"; Server="+this.server+";";
            FbConnection fbConn = new FbConnection(strConn);
            
            try{
                    this.conn = fbConn;
                    this.conn.Open();
            }catch (FbException fbex){
                throw new Exception("Erro ao conectar no banco de dados." + fbex.Message);
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
            try {
                this.conectar();
                FbCommand fbCmd = new FbCommand(sql, this.conn);
                FbDataAdapter fbDa = new FbDataAdapter(fbCmd);

                fbDa.Fill(data);
                result = data.Select();
                //Armazenamos a ultima query.
                this.lastQuery = sql;    
            }
            catch (FbException fbex) {
                throw new Exception("Erro ao executar um SQL:"+ fbex.Message);
            }
            finally {
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
        public bool delete(string sql) {
            //Armazenamos a ultima query.
        

            DataTable data = new DataTable();
            bool apagou = false;

            try {
                this.conectar();
                FbCommand fbCmd = new FbCommand(sql, this.conn);
                fbCmd.ExecuteNonQuery();
                apagou = true;
                this.lastQuery = sql;
            }catch (FbException fbex) {
                throw new Exception("Erro ao apagar um Registro:" + fbex.Message);
            }
            finally {
                this.desconectar();
            }
            return apagou;
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
        public bool insert(string sql)
        {
            
            DataTable data = new DataTable();
            bool apagou = false;

            try
            {
                this.conectar();
                FbCommand fbCmd = new FbCommand(sql, this.conn);
                fbCmd.ExecuteNonQuery();
                //Armazenamos a ultima query.
                this.lastQuery = sql;
            }
            catch (FbException fbex)
            {
                throw new Exception("Erro ao apagar um Registro:" + fbex.Message);
            }
            finally
            {
                this.desconectar();
            }
            return apagou;
        }


        /**
         * Retorna a ultima query executada.
         * @return          string
         */
        public string getLastExecutedQuery() {
            return this.lastQuery;
        }
    }

    
}