interface ResultBValidator {
    valid: boolean;
    message: string;
}

var bvAddValidators: (NombreAtribute: string, validate: (validator: any, $field: JQuery<HTMLElement>, options: any) => ResultBValidator) => void;


bvAddValidators = function (NombreAtribute: string, validateFun: (validator: any, $field: JQuery<HTMLElement>, options: any) => ResultBValidator) {
    eval(`$.fn.bootstrapValidator.validators.${NombreAtribute}={validate:function (validator, $field, options) { return  validateFun(validator,$field,options); } };`); 
}

