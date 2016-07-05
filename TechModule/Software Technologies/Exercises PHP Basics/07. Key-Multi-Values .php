<html>
<head>

</head>
<body>
<form>
    Delimiter: <input type="text" name="delimiter">
    Input: <textarea name="key-value-pairs"></textarea>
    Target Key: <input type="text" name="target-key">
    <input type="submit">
</form>
</body>
</html>

<?php if (isset($_GET['delimiter']) && isset($_GET['key-value-pairs']) && isset($_GET['target-key'])){
    $input = array_map('trim', explode("\r", $_GET['key-value-pairs']));
    $delimiter = $_GET['delimiter'];
    $target_key =  $_GET['target-key'];

    $result = [];

    foreach ($input as $item) {
        $elements = explode("$delimiter", $item);
        if (!isset($result[$elements[0]])){
            $result[$elements[0]] = [];
        }
        array_push($result[$elements[0]],$elements[1]);
    }

    if (isset($result[$target_key])){
        echo implode("<br>", $result[$target_key]);
    } else {
        echo "None";
    }
}

?>