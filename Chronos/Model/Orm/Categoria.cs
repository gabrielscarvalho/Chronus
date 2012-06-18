
	 using System;
	 using System.Collections.Generic;
	 using System.Linq;
	 using System.Web;
	 namespace Chronos.Model.Orm
	 {
	 public class Categoria : Model.Orm.Core
		 {

		/**
		 * Função que carrega a classe
		 * @author	Gabriel
		 * @version	1.0
		 * @since	14/06/2012
		*/
		public Categoria(){
			this.tableName= "categoria";
			this.primaryKey= "id";
		}

			/**
			 * Retorna o campo: categoria_pai_id
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getCategoriaPaiId(){
			 return this.getData("categoria_pai_id","");
		}

			/**
				* Seta o campo: categoria_pai_id
				* @author	Gabriel
				* @version	1.0
				* @param	string categoriaPaiId
				* @since	14/06/2012
				* @return	Categoria
			*/
			public Categoria setCategoriaPaiId(string categoriaPaiId){
				 this.setData("categoria_pai_id",categoriaPaiId);
				 return this;
			}

			/**
			 * Retorna o campo: titulo
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getTitulo(){
			 return this.getData("titulo","");
		}

			/**
				* Seta o campo: titulo
				* @author	Gabriel
				* @version	1.0
				* @param	string titulo
				* @since	14/06/2012
				* @return	Categoria
			*/
			public Categoria setTitulo(string titulo){
				 this.setData("titulo",titulo);
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
				* @return	Categoria
			*/
			public Categoria setDescricao(string descricao){
				 this.setData("descricao",descricao);
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
				* @return	Categoria
			*/
			public Categoria setStatus(string status){
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
				* @return	Categoria
			*/
			public Categoria setCriadoEm(string criadoEm){
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
				* @return	Categoria
			*/
			public Categoria setAlteradoEm(string alteradoEm){
				 this.setData("alterado_em",alteradoEm);
				 return this;
			}

			/**
			 * Retorna o campo: ordem
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getOrdem(){
			 return this.getData("ordem","");
		}

			/**
				* Seta o campo: ordem
				* @author	Gabriel
				* @version	1.0
				* @param	string ordem
				* @since	14/06/2012
				* @return	Categoria
			*/
			public Categoria setOrdem(string ordem){
				 this.setData("ordem",ordem);
				 return this;
			}

		 }
	 }