CREATE PROCEDURE [dbo].[InsertInscripcion] 
@idMateria int, @idAlumno int, @turno int, @fechaInscripcion date
AS
BEGIN
	insert into Inscripciones (idMateria, idAlumno, turno, fechaInscripcion) values (@idMateria, @idAlumno, @turno, @fechaInscripcion)
END
