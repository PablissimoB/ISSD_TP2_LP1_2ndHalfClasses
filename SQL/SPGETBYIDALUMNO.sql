CREATE PROCEDURE [dbo].[GetByIDAlumno] 
	@id int
AS
BEGIN

	SET NOCOUNT ON;

	SELECT * from Alumnos where id = @id
END
