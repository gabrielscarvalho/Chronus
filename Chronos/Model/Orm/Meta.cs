
	 using System;
	 using System.Collections.Generic;
	 using System.Linq;
	 using System.Web;
	 namespace Chronos.Model.Orm
	 {
	 public class Meta : Model.Orm.Core
		 {

		/**
		 * Função que carrega a classe
		 * @author	Gabriel
		 * @version	1.0
		 * @since	14/06/2012
		*/
		public Meta(){
			this.tableName= "meta";
			this.primaryKey= "id";
		}

			/**
			 * Retorna o campo: executor_id
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getExecutorId(){
			 return this.getData("executor_id","");
		}

			/**
				* Seta o campo: executor_id
				* @author	Gabriel
				* @version	1.0
				* @param	string executorId
				* @since	14/06/2012
				* @return	Meta
			*/
			public Meta setExecutorId(string executorId){
				 this.setData("executor_id",executorId);
				 return this;
			}

			/**
			 * Retorna o campo: meta_pai_id
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getMetaPaiId(){
			 return this.getData("meta_pai_id","");
		}

			/**
				* Seta o campo: meta_pai_id
				* @author	Gabriel
				* @version	1.0
				* @param	string metaPaiId
				* @since	14/06/2012
				* @return	Meta
			*/
			public Meta setMetaPaiId(string metaPaiId){
				 this.setData("meta_pai_id",metaPaiId);
				 return this;
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
				* @return	Meta
			*/
			public Meta setObjetivoId(string objetivoId){
				 this.setData("objetivo_id",objetivoId);
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
				* @return	Meta
			*/
			public Meta setTitulo(string titulo){
				 this.setData("titulo",titulo);
				 return this;
			}

			/**
			 * Retorna o campo: definicao
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getDefinicao(){
			 return this.getData("definicao","");
		}

			/**
				* Seta o campo: definicao
				* @author	Gabriel
				* @version	1.0
				* @param	string definicao
				* @since	14/06/2012
				* @return	Meta
			*/
			public Meta setDefinicao(string definicao){
				 this.setData("definicao",definicao);
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
				* @return	Meta
			*/
			public Meta setConcluido(string concluido){
				 this.setData("concluido",concluido);
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
				* @return	Meta
			*/
			public Meta setStatus(string status){
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
				* @return	Meta
			*/
			public Meta setCriadoEm(string criadoEm){
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
				* @return	Meta
			*/
			public Meta setAlteradoEm(string alteradoEm){
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
				* @return	Meta
			*/
			public Meta setIniciadoEm(string iniciadoEm){
				 this.setData("iniciado_em",iniciadoEm);
				 return this;
			}

			/**
			 * Retorna o campo: iniciar_em
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getIniciarEm(){
			 return this.getData("iniciar_em","");
		}

			/**
				* Seta o campo: iniciar_em
				* @author	Gabriel
				* @version	1.0
				* @param	string iniciarEm
				* @since	14/06/2012
				* @return	Meta
			*/
			public Meta setIniciarEm(string iniciarEm){
				 this.setData("iniciar_em",iniciarEm);
				 return this;
			}

			/**
			 * Retorna o campo: finalizado_em
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getFinalizadoEm(){
			 return this.getData("finalizado_em","");
		}

			/**
				* Seta o campo: finalizado_em
				* @author	Gabriel
				* @version	1.0
				* @param	string finalizadoEm
				* @since	14/06/2012
				* @return	Meta
			*/
			public Meta setFinalizadoEm(string finalizadoEm){
				 this.setData("finalizado_em",finalizadoEm);
				 return this;
			}

			/**
			 * Retorna o campo: finalizar_em
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getFinalizarEm(){
			 return this.getData("finalizar_em","");
		}

			/**
				* Seta o campo: finalizar_em
				* @author	Gabriel
				* @version	1.0
				* @param	string finalizarEm
				* @since	14/06/2012
				* @return	Meta
			*/
			public Meta setFinalizarEm(string finalizarEm){
				 this.setData("finalizar_em",finalizarEm);
				 return this;
			}

			/**
			 * Retorna o campo: meta_repete
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getMetaRepete(){
			 return this.getData("meta_repete","");
		}

			/**
				* Seta o campo: meta_repete
				* @author	Gabriel
				* @version	1.0
				* @param	string metaRepete
				* @since	14/06/2012
				* @return	Meta
			*/
			public Meta setMetaRepete(string metaRepete){
				 this.setData("meta_repete",metaRepete);
				 return this;
			}

			/**
			 * Retorna o campo: repete_qtd_dia
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getRepeteQtdDia(){
			 return this.getData("repete_qtd_dia","");
		}

			/**
				* Seta o campo: repete_qtd_dia
				* @author	Gabriel
				* @version	1.0
				* @param	string repeteQtdDia
				* @since	14/06/2012
				* @return	Meta
			*/
			public Meta setRepeteQtdDia(string repeteQtdDia){
				 this.setData("repete_qtd_dia",repeteQtdDia);
				 return this;
			}

		 }
	 }