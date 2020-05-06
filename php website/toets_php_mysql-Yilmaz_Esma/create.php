<?php
/**
 * Created by PhpStorm.
 * User: Esma_
 * Date: 26-3-2019
 * Time: 09:30
 */

require 'header.php'

?>

    <form action="contactContcoller.php" method="post">
        <input type="hidden" name="type" value="create">
        <div class="form-group">
            <label for="name">Titel</label>
            <input type="text" name="title">
        </div>

        <div class="form-group">
            <label for="desctription">Beschrijving</label>
            <input type="text" name="description">
        </div>

        <div class="form-group">
            <label for="ingrediënt">Ingrediënten</label>
            <input type="text" name="ingredients">
        </div>

        <div class="form-group">
            <label for="picture">plaatje</label>
            <input type="file" name="picture_url">
        </div>

        <div class="form-group">
            <input type="submit" value="Create new recept">
        </div>
    </form>

<?php require 'footer.php'; ?>