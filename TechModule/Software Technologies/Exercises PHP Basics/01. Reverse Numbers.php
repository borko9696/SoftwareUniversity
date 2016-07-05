<html>
<head>

</head>
<body>
<form>
    Delimiter: <input type="text" name="delimiter">
    Input: <textarea name="numbers"></textarea>
    <input type="submit">
</form>
</body>
</html>

<?php
 if (isset($_GET['numbers']) && isset($_GET['delimiter'])){
     $delimiter = $_GET['delimiter'];
     $numbers = $_GET['numbers'];

     $array = explode($delimiter, $numbers);
     $array = array_map('trim', $array);
     $array = array_reverse($array);

     foreach ($array as $item) {
            echo $item."<br>";
     }

 }
?>