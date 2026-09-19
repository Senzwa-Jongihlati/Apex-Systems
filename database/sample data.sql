USE ApexSystemsDB;
-- Receptionist
INSERT INTO Receptionist (FirstName, LastName, Username, PasswordHash, ContactNumber, Email, DateHired, IsActive) VALUES
('Thandeka', 'Mkhize', 'tmkhize', '$2a$10$examplehash1', '0731234567', 'tmkhize@apexsystems.co.za', '2024-02-01', 1),
('Sipho', 'Naidoo', 'snaidoo', '$2a$10$examplehash2', '0827654321', 'snaidoo@apexsystems.co.za', '2023-11-15', 1),
('Lerato', 'Dlamini', 'ldlamini', '$2a$10$examplehash3', '0619988776', 'ldlamini@apexsystems.co.za', '2025-01-10', 0);

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

-- Queue
INSERT INTO Queue (QueueNumber, PatientID, PriorityID, ReceptionistID, CheckInTime, CompletedTime, Status) VALUES
(1, 1, 1, 1, '2026-09-16 08:00:00', '2026-09-16 08:20:00', 'Completed'),
(2, 2, 3, 1, '2026-09-16 08:10:00', NULL, 'Waiting'),
(3, 3, 2, 2, '2026-09-16 08:25:00', '2026-09-16 08:50:00', 'Completed'),
(4, 4, 3, 2, '2026-09-16 08:30:00', NULL, 'Cancelled');



