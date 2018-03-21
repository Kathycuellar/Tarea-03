<?php 
	if ($_POST ["valor1"] !="" and $_POST ["valor2"]!=""){
        if ($_POST["calculando"] == "corri")
        {
			print ($resultado = $_POST ["valor1"] / $_POST ["valor2"]);
			print ('<br /><a href="calculadora.php">Volver</a>');
		} 
    }
     else 
    {
		print("Ingresa alg&uacute;n valor");
		print ('<br /><a href="calculando.php">Volver</a>');
	}
?>