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
if (isset($_GET['input']) && isset($_GET['delimiter'])) {
    $elements = array_map('trim', explode("\r", $_GET['input']));

    $name = "";
    $surname = "";
    $age = "";
    $grade = "";
    $date = "";
    $town = "";

    foreach ($elements as $element) {
        $args = explode($_GET['delimiter'], $element);

        switch ($args[0]){
            case "name": $name = $args[1]; break;
            case "surname": $surname = $args[1]; break;
            case "age": $age = $args[1]; break;
            case "grade": $grade = $args[1]; break;
            case "date": $date = $args[1]; break;
            case "town": $town = $args[1]; break;
        }
    }

    $student = array("name"=>$name,"surname"=>$surname,"age"=>intval($age),"grade"=>floatval($grade),"date"=>$date,"town"=>$town);
    echo json_encode($student, JSON_UNESCAPED_SLASHES);
}
?>