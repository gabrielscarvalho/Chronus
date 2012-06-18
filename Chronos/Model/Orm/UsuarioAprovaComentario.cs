
	 using System;
	 using System.Collections.Generic;
	 using System.Linq;
	 using System.Web;
	 namespace Chronos.Model.Orm
	 {
	 public class UsuarioAprovaComentario : Model.Orm.Core
		 {

		/**
		 * Função que carrega a classe
		 * @author	Gabriel
		 * @version	1.0
		 * @since	14/06/2012
		*/
		public UsuarioAprovaComentario(){
			this.tableName= "usuario_aprova_comentario";
			this.primaryKey= "id";
		}

			/**
			 * Retorna o campo: comentario_id
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getComentarioId(){
			 return this.getData("comentario_id","");
		}

			/**
				* Seta o campo: comentario_id
				* @author	Gabriel
				* @version	1.0
				* @param	string comentarioId
				* @since	14/06/2012
				* @return	UsuarioAprovaComentario
			*/
			public UsuarioAprovaComentario setComentarioId(string comentarioId){
				 this.setData("comentario_id",comentarioId);
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
				* @return	UsuarioAprovaComentario
			*/
			public UsuarioAprovaComentario setUsuarioId(string usuarioId){
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
				* @return	UsuarioAprovaComentario
			*/
			public UsuarioAprovaComentario setCriadoEm(string criadoEm){
				 this.setData("criado_em",criadoEm);
				 return this;
			}

		 }
	 }