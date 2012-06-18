
	 using System;
	 using System.Collections.Generic;
	 using System.Linq;
	 using System.Web;
	 namespace Chronos.Model.Orm
	 {
	 public class Comentario : Model.Orm.Core
		 {

		/**
		 * Função que carrega a classe
		 * @author	Gabriel
		 * @version	1.0
		 * @since	14/06/2012
		*/
		public Comentario(){
			this.tableName= "comentario";
			this.primaryKey= "id";
		}

			/**
			 * Retorna o campo: objeto_id
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getObjetoId(){
			 return this.getData("objeto_id","");
		}

			/**
				* Seta o campo: objeto_id
				* @author	Gabriel
				* @version	1.0
				* @param	string objetoId
				* @since	14/06/2012
				* @return	Comentario
			*/
			public Comentario setObjetoId(string objetoId){
				 this.setData("objeto_id",objetoId);
				 return this;
			}

			/**
			 * Retorna o campo: postador_id
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getPostadorId(){
			 return this.getData("postador_id","");
		}

			/**
				* Seta o campo: postador_id
				* @author	Gabriel
				* @version	1.0
				* @param	string postadorId
				* @since	14/06/2012
				* @return	Comentario
			*/
			public Comentario setPostadorId(string postadorId){
				 this.setData("postador_id",postadorId);
				 return this;
			}

			/**
			 * Retorna o campo: resposta_id
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getRespostaId(){
			 return this.getData("resposta_id","");
		}

			/**
				* Seta o campo: resposta_id
				* @author	Gabriel
				* @version	1.0
				* @param	string respostaId
				* @since	14/06/2012
				* @return	Comentario
			*/
			public Comentario setRespostaId(string respostaId){
				 this.setData("resposta_id",respostaId);
				 return this;
			}

			/**
			 * Retorna o campo: tipo_comentario_id
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getTipoComentarioId(){
			 return this.getData("tipo_comentario_id","");
		}

			/**
				* Seta o campo: tipo_comentario_id
				* @author	Gabriel
				* @version	1.0
				* @param	string tipoComentarioId
				* @since	14/06/2012
				* @return	Comentario
			*/
			public Comentario setTipoComentarioId(string tipoComentarioId){
				 this.setData("tipo_comentario_id",tipoComentarioId);
				 return this;
			}

			/**
			 * Retorna o campo: comentario
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getComentario(){
			 return this.getData("comentario","");
		}

			/**
				* Seta o campo: comentario
				* @author	Gabriel
				* @version	1.0
				* @param	string comentario
				* @since	14/06/2012
				* @return	Comentario
			*/
			public Comentario setComentario(string comentario){
				 this.setData("comentario",comentario);
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
				* @return	Comentario
			*/
			public Comentario setCriadoEm(string criadoEm){
				 this.setData("criado_em",criadoEm);
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
				* @return	Comentario
			*/
			public Comentario setStatus(string status){
				 this.setData("status",status);
				 return this;
			}

		 }
	 }