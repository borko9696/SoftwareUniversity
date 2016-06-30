<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit" />
</form>
<?php if (isset($_GET['num'])){
    $num = intval($_GET['num']);
    $array = array(1,1,2);
    for ($i = 4; $i <= $num; $i++){
        $sum = 0;
        $sum += $array[sizeof($array) - 1] + $array[sizeof($array) - 2] +  $array[sizeof($array) - 3];
        array_push($array, $sum);
    }

    foreach ($array as $item){
        echo $item." ";
    }
}

?>
</body>
</html>