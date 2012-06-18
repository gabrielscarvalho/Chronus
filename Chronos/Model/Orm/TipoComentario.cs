
	 using System;
	 using System.Collections.Generic;
	 using System.Linq;
	 using System.Web;
	 namespace Chronos.Model.Orm
	 {
	 public class TipoComentario : Model.Orm.Core
		 {

		/**
		 * Função que carrega a classe
		 * @author	Gabriel
		 * @version	1.0
		 * @since	14/06/2012
		*/
		public TipoComentario(){
			this.tableName= "tipo_comentario";
			this.primaryKey= "id";
		}

			/**
			 * Retorna o campo: tabela
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getTabela(){
			 return this.getData("tabela","");
		}

			/**
				* Seta o campo: tabela
				* @author	Gabriel
				* @version	1.0
				* @param	string tabela
				* @since	14/06/2012
				* @return	TipoComentario
			*/
			public TipoComentario setTabela(string tabela){
				 this.setData("tabela",tabela);
				 return this;
			}

			/**
			 * Retorna o campo: descricao
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getDescricao(){
			 return this.getData("descricao","");
		}

			/**
				* Seta o campo: descricao
				* @author	Gabriel
				* @version	1.0
				* @param	string descricao
				* @since	14/06/2012
				* @return	TipoComentario
			*/
			public TipoComentario setDescricao(string descricao){
				 this.setData("descricao",descricao);
				 return this;
			}

		 }
	 }