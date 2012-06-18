
	 using System;
	 using System.Collections.Generic;
	 using System.Linq;
	 using System.Web;
	 namespace Chronos.Model.Orm
	 {
	 public class Circulo : Model.Orm.Core
		 {

		/**
		 * Função que carrega a classe
		 * @author	Gabriel
		 * @version	1.0
		 * @since	14/06/2012
		*/
		public Circulo(){
			this.tableName= "circulo";
			this.primaryKey= "id";
		}

			/**
			 * Retorna o campo: dono_id
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getDonoId(){
			 return this.getData("dono_id","");
		}

			/**
				* Seta o campo: dono_id
				* @author	Gabriel
				* @version	1.0
				* @param	string donoId
				* @since	14/06/2012
				* @return	Circulo
			*/
			public Circulo setDonoId(string donoId){
				 this.setData("dono_id",donoId);
				 return this;
			}

			/**
			 * Retorna o campo: nome
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getNome(){
			 return this.getData("nome","");
		}

			/**
				* Seta o campo: nome
				* @author	Gabriel
				* @version	1.0
				* @param	string nome
				* @since	14/06/2012
				* @return	Circulo
			*/
			public Circulo setNome(string nome){
				 this.setData("nome",nome);
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
				* @return	Circulo
			*/
			public Circulo setStatus(string status){
				 this.setData("status",status);
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
				* @return	Circulo
			*/
			public Circulo setCriadoEm(string criadoEm){
				 this.setData("criado_em",criadoEm);
				 return this;
			}

		 }
	 }