<html>
<head>

</head>
<body>
<form>
    Delimiter: <input type="text" name="delimiter">
    Array-size: <input type="text" name="array-size">
    Input: <textarea name="key-value-pairs"></textarea>
    <input type="submit">
</form>
</body>
</html>

<?php if (isset($_GET['delimiter']) && isset($_GET['array-size']) && isset($_GET['key-value-pairs'])){
    $array = array_map('trim',explode("\r", $_GET['key-value-pairs']));
    $result = new SplFixedArray(intval($_GET['array-size']));

    foreach ($array as $item){
        $delimiter = $_GET['delimiter'];
        $elements = explode($delimiter, $item);
        $result[intval($elements[0])] = $elements[1];
    }
    foreach ($result as $item) {
        if ($item == null){
            $item = 0;
        }
        echo $item."<br>";
    }
}
?>