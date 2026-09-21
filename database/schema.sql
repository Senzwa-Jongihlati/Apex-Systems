CREATE DATABASE ApexSystemsDB;
USE ApexSystemsDB;

CREATE TABLE Patient (
    PatientID           INT AUTO_INCREMENT   NOT NULL,
    FirstName           VARCHAR(50)        NOT NULL,
    LastName            VARCHAR(50)        NOT NULL,
    DateOfBirth          DATE                NOT NULL,
    Gender              VARCHAR(20)        NOT NULL,
    IdentificationType	VARCHAR(20)        NOT NULL,
    IdentificationNumber	VARCHAR(20)        NOT NULL,
    ContactNumber        VARCHAR(20)        NOT NULL,
    Address              VARCHAR(255)       NULL,
    RegisteredDate        DATETIME            NOT NULL DEFAULT CURRENT_TIMESTAMP,

    CONSTRAINT PK_Patient PRIMARY KEY (PatientID),
    CONSTRAINT UQ_Patient_Identification UNIQUE (IdentificationType, IdentificationNumber),
    CONSTRAINT CK_Patient_IdentificationType CHECK (IdentificationType IN ('SA ID', 'Passport'))
);
CREATE TABLE Receptionist (
    ReceptionistID  INT AUTO_INCREMENT NOT NULL,
    FirstName       VARCHAR(50)       NOT NULL,
    LastName        VARCHAR(50)       NOT NULL,
    Username        VARCHAR(50)       NOT NULL,
    PasswordHash    VARCHAR(255)      NOT NULL,
    ContactNumber   VARCHAR(20)       NULL,
    Email           VARCHAR(100)      NULL,
    DateHired       DATE               NOT NULL,
    IsActive        BIT                NOT NULL DEFAULT 1,

    CONSTRAINT PK_Receptionist PRIMARY KEY (ReceptionistID),
    CONSTRAINT UQ_Receptionist_Username UNIQUE (Username),
    CONSTRAINT UQ_Receptionist_Email UNIQUE (Email)
);
CREATE TABLE PriorityLevel (
    PriorityID   INT AUTO_INCREMENT  NOT NULL,
    LevelName    VARCHAR(50)       NOT NULL,
    LevelRank    INT                NOT NULL,
    Description  VARCHAR(255)      NULL,

    CONSTRAINT PK_PriorityLevel PRIMARY KEY (PriorityID),
    CONSTRAINT UQ_PriorityLevel_LevelName UNIQUE (LevelName),
    CONSTRAINT UQ_PriorityLevel_LevelRank UNIQUE (LevelRank)
);
CREATE TABLE Queue (
    QueueID        INT AUTO_INCREMENT  NOT NULL,
    QueueNumber    INT                NOT NULL,
    PatientID      INT                NOT NULL,
    PriorityID     INT                NOT NULL,
    ReceptionistID INT                NOT NULL,
	ReasonForVisit VARCHAR(255)       NOT NULL,
    CheckInTime    DATETIME           NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CompletedTime  DATETIME           NULL,
    Status         VARCHAR(20)       NOT NULL DEFAULT 'Waiting',

    CONSTRAINT PK_Queue PRIMARY KEY (QueueID),
    CONSTRAINT FK_Queue_Patient FOREIGN KEY (PatientID) REFERENCES Patient(PatientID),
    CONSTRAINT FK_Queue_PriorityLevel FOREIGN KEY (PriorityID) REFERENCES PriorityLevel(PriorityID),
    CONSTRAINT FK_Queue_Receptionist FOREIGN KEY (ReceptionistID) REFERENCES Receptionist(ReceptionistID),
    CONSTRAINT CK_Queue_Status CHECK (Status IN ('Waiting', 'Completed', 'Cancelled')),
    CONSTRAINT CK_Queue_CompletedAfterCheckIn CHECK (CompletedTime IS NULL OR CompletedTime >= CheckInTime)
);
