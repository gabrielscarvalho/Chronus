
	 using System;
	 using System.Collections.Generic;
	 using System.Linq;
	 using System.Web;
	 namespace Chronos.Model.Orm
	 {
	 public class Relato : Model.Orm.Core
		 {

		/**
		 * Função que carrega a classe
		 * @author	Gabriel
		 * @version	1.0
		 * @since	14/06/2012
		*/
		public Relato(){
			this.tableName= "relato";
			this.primaryKey= "id";
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
				* @return	Relato
			*/
			public Relato setPostadorId(string postadorId){
				 this.setData("postador_id",postadorId);
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
				* @return	Relato
			*/
			public Relato setTitulo(string titulo){
				 this.setData("titulo",titulo);
				 return this;
			}

			/**
			 * Retorna o campo: resumo
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getResumo(){
			 return this.getData("resumo","");
		}

			/**
				* Seta o campo: resumo
				* @author	Gabriel
				* @version	1.0
				* @param	string resumo
				* @since	14/06/2012
				* @return	Relato
			*/
			public Relato setResumo(string resumo){
				 this.setData("resumo",resumo);
				 return this;
			}

			/**
			 * Retorna o campo: conteudo
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getConteudo(){
			 return this.getData("conteudo","");
		}

			/**
				* Seta o campo: conteudo
				* @author	Gabriel
				* @version	1.0
				* @param	string conteudo
				* @since	14/06/2012
				* @return	Relato
			*/
			public Relato setConteudo(string conteudo){
				 this.setData("conteudo",conteudo);
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
				* @return	Relato
			*/
			public Relato setCriadoEm(string criadoEm){
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
				* @return	Relato
			*/
			public Relato setAlteradoEm(string alteradoEm){
				 this.setData("alterado_em",alteradoEm);
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
				* @return	Relato
			*/
			public Relato setStatus(string status){
				 this.setData("status",status);
				 return this;
			}

			/**
			 * Retorna o campo: antes_imagem
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getAntesImagem(){
			 return this.getData("antes_imagem","");
		}

			/**
				* Seta o campo: antes_imagem
				* @author	Gabriel
				* @version	1.0
				* @param	string antesImagem
				* @since	14/06/2012
				* @return	Relato
			*/
			public Relato setAntesImagem(string antesImagem){
				 this.setData("antes_imagem",antesImagem);
				 return this;
			}

			/**
			 * Retorna o campo: depois_imagem
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getDepoisImagem(){
			 return this.getData("depois_imagem","");
		}

			/**
				* Seta o campo: depois_imagem
				* @author	Gabriel
				* @version	1.0
				* @param	string depoisImagem
				* @since	14/06/2012
				* @return	Relato
			*/
			public Relato setDepoisImagem(string depoisImagem){
				 this.setData("depois_imagem",depoisImagem);
				 return this;
			}

		 }
	 }