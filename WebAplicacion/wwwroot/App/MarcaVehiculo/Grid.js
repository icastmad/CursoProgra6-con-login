"use strict";
var MarcaVehiculoGrid;
(function (MarcaVehiculoGrid) {
    function OnClickEliminar(id) {
        ComfirmAlert("Desea eliminar el registro?", "Eliminar", "warning", "#3085d6", "#d33")
            .then(function (result) {
            if (result.isConfirmed) {
                Loading.fire("Borrando...");
                App.AxiosProvider.MarcaVehiculoEliminar(id).then(function (data) {
                    Loading.close();
                    if (data.CodeError == 0) {
                        Toast.fire({ title: "Se eliminó correctamente", icon: "success" }).then(function () { return window.location.reload(); });
                    }
                    else {
                        Toast.fire({ title: data.MsgError, icon: "error" });
                    }
                });
            }
        });
    }
    MarcaVehiculoGrid.OnClickEliminar = OnClickEliminar;
    $("#GridView").DataTable();
})(MarcaVehiculoGrid || (MarcaVehiculoGrid = {}));
//# sourceMappingURL=Grid.js.map