SELECT s.Name As 'name' , c.Name As 'course', cast(AVG(scp.points) as decimal(10,4)) AS 'avg(points)' 
FROM StudentCoursePoints as scp
Join Course As c ON c.Id = scp.CourseId 
Join Student As s ON s.Id = scp.StudentId
Group By s.Name,c.Name
Order By s.Name;
