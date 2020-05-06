<?php
/**
 * Created by PhpStorm.
 * User: Esma_
 * Date: 26-3-2019
 * Time: 09:31
 */





if ($_SERVER ['REQUEST_METHOD'] != 'POST')
{
    header('location: index.php');
    exit;
}

require 'config.php';

if ($_POST['type'] == 'create') {

    $title = $_POST['title'];
    $description =  $_POST['description'];
    $ingredients = $_POST['ingredients'];
    $picture_url = $_POST['picture_url'];

    $sql = "INSERT INTO recipes (title, description, ingredients, picture_url) VALUES (:title, :description, :ingredients, :picture_url)";
    $prepare = $db->prepare($sql);
    $prepare->execute([
        ':title' => $title,
        ':description' => $description,
        ':ingredients' => $ingredients,
        ':picture_url' => $picture_url
    ]);

    //$db->query($sql);
    $msg = "Contact is succesvol aangemaakt!";
    header("location: index.php?msg=$msg");
    exit;
}

if ($_POST['type'] == 'delete') {
    $id = $_GET['id'];

    $sql = "DELETE from recipes WHERE id = :id";
    $prepare =$db->prepare($sql);
    $prepare->execute([
        ':id' => $id
    ]);

    $msg = "Contact is succesvol verwijderd";
    header("location: index.php?msg=$msg");
    exit;
}

if ($_POST['type'] == 'edit') {
    echo "<pre>";
    var_dump($_POST);
    var_dump($_FILES);
    echo "</pre>";

    $title =  htmlentities($_POST['title']);
    $title =  trim($_POST['title']);
    $description =  htmlentities($_POST['description']);
    $description =  trim($_POST['description']);
    $ingredients =  htmlentities($_POST['ingredients']);
    $ingredients =  trim($_POST['ingredients']);
    $picture_url = $_FILES['picture_url']['name'];
    $id = $_GET['id'];

    $sql = "UPDATE recipes SET 
    title = :title,
    description = :description,
    ingredients = :ingredients,
    picture_url = :picture_url,
    updated_at = NOW()
    WHERE id = :id";
    $prepare =$db->prepare($sql);
    $prepare->execute([
        ':title' => $title,
        ':description' => $description,
        ':ingredients' => $ingredients,
        ':picture_url' => $picture_url,
        ':id' => $id
    ]);

    $msg = "Contact is succesvol update";
    header("location: index.php?msg=$msg");
    exit;
}