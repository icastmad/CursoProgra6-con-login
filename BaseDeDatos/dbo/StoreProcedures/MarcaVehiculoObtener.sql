CREATE PROCEDURE [dbo].[MarcaVehiculoObtener]
@MarcaVehiculoId int = null

AS
begin
set nocount on

Select MarcaVehiculoId, Descripcion, Estado from MarcaVehiculo
where (@MarcaVehiculoId is null or MarcaVehiculoId=@MarcaVehiculoId)

end
