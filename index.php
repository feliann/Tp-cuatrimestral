 <?php 
    include_once("./calculadora.php");
?>

<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Calculadora de daño</title>
</head>
<body>
    <h2>Calculadora de daño</h2>
    <form action= "./index.php" method="POST">

    <label for="numero">Vida actual</label>
    <input type ="numero" name= "vida"> <br><br>
    
    <label for="ataque">seleccione el tipo de daño</label>
    <select name="ataque">
        <option value="golpe">Golpe</option>
        <option value="patada">Patada</option>
        <option value="espadazo">Espadazo</option>
    </select> <br><br>

    <label for="pocion">seleccione el tipo de pocion</label> <br>
    <input type="radio" name="pocion" value="1"> Veneno <br>
    <input type="radio" name="pocion" value="2"> Fuego <br>
    <input type="radio" name="pocion" value="3"> Adormecimiento <br>

    <input type="submit" value="Calcular">
</form>

    <?php
         if(isset($_POST["ataque"])){
            echo("<h3> Vida restante: " . calcularVida($_POST["vida"], $_POST["ataque"], $_POST["pocion"]) . "</h3>");
         }
    ?>
</body>
</html>