<!DOCTYPE html>
<html>
	<head>
		<title>Calcular Corriente</title>
	</head>
	<body>
		<h1 align="center">Calculando Corriente</h1>
		<form align="center" action="resultado.php" method="post">
			<select name="calculando">

				<option align="center" value="corri">Corriente</option>

			</select><br />
			Ingresa el Voltaje:<br />
			<input type="text" name="valor1"><br />
			Ingresa la resistencia:<br />
			<input type="text" name="valor2"><br>
			<input type="reset" value="Borrar">
			<input type="submit" value="Enviar">
		</form>
	</body>
</html>