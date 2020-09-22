<?php


class financier 
{

	public $capital;
	public $tauxMensuel;
	public $nbMois;
	public static $typeclient="particulier";
	//propriétés accesseur modifieur
//constructeur avec surchages( paramêtres) 
	public  function __construct($_kal,$_tauxAnnuel, $_annees)
	{
	$this->capital=$_kal;
	$this->tauxMensuel=(double)$_tauxAnnuel/(100*12);	
	$this->nbMois=$_annees*12;	
}

//methode d'instance
  
public function calculMensualite()
	{
		/*(1- pow((1+$tm),-$n) )*/
		$quotient=(1 - pow((1+$this->tauxMensuel),-$this->nbMois));
		$mensualite=($this->capital*$this->tauxMensuel)/$quotient;
		
	return $mensualite; 
		
	}

public static function affichemessage()

{
echo "type de client autorisé:".self::$typeclient."<br>";
}

public function afficherTableau()
	{
		echo '<table class="table table-dark table-hover" >
        <thead>
          <tr>
            <th>Numero de mois</th>
            <th>Part intérêt</th>
            <th>Part amortissement </th>
			 <th>Capital restant dû</th>
			 <th>Mensualité </th>
          </tr>
        </thead>
        <tbody>';
		
		$compteur=1;
			
   $mensualite=$this->calculMensualite();
 do{ 

 echo "<tr>"; 

 if($compteur==1)
	{
	$k=$this->capital;//calcul du capital restant dû
	}else 
	{$k=$k-$part_kal;
		}	
$part_int=$k*$this->tauxMensuel;//calcul de la part intérêt
	$part_kal=$mensualite-$part_int; //calcul de la part capital
	
	
	echo "<td>".round($compteur,2)."</td>";
	echo "<td>".round($part_int,2)."</td>";	
	echo "<td>".round($part_kal,2)."</td>";	
	echo "<td>".round($k,2)."</td>";
	echo "<td>".round($mensualite,2)."</td>";
	echo "</tr>"; 
	$compteur++; 
}while($compteur<=$this->nbMois); 
echo "</tbody></table>";

	}

}






?>