CREATE PROCEDURE usp_api_getCompanyById
@CompanyId int
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
	FROM Companies
	WHERE Id=@CompanyId
END                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
GO
/*
EXEC usp_api_getCompanyById 1
*/