<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>RBG Table</title>
    <style>
        table * {
            border: 1px solid black;
            width: 50px;
            height: 50px;
        }
    </style>
</head>
<body>

<?php
    $red = 51;
    $blue = 51;
    $green = 51;

    echo "<table>";
    for ($i = 0; $i<6; $i++){
        if ($i == 0){
            echo " <tr><td>Red</td><td>Green</td><td>Blue</td></tr>";
        } else {
            $redColor = "rgb($red, 0, 0)";
            $blueColor = "rgb(0, 0, $blue)";
            $greenColor = "rgb(0, $green, 0)";
            echo "<tr><td style='background-color:$redColor'></td><td style='background-color:$greenColor'></td><td      style='background-color:$blueColor'></td></tr>";

            $red+=51;
            $blue+=51;
            $green+=51;
        }

    }
    echo "</table>";
?>
</body>
</html>