USE [master]
GO
/****** Object:  Database [UnivarsityDB]    Script Date: 12/4/2018 9:05:28 PM ******/
CREATE DATABASE [UnivarsityDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'UnivarsityDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL2014\MSSQL\DATA\UnivarsityDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'UnivarsityDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL2014\MSSQL\DATA\UnivarsityDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [UnivarsityDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UnivarsityDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UnivarsityDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [UnivarsityDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [UnivarsityDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [UnivarsityDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [UnivarsityDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [UnivarsityDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [UnivarsityDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [UnivarsityDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [UnivarsityDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [UnivarsityDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [UnivarsityDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [UnivarsityDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [UnivarsityDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [UnivarsityDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [UnivarsityDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [UnivarsityDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [UnivarsityDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [UnivarsityDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [UnivarsityDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [UnivarsityDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [UnivarsityDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [UnivarsityDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [UnivarsityDB] SET RECOVERY FULL 
GO
ALTER DATABASE [UnivarsityDB] SET  MULTI_USER 
GO
ALTER DATABASE [UnivarsityDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [UnivarsityDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [UnivarsityDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [UnivarsityDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [UnivarsityDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'UnivarsityDB', N'ON'
GO
USE [UnivarsityDB]
GO
/****** Object:  Table [dbo].[AllocateClassroom_tb]    Script Date: 12/4/2018 9:05:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AllocateClassroom_tb](
	[AllocateId] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentId] [int] NULL,
	[CourseId] [int] NULL,
	[RoomId] [int] NULL,
	[DayId] [int] NULL,
	[FromTime] [time](7) NULL,
	[ToTime] [time](7) NULL,
 CONSTRAINT [PK_AllocateClassroom_tb] PRIMARY KEY CLUSTERED 
(
	[AllocateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Course_tb]    Script Date: 12/4/2018 9:05:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course_tb](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CourseCode] [nvarchar](50) NULL,
	[CourseName] [nvarchar](50) NULL,
	[Cradit] [int] NULL,
	[DepartmentId] [int] NULL,
	[SemesterId] [int] NULL,
 CONSTRAINT [PK_Course_tb] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CourseAssign_tb]    Script Date: 12/4/2018 9:05:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseAssign_tb](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentId] [int] NULL,
	[TeacherId] [int] NULL,
	[CourseId] [int] NULL,
 CONSTRAINT [PK_CourseAssign_tb] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Day_tb]    Script Date: 12/4/2018 9:05:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Day_tb](
	[DayId] [int] IDENTITY(1,1) NOT NULL,
	[DayName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Day_tb] PRIMARY KEY CLUSTERED 
(
	[DayId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Department_tb]    Script Date: 12/4/2018 9:05:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department_tb](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Department_tb] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Designation_tb]    Script Date: 12/4/2018 9:05:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Designation_tb](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Designation_tb] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EnrollCourse_tb]    Script Date: 12/4/2018 9:05:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EnrollCourse_tb](
	[EnrollCoursesId] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [int] NULL,
	[CourseId] [int] NULL,
	[Date] [nvarchar](50) NULL,
 CONSTRAINT [PK_EnrollCourse_tb] PRIMARY KEY CLUSTERED 
(
	[EnrollCoursesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Grade_tb]    Script Date: 12/4/2018 9:05:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grade_tb](
	[GradeId] [int] IDENTITY(1,1) NOT NULL,
	[GradeLetter] [nvarchar](50) NULL,
 CONSTRAINT [PK_Grade_tb] PRIMARY KEY CLUSTERED 
(
	[GradeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Room_tb]    Script Date: 12/4/2018 9:05:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room_tb](
	[RoomId] [int] IDENTITY(1,1) NOT NULL,
	[RoomNo] [nvarchar](50) NULL,
 CONSTRAINT [PK_Room_tb] PRIMARY KEY CLUSTERED 
(
	[RoomId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Semester_tb]    Script Date: 12/4/2018 9:05:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Semester_tb](
	[SemesterId] [int] IDENTITY(1,1) NOT NULL,
	[SemesterName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Semester_tb] PRIMARY KEY CLUSTERED 
(
	[SemesterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student_tb]    Script Date: 12/4/2018 9:05:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_tb](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [nvarchar](50) NULL,
	[RegNo] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[ContactNo] [nvarchar](50) NULL,
	[Date] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[DepartmentId] [int] NULL,
 CONSTRAINT [PK_Student_tb] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentResult_tb]    Script Date: 12/4/2018 9:05:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentResult_tb](
	[ResultId] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [int] NULL,
	[CourseId] [int] NULL,
	[GradeId] [int] NULL,
 CONSTRAINT [PK_StudentResult_tb] PRIMARY KEY CLUSTERED 
(
	[ResultId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Teacher_tb]    Script Date: 12/4/2018 9:05:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher_tb](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TeacherName] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[ContactNo] [nvarchar](50) NULL,
	[DesignationId] [int] NULL,
	[DepartmentId] [int] NULL,
	[CraditTaken] [int] NULL,
 CONSTRAINT [PK_Teacher_tb] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[CourseAssign_tb]  WITH CHECK ADD  CONSTRAINT [FK_CourseAssign_tb_Course_tb] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Course_tb] ([Id])
GO
ALTER TABLE [dbo].[CourseAssign_tb] CHECK CONSTRAINT [FK_CourseAssign_tb_Course_tb]
GO
ALTER TABLE [dbo].[CourseAssign_tb]  WITH CHECK ADD  CONSTRAINT [FK_CourseAssign_tb_Department_tb] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department_tb] ([Id])
GO
ALTER TABLE [dbo].[CourseAssign_tb] CHECK CONSTRAINT [FK_CourseAssign_tb_Department_tb]
GO
ALTER TABLE [dbo].[CourseAssign_tb]  WITH CHECK ADD  CONSTRAINT [FK_CourseAssign_tb_Teacher_tb] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Teacher_tb] ([Id])
GO
ALTER TABLE [dbo].[CourseAssign_tb] CHECK CONSTRAINT [FK_CourseAssign_tb_Teacher_tb]
GO
ALTER TABLE [dbo].[EnrollCourse_tb]  WITH CHECK ADD  CONSTRAINT [FK_EnrollCourse_tb_Course_tb] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Course_tb] ([Id])
GO
ALTER TABLE [dbo].[EnrollCourse_tb] CHECK CONSTRAINT [FK_EnrollCourse_tb_Course_tb]
GO
ALTER TABLE [dbo].[EnrollCourse_tb]  WITH CHECK ADD  CONSTRAINT [FK_EnrollCourse_tb_EnrollCourse_tb] FOREIGN KEY([EnrollCoursesId])
REFERENCES [dbo].[EnrollCourse_tb] ([EnrollCoursesId])
GO
ALTER TABLE [dbo].[EnrollCourse_tb] CHECK CONSTRAINT [FK_EnrollCourse_tb_EnrollCourse_tb]
GO
ALTER TABLE [dbo].[EnrollCourse_tb]  WITH CHECK ADD  CONSTRAINT [FK_EnrollCourse_tb_Student_tb] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student_tb] ([StudentId])
GO
ALTER TABLE [dbo].[EnrollCourse_tb] CHECK CONSTRAINT [FK_EnrollCourse_tb_Student_tb]
GO
ALTER TABLE [dbo].[Student_tb]  WITH CHECK ADD  CONSTRAINT [FK_Student_tb_Department_tb] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department_tb] ([Id])
GO
ALTER TABLE [dbo].[Student_tb] CHECK CONSTRAINT [FK_Student_tb_Department_tb]
GO
ALTER TABLE [dbo].[StudentResult_tb]  WITH CHECK ADD  CONSTRAINT [FK_StudentResult_tb_Grade_tb] FOREIGN KEY([GradeId])
REFERENCES [dbo].[Grade_tb] ([GradeId])
GO
ALTER TABLE [dbo].[StudentResult_tb] CHECK CONSTRAINT [FK_StudentResult_tb_Grade_tb]
GO
ALTER TABLE [dbo].[Teacher_tb]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_tb_Department_tb] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department_tb] ([Id])
GO
ALTER TABLE [dbo].[Teacher_tb] CHECK CONSTRAINT [FK_Teacher_tb_Department_tb]
GO
ALTER TABLE [dbo].[Teacher_tb]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_tb_Designation_tb] FOREIGN KEY([DesignationId])
REFERENCES [dbo].[Designation_tb] ([Id])
GO
ALTER TABLE [dbo].[Teacher_tb] CHECK CONSTRAINT [FK_Teacher_tb_Designation_tb]
GO
USE [master]
GO
ALTER DATABASE [UnivarsityDB] SET  READ_WRITE 
GO
