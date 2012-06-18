
	 using System;
	 using System.Collections.Generic;
	 using System.Linq;
	 using System.Web;
	 namespace Chronos.Model.Orm
	 {
	 public class TagPropaganda : Model.Orm.Core
		 {

		/**
		 * Função que carrega a classe
		 * @author	Gabriel
		 * @version	1.0
		 * @since	14/06/2012
		*/
		public TagPropaganda(){
			this.tableName= "tag_propaganda";
			this.primaryKey= "id";
		}

			/**
			 * Retorna o campo: propaganda_id
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getPropagandaId(){
			 return this.getData("propaganda_id","");
		}

			/**
				* Seta o campo: propaganda_id
				* @author	Gabriel
				* @version	1.0
				* @param	string propagandaId
				* @since	14/06/2012
				* @return	TagPropaganda
			*/
			public TagPropaganda setPropagandaId(string propagandaId){
				 this.setData("propaganda_id",propagandaId);
				 return this;
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
				* @return	TagPropaganda
			*/
			public TagPropaganda setTagId(string tagId){
				 this.setData("tag_id",tagId);
				 return this;
			}

		 }
	 }