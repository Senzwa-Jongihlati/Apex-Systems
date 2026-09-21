-- MySQL dump 10.13  Distrib 8.0.46, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: apexsystemsdb
-- ------------------------------------------------------
-- Server version	8.0.46

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
  `CheckInTime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `CompletedTime` datetime DEFAULT NULL,
  `Status` varchar(20) NOT NULL DEFAULT 'Waiting',
  PRIMARY KEY (`QueueID`),
  KEY `FK_Queue_Patient` (`PatientID`),
  KEY `FK_Queue_PriorityLevel` (`PriorityID`),
  KEY `FK_Queue_Receptionist` (`ReceptionistID`),
  CONSTRAINT `FK_Queue_Patient` FOREIGN KEY (`PatientID`) REFERENCES `patient` (`PatientID`),
  CONSTRAINT `FK_Queue_PriorityLevel` FOREIGN KEY (`PriorityID`) REFERENCES `prioritylevel` (`PriorityID`),
  CONSTRAINT `FK_Queue_Receptionist` FOREIGN KEY (`ReceptionistID`) REFERENCES `receptionist` (`ReceptionistID`),
  CONSTRAINT `CK_Queue_CompletedAfterCheckIn` CHECK (((`CompletedTime` is null) or (`CompletedTime` >= `CheckInTime`))),
  CONSTRAINT `CK_Queue_Status` CHECK ((`Status` in (_utf8mb4'Waiting',_utf8mb4'Completed',_utf8mb4'Cancelled')))
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `queue`
--

LOCK TABLES `queue` WRITE;
/*!40000 ALTER TABLE `queue` DISABLE KEYS */;
INSERT INTO `queue` VALUES (1,1,1,1,1,'2026-09-16 08:00:00','2026-09-16 08:20:00','Completed'),(2,2,2,3,1,'2026-09-16 08:10:00',NULL,'Waiting'),(3,3,3,2,2,'2026-09-16 08:25:00','2026-09-16 08:50:00','Completed'),(4,4,4,3,2,'2026-09-16 08:30:00',NULL,'Cancelled');
/*!40000 ALTER TABLE `queue` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-09-21 15:35:41
