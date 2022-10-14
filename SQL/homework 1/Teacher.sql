
CREATE TABLE [Teacher](
[FirstName] [nvarchar](100) NOT NULL,
[LastName] [nvarchar] (100)NOT NULL,
[DateOfBirth] [date] NOT NULL,
[AcademicRank] [nvarchar](100) NULL,
[HireDate] [nvarchar] (100) NOT NULL,
)

SELECT * FROM Teacher

INSERT INTO [Teacher] ([FirstName],[LastName],[DateOfBirth],[AcademicRank],[HireDate])
VALUES ('Kalin','Nikolovski','06.08.1972','9','2008')

INSERT INTO [Teacher] ([FirstName],[LastName],[DateOfBirth],[AcademicRank],[HireDate])
VALUES ('Filip','Petrovski','06.08.1987','5','2014')

DELETE 
FROM Teacher
Where FirstName = 'Filip'