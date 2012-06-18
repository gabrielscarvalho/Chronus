
	 using System;
	 using System.Collections.Generic;
	 using System.Linq;
	 using System.Web;
	 namespace Chronos.Model.Orm
	 {
	 public class Empresa : Model.Orm.Core
		 {

		/**
		 * Função que carrega a classe
		 * @author	Gabriel
		 * @version	1.0
		 * @since	14/06/2012
		*/
		public Empresa(){
			this.tableName= "empresa";
			this.primaryKey= "id";
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
				* @return	Empresa
			*/
			public Empresa setNome(string nome){
				 this.setData("nome",nome);
				 return this;
			}

			/**
			 * Retorna o campo: website
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getWebsite(){
			 return this.getData("website","");
		}

			/**
				* Seta o campo: website
				* @author	Gabriel
				* @version	1.0
				* @param	string website
				* @since	14/06/2012
				* @return	Empresa
			*/
			public Empresa setWebsite(string website){
				 this.setData("website",website);
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
				* @return	Empresa
			*/
			public Empresa setCriadoEm(string criadoEm){
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
				* @return	Empresa
			*/
			public Empresa setStatus(string status){
				 this.setData("status",status);
				 return this;
			}

			/**
			 * Retorna o campo: descricao
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getDescricao(){
			 return this.getData("descricao","");
		}

			/**
				* Seta o campo: descricao
				* @author	Gabriel
				* @version	1.0
				* @param	string descricao
				* @since	14/06/2012
				* @return	Empresa
			*/
			public Empresa setDescricao(string descricao){
				 this.setData("descricao",descricao);
				 return this;
			}

			/**
			 * Retorna o campo: email
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getEmail(){
			 return this.getData("email","");
		}

			/**
				* Seta o campo: email
				* @author	Gabriel
				* @version	1.0
				* @param	string email
				* @since	14/06/2012
				* @return	Empresa
			*/
			public Empresa setEmail(string email){
				 this.setData("email",email);
				 return this;
			}

			/**
			 * Retorna o campo: senha
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getSenha(){
			 return this.getData("senha","");
		}

			/**
				* Seta o campo: senha
				* @author	Gabriel
				* @version	1.0
				* @param	string senha
				* @since	14/06/2012
				* @return	Empresa
			*/
			public Empresa setSenha(string senha){
				 this.setData("senha",senha);
				 return this;
			}

		 }
	 }