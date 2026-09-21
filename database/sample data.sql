USE ApexSystemsDB;
-- Receptionist
INSERT INTO Receptionist (FirstName, LastName, Username, PasswordHash, ContactNumber, Email, DateHired, IsActive) VALUES
('Thandeka', 'Mkhize', 'tmkhize', '$2a$11$ZOTryu2bpVjXAgpPyEqVLeOrydHrjKhlB8vDAtA84t4WxwFhzO.rC', '0731234567', 'tmkhize@apexsystems.co.za', '2024-02-01', 1),
('Sipho', 'Naidoo', 'snaidoo', '$2a$11$/GE0ZdcnsCWQSwIN5mW8ZOx0TLql47/ICwRbH9XnkKpNvovhNc8aC', '0827654321', 'snaidoo@apexsystems.co.za', '2023-11-15', 1),
('Lerato', 'Dlamini', 'ldlamini', '$2a$11$nLnXcEZW/R/.l7ZNKphnl.6zv72McVKiCFR2eLw6J8chN6HWhKYra', '0619988776', 'ldlamini@apexsystems.co.za', '2025-01-10', 0);

-- Patient
INSERT INTO Patient (FirstName, LastName, DateOfBirth, Gender, IdentificationType, IdentificationNumber, ContactNumber, Address, RegisteredDate) VALUES
('Nomvula', 'Zulu', '1990-05-14', 'Female', 'SA ID', '9005140123456', '0821112223', '12 Umgeni Road, Durban', '2024-03-01 09:15:00'),
('James', 'van der Merwe', '1985-11-02', 'Male', 'SA ID', '8511025678901', '0733334445', '45 Musgrave Road, Durban', '2024-03-02 10:00:00'),
('Aisha', 'Patel', '2000-07-22', 'Female', 'Passport', 'A12345678', '0845556667', '8 Overport Drive, Durban', '2024-03-03 08:45:00'),
('Bongani', 'Khumalo', '1978-01-30', 'Male', 'SA ID', '7801305432109', '0716667778', '23 Berea Road, Durban', '2024-03-04 11:20:00');
-- PriorityLevel (already have this one from before, included here for completeness)
INSERT INTO PriorityLevel (LevelName, LevelRank, Description) VALUES
('Emergency', 1, 'Life-threatening, seen immediately'),
('Urgent',    2, 'Serious but stable, seen ahead of routine cases'),
('Routine',   3, 'Standard walk-in or scheduled visit');
-- Doctor
INSERT INTO Doctor (FirstName, LastName, Username, PasswordHash, ContactNumber, Email, DateHired, IsActive)
VALUES ('Nkosinathi', 'Ndlovu', 'nndlovu', '$2a$11$6ybmg.YRpq3d6Esdc.ovlu/WbLZxPqoLaqIB/p6ENqxKGKqCD7U9S','0721239876', 'nndlovu@apexsystems.co.za', '2022-06-01', 1);

INSERT INTO Doctor (FirstName, LastName, Username, PasswordHash, ContactNumber, Email, DateHired, IsActive)
VALUES ('Priya', 'Govender', 'pgovender', '$2a$11$St4J2YU0v74fAVC5Vkh0UeHZxd2S9rnw/3/R7NiHd6.QyBZ6b1RWu','0839871234', 'pgovender@apexsystems.co.za', '2023-03-20', 1);

INSERT INTO Doctor (FirstName, LastName, Username, PasswordHash, ContactNumber, Email, DateHired, IsActive)
VALUES ('Pieter', 'Botha', 'pbotha', '$2a$11$u1FFbgZ8n.YLsyiUpxiTI.rKHcbq2Y3vHahbPZGT8cw6cKfba3Pke','0645551212', 'pbotha@apexsystems.co.za', '2021-09-05', 0);


-- Queue (replaces your old Queue insert: it now has DoctorID and ReasonForVisit)
INSERT INTO Queue (QueueNumber, PatientID, PriorityID, ReceptionistID, DoctorID, ReasonForVisit, CheckInTime, CompletedTime, Status) VALUES
(1, 1, 1, 1, 2,    'Severe chest pain and shortness of breath', '2026-09-16 08:00:00', '2026-09-16 08:20:00', 'Completed'),
(2, 2, 3, 1, NULL, 'Routine blood pressure check',              '2026-09-16 08:10:00', NULL,                  'Waiting'),
(3, 3, 2, 2, 1,    'High fever and persistent cough',            '2026-09-16 08:25:00', '2026-09-16 08:50:00', 'Completed'),
(4, 4, 3, 2, NULL, 'Follow-up consultation',                     '2026-09-16 08:30:00', NULL,                  'Cancelled'),
(5, 1, 2, 1, 1,    'Follow-up on chest pain',                    '2026-09-16 09:00:00', NULL,                  'In Consultation');

-- ConsultationNote
INSERT INTO ConsultationNote (QueueID, DoctorID, Diagnosis, Notes, Prescription, CreatedTime)
VALUES (1, 2, 'Suspected angina',
        'Patient stabilised on arrival. ECG normal. Advised to book a cardiology follow-up.',
        'Aspirin 75 mg once daily', '2026-09-16 08:18:00');

INSERT INTO ConsultationNote (QueueID, DoctorID, Diagnosis, Notes, Prescription, CreatedTime)
VALUES (3, 1, 'Viral upper respiratory infection',
        'Temperature 38.4 C. Advised rest and plenty of fluids. Return if symptoms last beyond 5 days.',
        NULL, '2026-09-16 08:48:00');

