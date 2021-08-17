
namespace App.AxiosProvider   {

    //export const GuardarEmpleado = () => axios.get<Entity.DBEntity>("aplicacion").then(({data})=>data );

    export const AgenciaEliminar = (id) => axios.delete<DBEntity>("Agencia/Grid?handler=Eliminar&id="+ id).then(({ data }) => data);

    export const AgenciaGuardar = (entity) => axios.post<DBEntity>("Agencia/Edit",entity).then(({ data }) => data);

    export const AgenciaChangeProvincia = (entity) => axios.post<any>("Agencia/Edit?handler=ChangeProvincia",entity).then(({ data }) => data);

    export const AgenciaChangeCanton = (entity) => axios.post<any>("Agencia/Edit?handler=ChangeCanton", entity).then(({ data }) => data);

    export const MarcaVehiculoEliminar = (id) => axios.delete<DBEntity>("MarcaVehiculo/Grid?handler=Eliminar&id=" + id).then(({ data }) => data);

    export const MarcaVehiculoGuardar = (entity) => axios.post<DBEntity>("MarcaVehiculo/Edit", entity).then(({ data }) => data);

    export const VehiculoEliminar = (id) => ServiceApi.delete<DBEntity>("api/Vehiculo/" + id).then(({ data }) => data);

    export const VehiculoGuardar = (entity) => ServiceApi.post<DBEntity>("api/Vehiculo", entity).then(({ data }) => data);

    export const VehiculoActualizar = (entity) => ServiceApi.put<DBEntity>("api/Vehiculo", entity).then(({ data }) => data);

    export const ClientesEliminar = (id) => ServiceApi.delete<DBEntity>("api/Clientes/" + id).then(({ data }) => data);

    export const ClientesGuardar = (entity) => ServiceApi.post<DBEntity>("api/Clientes", entity).then(({ data }) => data);

    export const ClientesActualizar = (entity) => ServiceApi.put<DBEntity>("api/Clientes", entity).then(({ data }) => data);

    export const UsuarioRegistrar = (entity) => ServiceApi.post<DBEntity>("api/Usuarios/Registrar", entity).then(({ data }) => data);

    export const UsuarioLogin = (entity) => axios.post<DBEntity>("Login", entity).then(({ data }) => data);


}




