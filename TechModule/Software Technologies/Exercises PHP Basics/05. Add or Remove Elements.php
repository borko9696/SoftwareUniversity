<html>
<head>

</head>
<body>
<form>
    Delimiter: <input type="text" name="delimiter">
    Input: <textarea name="commands"></textarea>
    <input type="submit">
</form>
</body>
</html>

<?php if (isset($_GET['delimiter']) && isset($_GET['commands'])){
    $commands = array_map('trim', explode("\r", $_GET['commands']));
    $delimiter = $_GET['delimiter'];

    $result = [];
    foreach ($commands as $command){
        $params = explode($delimiter, $command);

        if ($params[0] == "add"){
            $result = add($params[1], $result);
        } else {
            $result = delete($params[1], $result);
        }
    }
    foreach ($result as $item) {
        echo $item."<br>";
    }
}

function add($element , array $result) : array {
    array_push($result, $element);
    return $result;
}

function delete($position, array $result) : array {
    array_splice($result, intval($position), 1);
    return $result;
}
?>