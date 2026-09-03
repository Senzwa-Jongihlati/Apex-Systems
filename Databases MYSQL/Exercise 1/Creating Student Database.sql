
CREATE DATABASE Student;
USE Student;
CREATE TABLE Students (
    StudentID INT AUTO_INCREMENT primary key,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Gender CHAR(1),
    DateOfBirth DATE,
    Email VARCHAR(100)
);

CREATE TABLE Lecturers (
    LecturerID INT AUTO_INCREMENT primary key,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Department VARCHAR(50),
    Email VARCHAR(100)
);

-- 4. Create the Courses table
CREATE TABLE Courses (
    CourseID INT AUTO_INCREMENT primary key,
    CourseName VARCHAR(100) NOT NULL,
    Credits INT,
    LecturerID INT,
    FOREIGN KEY (LecturerID) REFERENCES Lecturers(LecturerID)
);

CREATE TABLE Enrolments (
    EnrolmentID INT AUTO_INCREMENT,
    StudentID INT NOT NULL,
    CourseID INT NOT NULL,
    EnrolmentDate DATE,
    FinalMark DECIMAL(5,2),
    PRIMARY KEY (EnrolmentID),
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

SELECT * FROM lecturers;