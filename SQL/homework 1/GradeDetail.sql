CREATE TABLE [GradeDetail](
[Id] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
[GradeID] [int] NOT NULL,
[AchievementTypeID] [int]NOT NULL,
[AchievementPoints] [int] NOT NULL,
[AchievementMaxPoints] [int] NOT NULL,
[AchievementDate] [date] NOT NULL

)

SELECT * FROM GradeDetail

INSERT INTO [GradeDetail] ([GradeID],[AchievementTypeID],[AchievementPoints],[AchievementMaxPoints],[AchievementDate])
VALUES ('123456','222','123','130','14.10.2022')