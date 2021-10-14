CREATE TABLE [dbo].[Student] (
    [Id]   NCHAR (20)           NOT NULL,
    [Name] NVARCHAR (20) NOT NULL,
    [Phone]        NCHAR (20)   NOT NULL,
    CONSTRAINT PK_Student PRIMARY KEY NONCLUSTERED ([Id])

);

CREATE TABLE [dbo].[Course] (
    [Id] NCHAR (20)           NOT NULL,
    [Name]     NVARCHAR (20)  NOT NULL,
    CONSTRAINT PK_Course PRIMARY KEY NONCLUSTERED ([Id])
);

CREATE TABLE [dbo].[StudentCoursePoints]
(
	[CourseId] NCHAR (20) NOT NULL , 
    [StudentId] NCHAR (20) NOT NULL, 
    [Points] INT NOT NULL, 
    CONSTRAINT FK_StudentId  FOREIGN KEY ([StudentId])
        REFERENCES Student (Id),
    CONSTRAINT FK_CourseId  FOREIGN KEY ([CourseId])
        REFERENCES Course (Id)
    ON DELETE CASCADE
    ON UPDATE CASCADE
)

--In case we need to disallow having multiple entries for same student and course in the points table.
--There will be composite primary key in StudentCoursePoints table
--CREATE TABLE [dbo].[StudentCoursePoints]
--(
--	[CourseId] NCHAR (20) NOT NULL , 
--    [StudentId] NCHAR (20) NOT NULL, 
--    [Points] INT NOT NULL, 
--    CONSTRAINT PK_StudentCoursePoint PRIMARY KEY NONCLUSTERED ([CourseId], [StudentId]),
--    CONSTRAINT FK_StudentId  FOREIGN KEY ([StudentId])
--        REFERENCES Student (Id),
--    CONSTRAINT FK_CourseId  FOREIGN KEY ([CourseId])
--        REFERENCES Course (Id)
    
--    ON DELETE CASCADE
--    ON UPDATE CASCADE
--)