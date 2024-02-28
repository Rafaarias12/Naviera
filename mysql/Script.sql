-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: Naviera
-- ------------------------------------------------------
-- Server version	8.3.0

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
-- Table structure for table `Areas`
--

DROP TABLE IF EXISTS `Areas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Areas` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Codigo` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `BarcoId` int NOT NULL,
  `ContenedorId` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`),
  KEY `IX_Areas_BarcoId` (`BarcoId`),
  CONSTRAINT `FK_Areas_Barcos_BarcoId` FOREIGN KEY (`BarcoId`) REFERENCES `Barcos` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Areas`
--

LOCK TABLES `Areas` WRITE;
/*!40000 ALTER TABLE `Areas` DISABLE KEYS */;
INSERT INTO `Areas` VALUES (1,'A01',1,0),(2,'A02',1,0),(3,'A03',1,0),(4,'A04',1,0),(5,'B01',1,0),(6,'B02',1,0),(7,'B03',1,0),(8,'B04',1,0),(9,'A01',2,0),(10,'A02',2,0),(11,'A03',2,0),(12,'A04',2,0),(13,'B01',2,0),(14,'B02',2,0),(15,'B03',2,0),(16,'A01',3,0),(17,'A02',3,0),(18,'B01',3,0),(19,'B02',3,0),(20,'C01',3,0);
/*!40000 ALTER TABLE `Areas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Barcos`
--

DROP TABLE IF EXISTS `Barcos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Barcos` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Cap_carga` int NOT NULL,
  `Cap_personal` int NOT NULL,
  `Tamaño` int NOT NULL,
  `Peso` double NOT NULL,
  `Nombre` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Codigo` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Barcos`
--

