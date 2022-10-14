CREATE TABLE [Course](
[Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
[Name] [nvarchar](100) NOT NULL,
[Credit] [nvarchar] (100)NOT NULL,
[AcademicYear] [nvarchar] (100) NOT NULL,
[Semester] [nvarchar] (100) NOT NULL,

)

SELECT * FROM Course

INSERT INTO [Course] ([Name],[Credit],[AcademicYear],[Semester])
VALUES ('Krisitjan','10','2022','Leten')

INSERT INTO [Course] ([Name],[Credit],[AcademicYear],[Semester])
VALUES ('David','5','2022','Zimski')