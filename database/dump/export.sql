-- MySQL dump 10.13  Distrib 8.0.43, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: apexsystemsdb
-- ------------------------------------------------------
-- Server version	8.0.43

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `appointment`
--

DROP TABLE IF EXISTS `appointment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `appointment` (
  `AppointmentID` int NOT NULL AUTO_INCREMENT,
  `PatientID` int NOT NULL,
  `DoctorID` int NOT NULL,
  `ReceptionistID` int NOT NULL,
  `AppointmentDateTime` datetime NOT NULL,
  `ReasonForVisit` varchar(255) NOT NULL,
  `Status` varchar(20) NOT NULL DEFAULT 'Scheduled',
  `CreatedDate` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`AppointmentID`),
  KEY `FK_Appointment_Patient` (`PatientID`),
  KEY `FK_Appointment_Doctor` (`DoctorID`),
  KEY `FK_Appointment_Receptionist` (`ReceptionistID`),
  CONSTRAINT `FK_Appointment_Doctor` FOREIGN KEY (`DoctorID`) REFERENCES `doctor` (`DoctorID`),
  CONSTRAINT `FK_Appointment_Patient` FOREIGN KEY (`PatientID`) REFERENCES `patient` (`PatientID`),
  CONSTRAINT `FK_Appointment_Receptionist` FOREIGN KEY (`ReceptionistID`) REFERENCES `receptionist` (`ReceptionistID`),
  CONSTRAINT `CK_Appointment_Status` CHECK ((`Status` in (_utf8mb4'Scheduled',_utf8mb4'Completed',_utf8mb4'Cancelled')))
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `appointment`
--

LOCK TABLES `appointment` WRITE;
/*!40000 ALTER TABLE `appointment` DISABLE KEYS */;
INSERT INTO `appointment` VALUES (1,2,1,1,'2026-09-28 10:00:00','Hypertension medication review','Scheduled','2026-09-24 13:55:39'),(2,3,2,2,'2026-09-28 11:30:00','Allergy consultation','Scheduled','2026-09-25 13:55:39'),(3,18,1,1,'2026-09-28 13:30:00','Diabetes management review','Scheduled','2026-09-23 13:55:39'),(4,1,4,4,'2026-09-28 15:00:00','Annual check-up','Scheduled','2026-09-26 13:55:39'),(5,14,1,1,'2026-09-29 09:00:00','Follow-up on cough and sore throat','Scheduled','2026-09-28 13:35:39'),(6,15,2,2,'2026-09-29 11:00:00','Back pain follow-up','Scheduled','2026-09-28 12:55:39'),(7,13,4,1,'2026-09-30 10:00:00','Fever follow-up and blood tests','Scheduled','2026-09-27 13:55:39'),(8,4,1,4,'2026-09-30 14:30:00','Wound dressing and stitches review','Scheduled','2026-09-27 13:55:39'),(9,16,2,1,'2026-10-01 09:30:00','Cardiology follow-up and ECG','Scheduled','2026-09-26 13:55:39'),(10,17,4,2,'2026-10-03 13:00:00','Throat infection follow-up','Scheduled','2026-09-26 13:55:39'),(11,3,1,4,'2026-10-05 08:30:00','Allergy test results review','Scheduled','2026-09-25 13:55:39'),(12,2,1,1,'2026-10-12 09:00:00','Blood pressure re-check','Scheduled','2026-09-24 13:55:39');
/*!40000 ALTER TABLE `appointment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `consultationnote`
--

