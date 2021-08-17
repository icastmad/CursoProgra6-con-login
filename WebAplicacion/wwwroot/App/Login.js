"use strict";
var Login;
(function (Login) {
    var Entity = $("#AppLogin").data("entity");
    var Formulario = new Vue({
        data: {
            Formulario: "#LoginForm",
            Entity: Entity,
        },
        methods: {
            Login: function () {
                if (BValidateData(this.Formulario)) {
                    Loading.fire("Ingresando...");
                    App.AxiosProvider.UsuarioLogin(this.Entity).then(function (data) {
                        Loading.close();
                        console.log(data);
                        if (data.CodeError == 0) {
                            window.location.href = "/";
                        }
                        else {
                            Toast.fire({ title: data.MsgError, icon: "error" });
                        }
                    }).catch(function (c) { return console.log(c); });
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
    Formulario.$mount("#AppLogin");
})(Login || (Login = {}));
//# sourceMappingURL=Login.js.map