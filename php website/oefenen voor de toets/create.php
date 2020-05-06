<?php
/**
 * Created by PhpStorm.
 * User: Esma_
 * Date: 26-3-2019
 * Time: 09:30
 */

require 'Header.php'

?>

    <form action="contactContcoller.php" method="post">
        <input type="hidden" name="type" value="create">
        <div class="form-group">
            <label for="name">Username</label>
            <input type="text" name="username">
        </div>

        <div class="form-group">
            <label for="email">password</label>
            <input type="password" name="password">
        </div>

        <div class="form-group">
            <label for="email">Email</label>
            <input type="email" name="email">
        </div>

        <div class="form-group">
            <input type="submit" value="Create new contact">
        </div>
    </form>

<?php require 'footer.php'; ?>