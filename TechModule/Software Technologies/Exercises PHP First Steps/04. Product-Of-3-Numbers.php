<!doctype html>
<html lang="bg">
<head>
    <meta charset="UTF-8">
    <title>Multiply / Divide a Number by a Given Second Number</title>
</head>
<body>
<?php if (isset($_GET['num1']) && isset($_GET['num2']) && isset($_GET['num3'])) {
    $firstNum = $_GET['num1'];
    $secondNum = $_GET['num2'];
    $thirdNum = $_GET['num3'];
    $array = array($firstNum,$secondNum,$thirdNum);
    $countNegative = 0;
    foreach ($array as $num){
        if ($num <= 0 ){
            $countNegative++;
        }
    }

    if ($countNegative % 2 == 0){
        echo "Positive";
    } else {
        echo "Negative";
    }

}
?>

<form>
    <div>First Number:</div>
    <input type="number" name="num1" />
    <div>Second Number:</div>
    <input type="number" name="num2" />
    <div>Third Number:</div>
    <input type="number" name="num3" />
    <div><input type="submit" /></div>
</form>
</body>
</html>