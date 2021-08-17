"use strict";
var Registrarse;
(function (Registrarse) {
    var Entity = $("#AppRegistrar").data("entity");
    var Formulario = new Vue({
        data: {
            Formulario: "#FromRegistrarse",
            Entity: Entity,
        },
        methods: {
            Save: function () {
                if (BValidateData(this.Formulario)) {
                    Loading.fire("Registrandose...");
                    App.AxiosProvider.UsuarioRegistrar(this.Entity).then(function (data) {
                        Loading.close();
                        if (data.CodeError == 0) {
                            window.location.href = "/";
                        }
                        else {
                            Toast.fire({ title: data.MsgError, icon: "error" });
                        }
                    });
                }
                else {
                    Toast.fire({ title: "Por favor complete los campos requeridos!", icon: "error" });
                }
            }
        },
        mounted: function () {
            CreateValidator(this.Formulario);
        }
    });
    Formulario.$mount("#AppRegistrar");
})(Registrarse || (Registrarse = {}));
//# sourceMappingURL=Registrarse.js.map