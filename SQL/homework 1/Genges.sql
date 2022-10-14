

CREATE TABLE [Grades](
[Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
[StudentID] [nvarchar](100) NOT NULL,
[CourseID] [nvarchar] (100)NOT NULL,
[TeacherID] [nvarchar] (100) NOT NULL,
[Gender] [nvarchar] (100) NOT NULL,
[Comment] [nvarchar] (100) NOT NULL,
[CreatedDate] [date] NOT NULL,
)

SELECT * FROM Grades

INSERT INTO [Grades] ([StudentID],[CourseID],[TeacherID],[Gender],[Comment],[CreatedDate])
VALUES ('123456','25','9999','Male','Top','14.10.2022')

INSERT INTO [Grades] ([StudentID],[CourseID],[TeacherID],[Gender],[Comment],[CreatedDate])
VALUES ('7891011','18','123444','Male','Top-10','16.10.2022')