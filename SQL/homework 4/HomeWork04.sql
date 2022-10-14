Declare @FirstName nvarchar(100)
SET @FirstName = 'Kristijan'
SELECT * FROM Student
WHERE FirstName = @FirstName


DECLARE @StudentList TABLE (StudentId int, StuidentName nvarchar(100), DateOfBirth date)
INSERT INTO @StudentList
SELECT Id, FirstName, DateOfBirth FROM Student
Where Gender = 'F'
SELECT * FROM @StudentList


CREATE TABLE #StudentList (LastName nvarchar(100), EnrolledDate date)
INSERT INTO #StudentList
SELECT LastName, EnrolledDate FROM Student
WHERE Gender = 'M' and FirstName Like 'A%'

SELECT * FROM #StudentList
WHERE LEN(LastName) = 7

SELECT FirstName, LastName from Teacher
WHERE LEN(FirstName) < 5 and LEFT(FirstName,3) = LEFT(LastName,3) 