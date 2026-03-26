-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Creato il: Mar 26, 2026 alle 21:09
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
(25, 'ivan', 'silvestrini'),
(26, 'alessandro', 'aquili');

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
(37, 'Borghettari', 25, 26);

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
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT per la tabella `squadre`
--
ALTER TABLE `squadre`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

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
