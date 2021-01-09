USE master
GO
IF  EXISTS (
	SELECT name 
		FROM sys.databases 
		WHERE name = N'რეალური'
)
DROP DATABASE [რეალური]
GO

CREATE DATABASE [რეალური]
GO

USE [რეალური]
go
--=========================================================

IF OBJECT_ID('dbo.Teacher', 'U') IS NOT NULL
  DROP TABLE dbo.Teacher
GO
create table Teacher(

ID int  primary key identity(1,1),
სახელი nvarchar(255) not null,
გვარი  nvarchar(255) not null,
სქესი  nvarchar(255) not null,
საგანი nvarchar(255) not null,

)
go


IF OBJECT_ID('dbo.Pupil', 'U') IS NOT NULL
  DROP TABLE dbo.Pupil
GO
create table Pupil(
ID int  primary key identity(1,1),
სახელი nvarchar(255) not null,
გვარი  nvarchar(255) not null,
სქესი  nvarchar(255) not null,
კლასი nvarchar(255) not null,

)
go

IF OBJECT_ID('dbo.TeacherAndPupil', 'U') IS NOT NULL
  DROP TABLE dbo.TeacherAndPupil
GO
create table TeacherAndPupil(

ID int  primary key identity(1,1),
TeacherID int FOREIGN KEY REFERENCES Teacher(ID) ,
PupilID int FOREIGN KEY REFERENCES Pupil(ID),

)
go

select * from Pupil
select * from Teacher
select * from TeacherAndPupil   
select Teacher.სახელი as TeacherName,Pupil.სახელი as PupilName from Teacher inner join TeacherAndPupil on Teacher.ID=TeacherAndPupil.TeacherID inner join Pupil on Pupil.ID=TeacherAndPupil.PupilID