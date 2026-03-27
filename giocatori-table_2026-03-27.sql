-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Creato il: Mar 27, 2026 alle 16:01
-- Versione del server: 8.2.0
-- Versione PHP: 8.3.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `torneo_briscola`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `giocatori`
--

CREATE TABLE `giocatori` (
  `id` int NOT NULL,
  `nome` varchar(100) DEFAULT NULL,
  `cognome` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dump dei dati per la tabella `giocatori`
--

INSERT INTO `giocatori` (`id`, `nome`, `cognome`) VALUES
(33, 'sofia', 'burattini'),
(34, 'sofia', 'carlini'),
(35, 'nicola', 'cardinaletti'),
(36, 'pietro', 'quattrini'),
(37, 'francesco', 'catalani'),
(38, 'nicolas', 'tasquier'),
(39, 'filippo', 'faini'),
(40, 'omar', 'vittori'),
(41, 'fabio', 'corrarella'),
(42, 'lorenzo', 'petrucci'),
(43, 'giacomo', 'marcucci'),
(44, 'nicolò', 'scortechini'),
(45, 'pietro', 'quattrini'),
(46, 'nicola', 'cardinaletti'),
(47, 'lorenzo', 'bianchi'),
(48, 'leonardo', 'rossi'),
(49, 'lorenzo', 'bonzì'),
(50, 'giovanni', 'fabrizi'),
(51, 'andrea', 'giorgini'),
(52, 'diego', 'stanziano'),
(53, 'nicole', 'giovagnoli'),
(54, 'jennifer', 'campana'),
(55, 'sergio', 'massaccesi'),
(56, 'davide', 'pacetti'),
(57, 'greta', 'pinti'),
(58, 'anna', 'boria'),
(59, 'nicolò', 'pierangeli'),
(60, 'alessandro', 'cacciamani'),
(61, 'luca', 'sabbatini'),
(62, 'matteo', 'pastori'),
(63, 'michele', 'ciampichetti'),
(64, 'edoardo', 'borra'),
(65, 'leonida', 'salja'),
(66, 'kristian', 'zimbardo'),
(67, 'francesco', 'coltorti'),
(68, 'mattia', 'maggiori'),
(69, 'gioele', 'barbini'),
(70, 'loris', 'boccolini'),
(71, 'tommaso', 'bastari'),
(72, 'corrado', 'morchio'),
(73, 'leonardo', 'felici'),
(74, 'mattia', 'mezzelani'),
(75, 'leonardo', 'scortichini'),
(76, 'leonardo', 'matteucci');

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `giocatori`
--
ALTER TABLE `giocatori`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT per le tabelle scaricate
--

--
-- AUTO_INCREMENT per la tabella `giocatori`
--
ALTER TABLE `giocatori`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=77;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
