-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Feb 14, 2018 at 07:13 PM
-- Server version: 10.1.13-MariaDB
-- PHP Version: 5.6.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `practice`
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
(1, 'Breakfast'),
(2, 'Lunch'),
(3, 'Dinner');

-- --------------------------------------------------------

--
-- Table structure for table `recipe`
--

CREATE TABLE `recipe` (
  `RecipeID` int(11) NOT NULL,
  `RecipeName` varchar(40) NOT NULL,
  `ing1` varchar(20) NOT NULL,
  `ing2` varchar(20) NOT NULL,
  `ing3` varchar(20) NOT NULL,
  `ing4` varchar(20) NOT NULL,
  `ing5` varchar(20) NOT NULL,
  `ing6` varchar(20) NOT NULL,
  `ing7` varchar(20) NOT NULL,
  `ing8` varchar(20) NOT NULL,
  `step1` varchar(40) NOT NULL,
  `step2` varchar(40) NOT NULL,
  `step3` varchar(40) NOT NULL,
  `step4` varchar(40) NOT NULL,
  `step5` varchar(40) NOT NULL,
  `step6` varchar(40) NOT NULL,
  `instruction` varchar(100) NOT NULL,
  `categoryID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `recipe`
--

INSERT INTO `recipe` (`RecipeID`, `RecipeName`, `ing1`, `ing2`, `ing3`, `ing4`, `ing5`, `ing6`, `ing7`, `ing8`, `step1`, `step2`, `step3`, `step4`, `step5`, `step6`, `instruction`, `categoryID`) VALUES
(1, 'Chicken Pot Pie', 'chicken', 'salt', 'pepper', 'flour', 'sugar', 'milk', 'eggs', 'pumpkin juice', 'add egg and flower', 'mix egg and flower', 'then add more things', 'mix them too', 'bake for 350 degrees ', 'take out of oven', 'enjoy the eats of this amazing recipe', 3),
(2, 'recioe', '', '', '', '', '', '', '', '', '', '', '', '', '', '', 'hope', 0),
(3, 'Cheesy Poofs', 'cheese', 'bacon', 'cheese', 'salt', 'pepper', 'flour', '', '', 'combine all ingredients', 'fry it up', 'let cool', '', '', '', 'Eat it up and ask your mom for more chessy poofs', 1),
(4, 'Bacon Bits', 'salt', 'pepper', 'sugar', 'brown sugar', 'bacon', 'bacon fat', 'oil', '', 'get out pan', 'fry it up', 'cook till crispy', 'let it cool', '', '', 'Eat it up!', 2),
(5, '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', 0),
(6, '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', 0),
(7, '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', 1),
(8, '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', 2),
(9, 'Biskets', 'salt', 'pepper', 'sugar', 'floure', 'power aid', 'protien', 'oats', '', 'mix', 'blend', '', '', '', '', '', 1),
(10, 'bob', 'gggfotf', 'yugouy', 'pygouygf', 'uygouygg', 'yguoyg', '', '', '', 'oyguuyg', 'iygpyg', 'piygpyg', 'pygpuyg', '', '', '', 2),
(11, 'adrians recipie', 'eat', 'more', 'vegiatables', '', '', '', '', '', '', '', '', '', '', '', '', 1);

-- --------------------------------------------------------

--
-- Table structure for table `username`
--

CREATE TABLE `username` (
  `UserNameID` int(9) NOT NULL,
  `userName` varchar(40) NOT NULL,
  `pass` varchar(40) NOT NULL,
  `email` varchar(40) NOT NULL,
  `fullname` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `username`
--

INSERT INTO `username` (`UserNameID`, `userName`, `pass`, `email`, `fullname`) VALUES
(2, 'tom', 'poor', '', ''),
(3, 'scott', '12345', 'email@email', 'scott vereen'),
(4, 'tommy', 'bob', 'email@email.com', 'tom'),
(5, 'bobby', '123', 'stvereen@email.neit.edu', 'scott t vereen'),
(6, 'scotty', 'bobby', 'email@email', 'scott'),
(7, 'name', 'bob', 'email', 'scott'),
(8, 'name', 'bob', 'email', 'scott'),
(9, '', '', 'yup', ''),
(10, 'scotty', 'bob', 'email@email', 'scott'),
(11, 'bobby', 'bob', 'email@email', 'scott'),
(12, 'suee', 'booppy', 'email@email', 'sue'),
(13, 'thomas', 'bob', 'email@email', 'scotty'),
(14, 'van', 'bob', 'email@email', 'erick');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`categoryID`);

--
-- Indexes for table `recipe`
--
ALTER TABLE `recipe`
  ADD PRIMARY KEY (`RecipeID`);

--
-- Indexes for table `username`
--
ALTER TABLE `username`
  ADD PRIMARY KEY (`UserNameID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `categoryID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `recipe`
--
ALTER TABLE `recipe`
  MODIFY `RecipeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT for table `username`
--
ALTER TABLE `username`
  MODIFY `UserNameID` int(9) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
