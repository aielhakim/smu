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
