<?php 


function nomeJunto($string){

  $nomeQuebrado = explode("_",$string);
  
  $nomeJunto = "";
  foreach($nomeQuebrado as $pedaco){
      $nomeJunto.= ucfirst($pedaco);
  }
  return $nomeJunto;
}

function classeAbre($classe){
	$txt ="";
	$txt.="\n\t using System;";
	$txt.="\n\t using System.Collections.Generic;";
	$txt.="\n\t using System.Linq;";
	$txt.="\n\t using System.Web;";

	$txt.="\n\t namespace Chronos.Model.Orm";
	$txt.="\n\t {";
	$txt.="\n\t public class ".$classe." : Model.Orm.Core";
	$txt.="\n\t\t {";
	return $txt;
}

function classeFecha(){
	$txt = "\n";
	$txt.= "\n\t\t }";
	$txt.= "\n\t }";
	return $txt;
}


function constr($table,$primary,$classe){
 $txt = "\n\n\t\t/**";
  $txt.= "\n\t\t * Funчуo que carrega a classe";
  $txt.= "\n\t\t * @author\tGabriel";
  $txt.= "\n\t\t * @version\t1.0";
  $txt.= "\n\t\t * @since\t14/06/2012";
  $txt.= "\n\t\t*/";
  $txt.= "\n\t\tpublic ".$classe."(){";
  $txt.= "\n\t\t\tthis.tableName".'= "'.$table.'";';
  $txt.= "\n\t\t\tthis.primaryKey".'= "'.$primary.'";';
  $txt.= "\n\t\t}";
  return $txt;

}

function get($campo){

	if($campo != 'id'){
	  $txt = "\n\n\t\t\t/**";
	  $txt.= "\n\t\t\t * Retorna o campo: ".$campo;
	  $txt.= "\n\t\t\t * @author\tGabriel";
	  $txt.= "\n\t\t\t * @version\t1.0";
	  $txt.= "\n\t\t\t * @since\t14/06/2012";
	  $txt.= "\n\t\t\t * @return\tstring";
	  $txt.= "\n\t\t\t*/";
  
	  $nomeFunction = nomeJunto($campo);
	  
	  $txt.= "\n\t\tpublic string get".$nomeFunction."(){";
	  $txt.= "\n\t\t\t return this.".'getData("'.$campo.'","");';
	  $txt.= "\n\t\t}";
	  $txt.= "";
	  
	  return $txt;
  }
  return '';
}






function set($campo,$nomeClasse	){

 	if($campo != 'id'){
		  $nomeQuebrado = explode("_",$campo);
		  
		  $nomeFunction = "";
		  foreach($nomeQuebrado as $pedaco){
			  $nomeFunction.= ucfirst($pedaco);
		  }
		  $var = lcfirst($nomeFunction);
		  $txt = "\n\n\t\t\t/**";
		  $txt.= "\n\t\t\t\t* Seta o campo: ".$campo;
		  $txt.= "\n\t\t\t\t* @author\tGabriel";
		  $txt.= "\n\t\t\t\t* @version\t1.0";
		  $txt.= "\n\t\t\t\t* @param\tstring ".$var;
		  $txt.= "\n\t\t\t\t* @since\t14/06/2012";
		  $txt.= "\n\t\t\t\t* @return\t".$nomeClasse;
		  $txt.= "\n\t\t\t*/";
		  

		  $txt.= "\n\t\t\tpublic ".$nomeClasse." set".$nomeFunction."(string ".$var."){";
		  $txt.= "\n\t\t\t\t this.".'setData("'.$campo.'",'.$var.');';
		  $txt.= "\n\t\t\t\t return this;";
		  $txt.= "\n\t\t\t}";
		  return $txt;
  }
  return '';
}



$link = mysql_connect('localhost', 'root', '');
if (!$link) {
    die('Not connected : ' . mysql_error());
}

// make foo the current db
$db_selected = mysql_select_db('chronus', $link);
if (!$db_selected) {
    die ('Can\'t use foo : ' . mysql_error());
}

$sql = "SHOW tables from chronus;";
$resultTABLE = mysql_query($sql);

while($tabelas = mysql_fetch_row($resultTABLE)){
	$table = $tabelas[0];
	$classe = nomeJunto($table);
	$primary = 'id';


	$result = mysql_query("show columns from ".$table);
	$count = 0;

	$fp = fopen('model/'.$classe.".cs", "w");

	fwrite($fp, classeAbre($classe));


	fwrite($fp,constr($table,$primary,$classe));
	while($row = mysql_fetch_row($result)){
    
		// Escreve "exemplo de escrita" no bloco1.txt
		$escreve = fwrite($fp, get($row[0]));
		$escreve = fwrite($fp, set($row[0],$classe));
	  
	}
	fwrite($fp,classeFecha());
	// Fecha o arquivo
	fclose($fp);

}