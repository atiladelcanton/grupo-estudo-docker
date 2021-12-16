<?php

namespace App\Services;

use App\Repositories\ClientRepository;

class ClientServices
{
    protected $repository;

    public function __construct()
    {
        $this->repository = new ClientRepository();
    }

    public function getClient()
    {
        return $this->repository->getAllClient();
    }

    public function createNewClient(array $data)
    {
        return $this->repository->createNewClient($data);
    }

    public function getClientById(int $id)
    {
        return $this->repository->getClientById($id);
    }

    public function delete(int $id)
    {
        return $this->repository->delete($id);
    }

    public function updateClientById(array $data, int $id)
    {
        return $this->repository->updateClientById($data,$id);
    }
}

?>
