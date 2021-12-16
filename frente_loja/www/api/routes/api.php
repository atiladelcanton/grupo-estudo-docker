<?php

use App\Http\Controllers\ClientsController;
use Illuminate\Support\Facades\Route;

Route::get('/version', function () {
    return response()->json(['versao' => '1.0.0', 'status' => 'up'], 200);
});
Route::resource('/clients', ClientsController::class);
