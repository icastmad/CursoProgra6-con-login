
// Type definitions for bootstrap-validator 0.11
// Project: https://github.com/1000hz/bootstrap-validator
// Definitions by: Brady Liles <https://github.com/BradyLiles>
// Definitions: https://github.com/DefinitelyTyped/DefinitelyTyped
// TypeScript Version: 2.3


interface ValidatorOptions {
    delay?: number;
    html?: boolean;
    disable?: boolean;
    focus?: boolean;
    feedback?: any;
    custom?: any;
}

interface feedbackIconsOption {
    valid?: string;
    invalid?: string;
    validating: string;
}

declare interface bootstrapValidatorOption {
    excluded?: string[];
    feedbackIcons?: feedbackIconsOption;
    fields?: any;
    message?: string;
    live?: string;
}
interface bvIsValid {
    isValid(): boolean;
}

interface JQuery {
    validator(options?: ValidatorOptions): JQuery;
    validator(command: string): JQuery;
    bootstrapValidator(): JQuery;
    bootstrapValidator(options?: bootstrapValidatorOption): JQuery;
    bootstrapValidator(accion: "destroy" | "validate" | "resetForm", required?: boolean): JQuery;
    data(bootrap: bvFormValid): bvIsValid;
}
