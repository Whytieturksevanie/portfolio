<?php
/**
 * Created by PhpStorm.
 * User: Esma_
 * Date: 26-3-2019
 * Time: 09:33
 */


require 'header.php';

$id = $_GET['id'];
$sql = "SELECT * fROM recipes WHERE id = :id";
$prepare = $db->prepare($sql);
$prepare->execute([
    ':id' => $id
]);

$contacts = $prepare->fetch(PDO::FETCH_ASSOC);

?>

    <form action="contactContcoller.php?id=<?=$id?>" method="post" enctype="multipart/form-data">
        <input type="hidden" name="type" value="edit">
        <div class="form-group">
            <label for="title">Titel</label>
            <input type="text" name="title" id="title" value="<?= $contacts['title'] ?>">
        </div>

        <div class="form-group">
            <label for="description">Beschrijving</label>
            <input type="text" name="description" id="description" value="<?= $contacts['description'] ?>">
        </div>

        <div class="form-group">
            <label for="ingredients">ingrediënten</label>
            <input type="text" name="ingredients" id="ingredients" value="<?= $contacts['ingredients'] ?>">
        </div>

        <div class="form-group">
            <label for="picture_url">picture_url</label>
            <input type="file" name="picture_url" id="picture_url" accept="image/png, image/jpeg" value="<?= $contacts['picture_url']  ?>">
        </div>

        <div class="form-group">
            <input type="submit" value="Edit recipes">
        </div>
    </form>

<?php require 'footer.php'; ?>