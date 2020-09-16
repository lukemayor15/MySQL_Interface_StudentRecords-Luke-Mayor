-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 16, 2020 at 01:42 AM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.4.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `studentrecords`
--

-- --------------------------------------------------------

--
-- Table structure for table `address`
--

CREATE TABLE `address` (
  `address_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `a_postcode` varchar(7) NOT NULL COMMENT 'Post code of the student/staff address',
  `a_address_line1` varchar(200) NOT NULL COMMENT 'Address line 1 of a student/staff address',
  `a_address_line2` varchar(200) DEFAULT NULL COMMENT 'Address line 2 of a student/staff address',
  `a_town` varchar(70) NOT NULL COMMENT 'Town/city of student/staff address',
  `a_county` varchar(30) NOT NULL COMMENT 'County of the student/staff address',
  `a_current_address` tinyint(4) NOT NULL COMMENT 'Is the address their current address'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `address`
--

INSERT INTO `address` (`address_id`, `user_id`, `a_postcode`, `a_address_line1`, `a_address_line2`, `a_town`, `a_county`, `a_current_address`) VALUES
(1, 1, 'f111', '111', '111', '1', '1', 1);

-- --------------------------------------------------------

--
-- Table structure for table `course`
--

CREATE TABLE `course` (
  `course_id` int(11) NOT NULL,
  `aim_id` int(11) NOT NULL,
  `c_cname` text NOT NULL,
  `c_level` varchar(50) NOT NULL COMMENT 'Level of the course',
  `c_start_d` date NOT NULL COMMENT 'The start date for the course',
  `C_end_d` date NOT NULL COMMENT 'The end date for the course'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `department`
--

CREATE TABLE `department` (
  `dep_id` int(11) NOT NULL,
  `dep_name` varchar(50) NOT NULL,
  `dep_email` varchar(200) NOT NULL COMMENT 'Email of the department',
  `dep_phone_no` varchar(20) NOT NULL COMMENT 'Phone number of the department',
  `dep_leader` varchar(50) NOT NULL COMMENT 'Name of the head of department'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `department`
--

INSERT INTO `department` (`dep_id`, `dep_name`, `dep_email`, `dep_phone_no`, `dep_leader`) VALUES
(1, 'w', 'w', 'w', 'w'),
(2, 'w', 'w', 'ww', 'w');

-- --------------------------------------------------------

--
-- Table structure for table `enrolment`
--

CREATE TABLE `enrolment` (
  `enrolment_id` int(11) NOT NULL,
  `course_id` int(11) NOT NULL,
  `student_id` int(11) NOT NULL,
  `en_date` date NOT NULL COMMENT 'The date when the enrolment took place'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `job_role`
--

CREATE TABLE `job_role` (
  `role_id` int(11) NOT NULL,
  `staff_id` int(11) NOT NULL,
  `dep_id` int(11) NOT NULL,
  `j_title` varchar(59) NOT NULL COMMENT 'Title of staff job role'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `learning_aim`
--

CREATE TABLE `learning_aim` (
  `aim_id` int(11) NOT NULL,
  `dep_id` int(11) NOT NULL,
  `l_learning_aim_title` varchar(150) NOT NULL COMMENT 'The title of the learning aim',
  `l_learning_aim_description` text NOT NULL COMMENT 'A description of the objectives of the learning aim'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `next_of_kin`
--

CREATE TABLE `next_of_kin` (
  `kin_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `k_fname` varchar(50) NOT NULL COMMENT 'First name of the next of kin',
  `k_phone_no` varchar(20) NOT NULL COMMENT 'Phone number of the next of kin'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `staff_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `st_fname` varchar(50) NOT NULL COMMENT 'First name of staff ',
  `st_sname` varchar(50) NOT NULL COMMENT ' Surname of staff ',
  `st_mname` varchar(50) DEFAULT NULL COMMENT 'Middle name of staff optional',
  `st_dob` date NOT NULL COMMENT 'Staff data of birth',
  `st_phone_no` varchar(20) NOT NULL COMMENT 'Staff phone number',
  `st_email` varchar(200) NOT NULL COMMENT 'Staff email address',
  `st_id_image` varchar(200) NOT NULL COMMENT 'Photo ID of staff store using a path'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `student_id` int(11) NOT NULL,
  `user_id` int(50) NOT NULL,
  `s_fname` varchar(50) NOT NULL COMMENT 'First name of student',
  `s_sname` varchar(50) NOT NULL COMMENT 'Surname of student',
  `s_mname` varchar(50) DEFAULT NULL COMMENT 'Middle name of student optional',
  `s_dob` date NOT NULL COMMENT 'Date of birth of student',
  `s_phone_no` varchar(20) NOT NULL COMMENT 'Phone number of student',
  `s_email` varchar(200) NOT NULL COMMENT 'Email of student',
  `s_id_image` varchar(200) NOT NULL COMMENT 'Photo ID of student store using a path'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `user_account`
--

CREATE TABLE `user_account` (
  `user_id` int(11) NOT NULL,
  `u_uname` varchar(10) NOT NULL,
  `u_access_level` int(11) NOT NULL,
  `u_password` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `address`
--
ALTER TABLE `address`
  ADD PRIMARY KEY (`address_id`);

--
-- Indexes for table `course`
--
ALTER TABLE `course`
  ADD PRIMARY KEY (`course_id`);

--
-- Indexes for table `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`dep_id`);

--
-- Indexes for table `enrolment`
--
ALTER TABLE `enrolment`
  ADD PRIMARY KEY (`enrolment_id`);

--
-- Indexes for table `job_role`
--
ALTER TABLE `job_role`
  ADD PRIMARY KEY (`role_id`);

--
-- Indexes for table `learning_aim`
--
ALTER TABLE `learning_aim`
  ADD PRIMARY KEY (`aim_id`);

--
-- Indexes for table `next_of_kin`
--
ALTER TABLE `next_of_kin`
  ADD PRIMARY KEY (`kin_id`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`staff_id`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`student_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `address`
--
ALTER TABLE `address`
  MODIFY `address_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `course`
--
ALTER TABLE `course`
  MODIFY `course_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `department`
--
ALTER TABLE `department`
  MODIFY `dep_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `enrolment`
--
ALTER TABLE `enrolment`
  MODIFY `enrolment_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `job_role`
--
ALTER TABLE `job_role`
  MODIFY `role_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `learning_aim`
--
ALTER TABLE `learning_aim`
  MODIFY `aim_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `next_of_kin`
--
ALTER TABLE `next_of_kin`
  MODIFY `kin_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `staff`
--
ALTER TABLE `staff`
  MODIFY `staff_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `student`
--
ALTER TABLE `student`
  MODIFY `student_id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
