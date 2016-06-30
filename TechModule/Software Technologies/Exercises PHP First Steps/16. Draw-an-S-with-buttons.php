<!doctype html>
<html lang="bg">
<head>
    <meta charset="UTF-8">
    <title>Draw an S with buttons</title>
</head>
<body>
<?php
    for ($i = 0; $i<5; $i++){
        echo "<button style='background-color: blue'>1</button>";
    }

    for ($i = 0; $i<3; $i++){
        echo "<br>";
        for ($y = 0; $y<5; $y++){
            if ($y == 0){
                echo "<button style='background-color: blue'>1</button>";
            } else {
                echo "<button>0</button>";
            }
        }
    }
    echo "<br>";
    for ($i = 0; $i<5; $i++){
        echo "<button style='background-color: blue'>1</button>";
    }

    for ($i = 0; $i<3; $i++){
        echo "<br>";
        for ($y = 0; $y<=4; $y++){
            if ($y == 4){
                echo "<button style='background-color: blue'>1</button>";
            } else {
            echo "<button>0</button>";
            }
        }
    }

    echo "<br>";
    for ($i = 0; $i<5; $i++){
        echo "<button style='background-color: blue'>1</button>";
    }

?>
</body>
</html>