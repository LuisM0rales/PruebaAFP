CREATE PROCEDURE usp_api_getAllCompanies
AS
BEGIN
    SET NOCOUNT ON;
	SELECT Id,
		Nombre,
		RazonSocial,
		FechaRegistro,
		FechaCreacion,
		UsuarioCreo,
		FechaModificacion,
		UsuarioModifico
	FROM Companies;
END                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
GO
/*
EXEC usp_api_getAllCompanies
*/