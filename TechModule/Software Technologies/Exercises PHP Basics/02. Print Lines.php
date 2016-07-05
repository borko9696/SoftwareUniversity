<html>
<head>

</head>
<body>
<form>
    Input: <textarea name="lines"></textarea>
    <input type="submit">
</form>
</body>
</html>

<?php
if (isset($_GET['lines'])){
    $array = array_map('trim', explode("\r", $_GET['lines']));
    foreach ($array as $item){
        if ($item == "Stop"){
            break;
        }

        echo $item."<br>";
    }
}
?>