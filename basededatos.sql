USE [master]
GO
/****** Object:  Database [SegundoOrdinario00830]    Script Date: 5/2/2020 10:18:23 AM ******/
CREATE DATABASE [SegundoOrdinario00830]

USE [SegundoOrdinario00830]
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 5/2/2020 10:18:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno](
	[Id_alumno] [int] NOT NULL,
	[Dsc_nombre] [varchar](50) NOT NULL,
	[Dsc_apellido1] [varchar](50) NOT NULL,
	[Dsc_apellido2] [varchar](50) NOT NULL,
	[Dsc_user_name] [varchar](50) NOT NULL,
	[Dsc_password] [varchar](50) NOT NULL,
	[Dsc_rol] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Alumno] PRIMARY KEY CLUSTERED 
(
	[Id_alumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cursos]    Script Date: 5/2/2020 10:18:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cursos](
	[Id_curso] [int] NOT NULL,
	[Dsc_curso] [varchar](50) NOT NULL,
	[Dsc_Grado] [varchar](50) NOT NULL,
	[Can_Horas] [int] NOT NULL,
 CONSTRAINT [PK_Cursos] PRIMARY KEY CLUSTERED 
(
	[Id_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CursosAlumno]    Script Date: 5/2/2020 10:18:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CursosAlumno](
	[Id_curso] [int] NOT NULL,
	[Id_alumno] [int] NOT NULL,
	[NotaOrdinario1] [decimal](18, 0) NOT NULL,
	[NotaOrdinario2] [decimal](18, 0) NOT NULL,
	[NotaProyecto] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_CursosAlumno] PRIMARY KEY CLUSTERED 
(
	[Id_curso] ASC,
	[Id_alumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Alumno] ADD  CONSTRAINT [DF_Alumno_Dsc_rol]  DEFAULT ((0)) FOR [Dsc_rol]
GO
ALTER TABLE [dbo].[CursosAlumno] ADD  CONSTRAINT [DF_CursosAlumno_NotaOrdinario1]  DEFAULT ((0)) FOR [NotaOrdinario1]
GO
ALTER TABLE [dbo].[CursosAlumno] ADD  CONSTRAINT [DF_CursosAlumno_NotaOrdinario2]  DEFAULT ((0)) FOR [NotaOrdinario2]
GO
ALTER TABLE [dbo].[CursosAlumno] ADD  CONSTRAINT [DF_CursosAlumno_NotaProyecto]  DEFAULT ((0)) FOR [NotaProyecto]
GO
ALTER TABLE [dbo].[CursosAlumno]  WITH CHECK ADD  CONSTRAINT [FK_CursosAlumno_Alumno] FOREIGN KEY([Id_alumno])
REFERENCES [dbo].[Alumno] ([Id_alumno])
GO
ALTER TABLE [dbo].[CursosAlumno] CHECK CONSTRAINT [FK_CursosAlumno_Alumno]
GO
ALTER TABLE [dbo].[CursosAlumno]  WITH CHECK ADD  CONSTRAINT [FK_CursosAlumno_Cursos] FOREIGN KEY([Id_curso])
REFERENCES [dbo].[Cursos] ([Id_curso])
GO
ALTER TABLE [dbo].[CursosAlumno] CHECK CONSTRAINT [FK_CursosAlumno_Cursos]
GO
USE [master]
GO
ALTER DATABASE [SegundoOrdinario00830] SET  READ_WRITE 
GO
