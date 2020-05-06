<?php
/**
 * Created by PhpStorm.
 * User: Esma_
 * Date: 26-3-2019
 * Time: 09:36
 */

// detailgegevens van 1 specifieke contact

require 'header.php';
$id = $_GET['id'];
$sql = "SELECT * FROM recipes WHERE id = :id";
$prepare = $db->prepare($sql);
$prepare->execute([
    ':id' => $id
]);

//$prepare = $db->prepare($sql);
$recipes = $prepare->fetch(PDO::FETCH_ASSOC);

?>

    <h1>Title: <?php echo $recipes ['title']; ?></h1>
    <p>Description: <?php echo $recipes ['description']; ?></p>
    <p>Ingredients: <?php echo $recipes ['ingredients']; ?></p>
    <p>Picture_url: <?php echo "<img src= img/".$recipes['picture_url']." alt='photo of recipes'/>";?></p>

    <form action="contactContcoller.php?id=<?=$id;?>" method="post">
        <input type="hidden" name="type" value="delete">
        <input type="submit" value="Delete recept">
    </form>

    <a href="edit.php?id=<?=$id?>"> EDIT THIS recept</a>

<?php

require 'footer.php';

?>