USE [ISSD-TP2-202302]
GO
CREATE PROCEDURE UpdateInscripcion 
@idMateria int, @idAlumno int, @turno int, @fechaInscripcion date,  @id int
AS
BEGIN
	update Inscripciones set idMateria = @idMateria, idAlumno= @idAlumno, turno = @turno, fechaInscripcion=  @fechaInscripcion where id = @id
END
