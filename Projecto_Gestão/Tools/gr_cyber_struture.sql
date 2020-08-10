CREATE DATABASE  IF NOT EXISTS `gr_cyber` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `gr_cyber`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: gr_cyber
-- ------------------------------------------------------
-- Server version	5.7.19

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
-- Table structure for table `admin`
--

DROP TABLE IF EXISTS `admin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `admin` (
  `idAdmin` tinyint(4) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) DEFAULT 'Admin',
  `foto` longblob,
  `senha` varchar(30) NOT NULL,
  `sexo` enum('M','F') DEFAULT NULL,
  `estadoCivil` enum('S','C') DEFAULT NULL,
  `nascimento` date DEFAULT NULL,
  `numeroBI` varchar(45) DEFAULT NULL,
  `morada` varchar(50) DEFAULT NULL,
  `telefone` varchar(45) DEFAULT NULL,
  `outros` text,
  `nacionalidade` varchar(45) DEFAULT NULL,
  `naturalidade` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idAdmin`),
  UNIQUE KEY `senha` (`senha`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `produto`
--

DROP TABLE IF EXISTS `produto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produto` (
  `idProduto` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `quantidade` int(11) NOT NULL,
  `valor` varchar(30) NOT NULL DEFAULT '0',
  `total` varchar(30) NOT NULL DEFAULT '0',
  `foto` longblob,
  `stock` varchar(30) NOT NULL DEFAULT '0',
  `outros` text,
  PRIMARY KEY (`idProduto`),
  UNIQUE KEY `nome_UNIQUE` (`nome`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `registo`
--

DROP TABLE IF EXISTS `registo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `registo` (
  `idRegisto` int(11) NOT NULL AUTO_INCREMENT,
  `texto` text,
  `data_registo` date DEFAULT NULL,
  `hora_registo` time DEFAULT NULL,
  `foto` longblob,
  PRIMARY KEY (`idRegisto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `servico`
--

DROP TABLE IF EXISTS `servico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `servico` (
  `idServico` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `outros` text,
  PRIMARY KEY (`idServico`),
  UNIQUE KEY `idServico_UNIQUE` (`idServico`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tiposervico`
--

DROP TABLE IF EXISTS `tiposervico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tiposervico` (
  `idTipoServico` int(11) NOT NULL AUTO_INCREMENT,
  `idServico` int(11) DEFAULT NULL,
  `nome` varchar(100) NOT NULL,
  `valor` int(11) NOT NULL,
  PRIMARY KEY (`idTipoServico`),
  UNIQUE KEY `idTipoServico_UNIQUE` (`idTipoServico`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `idUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(150) NOT NULL DEFAULT 'Usuário',
  `foto` longblob,
  `senha` varchar(30) NOT NULL,
  `sexo` enum('M','F') DEFAULT NULL,
  `estadoCivil` varchar(15) DEFAULT NULL,
  `nascimento` date DEFAULT NULL,
  `numeroBI` varchar(45) DEFAULT NULL,
  `morada` varchar(50) DEFAULT NULL,
  `telefone` varchar(45) DEFAULT NULL,
  `outros` text,
  `dataIngresso` date DEFAULT NULL,
  `nacionalidade` varchar(45) NOT NULL,
  `naturalidade` varchar(45) NOT NULL,
  `email` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idUsuario`),
  UNIQUE KEY `senha` (`senha`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `venderproduto`
--

DROP TABLE IF EXISTS `venderproduto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `venderproduto` (
  `idVenda` int(11) NOT NULL AUTO_INCREMENT,
  `idUsuario` int(11) DEFAULT NULL,
  `idProduto` int(11) DEFAULT NULL,
  `quantidade` int(11) NOT NULL,
  `data_venda` date DEFAULT NULL,
  `hora_venda` time DEFAULT NULL,
  `total` varchar(15) NOT NULL,
  PRIMARY KEY (`idVenda`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping routines for database 'gr_cyber'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-07-07  3:00:05