DROP TABLE IF EXISTS `consultationnote`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `consultationnote` (
  `NoteID` int NOT NULL AUTO_INCREMENT,
  `QueueID` int NOT NULL,
  `DoctorID` int NOT NULL,
  `Diagnosis` varchar(255) NOT NULL,
  `Notes` text,
  `Prescription` text,
  `CreatedTime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`NoteID`),
  KEY `FK_Note_Queue` (`QueueID`),
  KEY `FK_Note_Doctor` (`DoctorID`),
  CONSTRAINT `FK_Note_Doctor` FOREIGN KEY (`DoctorID`) REFERENCES `doctor` (`DoctorID`),
  CONSTRAINT `FK_Note_Queue` FOREIGN KEY (`QueueID`) REFERENCES `queue` (`QueueID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consultationnote`
--

LOCK TABLES `consultationnote` WRITE;
/*!40000 ALTER TABLE `consultationnote` DISABLE KEYS */;
INSERT INTO `consultationnote` VALUES (1,1,2,'Mild hypertension','Blood pressure 146/92. Advised to reduce salt intake and return for a review.','Amlodipine 5 mg once daily','2026-09-19 09:35:00'),(2,2,1,'Chest tightness on exertion','ECG normal. Advised to avoid strenuous activity and to return immediately if the pain worsens.','Aspirin 75 mg once daily','2026-09-25 08:55:00'),(3,3,4,'Acute tonsillitis','Throat inflamed with white patches. Advised rest and plenty of fluids.','Amoxicillin 500 mg three times daily for 7 days','2026-09-23 10:40:00'),(4,4,1,'Lower back strain','Muscle strain after lifting. Advised rest, gentle stretching and no heavy lifting for two weeks.','Ibuprofen 400 mg three times daily with food for 5 days','2026-09-28 12:00:39');
/*!40000 ALTER TABLE `consultationnote` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `doctor`
--

DROP TABLE IF EXISTS `doctor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `doctor` (
  `DoctorID` int NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `PasswordHash` varchar(255) NOT NULL,
  `ContactNumber` varchar(20) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `DateHired` date NOT NULL,
  `IsActive` bit(1) NOT NULL DEFAULT b'1',
  `Experience` varchar(50) DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `Role` varchar(10) DEFAULT 'Doctor',
  PRIMARY KEY (`DoctorID`),
  UNIQUE KEY `UQ_Doctor_Username` (`Username`),
  UNIQUE KEY `UQ_Doctor_Email` (`Email`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doctor`
--

LOCK TABLES `doctor` WRITE;
/*!40000 ALTER TABLE `doctor` DISABLE KEYS */;
INSERT INTO `doctor` VALUES (1,'Nkosinathi','Ndlovu','nndlovu','$2a$11$6ybmg.YRpq3d6Esdc.ovlu/WbLZxPqoLaqIB/p6ENqxKGKqCD7U9S','0721239876','nndlovu@apexsystems.co.za','2022-06-01',_binary '',NULL,NULL,'Doctor'),(2,'Priya','Govender','pgovender','$2a$11$St4J2YU0v74fAVC5Vkh0UeHZxd2S9rnw/3/R7NiHd6.QyBZ6b1RWu','0839871234','pgovender@apexsystems.co.za','2023-03-20',_binary '',NULL,NULL,'Doctor'),(3,'Pieter','Botha','pbotha','$2a$11$u1FFbgZ8n.YLsyiUpxiTI.rKHcbq2Y3vHahbPZGT8cw6cKfba3Pke','0645551212','pbotha@apexsystems.co.za','2021-09-05',_binary '\0',NULL,NULL,'Doctor'),(4,'Singatha','Jongihlati','sjongihlati','$2a$11$hu0hOoyrnXLUy5ODe1F3JuBE8z0l8fZUgLXt2SgwA5GDEEzT5N4cO','0863521678',NULL,'2026-09-28',_binary '','15 years in medical practice','45 Don Thomson Drive, Fortgale, Mthatha','Doctor');
/*!40000 ALTER TABLE `doctor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patient`
--

DROP TABLE IF EXISTS `patient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patient` (
  `PatientID` int NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `DateOfBirth` date NOT NULL,
  `Gender` varchar(20) NOT NULL,
  `IdentificationType` varchar(20) NOT NULL,
  `IdentificationNumber` varchar(20) NOT NULL,
  `ContactNumber` varchar(20) NOT NULL,
  `EmergencyContactNumber` varchar(20) DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `RegisteredDate` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `EmergencyContact` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`PatientID`),
  UNIQUE KEY `UQ_Patient_Identification` (`IdentificationType`,`IdentificationNumber`),
  CONSTRAINT `CK_Patient_IdentificationType` CHECK ((`IdentificationType` in (_utf8mb4'SA ID',_utf8mb4'Passport')))
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patient`
--

LOCK TABLES `patient` WRITE;
/*!40000 ALTER TABLE `patient` DISABLE KEYS */;
INSERT INTO `patient` VALUES (1,'Nomvula','Zulu','1990-05-14','Female','SA ID','9005140123456','0821112223',NULL,'12 Umgeni Road, Durban','2024-03-01 09:15:00',NULL),(2,'James','van der Merwe','1985-11-02','Male','SA ID','8511025678901','0733334445',NULL,'45 Musgrave Road, Durban','2024-03-02 10:00:00',NULL),(3,'Aisha','Patel','2000-07-22','Female','Passport','A12345678','0845556667',NULL,'8 Overport Drive, Durban','2024-03-03 08:45:00',NULL),(4,'Bongani','Khumalo','1978-01-30','Male','SA ID','7801305432109','0716667778',NULL,'23 Berea Road, Durban','2024-03-04 11:20:00',NULL),(13,'Thabo','Mokoena','1998-04-15','Male','SA ID','9804155123087','0712345678',NULL,'12 Aloe Street, Durban','2026-09-21 20:16:26','0823456789'),(14,'Ayanda','Dlamini','1987-09-22','Female','SA ID','8709220486082','0723456789',NULL,'45 Umlazi Road, Durban','2026-09-21 20:16:26','0834567890'),(15,'Liam','Naidoo','2001-02-10','Male','SA ID','0102105123084','0734567890',NULL,'8 Palm Avenue, Berea','2026-09-21 20:16:26','0845678901'),(16,'Nomsa','Zulu','1979-11-03','Female','SA ID','7911030486085','0745678901',NULL,'27 Church Street, Pinetown','2026-09-21 20:16:26','0856789012'),(17,'Daniel','Pillay','1993-06-18','Male','SA ID','9306185123088','0756789012',NULL,'16 Marine Drive, Bluff','2026-09-21 20:16:26','0867890123'),(18,'Precious','Ndlovu','1966-08-27','Female','SA ID','6608270486081','0767890123',NULL,'31 Station Road, Chatsworth','2026-09-21 20:16:26','0878901234'),(22,'kjvbjvk','Jongihlati','2008-09-21','Male','SA ID','0614236118745','0763514662',NULL,'05 Olive place, Hilcrest, Mthatha','2026-09-21 20:34:26',NULL),(23,'Salem','Moumin','2008-09-22','Male','SA ID','1524153556298','0245144332',NULL,'Somewhere in Africa','2026-09-22 13:18:56','0835369957'),(27,'Olwethu','Mgxaji','2003-12-24','Male','SA ID','0312241223485','0836539487',NULL,'107 Marine Parade, South Beach, Durban','2026-09-23 16:25:13','0762494559'),(28,'Senzwa','Jongihlati','2005-10-10','Male','SA ID','0510105448086','0762494559',NULL,'107 Marine Parade, South Beach, Durban','2026-09-26 12:45:26','0765204747'),(29,'Samuel','Jackson','2001-08-09','Male','SA ID','0365124887953','0834517485',NULL,'107 marine parade, south beach, durban','2026-09-28 11:34:00','0769563468');
/*!40000 ALTER TABLE `patient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prioritylevel`
--

DROP TABLE IF EXISTS `prioritylevel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `prioritylevel` (
  `PriorityID` int NOT NULL AUTO_INCREMENT,
  `LevelName` varchar(50) NOT NULL,
  `LevelRank` int NOT NULL,
  `Description` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`PriorityID`),
  UNIQUE KEY `UQ_PriorityLevel_LevelName` (`LevelName`),
  UNIQUE KEY `UQ_PriorityLevel_LevelRank` (`LevelRank`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prioritylevel`
--

LOCK TABLES `prioritylevel` WRITE;
/*!40000 ALTER TABLE `prioritylevel` DISABLE KEYS */;
INSERT INTO `prioritylevel` VALUES (1,'Emergency',1,'Life-threatening, seen immediately'),(2,'Urgent',2,'Serious but stable, seen ahead of routine cases'),(3,'Routine',3,'Standard walk-in or scheduled visit');
/*!40000 ALTER TABLE `prioritylevel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `queue`
--

DROP TABLE IF EXISTS `queue`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `queue` (
  `QueueID` int NOT NULL AUTO_INCREMENT,
  `QueueNumber` int NOT NULL,
  `PatientID` int NOT NULL,
  `PriorityID` int NOT NULL,
  `ReceptionistID` int NOT NULL,
  `ReasonForVisit` varchar(255) NOT NULL,
  `CheckInTime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `CompletedTime` datetime DEFAULT NULL,
  `Status` varchar(20) NOT NULL DEFAULT 'Waiting',
  `DoctorID` int DEFAULT NULL,
  PRIMARY KEY (`QueueID`),
  KEY `FK_Queue_Doctor` (`DoctorID`),
  KEY `FK_Queue_Patient` (`PatientID`),
  KEY `FK_Queue_PriorityLevel` (`PriorityID`),
  KEY `FK_Queue_Receptionist` (`ReceptionistID`),
  CONSTRAINT `FK_Queue_Doctor` FOREIGN KEY (`DoctorID`) REFERENCES `doctor` (`DoctorID`),
  CONSTRAINT `FK_Queue_Patient` FOREIGN KEY (`PatientID`) REFERENCES `patient` (`PatientID`),
  CONSTRAINT `FK_Queue_PriorityLevel` FOREIGN KEY (`PriorityID`) REFERENCES `prioritylevel` (`PriorityID`),
  CONSTRAINT `FK_Queue_Receptionist` FOREIGN KEY (`ReceptionistID`) REFERENCES `receptionist` (`ReceptionistID`),
  CONSTRAINT `CK_Queue_CompletedAfterCheckIn` CHECK (((`CompletedTime` is null) or (`CompletedTime` >= `CheckInTime`))),
  CONSTRAINT `CK_Queue_Status` CHECK ((`Status` in (_utf8mb4'Waiting',_utf8mb4'In Consultation',_utf8mb4'Completed',_utf8mb4'Cancelled')))
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `queue`
--

LOCK TABLES `queue` WRITE;
/*!40000 ALTER TABLE `queue` DISABLE KEYS */;
INSERT INTO `queue` VALUES (1,1,14,3,1,'Routine medical check-up','2026-09-19 09:05:00','2026-09-19 09:35:00','Completed',2),(2,1,16,2,2,'Chest discomfort on exertion','2026-09-25 08:20:00','2026-09-25 08:55:00','Completed',1),(3,1,17,3,4,'Sore throat and mild fever','2026-09-23 10:10:00','2026-09-23 10:40:00','Completed',4),(4,1,15,3,1,'Lower back pain','2026-09-28 11:25:39','2026-09-28 12:00:39','Completed',1),(6,3,13,2,4,'High fever and body aches','2026-09-28 12:40:39',NULL,'Waiting',NULL),(7,4,17,3,4,'Sore throat not improving','2026-09-28 13:00:39',NULL,'Waiting',NULL),(8,5,4,2,1,'Deep cut on left hand','2026-09-28 13:25:39',NULL,'Waiting',NULL),(9,6,16,1,1,'Chest pain and shortness of breath','2026-09-28 13:49:39',NULL,'Waiting',NULL);
/*!40000 ALTER TABLE `queue` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `receptionist`
--

DROP TABLE IF EXISTS `receptionist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `receptionist` (
  `ReceptionistID` int NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `PasswordHash` varchar(255) NOT NULL,
  `ContactNumber` varchar(20) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `DateHired` date NOT NULL,
  `IsActive` bit(1) NOT NULL DEFAULT b'1',
  `Experience` varchar(250) DEFAULT NULL,
  `Address` varchar(250) DEFAULT NULL,
  `Role` varchar(20) DEFAULT 'Receptionist',
  PRIMARY KEY (`ReceptionistID`),
  UNIQUE KEY `UQ_Receptionist_Username` (`Username`),
  UNIQUE KEY `UQ_Receptionist_Email` (`Email`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receptionist`
--

LOCK TABLES `receptionist` WRITE;
/*!40000 ALTER TABLE `receptionist` DISABLE KEYS */;
INSERT INTO `receptionist` VALUES (1,'Thandeka','Mkhize','tmkhize','$2a$11$ZOTryu2bpVjXAgpPyEqVLeOrydHrjKhlB8vDAtA84t4WxwFhzO.rC','0731234567','tmkhize@apexsystems.co.za','2024-02-01',_binary '',NULL,NULL,'Receptionist'),(2,'Sagree','Naidoo','snaidoo','$2a$11$/GE0ZdcnsCWQSwIN5mW8ZOx0TLql47/ICwRbH9XnkKpNvovhNc8aC','0827654321','snaidoo@apexsystems.co.za','2023-11-15',_binary '',NULL,'','Receptionist'),(3,'Lerato','Dlamini','ldlamini','$2a$11$nLnXcEZW/R/.l7ZNKphnl.6zv72McVKiCFR2eLw6J8chN6HWhKYra','0619988776','ldlamini@apexsystems.co.za','2025-01-10',_binary '\0',NULL,NULL,'Receptionist'),(4,'Apex','Receptionist','receptionist','$2a$11$6MuYCKdDNW0GIFPxp7CdaeyD6fbcgXvzmoepoeuQhaX4sKj.bTviC','0762494558','receptionist@apexsystems.co.za','2026-09-21',_binary '','12 years in receptionist experience','107 marine parade, south beach, durban','Receptionist'),(5,'System','Administrator','admin','$2a$11$XAJfREspyqwVFnn1wyuLaOaJoOjk1T/N/qAuQR5C6d/EmU6hxZKuC',NULL,'admin@apexsystems.co.za','2026-09-21',_binary '',NULL,NULL,'Admin');
/*!40000 ALTER TABLE `receptionist` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-09-28 16:02:40
