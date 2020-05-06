<?php
/**
 * Created by PhpStorm.
 * User: Esma_
 * Date: 26-3-2019
 * Time: 09:36
 */

// detailgegevens van 1 specifieke contact
require 'Header.php';
$id = $_GET['id'];
$sql = "SELECT * FROM account WHERE id = :id";
$prepare = $db->prepare($sql);
$prepare->execute([
    ':id' => $id
]);

//$prepare = $db->prepare($sql);
$contact = $prepare->fetch(PDO::FETCH_ASSOC);

?>

    <h1><?php echo htmlentities($contact ['username']); ?></h1>
    <p>password: <?php echo $contact ['password']; ?></p>
    <p>email: <?php echo $contact ['email']; ?></p>

    <form action="contactContcoller.php?id=<?=$id;?>" method="post">
        <input type="hidden" name="type" value="delete">
        <input type="submit" value="Delete user">
    </form>

    <a href="edit.php?id=<?=$id?>"> EDIT THIS CONTACT</a>

<?php

require 'footer.php';

?>