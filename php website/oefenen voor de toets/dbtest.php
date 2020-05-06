<?php
require 'header.php';
$sql = "SELECT * FROM account";
$query = $db->query($sql);
$accounts = $query->fetchAll(PDO::FETCH_ASSOC);

?>

<?php

if ( isset ( $_GET['msg'] ) )
{
    echo "<p> {$_GET['msg']} </p>";
}

?>


    <h1>Accounts</h1>
    <ul>
        <?php
            foreach ($accounts as $account) {
                $name = htmlentities( $account['username']);
            //echo '<li>' . $contact['username'] . ': ' . $contact['email'] . '</li>';
                echo "<li><a href='./detail.php?id={$account['id']}'> $name </a> </li>";
            }
        ?>
    </ul>

<?php
//echo '<ul>';

//foreach ($accounts as $account) {
    //echo '<li>' . $account['username'] . ': ' . $account['email'] . '</li>';
   //echo "<li> ${account['username']} : ${account['email']}</li>";
//}

//echo '</ul>';

echo '<a href="create.php">Create new contact</a>';

//echo '<pre>';
//var_dump($accounts[0]['username']);

//echo $dbName;

require 'footer.php';
?>
