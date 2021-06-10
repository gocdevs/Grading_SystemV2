-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 10, 2021 at 04:52 AM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 7.3.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_grading2021`
--

-- --------------------------------------------------------

--
-- Table structure for table `academic_grades`
--

CREATE TABLE `academic_grades` (
  `id` int(11) NOT NULL,
  `goc_no` varchar(255) DEFAULT NULL,
  `student_name` varchar(255) DEFAULT NULL,
  `subject_name` varchar(255) DEFAULT NULL,
  `sem_grade1` varchar(255) DEFAULT NULL,
  `sem_grade2` varchar(255) DEFAULT NULL,
  `average` varchar(255) DEFAULT NULL,
  `grade_level` varchar(255) DEFAULT NULL,
  `section` varchar(255) DEFAULT NULL,
  `strand` varchar(255) DEFAULT NULL,
  `term` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `char_grades_and_attendance`
--

CREATE TABLE `char_grades_and_attendance` (
  `id` int(11) NOT NULL,
  `goc_no` varchar(255) DEFAULT NULL,
  `student_name` varchar(255) DEFAULT NULL,
  `1st_md1` varchar(5) DEFAULT NULL,
  `2nd_md1` varchar(5) DEFAULT NULL,
  `3rd_md1` varchar(5) DEFAULT NULL,
  `4th_md1` varchar(5) DEFAULT NULL,
  `1st_md2` varchar(5) DEFAULT NULL,
  `2nd_md2` varchar(5) DEFAULT NULL,
  `3rd_md2` varchar(5) DEFAULT NULL,
  `4th_md2` varchar(5) DEFAULT NULL,
  `1st_mt1` varchar(5) DEFAULT NULL,
  `2nd_mt1` varchar(5) DEFAULT NULL,
  `3rd_mt1` varchar(5) DEFAULT NULL,
  `4th_mt1` varchar(5) DEFAULT NULL,
  `1st_mt2` varchar(5) DEFAULT NULL,
  `2nd_mt2` varchar(5) DEFAULT NULL,
  `3rd_mt2` varchar(5) DEFAULT NULL,
  `4th_mt2` varchar(5) DEFAULT NULL,
  `1st_mk1` varchar(5) DEFAULT NULL,
  `2nd_mk1` varchar(5) DEFAULT NULL,
  `3rd_mk1` varchar(5) DEFAULT NULL,
  `4th_mk1` varchar(5) DEFAULT NULL,
  `1st_mk2` varchar(5) DEFAULT NULL,
  `2nd_mk2` varchar(5) DEFAULT NULL,
  `3rd_mk2` varchar(5) DEFAULT NULL,
  `4th_mk2` varchar(5) DEFAULT NULL,
  `1st_mb1` varchar(5) DEFAULT NULL,
  `2nd_mb1` varchar(5) DEFAULT NULL,
  `3rd_mb1` varchar(5) DEFAULT NULL,
  `4th_mb1` varchar(5) DEFAULT NULL,
  `1st_mb2` varchar(5) DEFAULT NULL,
  `2nd_mb2` varchar(5) DEFAULT NULL,
  `3rd_mb2` varchar(5) DEFAULT NULL,
  `4th_mb2` varchar(5) DEFAULT NULL,
  `month1` varchar(5) DEFAULT NULL,
  `month2` varchar(5) DEFAULT NULL,
  `month3` varchar(5) DEFAULT NULL,
  `month4` varchar(5) DEFAULT NULL,
  `month5` varchar(5) DEFAULT NULL,
  `month6` varchar(5) DEFAULT NULL,
  `month7` varchar(5) DEFAULT NULL,
  `month8` varchar(5) DEFAULT NULL,
  `month9` varchar(5) DEFAULT NULL,
  `month10` varchar(5) DEFAULT NULL,
  `total_abs` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `faculty`
--

CREATE TABLE `faculty` (
  `id` int(11) NOT NULL,
  `faculty_id` varchar(255) DEFAULT NULL,
  `fname` varchar(255) DEFAULT NULL,
  `lname` varchar(255) DEFAULT NULL,
  `mname` varchar(255) DEFAULT NULL,
  `course` varchar(255) DEFAULT NULL,
  `specialize_subject` varchar(255) DEFAULT NULL,
  `adviser_of` varchar(255) DEFAULT NULL,
  `employement_status` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `faculty_loads`
--

CREATE TABLE `faculty_loads` (
  `id` int(11) NOT NULL,
  `faculty_id` varchar(255) DEFAULT NULL,
  `fname` varchar(255) DEFAULT NULL,
  `mname` varchar(255) DEFAULT NULL,
  `lname` varchar(255) DEFAULT NULL,
  `subject_code` varchar(255) DEFAULT NULL,
  `section` varchar(255) DEFAULT NULL,
  `strand` varchar(255) DEFAULT NULL,
  `semester` varchar(255) DEFAULT NULL,
  `note` varchar(255) DEFAULT NULL,
  `date_assigned` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `grade_level`
--

CREATE TABLE `grade_level` (
  `id` int(11) NOT NULL,
  `grade_level` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `section`
--

CREATE TABLE `section` (
  `id` int(11) NOT NULL,
  `section_name` varchar(255) DEFAULT NULL,
  `strand` varchar(255) DEFAULT NULL,
  `department` varchar(255) DEFAULT NULL,
  `grade_level` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `strand`
--

CREATE TABLE `strand` (
  `id` int(11) NOT NULL,
  `strand_name` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `student_profile`
--

CREATE TABLE `student_profile` (
  `id` int(11) NOT NULL,
  `goc_no` varchar(255) DEFAULT NULL,
  `lrn_no` varchar(255) DEFAULT NULL,
  `fname` varchar(255) DEFAULT NULL,
  `mname` varchar(255) DEFAULT NULL,
  `lname` varchar(255) DEFAULT NULL,
  `grade_level` varchar(255) DEFAULT NULL,
  `section` varchar(255) DEFAULT NULL,
  `strand` varchar(255) DEFAULT NULL,
  `academic_status` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `subject`
--

CREATE TABLE `subject` (
  `id` int(11) NOT NULL,
  `subject_code` varchar(255) DEFAULT NULL,
  `subject_name` varchar(255) DEFAULT NULL,
  `subject_type` varchar(255) DEFAULT NULL,
  `semester` varchar(255) DEFAULT NULL,
  `grade_level` varchar(255) DEFAULT NULL,
  `strand` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `subject_type`
--

CREATE TABLE `subject_type` (
  `id` int(11) NOT NULL,
  `subject_type` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `academic_grades`
--
ALTER TABLE `academic_grades`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `char_grades_and_attendance`
--
ALTER TABLE `char_grades_and_attendance`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `faculty`
--
ALTER TABLE `faculty`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `faculty_loads`
--
ALTER TABLE `faculty_loads`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `grade_level`
--
ALTER TABLE `grade_level`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `section`
--
ALTER TABLE `section`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `strand`
--
ALTER TABLE `strand`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `student_profile`
--
ALTER TABLE `student_profile`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `subject`
--
ALTER TABLE `subject`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `subject_type`
--
ALTER TABLE `subject_type`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `academic_grades`
--
ALTER TABLE `academic_grades`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `char_grades_and_attendance`
--
ALTER TABLE `char_grades_and_attendance`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `faculty`
--
ALTER TABLE `faculty`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `faculty_loads`
--
ALTER TABLE `faculty_loads`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `section`
--
ALTER TABLE `section`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `student_profile`
--
ALTER TABLE `student_profile`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `subject`
--
ALTER TABLE `subject`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
