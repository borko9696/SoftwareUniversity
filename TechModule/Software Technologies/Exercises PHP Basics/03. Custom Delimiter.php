<html>
<head>

</head>
<body>
<form>
    Delimiter: <input type="text" name="delimiter">
    Input: <textarea name="lines"></textarea>
    <input type="submit">
</form>
</body>
</html>

<?php
if (isset($_GET['lines']) && isset($_GET['delimiter'])){
    $delimiter = $_GET['delimiter'];
    $numbers = $_GET['lines'];

    $array = explode($delimiter, $numbers);
    $array = array_map('trim', $array);

    foreach ($array as $item) {
        if ($item == "Stop"){
            break;
        }
        echo $item."<br>";
    }

}
?>