<?php
/**
 * Created by PhpStorm.
 * User: Esma_
 * Date: 26-3-2019
 * Time: 09:31
 */





if ($_SERVER ['REQUEST_METHOD'] != 'POST')
{
    header('location: dbtest.php');
    exit;
}

require 'config.php';

if ($_POST['type'] == 'create') {

    $username = $_POST['username'];
    $password = $_POST['password'];
    $email = $_POST['email'];

// Alleen als het niet werkt//
//var_dump($_POST); exit;

    if (!filter_var($_POST["email"], FILTER_VALIDATE_EMAIL)) {
        echo "Invalid email format";
    }

    $sql = "INSERT INTO account (username, password, email) VALUES (:username, :password, :email)";

    $prepare = $db->prepare($sql);
    $prepare->execute([
        ':username' => $username,
        ':password' => $password,
        ':email' => $email,
    ]);

    //$db->query($sql);
    $msg = "Contact is succesvol aangemaakt!";
    header("location: dbtest.php?msg=$msg");
    exit;
}

if ($_POST['type'] == 'delete') {
    $id = $_GET['id'];

    $sql = "DELETE from account WHERE id = :id";
    $prepare =$db->prepare($sql);
    $prepare->execute([
        ':id' => $id
    ]);

    $msg = "Contact is succesvol verwijderd";
    header("location: dbtest.php?msg=$msg");
    exit;
}

if ($_POST['type'] == 'edit') {

    $username = htmlentities($_POST['username']);
    $password =  htmlentities($_POST['password']);
    $email =  htmlentities($_POST['email']);
    $id = $_GET['id'];

    $sql = "UPDATE account SET 
    username = :username,
    password = :password,
    email = :email
    WHERE id = :id";
    $prepare =$db->prepare($sql);
    $prepare->execute([
        ':username' => $username,
        'password' => $password,
        'email' => $email,
        ':id' => $id
    ]);

    $msg = "Contact is succesvol update";
    header("location: dbtest.php?msg=$msg");
    exit;
}