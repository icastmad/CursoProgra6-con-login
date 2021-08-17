namespace Login {



    var Entity = $("#AppLogin").data("entity");

    var Formulario = new Vue({
        data: {
            Formulario: "#LoginForm",
            Entity: Entity,

        },

        methods: {

            Login() {

                if (BValidateData(this.Formulario)) {

                    Loading.fire("Ingresando...");

                    App.AxiosProvider.UsuarioLogin(this.Entity).then(data => {

                        Loading.close();
                        console.log(data);
                        if (data.CodeError == 0) {
                            window.location.href = "/"
                        } else {
                            Toast.fire({ title: data.MsgError, icon: "error" });

                        }


                    }).catch(c => console.log(c));
                } else {
                    Toast.fire({ title: "Por favor complete los campos requeridos!", icon: "error" });
                }

            }


        },
        mounted() {


            CreateValidator(this.Formulario);

        }

    });

    Formulario.$mount("#AppLogin")


}