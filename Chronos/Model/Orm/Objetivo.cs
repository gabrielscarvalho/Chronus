
	 using System;
	 using System.Collections.Generic;
	 using System.Linq;
	 using System.Web;
	 namespace Chronos.Model.Orm
	 {
	 public class Objetivo : Model.Orm.Core
		 {

		/**
		 * Função que carrega a classe
		 * @author	Gabriel
		 * @version	1.0
		 * @since	14/06/2012
		*/
		public Objetivo(){
			this.tableName= "objetivo";
			this.primaryKey= "id";
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
				* @return	Objetivo
			*/
			public Objetivo setTitulo(string titulo){
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
				* @return	Objetivo
			*/
			public Objetivo setDescricao(string descricao){
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
				* @return	Objetivo
			*/
			public Objetivo setStatus(string status){
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
				* @return	Objetivo
			*/
			public Objetivo setCriadoEm(string criadoEm){
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
				* @return	Objetivo
			*/
			public Objetivo setAlteradoEm(string alteradoEm){
				 this.setData("alterado_em",alteradoEm);
				 return this;
			}

			/**
			 * Retorna o campo: iniciado_em
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getIniciadoEm(){
			 return this.getData("iniciado_em","");
		}

			/**
				* Seta o campo: iniciado_em
				* @author	Gabriel
				* @version	1.0
				* @param	string iniciadoEm
				* @since	14/06/2012
				* @return	Objetivo
			*/
			public Objetivo setIniciadoEm(string iniciadoEm){
				 this.setData("iniciado_em",iniciadoEm);
				 return this;
			}

			/**
			 * Retorna o campo: concluido_em
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getConcluidoEm(){
			 return this.getData("concluido_em","");
		}

			/**
				* Seta o campo: concluido_em
				* @author	Gabriel
				* @version	1.0
				* @param	string concluidoEm
				* @since	14/06/2012
				* @return	Objetivo
			*/
			public Objetivo setConcluidoEm(string concluidoEm){
				 this.setData("concluido_em",concluidoEm);
				 return this;
			}

			/**
			 * Retorna o campo: concluido
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getConcluido(){
			 return this.getData("concluido","");
		}

			/**
				* Seta o campo: concluido
				* @author	Gabriel
				* @version	1.0
				* @param	string concluido
				* @since	14/06/2012
				* @return	Objetivo
			*/
			public Objetivo setConcluido(string concluido){
				 this.setData("concluido",concluido);
				 return this;
			}

			/**
			 * Retorna o campo: imagem_objetivo
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getImagemObjetivo(){
			 return this.getData("imagem_objetivo","");
		}

			/**
				* Seta o campo: imagem_objetivo
				* @author	Gabriel
				* @version	1.0
				* @param	string imagemObjetivo
				* @since	14/06/2012
				* @return	Objetivo
			*/
			public Objetivo setImagemObjetivo(string imagemObjetivo){
				 this.setData("imagem_objetivo",imagemObjetivo);
				 return this;
			}

			/**
			 * Retorna o campo: imagem_antes
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getImagemAntes(){
			 return this.getData("imagem_antes","");
		}

			/**
				* Seta o campo: imagem_antes
				* @author	Gabriel
				* @version	1.0
				* @param	string imagemAntes
				* @since	14/06/2012
				* @return	Objetivo
			*/
			public Objetivo setImagemAntes(string imagemAntes){
				 this.setData("imagem_antes",imagemAntes);
				 return this;
			}

			/**
			 * Retorna o campo: imagem_depois
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getImagemDepois(){
			 return this.getData("imagem_depois","");
		}

			/**
				* Seta o campo: imagem_depois
				* @author	Gabriel
				* @version	1.0
				* @param	string imagemDepois
				* @since	14/06/2012
				* @return	Objetivo
			*/
			public Objetivo setImagemDepois(string imagemDepois){
				 this.setData("imagem_depois",imagemDepois);
				 return this;
			}

		 }
	 }