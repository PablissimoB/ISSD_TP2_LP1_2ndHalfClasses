CREATE PROCEDURE [dbo].[GetByIDMateria] 
	@id int
AS
BEGIN

	SET NOCOUNT ON;

	SELECT * from Materias where id = @id
END
