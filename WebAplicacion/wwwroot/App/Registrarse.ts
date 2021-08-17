namespace Registrarse {



    var Entity = $("#AppRegistrar").data("entity");

    var Formulario = new Vue({
        data: {
            Formulario: "#FromRegistrarse",
            Entity: Entity,

        },

        methods: {

            Save() {

                if (BValidateData(this.Formulario)) {

                    Loading.fire("Registrandose...");

                    App.AxiosProvider.UsuarioRegistrar(this.Entity).then(data => {

                        Loading.close();

                        if (data.CodeError == 0) {
                            window.location.href = "/"
                        } else {
                            Toast.fire({ title: data.MsgError, icon: "error" });

                        }


                    });
                } else {
                    Toast.fire({ title: "Por favor complete los campos requeridos!", icon: "error" });
                }

            }


        },
        mounted() {


            CreateValidator(this.Formulario);

        }

    });

    Formulario.$mount("#AppRegistrar")


}