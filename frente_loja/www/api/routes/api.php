<?php

<<<<<<< HEAD
use App\Http\Controllers\{
    ClientController
};
use Illuminate\Http\Request;
=======
use App\Http\Controllers\ClientsController;
>>>>>>> b85d74e2999e5599fa52195440740140cbf4b69e
use Illuminate\Support\Facades\Route;

Route::get('/version', function () {
    return response()->json(['versao' => '1.0.0', 'status' => 'up'], 200);
});

Route::get('/client',[ClientController::class,'index']);
Route::get('/client/{id}',[ClientController::class,'show']);
Route::delete('/client/{id}',[ClientController::class,'destroy']);
Route::post('/client',[ClientController::class,'store']);
Route::put('/client/{id}',[ClientController::class,'update']);
