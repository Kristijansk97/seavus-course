CREATE TABLE [ArchievementType](
[Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
[Name] [nvarchar](100) NOT NULL,
[Description] [nvarchar](100)NOT NULL,
[ParticipationRate] [nvarchar](100) NOT NULL,


)

SELECT * FROM ArchievementType

INSERT INTO [ArchievementType] ([Name],[Description],[ParticipationRate])
VALUES ('Kristijan','test test test test','20')

INSERT INTO [ArchievementType] ([Name],[Description],[ParticipationRate])
VALUES ('Toni','test test test test','25')