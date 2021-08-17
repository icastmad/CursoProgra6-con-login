"use strict";
var CreateValidator = function (Formulario) {
    $(Formulario).bootstrapValidator('destroy');
    $(Formulario).bootstrapValidator({
        feedbackIcons: {
            valid: 'bx bx-check',
            invalid: 'bx bx-x',
            validating: 'bx bx-refresh'
        }
    });
};
var BValidateData = function (Formulario) {
    CreateValidator(Formulario);
    $(Formulario).bootstrapValidator('validate');
    var ValidForm = $(Formulario).data('bootstrapValidator').isValid();
    return ValidForm;
};
var BvReset = function (Formulario) {
    $(Formulario).bootstrapValidator('resetForm', true);
};
//# sourceMappingURL=FormValidateConfig.js.map