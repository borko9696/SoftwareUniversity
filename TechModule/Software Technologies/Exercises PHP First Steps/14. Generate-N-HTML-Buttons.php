<!doctype html>
<html lang="bg">
<head>
    <meta charset="UTF-8">
    <title>Generate N HTML Buttons</title>
</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit" />
</form>

<?php if (isset($_GET['num'])){
    $num = intval($_GET['num']);
    for ($i = 1; $i <= $num; $i++){
        echo "<button>$i</button>";
    }
}
?>

</body>
</html>