"use strict";
var AgenciaGrid;
(function (AgenciaGrid) {
    function OnClickEliminar(id) {
        ComfirmAlert("Desea eliminar el registro?", "Eliminar", "warning", "#3085d6", "#d33")
            .then(function (result) {
            if (result.isConfirmed) {
                Loading.fire("Borrando...");
                App.AxiosProvider.AgenciaEliminar(id).then(function (data) {
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
    AgenciaGrid.OnClickEliminar = OnClickEliminar;
    $("#GridView").DataTable();
})(AgenciaGrid || (AgenciaGrid = {}));
//# sourceMappingURL=Grid.js.map