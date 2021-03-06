
	 using System;
	 using System.Collections.Generic;
	 using System.Linq;
	 using System.Web;
	 namespace Chronos.Model.Orm
	 {
	 public class Usuario : Model.Orm.Core
		 {

		/**
		 * Fun��o que carrega a classe
		 * @author	Gabriel
		 * @version	1.0
		 * @since	14/06/2012
		*/
		public Usuario(){
			this.tableName= "usuario";
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
				* @return	Usuario
			*/
			public Usuario setNome(string nome){
				 this.setData("nome",nome);
				 return this;
			}

			/**
			 * Retorna o campo: sobrenome
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getSobrenome(){
			 return this.getData("sobrenome","");
		}

			/**
				* Seta o campo: sobrenome
				* @author	Gabriel
				* @version	1.0
				* @param	string sobrenome
				* @since	14/06/2012
				* @return	Usuario
			*/
			public Usuario setSobrenome(string sobrenome){
				 this.setData("sobrenome",sobrenome);
				 return this;
			}

			/**
			 * Retorna o campo: sexo
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getSexo(){
			 return this.getData("sexo","");
		}

			/**
				* Seta o campo: sexo
				* @author	Gabriel
				* @version	1.0
				* @param	string sexo
				* @since	14/06/2012
				* @return	Usuario
			*/
			public Usuario setSexo(string sexo){
				 this.setData("sexo",sexo);
				 return this;
			}

			/**
			 * Retorna o campo: nascimento
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getNascimento(){
			 return this.getData("nascimento","");
		}

			/**
				* Seta o campo: nascimento
				* @author	Gabriel
				* @version	1.0
				* @param	string nascimento
				* @since	14/06/2012
				* @return	Usuario
			*/
			public Usuario setNascimento(string nascimento){
				 this.setData("nascimento",nascimento);
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
				* @return	Usuario
			*/
			public Usuario setStatus(string status){
				 this.setData("status",status);
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
				* @return	Usuario
			*/
			public Usuario setEmail(string email){
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
				* @return	Usuario
			*/
			public Usuario setSenha(string senha){
				 this.setData("senha",senha);
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
				* @return	Usuario
			*/
			public Usuario setCriadoEm(string criadoEm){
				 this.setData("criado_em",criadoEm);
				 return this;
			}

			/**
			 * Retorna o campo: alterado_em
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getAlteradoEm(){
			 return this.getData("alterado_em","");
		}

			/**
				* Seta o campo: alterado_em
				* @author	Gabriel
				* @version	1.0
				* @param	string alteradoEm
				* @since	14/06/2012
				* @return	Usuario
			*/
			public Usuario setAlteradoEm(string alteradoEm){
				 this.setData("alterado_em",alteradoEm);
				 return this;
			}

			/**
			 * Retorna o campo: foto_perfil
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getFotoPerfil(){
			 return this.getData("foto_perfil","");
		}

			/**
				* Seta o campo: foto_perfil
				* @author	Gabriel
				* @version	1.0
				* @param	string fotoPerfil
				* @since	14/06/2012
				* @return	Usuario
			*/
			public Usuario setFotoPerfil(string fotoPerfil){
				 this.setData("foto_perfil",fotoPerfil);
				 return this;
			}

		 }
	 }