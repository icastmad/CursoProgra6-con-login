namespace AgenciaEdit {

    var Entity = $("#AppEdit").data("entity");

    var Formulario = new Vue({

        data: {
            Formulario: "#FormEdit",
            Entity: Entity,
            CantonLista: [],
            DistritoLista: [],
        },

        methods: {
            OnChangeProvincia() {
                Loading.fire("Cargando...")

                App.AxiosProvider.AgenciaChangeProvincia(this.Entity).then(
                    data => {
                        Loading.close();
                        this.CantonLista=data
                    }

                );

            },

            OnChangeCanton() {
                Loading.fire("Cargando...")

                App.AxiosProvider.AgenciaChangeCanton(this.Entity).then(
                    data => {
                        Loading.close();
                        this.DistritoLista = data
                    }

                );

            },

            Save() {
                if (BValidateData(this.Formulario)) {
                    Loading.fire("Guardando...");
                    App.AxiosProvider.AgenciaGuardar(this.Entity).then(
                        data => {
                            Loading.close();

                            if (data.CodeError == 0) {
                                Toast.fire({ title: "Se guardó satisfactoriamente", icon: "success" }).then(() => window.location.href = "Agencia/Grid");

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
        },

        created() {
            this.OnChangeProvincia();
            this.OnChangeCanton();


        }

    }
    );

    Formulario.$mount("#AppEdit");
}