Ini adalah database yang saya gunakan

-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 16, 2025 at 03:01 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `peminjaman_playstation`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `Nama_Admin` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`Nama_Admin`) VALUES
('Admin 1'),
('Admin 2');

-- --------------------------------------------------------

--
-- Table structure for table `pelanggan`
--

CREATE TABLE `pelanggan` (
  `ID_Pelanggan` varchar(20) NOT NULL,
  `NIK` varchar(20) DEFAULT NULL,
  `Nama` varchar(255) DEFAULT NULL,
  `Nomor_Telepon` varchar(20) DEFAULT NULL,
  `Jenis_Kelamin` varchar(10) DEFAULT NULL,
  `Alamat` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pelanggan`
--

INSERT INTO `pelanggan` (`ID_Pelanggan`, `NIK`, `Nama`, `Nomor_Telepon`, `Jenis_Kelamin`, `Alamat`) VALUES
('CUST001', 'weqqw', 'eqweqe', 'eqwweq', 'Laki-laki', 'eqeweqw'),
('CUST002', 'jghjgjgj', 'jhgjhgjg', 'jghjhg', 'Perempuan', 'jghjgjgh');

-- --------------------------------------------------------

--
-- Table structure for table `peminjaman`
--

CREATE TABLE `peminjaman` (
  `No_Transaksi` varchar(20) NOT NULL,
  `ID_Pelanggan` varchar(20) DEFAULT NULL,
  `ID_Playstation` varchar(20) DEFAULT NULL,
  `Tanggal_Peminjaman` date DEFAULT NULL,
  `Tanggal_Pengembalian` date DEFAULT NULL,
  `Lama_Sewa` int(11) DEFAULT NULL,
  `Total_Harga` decimal(10,2) DEFAULT NULL,
  `Nama_Admin` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `pengembalian`
--

CREATE TABLE `pengembalian` (
  `No_Transaksi` varchar(20) NOT NULL,
  `Tanggal_Pengembalian` date DEFAULT NULL,
  `Keterlambatan` int(11) DEFAULT NULL,
  `Denda_Per_Hari` decimal(10,2) DEFAULT NULL,
  `Total_Denda` decimal(10,2) DEFAULT NULL,
  `Total_Bayar` decimal(10,2) DEFAULT NULL,
  `Bayar` decimal(10,2) DEFAULT NULL,
  `Kembalian` decimal(10,2) DEFAULT NULL,
  `Nama_Admin` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `playstation`
--

CREATE TABLE `playstation` (
  `ID_Playstation` varchar(20) NOT NULL,
  `Jenis_Playstation` varchar(255) DEFAULT NULL,
  `Harga_Sewa_Per_Hari` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `playstation`
--

INSERT INTO `playstation` (`ID_Playstation`, `Jenis_Playstation`, `Harga_Sewa_Per_Hari`) VALUES
('PS001', 'PlayStation 5', 50000.00),
('PS002', 'PlayStation 4', 30000.00),
('PS003', 'PlayStation 3', 20000.00),
('PS004', 'PlayStation 2', 15000.00),
('PS005', 'PlayStation 1', 10000.00);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`Nama_Admin`);

--
-- Indexes for table `pelanggan`
--
ALTER TABLE `pelanggan`
  ADD PRIMARY KEY (`ID_Pelanggan`);

--
-- Indexes for table `peminjaman`
--
ALTER TABLE `peminjaman`
  ADD PRIMARY KEY (`No_Transaksi`),
  ADD KEY `ID_Pelanggan` (`ID_Pelanggan`),
  ADD KEY `ID_Playstation` (`ID_Playstation`),
  ADD KEY `Nama_Admin` (`Nama_Admin`);

--
-- Indexes for table `pengembalian`
--
ALTER TABLE `pengembalian`
  ADD PRIMARY KEY (`No_Transaksi`),
  ADD KEY `Nama_Admin` (`Nama_Admin`);

--
-- Indexes for table `playstation`
--
ALTER TABLE `playstation`
  ADD PRIMARY KEY (`ID_Playstation`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `peminjaman`
--
ALTER TABLE `peminjaman`
  ADD CONSTRAINT `peminjaman_ibfk_1` FOREIGN KEY (`ID_Pelanggan`) REFERENCES `pelanggan` (`ID_Pelanggan`),
  ADD CONSTRAINT `peminjaman_ibfk_2` FOREIGN KEY (`ID_Playstation`) REFERENCES `playstation` (`ID_Playstation`),
  ADD CONSTRAINT `peminjaman_ibfk_3` FOREIGN KEY (`Nama_Admin`) REFERENCES `admin` (`Nama_Admin`);

--
-- Constraints for table `pengembalian`
--
ALTER TABLE `pengembalian`
  ADD CONSTRAINT `pengembalian_ibfk_1` FOREIGN KEY (`No_Transaksi`) REFERENCES `peminjaman` (`No_Transaksi`),
  ADD CONSTRAINT `pengembalian_ibfk_2` FOREIGN KEY (`Nama_Admin`) REFERENCES `admin` (`Nama_Admin`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
