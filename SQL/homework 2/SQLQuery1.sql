﻿SELECT * FROM Student
WHERE FirstName = 'Kristijan'

SELECT * FROM Student
WHERE DateOfBirth > '18.10.1997'

SELECT * FROM STUDENT
WHERE LastName like 'J%' and (EnrolledDate between '18.10.1997' and '20.10.1997')

SELECT * FROM STUDENT
ORDER BY FirstName ASC

SELECT LastName FROM TEACHER ​
UNION
SELECT LastName FROM STUDENT 

ALTER TABLE GRADE WITH NOCHECK
ADD CONSTRAINT FK_GRADE_StudentID
Foreign key (StudentID)
REFERENCES STUDENT (Id)

SELECT COURSE.Name, ACHIEVEMENTTYPE.Name from COURSE 
  CROSS JOIN ACHIEVEMENTTYPE

SELECT * FROM TEACHER
LEFT JOIN GRADE
ON TEACHER.Id = GRADE.TeacherId  
WHERE GRADE.TeacherId is null