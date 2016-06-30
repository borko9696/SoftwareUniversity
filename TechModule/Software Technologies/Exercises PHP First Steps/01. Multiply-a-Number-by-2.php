<!doctype html>
<html lang="bg">
<head>
    <meta charset="UTF-8">
    <title>Multiply a Number by 2</title>
</head>
<body>
    <form>
        <input type="text" name="num" />
        <input type="submit" />
    </form>

<?php
if (isset($_GET['num'])){
    $num = intval(htmlspecialchars($_GET['num']));
    echo $num*2;
}
?>
</body>
</html>