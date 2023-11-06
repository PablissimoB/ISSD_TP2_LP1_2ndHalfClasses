CREATE PROCEDURE [dbo].[GetAllInscripcionesTabla] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Inscripciones
	INNER JOIN Alumnos ON Alumnos.id = Inscripciones.idAlumno
	INNER JOIN Materias ON Materias.id = Inscripciones.idMateria
END
