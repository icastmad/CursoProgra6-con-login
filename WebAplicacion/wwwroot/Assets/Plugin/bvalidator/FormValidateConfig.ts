
var CreateValidator = function (Formulario:string) {
    $(Formulario).bootstrapValidator('destroy');
    $(Formulario).bootstrapValidator({
        feedbackIcons: {
            valid: 'bx bx-check',
            invalid: 'bx bx-x',
            validating: 'bx bx-refresh'
        }
    });


}


var BValidateData = function (Formulario:string):boolean {

    CreateValidator(Formulario);
    $(Formulario).bootstrapValidator('validate');
    var ValidForm = $(Formulario).data('bootstrapValidator').isValid();

    return ValidForm;
}



var BvReset = function (Formulario:string) {
    $(Formulario).bootstrapValidator('resetForm', true);

}