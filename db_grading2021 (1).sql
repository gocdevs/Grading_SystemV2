-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 30, 2021 at 04:09 AM
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
  `employment_status` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `faculty`
--

INSERT INTO `faculty` (`id`, `faculty_id`, `fname`, `lname`, `mname`, `course`, `specialize_subject`, `adviser_of`, `employment_status`) VALUES
(1, '0001', 'Efraim', 'Basilio', 'Garcia', 'AA', 'Name', 'Hermes', 'AAA'),
(2, '121212', 'Rodel', 'Ramos', 'I', 'BSIT', 'Java Programming', 'Hermes', 'A'),
(5, '0003', 'Karl', 'Cabrera', 'M', 'BSN', 'Math Name', 'Hermes', 'Regular');

-- --------------------------------------------------------

--
-- Table structure for table `faculty_loads`
--

CREATE TABLE `faculty_loads` (
  `id` int(11) NOT NULL,
  `faculty_id` varchar(255) DEFAULT NULL,
  `fullname` varchar(255) DEFAULT NULL,
  `subject_code` varchar(255) DEFAULT NULL,
  `strand` varchar(255) DEFAULT NULL,
  `semester` varchar(255) DEFAULT NULL,
  `grade_level` varchar(255) DEFAULT NULL,
  `subjectType` varchar(255) DEFAULT NULL,
  `section` varchar(255) DEFAULT NULL,
  `date_assigned` varchar(255) DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `faculty_loads`
--

INSERT INTO `faculty_loads` (`id`, `faculty_id`, `fullname`, `subject_code`, `strand`, `semester`, `grade_level`, `subjectType`, `section`, `date_assigned`) VALUES
(11, '0001', 'Efraim G. Basilio', 'WORLDLIT 11-1', 'All Strand', '1st', '11', 'CORE SUBJECTS', 'Zeus', '2021-07-20 17:50:40'),
(12, '0001', 'Efraim G. Basilio', 'ARTCON 11-2', 'All Strand', '2nd', '11', 'APPLIED SUBJECTS', 'Zeus', '2021-07-20 17:50:40'),
(13, '121212', 'Rodel I. Ramos', 'WORLDLIT 11-1', 'All Strand', '1st', '11', 'CORE SUBJECTS', 'Hermes', '2021-07-20 19:37:42'),
(14, '121212', 'Rodel I. Ramos', 'EARTHSCI 11-1', 'All Strand', '1st', '11', 'CORE SUBJECTS', 'Athena', '2021-07-23 22:27:59'),
(15, '0003', 'Karl M. Cabrera', 'ARTCON 11-2', 'All Strand', '2nd', '11', 'APPLIED SUBJECTS', 'Hyperion', '2021-07-23 22:27:59'),
(16, '0003', 'Karl M. Cabrera', 'GENMATH 11-1', 'All Strand', '1st', '11', 'CORE SUBJECTS', 'Zeus', '2021-07-23 22:42:15');

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
-- Table structure for table `grading`
--

CREATE TABLE `grading` (
  `id` int(11) NOT NULL,
  `lrn_no` varchar(255) DEFAULT NULL,
  `fullname` varchar(255) DEFAULT NULL,
  `subject_code` varchar(255) DEFAULT NULL,
  `subject_desc` varchar(255) DEFAULT NULL,
  `units` varchar(255) DEFAULT NULL,
  `1st_or_3rd_Q` varchar(255) DEFAULT NULL,
  `2nd_or_4th_Q` varchar(255) DEFAULT NULL,
  `average` varchar(255) DEFAULT NULL,
  `remarks` varchar(255) DEFAULT NULL,
  `sem` varchar(255) DEFAULT NULL,
  `grade_level` varchar(255) DEFAULT NULL,
  `section` varchar(255) DEFAULT NULL,
  `strand` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `grading`
--

INSERT INTO `grading` (`id`, `lrn_no`, `fullname`, `subject_code`, `subject_desc`, `units`, `1st_or_3rd_Q`, `2nd_or_4th_Q`, `average`, `remarks`, `sem`, `grade_level`, `section`, `strand`) VALUES
(1, '106772100029', 'ALEXXAKAYE M. BASILIO', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(2, '106772100029', 'ALEXXAKAYE M. BASILIO', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(3, '106772100029', 'ALEXXAKAYE M. BASILIO', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(4, '106772100029', 'ALEXXAKAYE M. BASILIO', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(5, '106772100029', 'ALEXXAKAYE M. BASILIO', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(6, '106772100029', 'ALEXXAKAYE M. BASILIO', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(7, '106772100029', 'ALEXXAKAYE M. BASILIO', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(8, '106772100029', 'ALEXXAKAYE M. BASILIO', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(9, '106772100029', 'ALEXXAKAYE M. BASILIO', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(10, '106772100029', 'ALEXXAKAYE M. BASILIO', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(11, '106742100023', 'Kristine Grace A. David', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(12, '106742100023', 'Kristine Grace A. David', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(13, '106742100023', 'Kristine Grace A. David', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(14, '106742100023', 'Kristine Grace A. David', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(15, '106742100023', 'Kristine Grace A. David', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(16, '106742100023', 'Kristine Grace A. David', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(17, '106742100023', 'Kristine Grace A. David', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(18, '106742100023', 'Kristine Grace A. David', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(19, '106742100023', 'Kristine Grace A. David', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(20, '106742100023', 'Kristine Grace A. David', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(21, '106774100047', 'Caria Angel C. De Guzman', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(22, '106774100047', 'Caria Angel C. De Guzman', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(23, '106774100047', 'Caria Angel C. De Guzman', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(24, '106774100047', 'Caria Angel C. De Guzman', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(25, '106774100047', 'Caria Angel C. De Guzman', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(26, '106774100047', 'Caria Angel C. De Guzman', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(27, '106774100047', 'Caria Angel C. De Guzman', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(28, '106774100047', 'Caria Angel C. De Guzman', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(29, '106774100047', 'Caria Angel C. De Guzman', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(30, '106774100047', 'Caria Angel C. De Guzman', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(31, '106484090017', 'JHUN LOID C. DE GUZMAN', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'STEM '),
(32, '106484090017', 'JHUN LOID C. DE GUZMAN', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'STEM '),
(33, '106484090017', 'JHUN LOID C. DE GUZMAN', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'STEM '),
(34, '106484090017', 'JHUN LOID C. DE GUZMAN', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'STEM '),
(35, '106484090017', 'JHUN LOID C. DE GUZMAN', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'STEM '),
(36, '106484090017', 'JHUN LOID C. DE GUZMAN', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'STEM '),
(37, '106484090017', 'JHUN LOID C. DE GUZMAN', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'STEM '),
(38, '106484090017', 'JHUN LOID C. DE GUZMAN', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'STEM '),
(39, '106484090017', 'JHUN LOID C. DE GUZMAN', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'STEM '),
(40, '106484090017', 'JHUN LOID C. DE GUZMAN', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'STEM '),
(41, '106704100060', 'Russel N. Deang', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'STEM '),
(42, '106704100060', 'Russel N. Deang', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'STEM '),
(43, '106704100060', 'Russel N. Deang', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'STEM '),
(44, '106704100060', 'Russel N. Deang', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'STEM '),
(45, '106704100060', 'Russel N. Deang', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'STEM '),
(46, '106704100060', 'Russel N. Deang', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'STEM '),
(47, '106704100060', 'Russel N. Deang', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'STEM '),
(48, '106704100060', 'Russel N. Deang', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'STEM '),
(49, '106704100060', 'Russel N. Deang', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'STEM '),
(50, '106704100060', 'Russel N. Deang', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'STEM '),
(51, '106746100065', 'Alexa Mae R. Dela Cruz', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(52, '106746100065', 'Alexa Mae R. Dela Cruz', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(53, '106746100065', 'Alexa Mae R. Dela Cruz', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(54, '106746100065', 'Alexa Mae R. Dela Cruz', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(55, '106746100065', 'Alexa Mae R. Dela Cruz', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(56, '106746100065', 'Alexa Mae R. Dela Cruz', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(57, '106746100065', 'Alexa Mae R. Dela Cruz', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(58, '106746100065', 'Alexa Mae R. Dela Cruz', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(59, '106746100065', 'Alexa Mae R. Dela Cruz', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(60, '106746100065', 'Alexa Mae R. Dela Cruz', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(61, '106695100037', 'Jolly Hannah E. Dela Cruz', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(62, '106695100037', 'Jolly Hannah E. Dela Cruz', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(63, '106695100037', 'Jolly Hannah E. Dela Cruz', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(64, '106695100037', 'Jolly Hannah E. Dela Cruz', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(65, '106695100037', 'Jolly Hannah E. Dela Cruz', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(66, '106695100037', 'Jolly Hannah E. Dela Cruz', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(67, '106695100037', 'Jolly Hannah E. Dela Cruz', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(68, '106695100037', 'Jolly Hannah E. Dela Cruz', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(69, '106695100037', 'Jolly Hannah E. Dela Cruz', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(70, '106695100037', 'Jolly Hannah E. Dela Cruz', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Hermes', 'ABM '),
(71, '489520150156', 'John Paul S. Aguirre', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(72, '489520150156', 'John Paul S. Aguirre', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(73, '489520150156', 'John Paul S. Aguirre', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(74, '489520150156', 'John Paul S. Aguirre', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(75, '489520150156', 'John Paul S. Aguirre', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(76, '489520150156', 'John Paul S. Aguirre', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(77, '489520150156', 'John Paul S. Aguirre', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(78, '489520150156', 'John Paul S. Aguirre', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(79, '489520150156', 'John Paul S. Aguirre', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(80, '489520150156', 'John Paul S. Aguirre', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(81, '106329100007', 'JENAH MAEDELYN U. AGUSTIN', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(82, '106329100007', 'JENAH MAEDELYN U. AGUSTIN', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(83, '106329100007', 'JENAH MAEDELYN U. AGUSTIN', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(84, '106329100007', 'JENAH MAEDELYN U. AGUSTIN', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(85, '106329100007', 'JENAH MAEDELYN U. AGUSTIN', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(86, '106329100007', 'JENAH MAEDELYN U. AGUSTIN', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(87, '106329100007', 'JENAH MAEDELYN U. AGUSTIN', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(88, '106329100007', 'JENAH MAEDELYN U. AGUSTIN', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(89, '106329100007', 'JENAH MAEDELYN U. AGUSTIN', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(90, '106329100007', 'JENAH MAEDELYN U. AGUSTIN', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(91, '10673110002', 'Heaven Lyane H. Alabon', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(92, '10673110002', 'Heaven Lyane H. Alabon', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(93, '10673110002', 'Heaven Lyane H. Alabon', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(94, '10673110002', 'Heaven Lyane H. Alabon', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(95, '10673110002', 'Heaven Lyane H. Alabon', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(96, '10673110002', 'Heaven Lyane H. Alabon', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(97, '10673110002', 'Heaven Lyane H. Alabon', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(98, '10673110002', 'Heaven Lyane H. Alabon', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(99, '10673110002', 'Heaven Lyane H. Alabon', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(100, '10673110002', 'Heaven Lyane H. Alabon', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(101, '106694100007', 'IVAN S. ARANCIS', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(102, '106694100007', 'IVAN S. ARANCIS', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(103, '106694100007', 'IVAN S. ARANCIS', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(104, '106694100007', 'IVAN S. ARANCIS', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(105, '106694100007', 'IVAN S. ARANCIS', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(106, '106694100007', 'IVAN S. ARANCIS', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(107, '106694100007', 'IVAN S. ARANCIS', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(108, '106694100007', 'IVAN S. ARANCIS', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(109, '106694100007', 'IVAN S. ARANCIS', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(110, '106694100007', 'IVAN S. ARANCIS', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(111, '106797100014', 'Joan P. Ariola', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(112, '106797100014', 'Joan P. Ariola', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(113, '106797100014', 'Joan P. Ariola', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(114, '106797100014', 'Joan P. Ariola', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(115, '106797100014', 'Joan P. Ariola', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(116, '106797100014', 'Joan P. Ariola', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(117, '106797100014', 'Joan P. Ariola', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(118, '106797100014', 'Joan P. Ariola', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(119, '106797100014', 'Joan P. Ariola', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(120, '106797100014', 'Joan P. Ariola', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(121, '10529110004', 'John John F. Arquiza', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(122, '10529110004', 'John John F. Arquiza', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(123, '10529110004', 'John John F. Arquiza', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(124, '10529110004', 'John John F. Arquiza', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(125, '10529110004', 'John John F. Arquiza', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(126, '10529110004', 'John John F. Arquiza', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(127, '10529110004', 'John John F. Arquiza', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(128, '10529110004', 'John John F. Arquiza', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(129, '10529110004', 'John John F. Arquiza', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(130, '10529110004', 'John John F. Arquiza', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(131, '700027190193', 'Jan Eowynne M. Atienza', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(132, '700027190193', 'Jan Eowynne M. Atienza', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(133, '700027190193', 'Jan Eowynne M. Atienza', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(134, '700027190193', 'Jan Eowynne M. Atienza', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(135, '700027190193', 'Jan Eowynne M. Atienza', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(136, '700027190193', 'Jan Eowynne M. Atienza', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(137, '700027190193', 'Jan Eowynne M. Atienza', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(138, '700027190193', 'Jan Eowynne M. Atienza', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(139, '700027190193', 'Jan Eowynne M. Atienza', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(140, '700027190193', 'Jan Eowynne M. Atienza', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(141, '106505140082', 'Marc Andrei I. Austria', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(142, '106505140082', 'Marc Andrei I. Austria', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(143, '106505140082', 'Marc Andrei I. Austria', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(144, '106505140082', 'Marc Andrei I. Austria', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(145, '106505140082', 'Marc Andrei I. Austria', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(146, '106505140082', 'Marc Andrei I. Austria', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(147, '106505140082', 'Marc Andrei I. Austria', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(148, '106505140082', 'Marc Andrei I. Austria', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(149, '106505140082', 'Marc Andrei I. Austria', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(150, '106505140082', 'Marc Andrei I. Austria', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(151, '108247120486', 'Rhonnel T. Ayuro', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(152, '108247120486', 'Rhonnel T. Ayuro', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(153, '108247120486', 'Rhonnel T. Ayuro', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(154, '108247120486', 'Rhonnel T. Ayuro', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(155, '108247120486', 'Rhonnel T. Ayuro', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(156, '108247120486', 'Rhonnel T. Ayuro', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(157, '108247120486', 'Rhonnel T. Ayuro', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(158, '108247120486', 'Rhonnel T. Ayuro', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(159, '108247120486', 'Rhonnel T. Ayuro', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(160, '108247120486', 'Rhonnel T. Ayuro', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(161, '126214120194', 'Khrissta Ruth E. Caballa', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(162, '126214120194', 'Khrissta Ruth E. Caballa', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(163, '126214120194', 'Khrissta Ruth E. Caballa', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(164, '126214120194', 'Khrissta Ruth E. Caballa', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(165, '126214120194', 'Khrissta Ruth E. Caballa', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(166, '126214120194', 'Khrissta Ruth E. Caballa', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(167, '126214120194', 'Khrissta Ruth E. Caballa', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(168, '126214120194', 'Khrissta Ruth E. Caballa', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(169, '126214120194', 'Khrissta Ruth E. Caballa', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(170, '126214120194', 'Khrissta Ruth E. Caballa', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(171, '401528150780', 'Mekaella Q. Cabana', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(172, '401528150780', 'Mekaella Q. Cabana', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(173, '401528150780', 'Mekaella Q. Cabana', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(174, '401528150780', 'Mekaella Q. Cabana', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(175, '401528150780', 'Mekaella Q. Cabana', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(176, '401528150780', 'Mekaella Q. Cabana', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(177, '401528150780', 'Mekaella Q. Cabana', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(178, '401528150780', 'Mekaella Q. Cabana', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(179, '401528150780', 'Mekaella Q. Cabana', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(180, '401528150780', 'Mekaella Q. Cabana', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(181, '489519150057', 'Ezekiel P. Cortez', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(182, '489519150057', 'Ezekiel P. Cortez', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(183, '489519150057', 'Ezekiel P. Cortez', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(184, '489519150057', 'Ezekiel P. Cortez', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(185, '489519150057', 'Ezekiel P. Cortez', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(186, '489519150057', 'Ezekiel P. Cortez', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(187, '489519150057', 'Ezekiel P. Cortez', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(188, '489519150057', 'Ezekiel P. Cortez', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(189, '489519150057', 'Ezekiel P. Cortez', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(190, '489519150057', 'Ezekiel P. Cortez', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(191, '101604100014', 'ADRIAN PRINCE B. DAYAO', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(192, '101604100014', 'ADRIAN PRINCE B. DAYAO', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(193, '101604100014', 'ADRIAN PRINCE B. DAYAO', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(194, '101604100014', 'ADRIAN PRINCE B. DAYAO', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(195, '101604100014', 'ADRIAN PRINCE B. DAYAO', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(196, '101604100014', 'ADRIAN PRINCE B. DAYAO', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(197, '101604100014', 'ADRIAN PRINCE B. DAYAO', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(198, '101604100014', 'ADRIAN PRINCE B. DAYAO', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(199, '101604100014', 'ADRIAN PRINCE B. DAYAO', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(200, '101604100014', 'ADRIAN PRINCE B. DAYAO', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(201, '401548150125', 'Korben Deniell R. Melgar', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(202, '401548150125', 'Korben Deniell R. Melgar', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(203, '401548150125', 'Korben Deniell R. Melgar', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(204, '401548150125', 'Korben Deniell R. Melgar', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(205, '401548150125', 'Korben Deniell R. Melgar', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(206, '401548150125', 'Korben Deniell R. Melgar', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(207, '401548150125', 'Korben Deniell R. Melgar', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(208, '401548150125', 'Korben Deniell R. Melgar', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(209, '401548150125', 'Korben Deniell R. Melgar', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(210, '401548150125', 'Korben Deniell R. Melgar', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(211, '106731090067', 'Meanne Crystal C. Manicdo', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(212, '106731090067', 'Meanne Crystal C. Manicdo', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(213, '106731090067', 'Meanne Crystal C. Manicdo', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(214, '106731090067', 'Meanne Crystal C. Manicdo', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(215, '106731090067', 'Meanne Crystal C. Manicdo', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(216, '106731090067', 'Meanne Crystal C. Manicdo', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(217, '106731090067', 'Meanne Crystal C. Manicdo', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(218, '106731090067', 'Meanne Crystal C. Manicdo', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(219, '106731090067', 'Meanne Crystal C. Manicdo', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(220, '106731090067', 'Meanne Crystal C. Manicdo', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(221, '401537150168', 'Shanaia Ishi D. Cueva', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(222, '401537150168', 'Shanaia Ishi D. Cueva', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(223, '401537150168', 'Shanaia Ishi D. Cueva', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(224, '401537150168', 'Shanaia Ishi D. Cueva', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(225, '401537150168', 'Shanaia Ishi D. Cueva', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(226, '401537150168', 'Shanaia Ishi D. Cueva', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(227, '401537150168', 'Shanaia Ishi D. Cueva', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(228, '401537150168', 'Shanaia Ishi D. Cueva', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(229, '401537150168', 'Shanaia Ishi D. Cueva', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(230, '401537150168', 'Shanaia Ishi D. Cueva', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(231, '105111090083', 'Tricia Romae S. Cunanan', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(232, '105111090083', 'Tricia Romae S. Cunanan', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(233, '105111090083', 'Tricia Romae S. Cunanan', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(234, '105111090083', 'Tricia Romae S. Cunanan', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(235, '105111090083', 'Tricia Romae S. Cunanan', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(236, '105111090083', 'Tricia Romae S. Cunanan', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(237, '105111090083', 'Tricia Romae S. Cunanan', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(238, '105111090083', 'Tricia Romae S. Cunanan', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(239, '105111090083', 'Tricia Romae S. Cunanan', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(240, '105111090083', 'Tricia Romae S. Cunanan', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(241, '136404090061', 'Jazper T. Castro', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(242, '136404090061', 'Jazper T. Castro', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(243, '136404090061', 'Jazper T. Castro', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(244, '136404090061', 'Jazper T. Castro', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(245, '136404090061', 'Jazper T. Castro', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(246, '136404090061', 'Jazper T. Castro', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(247, '136404090061', 'Jazper T. Castro', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(248, '136404090061', 'Jazper T. Castro', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(249, '136404090061', 'Jazper T. Castro', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(250, '136404090061', 'Jazper T. Castro', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(251, '106696090107', 'Kyl Dimples R. Dulay', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(252, '106696090107', 'Kyl Dimples R. Dulay', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(253, '106696090107', 'Kyl Dimples R. Dulay', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(254, '106696090107', 'Kyl Dimples R. Dulay', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(255, '106696090107', 'Kyl Dimples R. Dulay', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(256, '106696090107', 'Kyl Dimples R. Dulay', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(257, '106696090107', 'Kyl Dimples R. Dulay', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(258, '106696090107', 'Kyl Dimples R. Dulay', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(259, '106696090107', 'Kyl Dimples R. Dulay', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(260, '106696090107', 'Kyl Dimples R. Dulay', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(261, '106679090012', 'Lovely Noreen C. Corpuz', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(262, '106679090012', 'Lovely Noreen C. Corpuz', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(263, '106679090012', 'Lovely Noreen C. Corpuz', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(264, '106679090012', 'Lovely Noreen C. Corpuz', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(265, '106679090012', 'Lovely Noreen C. Corpuz', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(266, '106679090012', 'Lovely Noreen C. Corpuz', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(267, '106679090012', 'Lovely Noreen C. Corpuz', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(268, '106679090012', 'Lovely Noreen C. Corpuz', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(269, '106679090012', 'Lovely Noreen C. Corpuz', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(270, '106679090012', 'Lovely Noreen C. Corpuz', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(271, '106755090057', 'Sophia B. Guiao', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(272, '106755090057', 'Sophia B. Guiao', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(273, '106755090057', 'Sophia B. Guiao', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(274, '106755090057', 'Sophia B. Guiao', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(275, '106755090057', 'Sophia B. Guiao', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(276, '106755090057', 'Sophia B. Guiao', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(277, '106755090057', 'Sophia B. Guiao', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(278, '106755090057', 'Sophia B. Guiao', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(279, '106755090057', 'Sophia B. Guiao', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(280, '106755090057', 'Sophia B. Guiao', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(281, '201900087', 'Mary Christina L. Mallari', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(282, '201900087', 'Mary Christina L. Mallari', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(283, '201900087', 'Mary Christina L. Mallari', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(284, '201900087', 'Mary Christina L. Mallari', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(285, '201900087', 'Mary Christina L. Mallari', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(286, '201900087', 'Mary Christina L. Mallari', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(287, '201900087', 'Mary Christina L. Mallari', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(288, '201900087', 'Mary Christina L. Mallari', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(289, '201900087', 'Mary Christina L. Mallari', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(290, '201900087', 'Mary Christina L. Mallari', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(291, '48950681', 'Clyde Lester A. Ramos', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(292, '48950681', 'Clyde Lester A. Ramos', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(293, '48950681', 'Clyde Lester A. Ramos', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(294, '48950681', 'Clyde Lester A. Ramos', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(295, '48950681', 'Clyde Lester A. Ramos', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(296, '48950681', 'Clyde Lester A. Ramos', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(297, '48950681', 'Clyde Lester A. Ramos', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(298, '48950681', 'Clyde Lester A. Ramos', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(299, '48950681', 'Clyde Lester A. Ramos', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(300, '48950681', 'Clyde Lester A. Ramos', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(301, '489506150542', 'Neil Lawrence M. Aquino', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(302, '489506150542', 'Neil Lawrence M. Aquino', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(303, '489506150542', 'Neil Lawrence M. Aquino', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(304, '489506150542', 'Neil Lawrence M. Aquino', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(305, '489506150542', 'Neil Lawrence M. Aquino', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(306, '489506150542', 'Neil Lawrence M. Aquino', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(307, '489506150542', 'Neil Lawrence M. Aquino', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(308, '489506150542', 'Neil Lawrence M. Aquino', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(309, '489506150542', 'Neil Lawrence M. Aquino', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(310, '489506150542', 'Neil Lawrence M. Aquino', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(311, '489506150681', 'Clyde Lester A. Ramos', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(312, '489506150681', 'Clyde Lester A. Ramos', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(313, '489506150681', 'Clyde Lester A. Ramos', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(314, '489506150681', 'Clyde Lester A. Ramos', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(315, '489506150681', 'Clyde Lester A. Ramos', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(316, '489506150681', 'Clyde Lester A. Ramos', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(317, '489506150681', 'Clyde Lester A. Ramos', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(318, '489506150681', 'Clyde Lester A. Ramos', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(319, '489506150681', 'Clyde Lester A. Ramos', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(320, '489506150681', 'Clyde Lester A. Ramos', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(321, '106477080033', 'Mark Kenneth G. Lacayanga', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(322, '106477080033', 'Mark Kenneth G. Lacayanga', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM ');
INSERT INTO `grading` (`id`, `lrn_no`, `fullname`, `subject_code`, `subject_desc`, `units`, `1st_or_3rd_Q`, `2nd_or_4th_Q`, `average`, `remarks`, `sem`, `grade_level`, `section`, `strand`) VALUES
(323, '106477080033', 'Mark Kenneth G. Lacayanga', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(324, '106477080033', 'Mark Kenneth G. Lacayanga', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(325, '106477080033', 'Mark Kenneth G. Lacayanga', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(326, '106477080033', 'Mark Kenneth G. Lacayanga', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(327, '106477080033', 'Mark Kenneth G. Lacayanga', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(328, '106477080033', 'Mark Kenneth G. Lacayanga', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(329, '106477080033', 'Mark Kenneth G. Lacayanga', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(330, '106477080033', 'Mark Kenneth G. Lacayanga', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(331, '106696090450', 'Ma.Andrea Lhey C. Zapata', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(332, '106696090450', 'Ma.Andrea Lhey C. Zapata', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(333, '106696090450', 'Ma.Andrea Lhey C. Zapata', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(334, '106696090450', 'Ma.Andrea Lhey C. Zapata', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(335, '106696090450', 'Ma.Andrea Lhey C. Zapata', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(336, '106696090450', 'Ma.Andrea Lhey C. Zapata', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(337, '106696090450', 'Ma.Andrea Lhey C. Zapata', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(338, '106696090450', 'Ma.Andrea Lhey C. Zapata', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(339, '106696090450', 'Ma.Andrea Lhey C. Zapata', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(340, '106696090450', 'Ma.Andrea Lhey C. Zapata', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(341, '106730090054', 'Scharlette B. Tongol', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(342, '106730090054', 'Scharlette B. Tongol', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(343, '106730090054', 'Scharlette B. Tongol', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(344, '106730090054', 'Scharlette B. Tongol', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(345, '106730090054', 'Scharlette B. Tongol', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(346, '106730090054', 'Scharlette B. Tongol', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(347, '106730090054', 'Scharlette B. Tongol', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(348, '106730090054', 'Scharlette B. Tongol', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(349, '106730090054', 'Scharlette B. Tongol', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(350, '106730090054', 'Scharlette B. Tongol', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(351, '10949120310', 'Xavier Louis L. De Guzman', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(352, '10949120310', 'Xavier Louis L. De Guzman', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(353, '10949120310', 'Xavier Louis L. De Guzman', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(354, '10949120310', 'Xavier Louis L. De Guzman', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(355, '10949120310', 'Xavier Louis L. De Guzman', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(356, '10949120310', 'Xavier Louis L. De Guzman', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(357, '10949120310', 'Xavier Louis L. De Guzman', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(358, '10949120310', 'Xavier Louis L. De Guzman', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(359, '10949120310', 'Xavier Louis L. De Guzman', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(360, '10949120310', 'Xavier Louis L. De Guzman', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(361, '489523150107', 'Kate Angel Nichole L. Calma', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(362, '489523150107', 'Kate Angel Nichole L. Calma', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(363, '489523150107', 'Kate Angel Nichole L. Calma', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(364, '489523150107', 'Kate Angel Nichole L. Calma', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(365, '489523150107', 'Kate Angel Nichole L. Calma', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(366, '489523150107', 'Kate Angel Nichole L. Calma', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(367, '489523150107', 'Kate Angel Nichole L. Calma', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(368, '489523150107', 'Kate Angel Nichole L. Calma', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(369, '489523150107', 'Kate Angel Nichole L. Calma', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(370, '489523150107', 'Kate Angel Nichole L. Calma', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(371, '489523150107', 'Kate Angel Nichole L. Calma', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(372, '489523150107', 'Kate Angel Nichole L. Calma', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(373, '489523150107', 'Kate Angel Nichole L. Calma', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(374, '489523150107', 'Kate Angel Nichole L. Calma', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(375, '489523150107', 'Kate Angel Nichole L. Calma', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(376, '489523150107', 'Kate Angel Nichole L. Calma', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(377, '489523150107', 'Kate Angel Nichole L. Calma', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(378, '489523150107', 'Kate Angel Nichole L. Calma', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(379, '489523150107', 'Kate Angel Nichole L. Calma', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(380, '489523150107', 'Kate Angel Nichole L. Calma', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(381, '420057150051', 'Hidie S. Lorenzo', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(382, '420057150051', 'Hidie S. Lorenzo', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(383, '420057150051', 'Hidie S. Lorenzo', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(384, '420057150051', 'Hidie S. Lorenzo', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(385, '420057150051', 'Hidie S. Lorenzo', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(386, '420057150051', 'Hidie S. Lorenzo', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(387, '420057150051', 'Hidie S. Lorenzo', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(388, '420057150051', 'Hidie S. Lorenzo', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(389, '420057150051', 'Hidie S. Lorenzo', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(390, '420057150051', 'Hidie S. Lorenzo', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(391, '106767090245', 'Mary Hyacinth A. Villanueva', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(392, '106767090245', 'Mary Hyacinth A. Villanueva', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(393, '106767090245', 'Mary Hyacinth A. Villanueva', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(394, '106767090245', 'Mary Hyacinth A. Villanueva', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(395, '106767090245', 'Mary Hyacinth A. Villanueva', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(396, '106767090245', 'Mary Hyacinth A. Villanueva', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(397, '106767090245', 'Mary Hyacinth A. Villanueva', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(398, '106767090245', 'Mary Hyacinth A. Villanueva', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(399, '106767090245', 'Mary Hyacinth A. Villanueva', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(400, '106767090245', 'Mary Hyacinth A. Villanueva', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(401, '106767090245', 'Mary Hyacinth A. Villanueva', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(402, '106767090245', 'Mary Hyacinth A. Villanueva', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(403, '106767090245', 'Mary Hyacinth A. Villanueva', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(404, '106767090245', 'Mary Hyacinth A. Villanueva', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(405, '106767090245', 'Mary Hyacinth A. Villanueva', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(406, '106767090245', 'Mary Hyacinth A. Villanueva', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(407, '106767090245', 'Mary Hyacinth A. Villanueva', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(408, '106767090245', 'Mary Hyacinth A. Villanueva', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(409, '106767090245', 'Mary Hyacinth A. Villanueva', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(410, '106767090245', 'Mary Hyacinth A. Villanueva', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(411, '106767090144', 'Jennilyn T. Manalili', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(412, '106767090144', 'Jennilyn T. Manalili', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(413, '106767090144', 'Jennilyn T. Manalili', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(414, '106767090144', 'Jennilyn T. Manalili', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(415, '106767090144', 'Jennilyn T. Manalili', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(416, '106767090144', 'Jennilyn T. Manalili', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(417, '106767090144', 'Jennilyn T. Manalili', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(418, '106767090144', 'Jennilyn T. Manalili', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(419, '106767090144', 'Jennilyn T. Manalili', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(420, '106767090144', 'Jennilyn T. Manalili', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(421, '106720120128', 'ANGLINE MAE M. VALLEJOS', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(422, '106720120128', 'ANGLINE MAE M. VALLEJOS', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(423, '106720120128', 'ANGLINE MAE M. VALLEJOS', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(424, '106720120128', 'ANGLINE MAE M. VALLEJOS', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(425, '106720120128', 'ANGLINE MAE M. VALLEJOS', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(426, '106720120128', 'ANGLINE MAE M. VALLEJOS', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(427, '106720120128', 'ANGLINE MAE M. VALLEJOS', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(428, '106720120128', 'ANGLINE MAE M. VALLEJOS', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(429, '106720120128', 'ANGLINE MAE M. VALLEJOS', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(430, '106720120128', 'ANGLINE MAE M. VALLEJOS', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(431, '106772130117', 'Phrazienna A. Lising', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(432, '106772130117', 'Phrazienna A. Lising', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(433, '106772130117', 'Phrazienna A. Lising', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(434, '106772130117', 'Phrazienna A. Lising', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(435, '106772130117', 'Phrazienna A. Lising', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(436, '106772130117', 'Phrazienna A. Lising', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(437, '106772130117', 'Phrazienna A. Lising', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(438, '106772130117', 'Phrazienna A. Lising', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(439, '106772130117', 'Phrazienna A. Lising', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(440, '106772130117', 'Phrazienna A. Lising', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(441, '106772130117', 'Laurence F. Oserin', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(442, '106772130117', 'Laurence F. Oserin', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(443, '106772130117', 'Laurence F. Oserin', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(444, '106772130117', 'Laurence F. Oserin', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(445, '106772130117', 'Laurence F. Oserin', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(446, '106772130117', 'Laurence F. Oserin', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(447, '106772130117', 'Laurence F. Oserin', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(448, '106772130117', 'Laurence F. Oserin', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(449, '106772130117', 'Laurence F. Oserin', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(450, '106772130117', 'Laurence F. Oserin', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(451, '106737090011', 'Angelene G. Neponcio', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(452, '106737090011', 'Angelene G. Neponcio', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(453, '106737090011', 'Angelene G. Neponcio', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(454, '106737090011', 'Angelene G. Neponcio', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(455, '106737090011', 'Angelene G. Neponcio', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(456, '106737090011', 'Angelene G. Neponcio', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(457, '106737090011', 'Angelene G. Neponcio', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(458, '106737090011', 'Angelene G. Neponcio', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(459, '106737090011', 'Angelene G. Neponcio', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(460, '106737090011', 'Angelene G. Neponcio', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(461, '106755090112', 'Jullia B. Usi', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(462, '106755090112', 'Jullia B. Usi', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(463, '106755090112', 'Jullia B. Usi', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(464, '106755090112', 'Jullia B. Usi', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(465, '106755090112', 'Jullia B. Usi', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(466, '106755090112', 'Jullia B. Usi', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(467, '106755090112', 'Jullia B. Usi', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(468, '106755090112', 'Jullia B. Usi', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(469, '106755090112', 'Jullia B. Usi', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(470, '106755090112', 'Jullia B. Usi', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(471, '106231090115', 'Art M. Manalastas', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(472, '106231090115', 'Art M. Manalastas', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(473, '106231090115', 'Art M. Manalastas', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(474, '106231090115', 'Art M. Manalastas', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(475, '106231090115', 'Art M. Manalastas', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(476, '106231090115', 'Art M. Manalastas', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(477, '106231090115', 'Art M. Manalastas', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(478, '106231090115', 'Art M. Manalastas', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(479, '106231090115', 'Art M. Manalastas', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(480, '106231090115', 'Art M. Manalastas', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(481, '105765080150', 'Railey G. Masiddo', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(482, '105765080150', 'Railey G. Masiddo', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(483, '105765080150', 'Railey G. Masiddo', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(484, '105765080150', 'Railey G. Masiddo', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(485, '105765080150', 'Railey G. Masiddo', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(486, '105765080150', 'Railey G. Masiddo', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(487, '105765080150', 'Railey G. Masiddo', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(488, '105765080150', 'Railey G. Masiddo', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(489, '105765080150', 'Railey G. Masiddo', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(490, '105765080150', 'Railey G. Masiddo', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(491, '106772130117', 'Phrazienna A. Lising', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(492, '106772130117', 'Phrazienna A. Lising', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(493, '106772130117', 'Phrazienna A. Lising', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(494, '106772130117', 'Phrazienna A. Lising', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(495, '106772130117', 'Phrazienna A. Lising', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(496, '106772130117', 'Phrazienna A. Lising', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(497, '106772130117', 'Phrazienna A. Lising', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(498, '106772130117', 'Phrazienna A. Lising', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(499, '106772130117', 'Phrazienna A. Lising', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(500, '106772130117', 'Phrazienna A. Lising', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(501, '136792120049', 'Bhabes Nicole A. Pasicolan', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(502, '136792120049', 'Bhabes Nicole A. Pasicolan', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(503, '136792120049', 'Bhabes Nicole A. Pasicolan', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(504, '136792120049', 'Bhabes Nicole A. Pasicolan', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(505, '136792120049', 'Bhabes Nicole A. Pasicolan', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(506, '136792120049', 'Bhabes Nicole A. Pasicolan', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(507, '136792120049', 'Bhabes Nicole A. Pasicolan', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(508, '136792120049', 'Bhabes Nicole A. Pasicolan', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(509, '136792120049', 'Bhabes Nicole A. Pasicolan', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(510, '136792120049', 'Bhabes Nicole A. Pasicolan', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(511, '106759090030', 'John Russel T. Garcia', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(512, '106759090030', 'John Russel T. Garcia', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(513, '106759090030', 'John Russel T. Garcia', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(514, '106759090030', 'John Russel T. Garcia', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(515, '106759090030', 'John Russel T. Garcia', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(516, '106759090030', 'John Russel T. Garcia', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(517, '106759090030', 'John Russel T. Garcia', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(518, '106759090030', 'John Russel T. Garcia', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(519, '106759090030', 'John Russel T. Garcia', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(520, '106759090030', 'John Russel T. Garcia', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(521, '489530150293', 'Lance R. Penullar', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(522, '489530150293', 'Lance R. Penullar', 'EARTHSCI 11-1', 'Earth Science', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(523, '489530150293', 'Lance R. Penullar', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(524, '489530150293', 'Lance R. Penullar', 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(525, '489530150293', 'Lance R. Penullar', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(526, '489530150293', 'Lance R. Penullar', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(527, '489530150293', 'Lance R. Penullar', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(528, '489530150293', 'Lance R. Penullar', 'RESDAL 1', 'Research in Daily Life 1', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(529, '489530150293', 'Lance R. Penullar', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM '),
(530, '489530150293', 'Lance R. Penullar', 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '0', '0', '0', NULL, '0', '1st', '11', 'Zeus', 'STEM ');

-- --------------------------------------------------------

--
-- Table structure for table `section`
--

CREATE TABLE `section` (
  `id` int(11) NOT NULL,
  `section_name` varchar(255) DEFAULT NULL,
  `strand` varchar(255) DEFAULT NULL,
  `grade_level` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `section`
--

INSERT INTO `section` (`id`, `section_name`, `strand`, `grade_level`) VALUES
(2, 'Hermes', 'ABM', '11'),
(3, 'Zeus', 'STEM', '11'),
(4, 'Athena', 'HUMSS', '11'),
(5, 'Hyperion', 'TVL', '11');

-- --------------------------------------------------------

--
-- Table structure for table `strand`
--

CREATE TABLE `strand` (
  `id` int(11) NOT NULL,
  `strand_name` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `strand`
--

INSERT INTO `strand` (`id`, `strand_name`) VALUES
(1, 'ABM'),
(2, 'STEM'),
(3, 'TVL'),
(4, 'HUMSS');

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

--
-- Dumping data for table `student_profile`
--

INSERT INTO `student_profile` (`id`, `goc_no`, `lrn_no`, `fname`, `mname`, `lname`, `grade_level`, `section`, `strand`, `academic_status`) VALUES
(1, 'GOC-2020-0001', '401548150096', 'Gabriel', 'Gamboa', 'Abad', '11', 'Hyperion', 'TVL ICT ', 'Enrolled'),
(2, 'GOC-2020-0002', '489520150156', 'John Paul', 'Santos', 'Aguirre', '11', 'Zeus', 'STEM ', 'Registrant'),
(3, 'GOC-2020-0003', '106329100007', 'JENAH MAEDELYN', 'URMAZA', 'AGUSTIN', '11', 'Zeus', 'STEM ', 'Enrolled'),
(4, 'GOC-2020-0004', '10673110002', 'Heaven Lyane', 'Hipolito', 'Alabon', '11', 'Zeus', 'STEM ', 'Enrolled'),
(5, 'GOC-2020-0005', '106647100002', 'Ma,Celine Faith', 'Barera', 'Apolinario', '11', 'Hyperion', 'HE ', 'Enrolled'),
(6, 'GOC-2020-0006', '106636090003', 'Whesley', 'Dupitas', 'Aquino', '11', 'Athena', 'HUMSS ', 'Enrolled'),
(7, 'GOC-2020-0007', '106694100007', 'IVAN', 'SIRON', 'ARANCIS', '11', 'Zeus', 'STEM ', 'Enrolled'),
(8, 'GOC-2020-0008', '106797100014', 'Joan', 'Provido', 'Ariola', '11', 'Zeus', 'STEM ', 'Registrant'),
(9, 'GOC-2020-0009', '10529110004', 'John John', 'Fabiala', 'Arquiza', '11', 'Zeus', 'STEM ', 'Registrant'),
(10, 'GOC-2020-0010', '700027190193', 'Jan Eowynne', 'Mallari', 'Atienza', '11', 'Zeus', 'STEM ', 'Enrolled'),
(11, 'GOC-2020-0011', '106505140082', 'Marc Andrei', 'Ignacio', 'Austria', '11', 'Zeus', 'STEM ', 'Enrolled'),
(12, 'GOC-2020-0012', '108247120486', 'Rhonnel', 'Tolentino', 'Ayuro', '11', 'Zeus', 'STEM ', 'Enrolled'),
(13, 'GOC-2020-0013', '106471080001', 'Louella', 'Lumboy', 'Balaweg', '11', 'Hyperion', 'HE ', 'Enrolled'),
(14, 'GOC-2020-0014', '106704100017', 'Gerson', 'Taruc', 'Balingit', '11', 'Athena', 'HUMSS ', 'Enrolled'),
(15, 'GOC-2020-0015', '106746140160', 'Jann Mari', 'Caritativo', 'Balingit', '11', 'Athena', 'HUMSS ', 'Enrolled'),
(16, 'GOC-2020-0016', '106797100020', 'Christine Joy', 'Sanchez', 'Balubar', '11', 'Apollo', 'STEM ', 'Enrolled'),
(17, 'GOC-2020-0017', '106772100029', 'ALEXXAKAYE', 'MARTINEZ', 'BASILIO', '11', 'Hermes', 'ABM ', 'Registrant'),
(18, 'GOC-2020-0018', '136409100038', 'Krishelle Ann', 'Zulueta', 'Basilio', '11', 'Apollo', 'STEM ', 'Enrolled'),
(19, 'GOC-2020-0019', '106410100009', 'Charles', 'Pallasigue', 'Bautista', '11', 'Athena', 'HUMSS ', 'Enrolled'),
(20, 'GOC-2020-0020', '105391100003', 'Kristina', 'Felisilda', 'Bautista', '11', 'Apollo', 'STEM ', 'Enrolled'),
(21, 'GOC-2020-0021', '489530150259', 'Paul John', 'Soriano', 'Bautista', '11', 'Athena', 'HUMSS ', 'Enrolled'),
(22, 'GOC-2020-0022', '106734100013', 'Stephanie', 'Melquiades', 'Bautista', '11', 'Athena', 'HUMSS ', 'Registrant'),
(23, 'GOC-2020-0023', '106774100021', 'Angel', 'Mabael', 'Bitangcol', '11', 'Apollo', 'STEM ', 'Enrolled'),
(24, 'GOC-2020-0024', '106772090044', 'Jerome', 'Tallada', 'Bonifacio', '11', 'Hyperion', 'TVL ICT ', 'Registrant'),
(25, 'GOC-2020-0025', '106696140276', 'Andrea Beatriz', 'Janeo', 'Borja', '11', 'Hyperion', 'TVL ICT ', 'Enrolled'),
(26, 'GOC-2020-0026', '489520150174', 'Airis', 'Yumul', 'Briones', '11', 'Apollo', 'STEM ', 'Enrolled'),
(27, 'GOC-2020-0027', '135871140101', 'Rehemiah', 'Laureta', 'Bulong', '11', 'Apollo', 'STEM ', 'Enrolled'),
(28, 'GOC-2020-0028', '126214120194', 'Khrissta Ruth', 'Española', 'Caballa', '11', 'Zeus', 'STEM ', 'Enrolled'),
(29, 'GOC-2020-0029', '401528150780', 'Mekaella', 'Quinto', 'Cabana', '11', 'Zeus', 'STEM ', 'Enrolled'),
(30, 'GOC-2020-0030', '401532150700', 'Kenji', 'Cabarios', 'Calda', '11', 'Apollo', 'STEM ', 'Enrolled'),
(31, 'GOC-2020-0031', '106690100003', 'Jhomar', 'Surla', 'Canlas', '11', 'Apollo', 'STEM ', 'Registrant'),
(32, 'GOC-2020-0032', '420003150047', 'Cellein Emeren', 'Bartolome', 'Cantre', '11', '', 'HE ', 'Enrolled'),
(33, 'GOC-2020-0033', '106714100024', 'Yhobel', 'Hempiso', 'Cariaga', '11', 'Apollo', 'STEM ', 'Enrolled'),
(34, 'GOC-2020-0034', '106410100031', 'Bea Bianca', 'Garcia', 'Carreon', '11', 'Apollo', 'STEM ', 'Enrolled'),
(35, 'GOC-2020-0035', '106606100070', 'Alyssa Grace', 'Marcos', 'Cayabyab', '11', 'Athena', 'HUMSS ', 'Enrolled'),
(36, 'GOC-2020-0036', '106739120010', 'April Louis', 'Zarate', 'Chavenia', '11', 'Athena', 'HUMSS ', 'Enrolled'),
(37, 'GOC-2020-0037', '106736100010', 'Abegaille', 'Tornalejo', 'Cordero', '11', 'Apollo', 'STEM ', 'Enrolled'),
(38, 'GOC-2020-0038', '489519150057', 'Ezekiel', 'Pangan', 'Cortez', '11', 'Zeus', 'STEM ', 'Enrolled'),
(39, 'GOC-2020-0039', '489506150455', 'Lance Matthew', 'Yabut', 'Dabu', '11', 'Apollo', 'STEM ', 'Registrant'),
(40, 'GOC-2020-0040', '106742100023', 'Kristine Grace', 'Aquino', 'David', '11', 'Hermes', 'ABM ', 'Enrolled'),
(41, 'GOC-2020-0041', '101604100014', 'ADRIAN PRINCE', 'BATOBATO', 'DAYAO', '11', 'Zeus', 'STEM ', 'Enrolled'),
(42, 'GOC-2020-0042', '106746130009', 'Aijay Gabriel', 'Cunanan', 'De Guzman', '11', 'Hyperion', 'TVL ICT ', 'Enrolled'),
(43, 'GOC-2020-0043', '106774100047', 'Caria Angel', 'Cerbas', 'De Guzman', '11', 'Hermes', 'ABM ', 'Enrolled'),
(44, 'GOC-2020-0044', '106484090017', 'JHUN LOID', 'CORTEZ', 'DE GUZMAN', '11', 'Hermes', 'STEM ', 'Enrolled'),
(45, 'GOC-2020-0045', '401528150828', 'Anjela Alexene', 'Molina', 'De Jesus', '11', 'Hyperion', 'TVL ICT ', 'Enrolled'),
(46, 'GOC-2020-0046', '106704100060', 'Russel', 'Napo', 'Deang', '11', 'Hermes', 'STEM ', 'Enrolled'),
(47, 'GOC-2020-0047', '106506100017', 'Mark Christian', 'Medrano', 'Decena', '11', 'Hyperion', 'TVL ICT ', 'Enrolled'),
(48, 'GOC-2020-0048', '106746100065', 'Alexa Mae', 'Reporin', 'Dela Cruz', '11', 'Hermes', 'ABM ', 'Enrolled'),
(49, 'GOC-2020-0049', '106695100037', 'Jolly Hannah', 'Enriquez', 'Dela Cruz', '11', 'Hermes', 'ABM ', 'Enrolled'),
(50, 'GOC-2020-0050', '489506150456', 'Marjon Francis', 'Mallari', 'Dela Cruz', '11', 'Hyperion', 'TVL ICT ', 'Enrolled'),
(51, 'GOC-2020-0051', '106380100049', 'Bianca Joy Nicole', 'Santos', 'Dizon', '11', '', 'STEM ', 'Enrolled'),
(52, 'GOC-2020-0052', '489527150142', 'Kristine', 'Quiazon', 'Dizon', '11', '', 'HUMSS ', 'Registrant'),
(53, 'GOC-2020-0053', '106767140218', 'Gwyneth', 'Salmazan', 'Dombriguez', '11', '', 'HUMSS ', 'Enrolled'),
(54, 'GOC-2020-0054', '489504150137', 'Clariza Jane', 'Lopez', 'Dona', '11', '', 'STEM ', 'Enrolled'),
(55, 'GOC-2020-0055', '106772130058', 'Patricia Ann', 'Dominguez', 'Donato', '11', '', 'ABM ', 'Enrolled'),
(56, 'GOC-2020-0056', '101976100018', 'Joshua Paul', 'Hipolito', 'Dotimas', '11', '', 'HUMSS ', 'Enrolled'),
(57, 'GOC-2020-0057', '420005150096', 'Cyronn', 'Lacuesta', 'Enriquez', '11', '', 'ABM ', 'Enrolled'),
(58, 'GOC-2020-0058', '109403150149', 'Rowann', 'Ramos', 'Eresuelo', '11', '', 'STEM ', 'Enrolled'),
(59, 'GOC-2020-0059', '106638100017', 'Alexa Isabel', 'Grande', 'Eugenio', '11', '', 'STEM ', 'Enrolled'),
(60, 'GOC-2020-0060', '106484100012', 'Audrie Joy', 'Manayan', 'Facun', '11', '', 'STEM ', 'Enrolled'),
(61, 'GOC-2020-0061', '106746100082', 'Arianna', 'Catacutan', 'Garcia', '11', '', 'ABM ', 'Enrolled'),
(62, 'GOC-2020-0062', '106767080088', 'Christian Llyod', 'De Jesus', 'Garcia', '11', '', 'HUMSS ', 'Enrolled'),
(63, 'GOC-2020-0063', '401534150063', 'L Jay Ann', 'Mayo', 'Garcia', '11', '', 'HE ', 'Enrolled'),
(64, 'GOC-2020-0064', '106348140069', 'Ren Chester', 'Ronato', 'Garcia', '11', '', 'TVL ICT ', 'Registrant'),
(65, 'GOC-2020-0065', '106359100028', 'Justine Mark', 'Sanchez', 'Garma', '11', '', 'STEM ', 'Enrolled'),
(66, 'GOC-2020-0066', '401538150252', 'Angel Anne', 'Baltazar', 'Gelilio', '11', '', 'ABM ', 'Enrolled'),
(67, 'GOC-2020-0067', '401548150110', 'Liana Joy', 'Benzon', 'Gonzales', '11', '', 'STEM ', 'Enrolled'),
(68, 'GOC-2020-0068', '489513150082', 'Lianna Ysabelle', 'Capili', 'Haen', '11', '', 'ABM ', 'Registrant'),
(69, 'GOC-2020-0069', '106696140435', 'Jan Vianney', 'Supan', 'Harb', '11', '', 'STEM ', 'Enrolled'),
(70, 'GOC-2020-0070', '106410100071', 'Ma. Kristine', 'Garcia', 'Hipolito', '11', '', 'HUMSS ', 'Enrolled'),
(71, 'GOC-2020-0071', '106448100091', 'Noelle Marie', 'Estrada', 'Inocencio', '11', '', 'STEM ', 'Enrolled'),
(72, 'GOC-2020-0072', '106696100163', 'MARY ROSE', 'MALLARI', 'INONG', '11', '', 'STEM ', 'Enrolled'),
(73, 'GOC-2020-0073', '136825100176', 'Elenor', 'Billones', 'Jardeleza', '11', '', 'STEM ', 'Enrolled'),
(74, 'GOC-2020-0074', '401533150230', 'Prince Allen', 'Santiago', 'Jovellanos', '11', '', 'STEM ', 'Enrolled'),
(75, 'GOC-2020-0075', '489530150277', 'Bea Sophia', 'Poceran', 'Komiya', '12', '', 'HUMSS ', 'Enrolled'),
(76, 'GOC-2020-0076', '489505150052', 'Natasha Nicole', 'Mamucod', 'Lacsa', '12', '', 'HUMSS ', 'Enrolled'),
(77, 'GOC-2020-0077', '489519150060', 'Fhrex Elijah', 'Esteban', 'Lacuesta', '12', '', 'ABM ', 'Enrolled'),
(78, 'GOC-2020-0078', '106734100045', 'Nathasha', 'Soliman', 'Lagman', '12', '', 'STEM ', 'Enrolled'),
(79, 'GOC-2020-0079', '106743100026', 'Ma.Sharleene', 'Paulo', 'Lambinicio', '12', '', 'STEM ', 'Enrolled'),
(80, 'GOC-2020-0080', '106741100051', 'Luis Grant', 'Tiglao', 'Lansangan', '12', '', 'ABM ', 'Enrolled'),
(81, 'GOC-2020-0081', '106632100063', 'Tamia Kayle', 'Maregmen', 'Lapuz', '12', '', 'ABM ', 'Enrolled'),
(82, 'GOC-2020-0082', '106502100041', 'Marie Fe', 'Sidora', 'Lazatin', '12', '', 'ABM ', 'Enrolled'),
(83, 'GOC-2020-0083', '10672810035', 'Hannah Micah', 'Balagtas', 'Liquiran', '12', '', 'HUMSS ', 'Enrolled'),
(84, 'GOC-2020-0084', 'TC20-484', 'Sophia Bianca', 'Magat', 'Lulu', '12', '', 'STEM ', 'Enrolled'),
(85, 'GOC-2020-0085', '106746100111', 'Clark Angelo', 'Guevarra', 'Magat', '12', '', 'STEM ', 'Enrolled'),
(86, 'GOC-2020-0086', '489520180001', 'Jake Rhayel', 'Felipe', 'Mallari', '12', '', 'STEM ', 'Enrolled'),
(87, 'GOC-2020-0087', '106696100194', 'Myco Eucka', 'Guevarra', 'Mallari', '12', '', 'STEM ', 'Enrolled'),
(88, 'GOC-2020-0088', '401533150245', 'FAITH', 'VALLEGA', 'MANALO', '12', '', 'STEM ', 'Enrolled'),
(89, 'GOC-2020-0089', '106731080061', 'Irha', 'Trinidad', 'Mandigma', '12', '', 'STEM ', 'Enrolled'),
(90, 'GOC-2020-0090', '106743100031', 'Jasper', 'Cajuguiran', 'Mañego', '12', '', 'TVL ICT ', 'Enrolled'),
(91, 'GOC-2020-0091', '489506150518', 'Mary Ingrid', 'Urquico', 'Marcos', '12', '', 'STEM ', 'Enrolled'),
(92, 'GOC-2020-0092', '700001137', 'Frances Mary Love', 'Areglado', 'Medina', '12', '', 'HUMSS ', 'Enrolled'),
(93, 'GOC-2020-0093', '106506100040', 'Kenneth', 'Aquino', 'Medrano', '12', '', 'HE ', 'Enrolled'),
(94, 'GOC-2020-0094', '401516150064', 'Louis Andrei', 'N/A', 'Menes', '12', '', 'STEM ', 'Enrolled'),
(95, 'GOC-2020-0095', '420015150042', 'Krisha', 'Torno', 'Mercado', '12', '', 'STEM ', 'Enrolled'),
(96, 'GOC-2020-0096', '106410100106', 'Kurt Clarence', 'Manalo', 'Miclat', '12', '', 'ABM ', 'Enrolled'),
(97, 'GOC-2020-0097', '10673910032', 'Britney Ashley', 'Hernandez', 'Millan', '12', '', 'STEM ', 'Enrolled'),
(98, 'GOC-2020-0098', '160008100029', 'Christine', 'Solis', 'Naigan', '12', '', 'ABM ', 'Enrolled'),
(99, 'GOC-2020-0099', 'SN202010853', 'Patricia Yvon', 'Cawigan', 'Napo', '12', '', 'ABM ', 'Enrolled'),
(100, 'GOC-2020-0100', '104635100507', 'Kate Cassandra', 'Tolentino', 'Orian', '12', '', 'STEM ', 'Enrolled'),
(501, 'GOC-2020-0501', '401548150125', 'Korben Deniell', 'Reyes', 'Melgar', '11', 'Zeus', 'STEM ', 'Enrolled'),
(502, 'GOC-2020-0502', '106731090067', 'Meanne Crystal', 'Capitli', 'Manicdo', '11', 'Zeus', 'STEM ', 'Enrolled'),
(503, 'GOC-2020-0503', '401537150168', 'Shanaia Ishi', 'Dantes', 'Cueva', '11', 'Zeus', 'STEM ', 'Enrolled'),
(504, 'GOC-2020-0504', '105111090083', 'Tricia Romae', 'San Roque', 'Cunanan', '11', 'Zeus', 'STEM ', 'Enrolled'),
(505, 'GOC-2020-0505', '136404090061', 'Jazper', 'Tañedo', 'Castro', '11', 'Zeus', 'STEM ', 'Enrolled'),
(506, 'GOC-2020-0506', '106696090107', 'Kyl Dimples', 'Rubio', 'Dulay', '11', 'Zeus', 'STEM ', 'Enrolled'),
(507, 'GOC-2020-0507', '106679090012', 'Lovely Noreen', 'Cuaresma', 'Corpuz', '11', 'Zeus', 'STEM ', 'Enrolled'),
(508, 'GOC-2020-0508', '106755090057', 'Sophia', 'Briones', 'Guiao', '11', 'Zeus', 'STEM ', 'Enrolled'),
(509, 'GOC-2020-0509', '201900087', 'Mary Christina', 'Lugue', 'Mallari', '11', 'Zeus', 'STEM ', 'Enrolled'),
(510, 'GOC-2020-0510', '48950681', 'Clyde Lester', 'Alfaro', 'Ramos', '11', 'Zeus', 'STEM ', 'Enrolled'),
(511, 'GOC-2020-0511', '489506150542', 'Neil Lawrence', 'Miranda', 'Aquino', '11', 'Zeus', 'STEM ', 'Enrolled'),
(512, 'GOC-2020-0512', '489506150681', 'Clyde Lester', 'Alfaro', 'Ramos', '11', 'Zeus', 'STEM ', 'Enrolled'),
(513, 'GOC-2020-0513', '106477080033', 'Mark Kenneth', 'Garcia', 'Lacayanga', '11', 'Zeus', 'STEM ', 'Enrolled'),
(514, 'GOC-2020-0514', '106696090450', 'Ma.Andrea Lhey', 'Canlas', 'Zapata', '11', 'Zeus', 'STEM ', 'Enrolled'),
(515, 'GOC-2020-0515', '106730090054', 'Scharlette', 'Beltran', 'Tongol', '11', 'Zeus', 'STEM ', 'Enrolled'),
(516, 'GOC-2020-0516', '10949120310', 'Xavier Louis', 'Lacsina', 'De Guzman', '11', 'Zeus', 'STEM ', 'Enrolled'),
(517, 'GOC-2020-0517', '489523150107', 'Kate Angel Nichole', 'Lee', 'Calma', '11', 'Zeus', 'STEM ', 'Enrolled'),
(518, 'GOC-2020-0518', '489523150107', 'Kate Angel Nichole', 'Lee', 'Calma', '11', 'Zeus', 'STEM ', 'Enrolled'),
(519, 'GOC-2020-0519', '420057150051', 'Hidie', 'Sumaoang', 'Lorenzo', '11', 'Zeus', 'STEM ', 'Enrolled'),
(520, 'GOC-2020-0520', '106767090245', 'Mary Hyacinth', 'Avanceña', 'Villanueva', '11', 'Zeus', 'STEM ', 'Enrolled'),
(521, 'GOC-2020-0521', '106767090245', 'Mary Hyacinth', 'Avanceña', 'Villanueva', '11', 'Zeus', 'STEM ', 'Enrolled'),
(522, 'GOC-2020-0522', '106767090144', 'Jennilyn', 'Tanedo', 'Manalili', '11', 'Zeus', 'STEM ', 'Enrolled'),
(523, 'GOC-2020-0523', '106720120128', 'ANGLINE MAE', 'MURING', 'VALLEJOS', '11', 'Zeus', 'STEM ', 'Enrolled'),
(524, 'GOC-2020-0524', '106772130117', 'Phrazienna', 'Agustin', 'Lising', '11', 'Zeus', 'STEM ', 'Enrolled'),
(525, 'GOC-2020-0525', '106772130117', 'Laurence', 'Fernandez', 'Oserin', '11', 'Zeus', 'STEM ', 'Enrolled'),
(526, 'GOC-2020-0526', '106737090011', 'Angelene', 'Godoy', 'Neponcio', '11', 'Zeus', 'STEM ', 'Enrolled'),
(527, 'GOC-2020-0527', '106755090112', 'Jullia', 'Batalon', 'Usi', '11', 'Zeus', 'STEM ', 'Enrolled'),
(528, 'GOC-2020-0528', '106231090115', 'Art', 'Melegrito', 'Manalastas', '11', 'Zeus', 'STEM ', 'Enrolled'),
(529, 'GOC-2020-0529', '105765080150', 'Railey', 'G.', 'Masiddo', '11', 'Zeus', 'STEM ', 'Enrolled'),
(530, 'GOC-2020-0530', '106772130117', 'Phrazienna', 'Agustin', 'Lising', '11', 'Zeus', 'STEM ', 'Enrolled'),
(531, 'GOC-2020-0531', '136792120049', 'Bhabes Nicole', 'Advincula', 'Pasicolan', '11', 'Zeus', 'STEM ', 'Enrolled'),
(532, 'GOC-2020-0532', '106759090030', 'John Russel', 'Tabamo', 'Garcia', '11', 'Zeus', 'STEM ', 'Enrolled'),
(533, 'GOC-2020-0533', '489530150293', 'Lance', 'Rebollo', 'Penullar', '11', 'Zeus', 'STEM ', 'Enrolled');

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

--
-- Dumping data for table `subject`
--

INSERT INTO `subject` (`id`, `subject_code`, `subject_name`, `subject_type`, `semester`, `grade_level`, `strand`) VALUES
(2, 'JAVA1', 'Java Programming', 'CORE', 'First', '11', 'ABM'),
(4, 'FIL', 'Filipuino', 'CORE', 'Second', '11', 'ABM'),
(5, 'MATH 1', 'Math Name', 'CORE', 'Second', '11', 'ABM');

-- --------------------------------------------------------

--
-- Table structure for table `subjects`
--

CREATE TABLE `subjects` (
  `id` int(11) NOT NULL,
  `subject_code` varchar(255) DEFAULT NULL,
  `subject_name` varchar(255) DEFAULT NULL,
  `grade_level` varchar(10) NOT NULL,
  `subject_type` varchar(255) NOT NULL,
  `strand` varchar(255) NOT NULL,
  `sem` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `subjects`
--

INSERT INTO `subjects` (`id`, `subject_code`, `subject_name`, `grade_level`, `subject_type`, `strand`, `sem`) VALUES
(367, 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '11', 'CORE SUBJECTS', 'All Strand', '1st'),
(368, 'EARTHSCI 11-1', 'Earth Science', '11', 'CORE SUBJECTS', 'All Strand', '1st'),
(369, 'GENMATH 11-1', 'General Mathematics', '11', 'CORE SUBJECTS', 'All Strand', '1st'),
(370, 'FILI1 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '11', 'CORE SUBJECTS', 'All Strand', '1st'),
(371, 'ORALCOM 11-1', 'Oral Communication in Context', '11', 'CORE SUBJECTS', 'All Strand', '1st'),
(372, 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '11', 'CORE SUBJECTS', 'All Strand', '1st'),
(373, 'PHYED1 11-1', 'Physical Education and Health 1', '11', 'CORE SUBJECTS', 'All Strand', '1st'),
(374, 'ARTCON 11-2', 'Contemporary Philipine Arts from the Regions', '11', 'APPLIED SUBJECTS', 'All Strand', '2nd'),
(375, 'MIL 11-2', 'Media and Information Literacy', '11', 'APPLIED SUBJECTS', 'All Strand', '2nd'),
(376, 'FILI2 11-2', 'Pagbasa at Pagsusuri ng Ibat ibang Teksto  tungo sa pananaliksik', '11', 'APPLIED SUBJECTS', 'All Strand', '2nd'),
(377, 'PHYED2 11-2', 'Physical Educationand Health 2', '11', 'APPLIED SUBJECTS', 'All Strand', '2nd'),
(378, 'STATPRO 11-2', 'Statistics and Probability', '11', 'APPLIED SUBJECTS', 'All Strand', '2nd'),
(379, 'SOCSCI1 12-1', 'Understanding Culture, Society and Politics', '12', 'CORE SUBJECTS', 'All Strand', '1st'),
(380, 'PHILMAN 12 -1', 'Introduction to the Philisophy of Human Person', '12', 'CORE SUBJECTS', 'All Strand', '1st'),
(381, 'RWSKILL 12-1', 'Reading and Writing Skills', '12', 'CORE SUBJECTS', 'All Strand', '1st'),
(382, 'PHYED3 12-1', 'Physical Education and Health 3', '12', 'CORE SUBJECTS', 'All Strand', '1st'),
(383, 'PHYSCI 12-2', 'Physical Science', '12', 'CORE SUBJECTS', 'NON STEM', '2nd'),
(384, 'DRR 12-2', 'Disaster Readiness and Risk Reduction', '12', 'CORE SUBJECTS', 'STEM', '2nd'),
(385, 'PHYED4 12-2', 'Physical Educationand Health 4', '12', 'CORE SUBJECTS', 'STEM', '2nd'),
(386, 'BUSMATH 11-2', 'Business Math', '11', 'SPECIALIZED SUBJECTS', 'ABM', '2nd'),
(387, 'ORGMAN 11-2', 'Organization and Management', '11', 'SPECIALIZED SUBJECTS', 'ABM', '2nd'),
(388, 'FABM1 11-2', 'Fundamentals of Accounting, Business and Management 1', '11', 'SPECIALIZED SUBJECTS', 'ABM', '2nd'),
(389, 'FABM2 12-1', 'Fundamentals of Accounting, Business and Management 2', '12', 'SPECIALIZED SUBJECTS', 'ABM', '1st'),
(390, 'PRINBM 12-1', 'Principles of Business Marketing', '12', 'SPECIALIZED SUBJECTS', 'ABM', '1st'),
(391, 'BUSFIN 12-1', 'Business Finance', '12', 'SPECIALIZED SUBJECTS', 'ABM', '1st'),
(392, 'APPECO 12-2', 'Applied Economics', '12', 'SPECIALIZED SUBJECTS', 'ABM', '2nd'),
(393, 'ETBUS 12-2', 'Business Ethics and Social Responsibility', '12', 'SPECIALIZED SUBJECTS', 'ABM', '2nd'),
(394, 'ENTBUS 12-2', 'Business Enterprise Simulation', '12', 'SPECIALIZED SUBJECTS', 'ABM', '2nd'),
(395, 'CRTV1 11-2', 'Creative Writing', '11', 'SPECIALIZED SUBJECTS', 'HUMSS', '2nd'),
(396, 'SOCSCI2 11-2', 'Introduction to World Religions and Belief Systems', '11', 'SPECIALIZED SUBJECTS', 'HUMSS', '2nd'),
(397, 'PHILGOV 11-2', 'Philippine Politics and Governance', '11', 'SPECIALIZED SUBJECTS', 'HUMSS', '2nd'),
(398, 'CRTV2 12-1', 'Creative Non Fiction', '12', 'SPECIALIZED SUBJECTS', 'HUMSS', '1st'),
(399, 'TNCT 12-1', 'Trends, Networks and Critical Thinking in the 21st Century Culture', '12', 'SPECIALIZED SUBJECTS', 'HUMSS', '1st'),
(400, 'SOCSCI3 12-1', 'Disciplines and Ideas in the Social Sciences', '12', 'SPECIALIZED SUBJECTS', 'HUMSS', '1st'),
(401, 'CESC 12-2', 'Community Engagement, Solidarity and Citizenship', '12', 'SPECIALIZED SUBJECTS', 'HUMSS', '2nd'),
(402, 'SOCSCI4 12-2', 'Disciplines and Ideas in the Applied Social Sciences', '12', 'SPECIALIZED SUBJECTS', 'HUMSS', '2nd'),
(403, 'CULACT 12-2', 'Culminating Activity', '12', 'SPECIALIZED SUBJECTS', 'HUMSS', '2nd'),
(404, 'JAVA1 11-2', 'Computer Programming NC II JAVA 1', '11', 'SPECIALIZED SUBJECTS', 'TVL - ICT', '2nd'),
(405, 'JAVA2 12-1', 'Computer Programming NC II JAVA 2', '12', 'SPECIALIZED SUBJECTS', 'TVL - ICT', '1st'),
(406, 'ANICOM1 12-1', 'Animation NC II 1', '12', 'SPECIALIZED SUBJECTS', 'TVL - ICT', '1st'),
(407, 'ANICOM2 12-2', 'Animation NC II 2', '12', 'SPECIALIZED SUBJECTS', 'TVL - ICT', '2nd'),
(408, 'STUDCOM 12-2', 'Computer Subjects', '12', 'SPECIALIZED SUBJECTS', 'TVL - ICT', '2nd'),
(409, 'COOK1 11-2', 'Cookery 1', '11', 'SPECIALIZED SUBJECTS', 'TVL - HE', '2nd'),
(410, 'COOK2 12-1', 'Cookery 2', '12', 'SPECIALIZED SUBJECTS', 'TVL - HE', '1st'),
(411, 'BRPROD1 12-1', 'Bread and Pastry Production 1', '12', 'SPECIALIZED SUBJECTS', 'TVL - HE', '1st'),
(412, 'BRPROD12-2', 'Bread and Pastry Production 2', '12', 'SPECIALIZED SUBJECTS', 'TVL - HE', '2nd'),
(413, 'WORKIMM 12-2', 'Work Immersion', '12', 'SPECIALIZED SUBJECTS', 'TVL - HE', '2nd'),
(414, 'GENBIO1 11-2', 'General Biology 1', '11', 'SPECIALIZED SUBJECTS', 'STEM', '2nd'),
(415, 'GENCHEM1 11-2', 'General Chemistry 1', '11', 'SPECIALIZED SUBJECTS', 'STEM', '2nd'),
(416, 'PRECALC 11-2', 'Pre Calculus', '11', 'SPECIALIZED SUBJECTS', 'STEM', '2nd'),
(417, 'BASCALC 12-1', 'Basic Calculus', '12', 'SPECIALIZED SUBJECTS', 'STEM', '1st'),
(418, 'GENPHYS1 12-1', 'General Physics 1', '12', 'SPECIALIZED SUBJECTS', 'STEM', '1st'),
(419, 'GENCHEM2 12-1', 'General Chemistry 2', '12', 'SPECIALIZED SUBJECTS', 'STEM', '1st'),
(420, 'GENBIO2 12-2', 'General Biology 2', '12', 'SPECIALIZED SUBJECTS', 'STEM', '2nd'),
(421, 'GENPHYS2 12-2', 'General Physics 2', '12', 'SPECIALIZED SUBJECTS', 'STEM', '2nd'),
(422, 'CAPPROJ 12-2', 'Research / Capstone Project', '12', 'SPECIALIZED SUBJECTS', 'STEM', '2nd'),
(423, 'RESDAL 2', 'Research in Daily Life 2', '12', 'APPLIED SUBJECTS', 'All Strand', '2nd'),
(424, 'RESDAL 1', 'Research in Daily Life 1', '11', 'APPLIED SUBJECTS', 'All Strand', '1st'),
(425, 'EMTECH 11-1', 'Empowerment Technologies', '11', 'APPLIED SUBJECTS', 'All Strand', '1st'),
(426, 'FILI 0 11-1', 'Pagsulat ng Filipino sa Piling Larangan', '11', 'APPLIED SUBJECTS', 'All Strand', '1st');

-- --------------------------------------------------------

--
-- Table structure for table `subject_type`
--

CREATE TABLE `subject_type` (
  `id` int(11) NOT NULL,
  `subject_type` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `subject_type`
--

INSERT INTO `subject_type` (`id`, `subject_type`) VALUES
(1, 'CORE'),
(2, 'SPECIALIZED');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `faculty_id` varchar(255) DEFAULT NULL,
  `user_id` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `user_type` varchar(255) NOT NULL,
  `full_name` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `faculty_id`, `user_id`, `password`, `user_type`, `full_name`) VALUES
(4, '0001', 'Efraim', '123456', 'Teacher', 'Rodel I. Ramos'),
(5, '0002', 'admin', 'admin', 'Admin', 'Efraim G. Basilio'),
(6, '0003', 'kcabrera', '1234', 'Teacher', 'Karl M. Cabrera');

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
-- Indexes for table `grading`
--
ALTER TABLE `grading`
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
-- Indexes for table `subjects`
--
ALTER TABLE `subjects`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `subject_type`
--
ALTER TABLE `subject_type`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `faculty_loads`
--
ALTER TABLE `faculty_loads`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `grade_level`
--
ALTER TABLE `grade_level`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `grading`
--
ALTER TABLE `grading`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=531;

--
-- AUTO_INCREMENT for table `section`
--
ALTER TABLE `section`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `strand`
--
ALTER TABLE `strand`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `student_profile`
--
ALTER TABLE `student_profile`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=534;

--
-- AUTO_INCREMENT for table `subject`
--
ALTER TABLE `subject`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `subjects`
--
ALTER TABLE `subjects`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=427;

--
-- AUTO_INCREMENT for table `subject_type`
--
ALTER TABLE `subject_type`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
