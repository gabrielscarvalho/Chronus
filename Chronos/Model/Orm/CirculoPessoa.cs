
	 using System;
	 using System.Collections.Generic;
	 using System.Linq;
	 using System.Web;
	 namespace Chronos.Model.Orm
	 {
	 public class CirculoPessoa : Model.Orm.Core
		 {

		/**
		 * Função que carrega a classe
		 * @author	Gabriel
		 * @version	1.0
		 * @since	14/06/2012
		*/
		public CirculoPessoa(){
			this.tableName= "circulo_pessoa";
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
				* @return	CirculoPessoa
			*/
			public CirculoPessoa setUsuarioId(string usuarioId){
				 this.setData("usuario_id",usuarioId);
				 return this;
			}

			/**
			 * Retorna o campo: circulo_id
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getCirculoId(){
			 return this.getData("circulo_id","");
		}

			/**
				* Seta o campo: circulo_id
				* @author	Gabriel
				* @version	1.0
				* @param	string circuloId
				* @since	14/06/2012
				* @return	CirculoPessoa
			*/
			public CirculoPessoa setCirculoId(string circuloId){
				 this.setData("circulo_id",circuloId);
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
				* @return	CirculoPessoa
			*/
			public CirculoPessoa setCriadoEm(string criadoEm){
				 this.setData("criado_em",criadoEm);
				 return this;
			}

		 }
	 }