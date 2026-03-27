-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Creato il: Mar 27, 2026 alle 16:04
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

-- --------------------------------------------------------

--
-- Struttura della tabella `squadre`
--

CREATE TABLE `squadre` (
  `id` int NOT NULL,
  `nome` varchar(100) DEFAULT NULL,
  `giocatore1_id` int DEFAULT NULL,
  `giocatore2_id` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dump dei dati per la tabella `squadre`
--

INSERT INTO `squadre` (`id`, `nome`, `giocatore1_id`, `giocatore2_id`) VALUES
(41, 'squadra_41', 33, 34),
(42, 'squadra_42', 35, 36),
(43, 'squadra_43', 37, 38),
(44, 'squadra_44', 39, 40),
(45, 'squadra_45', 41, 42),
(46, 'squadra_46', 43, 44),
(47, 'squadra_47', 45, 46),
(48, 'squadra_48', 47, 48),
(49, 'squadra_49', 49, 50),
(50, 'squadra_50', 51, 52),
(51, 'squadra_51', 53, 54),
(52, 'squadra_52', 55, 56),
(53, 'squadra_53', 57, 58),
(54, 'squadra_54', 59, 60),
(55, 'squadra_55', 61, 62),
(56, 'squadra_56', 63, 64),
(57, 'squadra_57', 65, 66),
(58, 'squadra_58', 67, 68),
(59, 'squadra_59', 69, 70),
(60, 'squadra_60', 71, 72),
(61, 'squadra_61', 73, 74),
(62, 'squadra_62', 75, 76);

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `giocatori`
--
ALTER TABLE `giocatori`
  ADD PRIMARY KEY (`id`);

--
-- Indici per le tabelle `squadre`
--
ALTER TABLE `squadre`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nome` (`nome`),
  ADD KEY `squadre_ibfk_1` (`giocatore1_id`),
  ADD KEY `squadre_ibfk_2` (`giocatore2_id`);

--
-- AUTO_INCREMENT per le tabelle scaricate
--

--
-- AUTO_INCREMENT per la tabella `giocatori`
--
ALTER TABLE `giocatori`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=77;

--
-- AUTO_INCREMENT per la tabella `squadre`
--
ALTER TABLE `squadre`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=63;

--
-- Limiti per le tabelle scaricate
--

--
-- Limiti per la tabella `squadre`
--
ALTER TABLE `squadre`
  ADD CONSTRAINT `squadre_ibfk_1` FOREIGN KEY (`giocatore1_id`) REFERENCES `giocatori` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `squadre_ibfk_2` FOREIGN KEY (`giocatore2_id`) REFERENCES `giocatori` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
