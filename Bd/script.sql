USE [ISSD-TP2-202302]
GO
/****** Object:  Table [dbo].[Alumnos]    Script Date: 23/10/2023 16:55:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumnos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[apellido] [varchar](100) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Alumnos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inscripciones]    Script Date: 23/10/2023 16:55:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inscripciones](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idAlumno] [int] NOT NULL,
	[idMateria] [int] NOT NULL,
	[fechaInscripcion] [date] NULL,
	[turno] [int] NULL,
 CONSTRAINT [PK_Inscripciones] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materias]    Script Date: 23/10/2023 16:55:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materias](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_Materias] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Inscripciones]  WITH CHECK ADD  CONSTRAINT [FK_Inscripciones_Alumnos] FOREIGN KEY([idAlumno])
REFERENCES [dbo].[Alumnos] ([id])
GO
ALTER TABLE [dbo].[Inscripciones] CHECK CONSTRAINT [FK_Inscripciones_Alumnos]
GO
ALTER TABLE [dbo].[Inscripciones]  WITH CHECK ADD  CONSTRAINT [FK_Inscripciones_Materias] FOREIGN KEY([idMateria])
REFERENCES [dbo].[Materias] ([id])
GO
ALTER TABLE [dbo].[Inscripciones] CHECK CONSTRAINT [FK_Inscripciones_Materias]
GO
/****** Object:  StoredProcedure [dbo].[DeleteMateria]    Script Date: 23/10/2023 16:55:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteMateria] 
	@id int
AS
BEGIN
	delete from Materias
	where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllAlumnos]    Script Date: 23/10/2023 16:55:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllAlumnos]
AS
BEGIN
	SELECT * from Alumnos
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllMaterias]    Script Date: 23/10/2023 16:55:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetAllMaterias]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select * from Materias
END
GO
/****** Object:  StoredProcedure [dbo].[InsertAlumno]    Script Date: 23/10/2023 16:55:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertAlumno] 
	@nombre varchar(100), @apellido varchar(100)
AS
BEGIN
	insert into Alumnos (nombre, apellido) values (@nombre, @apellido)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertMateria]    Script Date: 23/10/2023 16:55:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertMateria] 
	@descripcion varchar(100)
AS
BEGIN
	insert into Materias (descripcion) values (@descripcion)
END
GO
/****** Object:  StoredProcedure [dbo].[updateMateria]    Script Date: 23/10/2023 16:55:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateMateria] 
	@id int,
	@descripcion varchar(100)
AS
BEGIN
	update Materias set descripcion = @descripcion
	where id = @id
END
GO
