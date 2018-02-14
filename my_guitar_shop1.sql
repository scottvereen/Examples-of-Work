-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Feb 14, 2018 at 07:19 PM
-- Server version: 10.1.13-MariaDB
-- PHP Version: 5.6.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `my_guitar_shop1`
--

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `categoryID` int(11) NOT NULL,
  `categoryName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`categoryID`, `categoryName`) VALUES
(1, 'Guitars'),
(2, 'Basses'),
(3, 'Drums');

-- --------------------------------------------------------

--
-- Table structure for table `golfers`
--

CREATE TABLE `golfers` (
  `g_ID` int(11) NOT NULL,
  `fName` varchar(25) NOT NULL,
  `lName` varchar(25) NOT NULL,
  `recorder` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `orderID` int(11) NOT NULL,
  `customerID` int(11) NOT NULL,
  `orderDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `productID` int(11) NOT NULL,
  `categoryID` int(11) NOT NULL,
  `productCode` varchar(10) NOT NULL,
  `productName` varchar(255) NOT NULL,
  `listPrice` decimal(10,2) NOT NULL,
  `description` text NOT NULL,
  `dateAdded` datetime NOT NULL,
  `discountPercent` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`productID`, `categoryID`, `productCode`, `productName`, `listPrice`, `description`, `dateAdded`, `discountPercent`) VALUES
(2, 1, 'les_paul', 'Gibson Les Paul', '1199.00', '', '0000-00-00 00:00:00', '0.00'),
(3, 1, 'sg', 'Gibson SG', '2517.00', '', '0000-00-00 00:00:00', '0.00'),
(4, 1, 'fg700s', 'Yamaha FG700S', '489.99', '', '0000-00-00 00:00:00', '0.00'),
(5, 1, 'washburn', 'Washburn D10S', '299.00', '', '0000-00-00 00:00:00', '0.00'),
(6, 1, 'rodriguez', 'Rodriguez Caballero 11', '415.00', '', '0000-00-00 00:00:00', '0.00'),
(7, 2, 'precision', 'Fender Precision', '799.99', '', '0000-00-00 00:00:00', '0.00'),
(8, 2, 'hofner', 'Hofner Icon', '499.99', '', '0000-00-00 00:00:00', '0.00'),
(9, 3, 'ludwig', 'Ludwig 5-piece Drum Set with Cymbals', '699.99', '', '0000-00-00 00:00:00', '0.00'),
(10, 3, 'tama', 'Tama 5-Piece Drum Set with Cymbals', '799.99', '', '0000-00-00 00:00:00', '0.00'),
(13, 0, '', '', '0.00', '', '0000-00-00 00:00:00', '0.00'),
(14, 2, 'ADFB', 'DFB', '20.00', 'DFBD', '2017-03-09 00:00:00', '0.00');

-- --------------------------------------------------------

--
-- Table structure for table `rounds`
--

CREATE TABLE `rounds` (
  `r_ID` int(11) NOT NULL,
  `score` tinyint(3) UNSIGNED NOT NULL,
  `date` date NOT NULL,
  `golfer` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `userid` int(11) NOT NULL,
  `userfirst` varchar(50) NOT NULL,
  `userpassword` varchar(60) NOT NULL,
  `userlast` varchar(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `admin` int(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`userid`, `userfirst`, `userpassword`, `userlast`, `username`, `email`, `admin`) VALUES
(1, 'scott', '$2y$10$kcKuRRAIUQj5of7rJv/l/OZvy7Is2bpvpl9/XF0yxmrP4F16xng7i', 'vereen', 'shop', 'scottvereen@yahoo.com', 0),
(2, 'scott', '$2y$10$fJXDIkvVHpMQyQ7u5iYdceC.kE4/oDEcRCVcafplbhzSzt4AcqlH6', 'vereen', 'name', 'scottvereen@yahoo', 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`categoryID`);

--
-- Indexes for table `golfers`
--
ALTER TABLE `golfers`
  ADD PRIMARY KEY (`g_ID`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`orderID`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`productID`),
  ADD UNIQUE KEY `productCode` (`productCode`);

--
-- Indexes for table `rounds`
--
ALTER TABLE `rounds`
  ADD PRIMARY KEY (`r_ID`),
  ADD KEY `round_date` (`date`),
  ADD KEY `golfer_id` (`golfer`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`userid`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `categoryID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `orderID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `productID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `userid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
