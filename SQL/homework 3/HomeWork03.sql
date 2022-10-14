SELECT TeacherID, Teacher.FirstName, Teacher.LastName, COUNT(Grade) AS TotalNoOfGrades
FROM Grade
Join Teacher ON TeacherID = Teacher.Id
GROUP BY TeacherID,Teacher.FirstName, Teacher.LastName

SELECT TeacherID, Teacher.FirstName, Teacher.LastName, COUNT (Grade) AS TotalNoOfGrades 
FROM Grade
Join Teacher ON TeacherID = Teacher.Id
WHERE StudentID<100
GROUP BY TeacherID,Teacher.FirstName, Teacher.LastName

SELECT StudentID, Student.FirstName, Student.LastName, MAX(Grade) AS MaximumGrade, AVG(Grade) AS AverageGrade  
FROM Grade
Join Student ON StudentID = Student.Id
GROUP BY StudentId, Student.FirstName, Student.LastName
ORDER BY FirstName ASC

SELECT TeacherID, Teacher.FirstName, Teacher.LastName, COUNT (Grade) AS TotalNoOfGrades 
FROM Grade
Join Teacher ON TeacherID = Teacher.Id
GROUP BY TeacherID,Teacher.FirstName, Teacher.LastName
Having COUNT(Grade) > 200

SELECT StudentID, Student.FirstName, Student.LastName, Count(Grade) AS TotalNoOfGrades, MAX(Grade) AS MaximumGrade, AVG(Grade) AS AverageGrade  
FROM Grade
Join Student ON StudentID = Student.Id
GROUP BY StudentId, Student.FirstName, Student.LastName
Having MAX(Grade) = AVG(Grade)
ORDER BY FirstName ASC


GO;
CREATE VIEW vw_StudentGrades AS 
(
SELECT StudentId, COUNT(Grade) AS TotalNoOfGrades
FROM [Grade]
GROUP BY StudentId
) 
GO;
SELECT * from vw_StudentGrades 

GO;
ALTER VIEW vw_StudentGrades AS
(
SELECT Student.FirstName, Student.LastName, COUNT(Grade) AS TotalNoOfGrades 
FROM Grade
Join Student ON StudentId = Student.Id
GROUP BY Student.FirstName, Student.LastName 
);
GO;
SELECT * FROM vw_StudentGrades

GO;
SELECT * FROM vw_StudentGrades
ORDER BY TotalNoOfGrades DESC
GO;