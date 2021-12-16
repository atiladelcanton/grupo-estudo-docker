<?php

use App\Http\Controllers\{
    ClientController
};
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| API Routes
|--------------------------------------------------------------------------
|
| Here is where you can register API routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| is assigned the "api" middleware group. Enjoy building your API!
|
*/

Route::get('/version',function(){
    return response()->json(['versao'=>'1.0.0','status'=>'up'],200);
});

Route::get('/client',[ClientController::class,'index']);
Route::get('/client/{id}',[ClientController::class,'show']);
Route::delete('/client/{id}',[ClientController::class,'destroy']);
Route::post('/client',[ClientController::class,'store']);
Route::put('/client/{id}',[ClientController::class,'update']);
