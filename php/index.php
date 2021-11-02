<?php 

$host = '';
$db = '';
$usuario ='';
$senha = '';

try{
	$conn  = new PDO("mysql:host={$host};dbname={$db}", "$usuario", "$senha");

	$data = $conn->query('selec campo from table....');

    foreach($data as $row) {
        print_r($row['campo']);
    }

} catch(PDOException $e) {
    echo 'ERROR: ' . $e->getMessage();
}

?>