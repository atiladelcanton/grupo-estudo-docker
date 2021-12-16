<?php

namespace App\Http\Requests;

use Illuminate\Foundation\Http\FormRequest;

class StoreUpdateClient extends FormRequest
{
    /**
     * Determine if the user is authorized to make this request.
     *
     * @return bool
     */
    public function authorize()
    {
        return true;
    }

    /**
     * Get the validation rules that apply to the request.
     *
     * @return array
     */
    public function rules()
    {

        $id = $this->id ?? '';

        return [
            'name'=>['required','min:3','max:50',"unique:clients,name,{$id},id"],
            'city'=>['required','min:3','max:50'],
            'street'=>['required','min:3','max:50'],
            'District'=>['required','min:3','max:50']
        ];
    }
}
