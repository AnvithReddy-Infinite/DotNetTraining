create database EduTrackDB;
go

use EduTrackDB;
go

create table Students(
StudentId INT IDENTITY(1,1) PRIMARY KEY,
FullName VARCHAR(100) NOT NULL,
Email VARCHAR(100) UNIQUE,
Department  VARCHAR(50) NOT NULL,
YearOfStudy INT NOT NULL
);

create table Courses(
CourseId INT IDENTITY(1,1) PRIMARY KEY,
CourseName VARCHAR(100) NOT NULL,
Credits INT NOT NULL,
Semester VARCHAR(20) NOT NULL
);

create table Enrollments(
EnrollmentId INT IDENTITY(1,1) PRIMARY KEY,
StudentId INT NOT NULL FOREIGN KEY REFERENCES Students(StudentId),
CourseId INT NOT NULL FOREIGN KEY REFERENCES Courses(CourseId),
EnrollDate DATETIME NOT NULL,
Grade VARCHAR(5) NULL
);
go

SELECT * FROM Students;
SELECT * FROM Courses;
SELECT * FROM Enrollments;


insert into Students(FullName,Email,Department,YearOfStudy) values
('Anvith Reddy','anvith@example.com','Computer Science',2),
('Keerthi','keerthi@example.com','Information Technology',3),
('Monika','monika@example.com','Electronics',1),
('Sairam Somaraju','sairam@example.com','Computer Science',4),
('Pooja','pooja@example.com','Mechanical',2);

insert into Courses(CourseName,Credits,Semester) values
('Data Structures',4,'Sem1'),
('Database Systems',3,'Sem1'),
('Operating Systems',4,'Sem2'),
('Computer Networks',3,'Sem2'),
('Software Engineering',3,'Sem3'),
('Machine Learning',4,'Sem4');

insert into Enrollments(StudentId,CourseId,EnrollDate,Grade) values
(1,1,GETDATE(),'A'),
(1,2,GETDATE(),'B'),
(2,2,GETDATE(),NULL),
(3,3,GETDATE(),'C'),
(4,4,GETDATE(),'A'),
(5,5,GETDATE(),NULL);
go


create procedure usp_GetCoursesBySemester
@semester varchar(20)
as
begin
select CourseId,CourseName,Credits,Semester
from Courses
where Semester = @semester;
end;
go

EXEC usp_GetCoursesBySemester 'Sem1';
