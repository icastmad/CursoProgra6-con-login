namespace VehiculoEdit {

    var Entity = $("#AppEdit").data("entity");

    var Formulario = new Vue({

        data: {
            Formulario: "#FormEdit",
            Entity: Entity,
          
        },

        methods: {
           RefrescarValidaciones() {
                    BValidateData(this.Formulario);
            },

            VehiculoServicio(entity) {
                console.log(entity);
                if (entity.VehiculoId == null) {
                    return App.AxiosProvider.VehiculoGuardar(entity);
                } else {
                    return App.AxiosProvider.VehiculoActualizar(entity);
                }
            },

            Save() {
                if (BValidateData(this.Formulario)) {
                    Loading.fire("Guardando...");
                    this.VehiculoServicio(this.Entity).then(
                        data => {
                            Loading.close();

                            if (data.CodeError == 0) {
                                Toast.fire({ title: "Se guardó satisfactoriamente", icon: "success" }).then(() => window.location.href = "Vehiculo/Grid");

                            } else {

                                Toast.fire({ title: data.MsgError, icon: "error" });
                            }

                        }).catch (c => console.log(c));
                    
                }
                else {
                    Toast.fire({ title: "Por favor complete los campos requeridos", icon: "error" });
                }

            }

        },


        mounted() {

            CreateValidator(this.Formulario);
        },

    }
    );

    Formulario.$mount("#AppEdit");
}