LOCK TABLES `Barcos` WRITE;
/*!40000 ALTER TABLE `Barcos` DISABLE KEYS */;
INSERT INTO `Barcos` VALUES (1,200,40,800,400,'URBAN 1','A405'),(2,200,40,800,400,'URBAN 1','A405'),(3,200,40,800,400,'URBAN 2','A408'),(4,200,40,800,400,'URBAN 3','A4156');
/*!40000 ALTER TABLE `Barcos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Contactos`
--

DROP TABLE IF EXISTS `Contactos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Contactos` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `EmpresaId` int NOT NULL,
  `Nombre` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Apellido` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Telefono` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Contactos_EmpresaId` (`EmpresaId`),
  CONSTRAINT `FK_Contactos_Empresa_EmpresaId` FOREIGN KEY (`EmpresaId`) REFERENCES `Empresa` (`IdEmpresa`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Contactos`
--

LOCK TABLES `Contactos` WRITE;
/*!40000 ALTER TABLE `Contactos` DISABLE KEYS */;
/*!40000 ALTER TABLE `Contactos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Contenedores`
--

DROP TABLE IF EXISTS `Contenedores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Contenedores` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Codigo` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CapMin` double NOT NULL,
  `CapMax` double NOT NULL,
  `AreaId` int NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Contenedores_AreaId` (`AreaId`),
  CONSTRAINT `FK_Contenedores_Areas_AreaId` FOREIGN KEY (`AreaId`) REFERENCES `Areas` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Contenedores`
--

LOCK TABLES `Contenedores` WRITE;
/*!40000 ALTER TABLE `Contenedores` DISABLE KEYS */;
INSERT INTO `Contenedores` VALUES (1,'A011',25,80,1),(2,'A012',25,80,1),(3,'A013',25,80,1),(4,'A011',25,80,2);
/*!40000 ALTER TABLE `Contenedores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Contenidos`
--

DROP TABLE IF EXISTS `Contenidos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Contenidos` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Cantidad` double NOT NULL,
  `Peso` double NOT NULL,
  `TipoContenidoId` int NOT NULL,
  `UnidadId` int NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Contenidos_TipoContenidoId` (`TipoContenidoId`),
  KEY `IX_Contenidos_UnidadId` (`UnidadId`),
  CONSTRAINT `FK_Contenidos_TipoContenidos_TipoContenidoId` FOREIGN KEY (`TipoContenidoId`) REFERENCES `TipoContenidos` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Contenidos_Unidades_UnidadId` FOREIGN KEY (`UnidadId`) REFERENCES `Unidades` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Contenidos`
--

LOCK TABLES `Contenidos` WRITE;
/*!40000 ALTER TABLE `Contenidos` DISABLE KEYS */;
/*!40000 ALTER TABLE `Contenidos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Empresa`
--

DROP TABLE IF EXISTS `Empresa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Empresa` (
  `IdEmpresa` int NOT NULL AUTO_INCREMENT,
  `Nit` int NOT NULL,
  `Nombre` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Telefono` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Tercero` int NOT NULL,
  PRIMARY KEY (`IdEmpresa`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Empresa`
--

LOCK TABLES `Empresa` WRITE;
/*!40000 ALTER TABLE `Empresa` DISABLE KEYS */;
INSERT INTO `Empresa` VALUES (1,15879432,'TREACH CORP','3589632541',0),(2,89562314,'GENERAL ELECTRIC','3896521470',0),(3,32145879,'MABEL INC','3692587410',0),(4,96857471,'ICOLAB INC','965874123',0);
/*!40000 ALTER TABLE `Empresa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Tickets`
--

DROP TABLE IF EXISTS `Tickets`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Tickets` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Codigo` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ViajeId` int NOT NULL,
  `EmpresaId` int NOT NULL,
  `ContenedorId` int NOT NULL,
  `ContenidoId` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`),
  KEY `IX_Tickets_ContenedorId` (`ContenedorId`),
  KEY `IX_Tickets_EmpresaId` (`EmpresaId`),
  KEY `IX_Tickets_ViajeId` (`ViajeId`),
  KEY `IX_Tickets_ContenidoId` (`ContenidoId`),
  CONSTRAINT `FK_Tickets_Contenedores_ContenedorId` FOREIGN KEY (`ContenedorId`) REFERENCES `Contenedores` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Tickets_Contenidos_ContenidoId` FOREIGN KEY (`ContenidoId`) REFERENCES `Contenidos` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Tickets_Empresa_EmpresaId` FOREIGN KEY (`EmpresaId`) REFERENCES `Empresa` (`IdEmpresa`) ON DELETE CASCADE,
  CONSTRAINT `FK_Tickets_Viajes_ViajeId` FOREIGN KEY (`ViajeId`) REFERENCES `Viajes` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Tickets`
--

LOCK TABLES `Tickets` WRITE;
/*!40000 ALTER TABLE `Tickets` DISABLE KEYS */;
/*!40000 ALTER TABLE `Tickets` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `TipoContenidos`
--

DROP TABLE IF EXISTS `TipoContenidos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `TipoContenidos` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Descripcion` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `TipoContenidos`
--

LOCK TABLES `TipoContenidos` WRITE;
/*!40000 ALTER TABLE `TipoContenidos` DISABLE KEYS */;
INSERT INTO `TipoContenidos` VALUES (1,'Liquido'),(2,'Solido'),(3,'Mercancia');
/*!40000 ALTER TABLE `TipoContenidos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Unidades`
--

DROP TABLE IF EXISTS `Unidades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Unidades` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Descripcion` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `DesCorta` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Unidades`
--

LOCK TABLES `Unidades` WRITE;
/*!40000 ALTER TABLE `Unidades` DISABLE KEYS */;
INSERT INTO `Unidades` VALUES (1,'Unidades','UND'),(2,'Litros','LTS');
/*!40000 ALTER TABLE `Unidades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Usuarios`
--

DROP TABLE IF EXISTS `Usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Usuarios` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `User` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Password` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Estado` int NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Usuarios`
--

LOCK TABLES `Usuarios` WRITE;
/*!40000 ALTER TABLE `Usuarios` DISABLE KEYS */;
INSERT INTO `Usuarios` VALUES (1,'admin','ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f',1),(2,'vendedor','ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f',1);
/*!40000 ALTER TABLE `Usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Viajes`
--

DROP TABLE IF EXISTS `Viajes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Viajes` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Codigo` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `FechaInic` datetime NOT NULL,
  `FechaFinal` datetime NOT NULL,
  `Inicio` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Destino` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `BarcoId` int NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Viajes_BarcoId` (`BarcoId`),
  CONSTRAINT `FK_Viajes_Barcos_BarcoId` FOREIGN KEY (`BarcoId`) REFERENCES `Barcos` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Viajes`
--

LOCK TABLES `Viajes` WRITE;
/*!40000 ALTER TABLE `Viajes` DISABLE KEYS */;
INSERT INTO `Viajes` VALUES (1,'A582','2024-02-27 00:00:00','2024-02-27 00:00:00','Santa Marta','Buenaventura',1),(2,'A582','2024-02-27 00:00:00','2024-02-29 00:00:00','Santa Marta','Buenaventura',2),(3,'A582','2024-02-27 00:00:00','2024-03-01 00:00:00','Santa Marta','China',3);
/*!40000 ALTER TABLE `Viajes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `__EFMigrationsHistory`
--

DROP TABLE IF EXISTS `__EFMigrationsHistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProductVersion` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__EFMigrationsHistory`
--

LOCK TABLES `__EFMigrationsHistory` WRITE;
/*!40000 ALTER TABLE `__EFMigrationsHistory` DISABLE KEYS */;
INSERT INTO `__EFMigrationsHistory` VALUES ('20240227031316_InitialMigration','7.0.14'),('20240227043729_UpdateTipoContenido','7.0.14'),('20240227171621_BarcoCodigo','7.0.14'),('20240227175425_UpdateArea','7.0.14'),('20240227180142_CorreccionFk','7.0.14'),('20240227180625_CorreccionTicket2','7.0.14'),('20240227190357_ConfiguracionContenedor','7.0.14'),('20240227190850_MigracionTicket3','7.0.14'),('20240227192648_AddTableUsuarios','7.0.14'),('20240228014145_CargaContenido','7.0.14'),('20240228024559_ErrorIdEF','7.0.14');
/*!40000 ALTER TABLE `__EFMigrationsHistory` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-02-28  3:34:59
