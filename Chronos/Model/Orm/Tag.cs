
	 using System;
	 using System.Collections.Generic;
	 using System.Linq;
	 using System.Web;
	 namespace Chronos.Model.Orm
	 {
	 public class Tag : Model.Orm.Core
		 {

		/**
		 * Função que carrega a classe
		 * @author	Gabriel
		 * @version	1.0
		 * @since	14/06/2012
		*/
		public Tag(){
			this.tableName= "tag";
			this.primaryKey= "id";
		}

			/**
			 * Retorna o campo: tag
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getTag(){
			 return this.getData("tag","");
		}

			/**
				* Seta o campo: tag
				* @author	Gabriel
				* @version	1.0
				* @param	string tag
				* @since	14/06/2012
				* @return	Tag
			*/
			public Tag setTag(string tag){
				 this.setData("tag",tag);
				 return this;
			}

			/**
			 * Retorna o campo: criado_em
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getCriadoEm(){
			 return this.getData("criado_em","");
		}

			/**
				* Seta o campo: criado_em
				* @author	Gabriel
				* @version	1.0
				* @param	string criadoEm
				* @since	14/06/2012
				* @return	Tag
			*/
			public Tag setCriadoEm(string criadoEm){
				 this.setData("criado_em",criadoEm);
				 return this;
			}

		 }
	 }