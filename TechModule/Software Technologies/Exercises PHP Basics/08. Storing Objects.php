<html>
<head>

</head>
<body>
<form>
    Input:
    <br>
    <textarea name="input"></textarea>
    <br>
    Delimiter:
    <br>
    <input type="text" name="delimiter">
    <br>
    <input type="submit">
</form>
</body>
</html>

<?php
if (isset($_GET['input']) && isset($_GET['delimiter'])){
    $elements = array_map('trim', explode("\r",$_GET['input']));

    $students = [];
    foreach ($elements as $element) {
        $args = explode($_GET['delimiter'], $element);
        $grade = floatval($args[2]);
       echo "<ul><li>Name: $args[0]</li><li>Age: $args[1]</li><li>Grade: $grade</li></ul>";
    }

}
?>