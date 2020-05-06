<?php
/**
 * Created by PhpStorm.
 * User: Esma_
 * Date: 26-3-2019
 * Time: 09:33
 */


require 'Header.php';

$id = $_GET['id'];
$sql = "SELECT * fROM account WHERE id = :id";
$prepare = $db->prepare($sql);
$prepare->execute([
    ':id' => $id
]);

$contacts = $prepare->fetch(PDO::FETCH_ASSOC);

?>

    <form action="contactContcoller.php?id=<?=$id?>" method="post">
        <input type="hidden" name="type" value="edit">
        <div class="form-group">
            <label for="username">Username</label>
            <input type="text" name="username" id="username" value="<?= $contacts['username'] ?>">
        </div>

        <div class="form-group">
            <label for="email">passsword</label>
            <input type="password" name="password" id="email" value="<?= $contacts['password'] ?>">
        </div>

        <div class="form-group">
            <label for="city">city</label>
            <input type="email" name="email" id="email" value="<?= $contacts['email'] ?>">
        </div>

        <div class="form-group">
            <input type="submit" value="Edit contact">
        </div>
    </form>

<?php require 'footer.php'; ?>