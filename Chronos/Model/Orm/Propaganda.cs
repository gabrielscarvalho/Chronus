
	 using System;
	 using System.Collections.Generic;
	 using System.Linq;
	 using System.Web;
	 namespace Chronos.Model.Orm
	 {
	 public class Propaganda : Model.Orm.Core
		 {

		/**
		 * Função que carrega a classe
		 * @author	Gabriel
		 * @version	1.0
		 * @since	14/06/2012
		*/
		public Propaganda(){
			this.tableName= "propaganda";
			this.primaryKey= "id";
		}

			/**
			 * Retorna o campo: empresa_id
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getEmpresaId(){
			 return this.getData("empresa_id","");
		}

			/**
				* Seta o campo: empresa_id
				* @author	Gabriel
				* @version	1.0
				* @param	string empresaId
				* @since	14/06/2012
				* @return	Propaganda
			*/
			public Propaganda setEmpresaId(string empresaId){
				 this.setData("empresa_id",empresaId);
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
				* @return	Propaganda
			*/
			public Propaganda setTitulo(string titulo){
				 this.setData("titulo",titulo);
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
				* @return	Propaganda
			*/
			public Propaganda setConteudo(string conteudo){
				 this.setData("conteudo",conteudo);
				 return this;
			}

			/**
			 * Retorna o campo: link
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getLink(){
			 return this.getData("link","");
		}

			/**
				* Seta o campo: link
				* @author	Gabriel
				* @version	1.0
				* @param	string link
				* @since	14/06/2012
				* @return	Propaganda
			*/
			public Propaganda setLink(string link){
				 this.setData("link",link);
				 return this;
			}

			/**
			 * Retorna o campo: qtd_clique
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getQtdClique(){
			 return this.getData("qtd_clique","");
		}

			/**
				* Seta o campo: qtd_clique
				* @author	Gabriel
				* @version	1.0
				* @param	string qtdClique
				* @since	14/06/2012
				* @return	Propaganda
			*/
			public Propaganda setQtdClique(string qtdClique){
				 this.setData("qtd_clique",qtdClique);
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
				* @return	Propaganda
			*/
			public Propaganda setCriadoEm(string criadoEm){
				 this.setData("criado_em",criadoEm);
				 return this;
			}

			/**
			 * Retorna o campo: iniciar_em_data
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getIniciarEmData(){
			 return this.getData("iniciar_em_data","");
		}

			/**
				* Seta o campo: iniciar_em_data
				* @author	Gabriel
				* @version	1.0
				* @param	string iniciarEmData
				* @since	14/06/2012
				* @return	Propaganda
			*/
			public Propaganda setIniciarEmData(string iniciarEmData){
				 this.setData("iniciar_em_data",iniciarEmData);
				 return this;
			}

			/**
			 * Retorna o campo: data_inicia
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getDataInicia(){
			 return this.getData("data_inicia","");
		}

			/**
				* Seta o campo: data_inicia
				* @author	Gabriel
				* @version	1.0
				* @param	string dataInicia
				* @since	14/06/2012
				* @return	Propaganda
			*/
			public Propaganda setDataInicia(string dataInicia){
				 this.setData("data_inicia",dataInicia);
				 return this;
			}

			/**
			 * Retorna o campo: data_finaliza
			 * @author	Gabriel
			 * @version	1.0
			 * @since	14/06/2012
			 * @return	string
			*/
		public string getDataFinaliza(){
			 return this.getData("data_finaliza","");
		}

			/**
				* Seta o campo: data_finaliza
				* @author	Gabriel
				* @version	1.0
				* @param	string dataFinaliza
				* @since	14/06/2012
				* @return	Propaganda
			*/
			public Propaganda setDataFinaliza(string dataFinaliza){
				 this.setData("data_finaliza",dataFinaliza);
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
				* @return	Propaganda
			*/
			public Propaganda setStatus(string status){
				 this.setData("status",status);
				 return this;
			}

		 }
	 }