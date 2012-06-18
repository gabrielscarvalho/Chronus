
	 using System;
	 using System.Collections.Generic;
	 using System.Linq;
	 using System.Web;
	 namespace Chronos.Model.Orm
	 {
	 public class TagObjetivo : Model.Orm.Core
		 {

		/**
		 * Função que carrega a classe
		 * @author	Gabriel
		 * @version	1.0
		 * @since	14/06/2012
		*/
		public TagObjetivo(){
			this.tableName= "tag_objetivo";
			this.primaryKey= "id";
		}

			/**
			 * Retorna o campo: tag_id
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getTagId(){
			 return this.getData("tag_id","");
		}

			/**
				* Seta o campo: tag_id
				* @author	Gabriel
				* @version	1.0
				* @param	string tagId
				* @since	14/06/2012
				* @return	TagObjetivo
			*/
			public TagObjetivo setTagId(string tagId){
				 this.setData("tag_id",tagId);
				 return this;
			}

			/**
			 * Retorna o campo: objetivo_id
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getObjetivoId(){
			 return this.getData("objetivo_id","");
		}

			/**
				* Seta o campo: objetivo_id
				* @author	Gabriel
				* @version	1.0
				* @param	string objetivoId
				* @since	14/06/2012
				* @return	TagObjetivo
			*/
			public TagObjetivo setObjetivoId(string objetivoId){
				 this.setData("objetivo_id",objetivoId);
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
				* @return	TagObjetivo
			*/
			public TagObjetivo setCriadoEm(string criadoEm){
				 this.setData("criado_em",criadoEm);
				 return this;
			}

		 }
	 }