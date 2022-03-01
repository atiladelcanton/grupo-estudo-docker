<?php

namespace App\Repositories;

use App\Models\Client;

class ClientRepository
{
    private $entity;
    public function __construct()
    {
        $this->entity = new Client();
    }

    public function getAllClient()
    {
        return $this->entity->get();
    }

    public function createNewClient(array $data)
    {
         return $this->entity->create($data);
    }

    public function getClientById(int $id)
    {
         return $this->entity->findOrFail($id);
    }

    public function delete(int $id)
    {
        $client = $this->getClientById($id);
        return $client->delete();
    }

    public function updateClientById(array $data,int $id)
    {
        $client = $this->getClientById($id);
        return $client->update($data);
    }
}
