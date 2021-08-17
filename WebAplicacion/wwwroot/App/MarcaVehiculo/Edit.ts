namespace MarcaVehiculoEdit {

    var Entity = $("#AppEdit").data("entity");

    var Formulario = new Vue({

        data: {
            Formulario: "#FormEdit",
            Entity: Entity,
        },

        methods: {

            Save() {
                if (BValidateData(this.Formulario)) {
                    Loading.fire("Guardando...");
                    App.AxiosProvider.MarcaVehiculoGuardar(this.Entity).then(
                        data => {
                            Loading.close();

                            if (data.CodeError == 0) {
                                Toast.fire({ title: "Se guardó satisfactoriamente", icon: "success" }).then(() => window.location.href = "MarcaVehiculo/Grid");

                            } else {

                                Toast.fire({ title: data.MsgError, icon: "error" })
                            }

                        }
                    );

                }
                else {
                    Toast.fire({ title: "Por favor complete los campos requeridos", icon: "error" });
                }

            }
        },

        mounted() {

            CreateValidator(this.Formulario);
        }

    }
    );

    Formulario.$mount("#AppEdit");


}