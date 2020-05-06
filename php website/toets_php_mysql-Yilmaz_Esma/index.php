<?php
require 'header.php';
$sql = "SELECT * FROM recipes ORDER BY created_at";
$query = $db->query($sql);
$recipes = $query->fetchAll(PDO::FETCH_ASSOC);
//usort($recipes, "datefuction");

//function datefuction($a,$b) {
    //if (strtotime($a["created_at"]) < strtotime($b["created_at"]))
        //return true;
    //else
        //return false;
//}

//exit;
?>

<?php

if ( isset ( $_GET['msg'] ) )
{
    echo "<p> {$_GET['msg']} </p>";
}

?>
    <h1>Recepten</h1>
    <ul>
        <?php
            foreach ($recipes  as $recipe) {
                $title = htmlentities($recipe['title']);
                echo "<li><a href='./detail.php?id={$recipe['id']}'> $title </a> </li> <span style='color: grey'>-- " . $recipe['created_at'] . " </span>";
            }
        ?>
    </ul>

<?php

echo '<a href="create.php">Create new recept</a>';

require 'footer.php';
?>
