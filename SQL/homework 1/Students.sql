
CREATE TABLE [Students](
[Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
[FirstName] [nvarchar](100) NOT NULL,
[LastName] [nvarchar] (100)NOT NULL,
[DateOfBirth] [date] NOT NULL,
[EnrolledDate] [nvarchar](100) NOT NULL,
[Gender] [nvarchar] (100) NOT NULL,
[NationallDNumber] [nvarchar] (100) NOT NULL,
[StudentCardNumber] [nvarchar] (100) NOT NULL,
)

SELECT * FROM Students

INSERT INTO [Students] ([FirstName],[LastName],[DateOfBirth],[EnrolledDate],[Gender],[NationallDNumber],[StudentCardNumber])
VALUES ('Kristijan','Ilioski','18.10.1997','2016','Male','Macedonian','123456')

INSERT INTO [Students] ([FirstName],[LastName],[DateOfBirth],[EnrolledDate],[Gender],[NationallDNumber],[StudentCardNumber])
VALUES ('David','Filipovski','12.10.1998','2018','Male','Macedonian','159951')