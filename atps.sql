CREATE DATABASE  IF NOT EXISTS `db_atps` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `db_atps`;
-- MySQL dump 10.13  Distrib 5.6.24, for Win64 (x86_64)
--
-- Host: localhost    Database: db_atps
-- ------------------------------------------------------
-- Server version	5.5.45

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tb_departamento`
--

DROP TABLE IF EXISTS `tb_departamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_departamento` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(100) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_departamento`
--

LOCK TABLES `tb_departamento` WRITE;
/*!40000 ALTER TABLE `tb_departamento` DISABLE KEYS */;
INSERT INTO `tb_departamento` (`codigo`, `descricao`) VALUES (1,'programacao');
/*!40000 ALTER TABLE `tb_departamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_material`
--

DROP TABLE IF EXISTS `tb_material`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_material` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `data` date NOT NULL,
  `titulo` varchar(100) NOT NULL,
  `descricao` longtext NOT NULL,
  `Tb_usuario_codigo` int(11) NOT NULL,
  `tb_departamento_codigo` int(11) NOT NULL,
  PRIMARY KEY (`codigo`),
  KEY `fk_tb_material_Tb_usuario_idx` (`Tb_usuario_codigo`),
  KEY `fk_tb_material_tb_departamento1_idx` (`tb_departamento_codigo`),
  CONSTRAINT `fk_tb_material_tb_departamento1` FOREIGN KEY (`tb_departamento_codigo`) REFERENCES `tb_departamento` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_material_Tb_usuario` FOREIGN KEY (`Tb_usuario_codigo`) REFERENCES `tb_usuario` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_material`
--

LOCK TABLES `tb_material` WRITE;
/*!40000 ALTER TABLE `tb_material` DISABLE KEYS */;
INSERT INTO `tb_material` (`codigo`, `data`, `titulo`, `descricao`, `Tb_usuario_codigo`, `tb_departamento_codigo`) VALUES (1,'2015-11-15','lerolero','asdjhhdcjhagRKJEHCRGUWGV',1,1);
/*!40000 ALTER TABLE `tb_material` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_novos_usuarios`
--

DROP TABLE IF EXISTS `tb_novos_usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_novos_usuarios` (
  `tipo` varchar(45) NOT NULL,
  `nome` varchar(45) NOT NULL,
  `sobrenome` varchar(45) NOT NULL,
  `login` varchar(45) NOT NULL,
  `senha` varchar(45) NOT NULL,
  `endereco` varchar(100) NOT NULL,
  `cidade` varchar(45) NOT NULL,
  `cep` varchar(20) NOT NULL,
  `estado` varchar(45) NOT NULL,
  `tel_res` varchar(20) NOT NULL,
  `tel_cel1` varchar(20) NOT NULL,
  `tel_cel2` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_novos_usuarios`
--

LOCK TABLES `tb_novos_usuarios` WRITE;
/*!40000 ALTER TABLE `tb_novos_usuarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_novos_usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_usuario`
--

DROP TABLE IF EXISTS `tb_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_usuario` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) NOT NULL,
  `login` varchar(45) NOT NULL,
  `senha` varchar(45) NOT NULL,
  `tipo` int(11) DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_usuario`
--

LOCK TABLES `tb_usuario` WRITE;
/*!40000 ALTER TABLE `tb_usuario` DISABLE KEYS */;
INSERT INTO `tb_usuario` (`codigo`, `nome`, `login`, `senha`, `tipo`) VALUES (1,'welton cardoso','weltoncardoso','12345',0),(3,'Benigno Sol Filho','benigno','12345',0);
/*!40000 ALTER TABLE `tb_usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-12-02 23:55:40
