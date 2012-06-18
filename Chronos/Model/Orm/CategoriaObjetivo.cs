
	 using System;
	 using System.Collections.Generic;
	 using System.Linq;
	 using System.Web;
	 namespace Chronos.Model.Orm
	 {
	 public class CategoriaObjetivo : Model.Orm.Core
		 {

		/**
		 * Função que carrega a classe
		 * @author	Gabriel
		 * @version	1.0
		 * @since	14/06/2012
		*/
		public CategoriaObjetivo(){
			this.tableName= "categoria_objetivo";
			this.primaryKey= "id";
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
				* @return	CategoriaObjetivo
			*/
			public CategoriaObjetivo setObjetivoId(string objetivoId){
				 this.setData("objetivo_id",objetivoId);
				 return this;
			}

			/**
			 * Retorna o campo: categoria_id
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getCategoriaId(){
			 return this.getData("categoria_id","");
		}

			/**
				* Seta o campo: categoria_id
				* @author	Gabriel
				* @version	1.0
				* @param	string categoriaId
				* @since	14/06/2012
				* @return	CategoriaObjetivo
			*/
			public CategoriaObjetivo setCategoriaId(string categoriaId){
				 this.setData("categoria_id",categoriaId);
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
				* @return	CategoriaObjetivo
			*/
			public CategoriaObjetivo setCriadoEm(string criadoEm){
				 this.setData("criado_em",criadoEm);
				 return this;
			}

		 }
	 }