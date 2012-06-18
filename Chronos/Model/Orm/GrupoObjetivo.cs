
	 using System;
	 using System.Collections.Generic;
	 using System.Linq;
	 using System.Web;
	 namespace Chronos.Model.Orm
	 {
	 public class GrupoObjetivo : Model.Orm.Core
		 {

		/**
		 * Função que carrega a classe
		 * @author	Gabriel
		 * @version	1.0
		 * @since	14/06/2012
		*/
		public GrupoObjetivo(){
			this.tableName= "grupo_objetivo";
			this.primaryKey= "id";
		}

			/**
			 * Retorna o campo: usuario_id
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getUsuarioId(){
			 return this.getData("usuario_id","");
		}

			/**
				* Seta o campo: usuario_id
				* @author	Gabriel
				* @version	1.0
				* @param	string usuarioId
				* @since	14/06/2012
				* @return	GrupoObjetivo
			*/
			public GrupoObjetivo setUsuarioId(string usuarioId){
				 this.setData("usuario_id",usuarioId);
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
				* @return	GrupoObjetivo
			*/
			public GrupoObjetivo setObjetivoId(string objetivoId){
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
				* @return	GrupoObjetivo
			*/
			public GrupoObjetivo setCriadoEm(string criadoEm){
				 this.setData("criado_em",criadoEm);
				 return this;
			}

			/**
			 * Retorna o campo: criou_ideia
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getCriouIdeia(){
			 return this.getData("criou_ideia","");
		}

			/**
				* Seta o campo: criou_ideia
				* @author	Gabriel
				* @version	1.0
				* @param	string criouIdeia
				* @since	14/06/2012
				* @return	GrupoObjetivo
			*/
			public GrupoObjetivo setCriouIdeia(string criouIdeia){
				 this.setData("criou_ideia",criouIdeia);
				 return this;
			}

			/**
			 * Retorna o campo: status
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getStatus(){
			 return this.getData("status","");
		}

			/**
				* Seta o campo: status
				* @author	Gabriel
				* @version	1.0
				* @param	string status
				* @since	14/06/2012
				* @return	GrupoObjetivo
			*/
			public GrupoObjetivo setStatus(string status){
				 this.setData("status",status);
				 return this;
			}

		 }
	 }