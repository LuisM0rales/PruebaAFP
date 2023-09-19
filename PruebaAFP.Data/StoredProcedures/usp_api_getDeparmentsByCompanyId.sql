CREATE PROCEDURE usp_api_getDeparmentsByCompanyId
@CompanyId int
AS
BEGIN
    SET NOCOUNT ON;
	SELECT Id,
		Nombre,
		NumEmpleados,
		Nivel
	FROM Departamentos
	WHERE CompanyId=@CompanyId
END                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
GO
/*
EXEC usp_api_getDeparmentsByCompanyId 1
*/