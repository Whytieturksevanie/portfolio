<?php
/**
 * Created by PhpStorm.
 * User: Esma_
 * Date: 26-3-2019
 * Time: 09:25
 */

$dbHost = 'localhost';
$dbName = 'accounts';
$dbUser = 'root';
$dbPass = '';

$db = new PDO(
    "mysql:host=$dbHost;dbname=$dbName",
    $dbUser,
    $dbPass
);

$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);