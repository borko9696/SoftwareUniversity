<!doctype html>
<html lang="bg">
<head>
    <meta charset="UTF-8">
    <title>Print Numbers from 1 to N</title>
</head>
<body>
<?php if (isset($_GET['num'])) {
    $firstNum = $_GET['num'];
    for ($i = 1; $i <= $firstNum; $i++){
        echo $i . " ";
    }
}
?>

<form>
    <div>First Number:</div>
    <input type="number" name="num" />
    <div><input type="submit" /></div>
</form>
</body>
</html>