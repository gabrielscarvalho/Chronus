
	 using System;
	 using System.Collections.Generic;
	 using System.Linq;
	 using System.Web;
	 namespace Chronos.Model.Orm
	 {
	 public class SeguidorObjetivo : Model.Orm.Core
		 {

		/**
		 * Função que carrega a classe
		 * @author	Gabriel
		 * @version	1.0
		 * @since	14/06/2012
		*/
		public SeguidorObjetivo(){
			this.tableName= "seguidor_objetivo";
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
				* @return	SeguidorObjetivo
			*/
			public SeguidorObjetivo setObjetivoId(string objetivoId){
				 this.setData("objetivo_id",objetivoId);
				 return this;
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
				* @return	SeguidorObjetivo
			*/
			public SeguidorObjetivo setUsuarioId(string usuarioId){
				 this.setData("usuario_id",usuarioId);
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
				* @return	SeguidorObjetivo
			*/
			public SeguidorObjetivo setCriadoEm(string criadoEm){
				 this.setData("criado_em",criadoEm);
				 return this;
			}

			/**
			 * Retorna o campo: notificar_email
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getNotificarEmail(){
			 return this.getData("notificar_email","");
		}

			/**
				* Seta o campo: notificar_email
				* @author	Gabriel
				* @version	1.0
				* @param	string notificarEmail
				* @since	14/06/2012
				* @return	SeguidorObjetivo
			*/
			public SeguidorObjetivo setNotificarEmail(string notificarEmail){
				 this.setData("notificar_email",notificarEmail);
				 return this;
			}

		 }
	 }