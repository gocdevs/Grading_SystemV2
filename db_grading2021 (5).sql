-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 24, 2021 at 03:15 AM
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
(1, 'SHS-21-0001', 'Rodel', 'Ramos', 'I', 'BSCS', 'Programming', 'Hermes', 'Full-time'),
(2, 'SHS-21-0002', 'Christian', 'Manuel', 'A', 'BSCE', 'Math', 'Hyperion', 'Full-time');

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
(1, 'SHS-21-0001', 'Rodel I. Ramos', 'EMTECH 11-1', 'TVL - ICT', '1st', '11', 'APPLIED', 'Hyperion', '2021-08-11 15:02:05'),
(2, 'SHS-21-0001', 'Rodel I. Ramos', 'EMTECH 11-1', 'TVL - HE', '1st', '11', 'APPLIED', 'Hyperion', '2021-08-11 15:02:05'),
(3, 'SHS-21-0002', 'Christian A. Manuel', 'GENMATH 11-1', 'TVL - ICT', '1st', '11', 'CORE', 'Hyperion', '2021-08-11 15:02:05'),
(4, 'SHS-21-0002', 'Christian A. Manuel', 'GENMATH 11-1', 'TVL - HE', '1st', '11', 'CORE', 'Athena', '2021-08-11 15:02:05'),
(6, 'SHS-21-0002', 'Christian A. Manuel', 'GENMATH 11-1', 'ABM', '1st', '11', 'CORE', 'Hermes', '2021-08-18 14:18:54');

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
  `first_or_3rd_Q` varchar(255) DEFAULT NULL,
  `second_or_4th_Q` varchar(255) DEFAULT NULL,
  `average` varchar(255) DEFAULT NULL,
  `remarks` varchar(255) DEFAULT NULL,
  `sem` varchar(255) DEFAULT NULL,
  `grade_level` varchar(255) DEFAULT NULL,
  `section` varchar(255) DEFAULT NULL,
  `strand` varchar(255) DEFAULT NULL,
  `sex` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `grading`
--

INSERT INTO `grading` (`id`, `lrn_no`, `fullname`, `subject_code`, `subject_desc`, `units`, `first_or_3rd_Q`, `second_or_4th_Q`, `average`, `remarks`, `sem`, `grade_level`, `section`, `strand`, `sex`) VALUES
(1, '489521150056', 'BILLONES,  JVEN J.', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(2, '489521150056', 'BILLONES,  JVEN J.', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(3, '489521150056', 'BILLONES,  JVEN J.', 'GENMATH 11-1', 'General Mathematics', '0', '90', '95', '93', 'PASSED', '1st', '11', 'Hermes', 'ABM', ''),
(4, '489521150056', 'BILLONES,  JVEN J.', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(5, '489521150056', 'BILLONES,  JVEN J.', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(6, '489521150056', 'BILLONES,  JVEN J.', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(7, '489521150056', 'BILLONES,  JVEN J.', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(8, '489521150056', 'BILLONES,  JVEN J.', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(9, '489521150056', 'BILLONES,  JVEN J.', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(10, '106720080044', 'FAALA, ALLEN JOSEPH L.', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(11, '106720080044', 'FAALA, ALLEN JOSEPH L.', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(12, '106720080044', 'FAALA, ALLEN JOSEPH L.', 'GENMATH 11-1', 'General Mathematics', '0', '78', '79', '79', 'PASSED', '1st', '11', 'Hermes', 'ABM', ''),
(13, '106720080044', 'FAALA, ALLEN JOSEPH L.', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(14, '106720080044', 'FAALA, ALLEN JOSEPH L.', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(15, '106720080044', 'FAALA, ALLEN JOSEPH L.', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(16, '106720080044', 'FAALA, ALLEN JOSEPH L.', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(17, '106720080044', 'FAALA, ALLEN JOSEPH L.', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(18, '106720080044', 'FAALA, ALLEN JOSEPH L.', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(19, '106720090038', 'FAALA, CHARLES BENEDICT L.', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(20, '106720090038', 'FAALA, CHARLES BENEDICT L.', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(21, '106720090038', 'FAALA, CHARLES BENEDICT L.', 'GENMATH 11-1', 'General Mathematics', '0', '85', '86', '86', 'PASSED', '1st', '11', 'Hermes', 'ABM', ''),
(22, '106720090038', 'FAALA, CHARLES BENEDICT L.', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(23, '106720090038', 'FAALA, CHARLES BENEDICT L.', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(24, '106720090038', 'FAALA, CHARLES BENEDICT L.', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(25, '106720090038', 'FAALA, CHARLES BENEDICT L.', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(26, '106720090038', 'FAALA, CHARLES BENEDICT L.', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(27, '106720090038', 'FAALA, CHARLES BENEDICT L.', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(28, '103840090273', 'PASCUAL, IVEZ A.', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(29, '103840090273', 'PASCUAL, IVEZ A.', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(30, '103840090273', 'PASCUAL, IVEZ A.', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(31, '103840090273', 'PASCUAL, IVEZ A.', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(32, '103840090273', 'PASCUAL, IVEZ A.', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(33, '103840090273', 'PASCUAL, IVEZ A.', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(34, '103840090273', 'PASCUAL, IVEZ A.', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(35, '103840090273', 'PASCUAL, IVEZ A.', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(36, '103840090273', 'PASCUAL, IVEZ A.', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(37, '106746090141', 'RAMIREZ, JIN HOWELL G.', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(38, '106746090141', 'RAMIREZ, JIN HOWELL G.', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(39, '106746090141', 'RAMIREZ, JIN HOWELL G.', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(40, '106746090141', 'RAMIREZ, JIN HOWELL G.', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(41, '106746090141', 'RAMIREZ, JIN HOWELL G.', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(42, '106746090141', 'RAMIREZ, JIN HOWELL G.', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(43, '106746090141', 'RAMIREZ, JIN HOWELL G.', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(44, '106746090141', 'RAMIREZ, JIN HOWELL G.', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(45, '106746090141', 'RAMIREZ, JIN HOWELL G.', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(46, '420003150057', 'TOMAS, HAROLD D.', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(47, '420003150057', 'TOMAS, HAROLD D.', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(48, '420003150057', 'TOMAS, HAROLD D.', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(49, '420003150057', 'TOMAS, HAROLD D.', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(50, '420003150057', 'TOMAS, HAROLD D.', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(51, '420003150057', 'TOMAS, HAROLD D.', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(52, '420003150057', 'TOMAS, HAROLD D.', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(53, '420003150057', 'TOMAS, HAROLD D.', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(54, '420003150057', 'TOMAS, HAROLD D.', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(55, '106329090007', 'ALTAREJOS, DANIELLE G.', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(56, '106329090007', 'ALTAREJOS, DANIELLE G.', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(57, '106329090007', 'ALTAREJOS, DANIELLE G.', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(58, '106329090007', 'ALTAREJOS, DANIELLE G.', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(59, '106329090007', 'ALTAREJOS, DANIELLE G.', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(60, '106329090007', 'ALTAREJOS, DANIELLE G.', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(61, '106329090007', 'ALTAREJOS, DANIELLE G.', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(62, '106329090007', 'ALTAREJOS, DANIELLE G.', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(63, '106329090007', 'ALTAREJOS, DANIELLE G.', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(64, '106705090004', 'AQUINO, ABIGAIL T.', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(65, '106705090004', 'AQUINO, ABIGAIL T.', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(66, '106705090004', 'AQUINO, ABIGAIL T.', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(67, '106705090004', 'AQUINO, ABIGAIL T.', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(68, '106705090004', 'AQUINO, ABIGAIL T.', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(69, '106705090004', 'AQUINO, ABIGAIL T.', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(70, '106705090004', 'AQUINO, ABIGAIL T.', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(71, '106705090004', 'AQUINO, ABIGAIL T.', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(72, '106705090004', 'AQUINO, ABIGAIL T.', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(73, '106735090008', 'ARQUIZA, KHARISSA B.', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(74, '106735090008', 'ARQUIZA, KHARISSA B.', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(75, '106735090008', 'ARQUIZA, KHARISSA B.', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(76, '106735090008', 'ARQUIZA, KHARISSA B.', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(77, '106735090008', 'ARQUIZA, KHARISSA B.', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(78, '106735090008', 'ARQUIZA, KHARISSA B.', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(79, '106735090008', 'ARQUIZA, KHARISSA B.', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(80, '106735090008', 'ARQUIZA, KHARISSA B.', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(81, '106735090008', 'ARQUIZA, KHARISSA B.', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(82, '106752090019', 'BAQUING, SHEREE MYLES D.', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(83, '106752090019', 'BAQUING, SHEREE MYLES D.', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(84, '106752090019', 'BAQUING, SHEREE MYLES D.', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(85, '106752090019', 'BAQUING, SHEREE MYLES D.', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(86, '106752090019', 'BAQUING, SHEREE MYLES D.', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(87, '106752090019', 'BAQUING, SHEREE MYLES D.', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(88, '106752090019', 'BAQUING, SHEREE MYLES D.', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(89, '106752090019', 'BAQUING, SHEREE MYLES D.', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(90, '106752090019', 'BAQUING, SHEREE MYLES D.', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(91, '108226090010', 'BAUTISTA, MARIEL F.', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(92, '108226090010', 'BAUTISTA, MARIEL F.', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(93, '108226090010', 'BAUTISTA, MARIEL F.', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(94, '108226090010', 'BAUTISTA, MARIEL F.', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(95, '108226090010', 'BAUTISTA, MARIEL F.', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(96, '108226090010', 'BAUTISTA, MARIEL F.', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(97, '108226090010', 'BAUTISTA, MARIEL F.', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(98, '108226090010', 'BAUTISTA, MARIEL F.', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(99, '108226090010', 'BAUTISTA, MARIEL F.', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(100, '106702090042', 'CALAGUAS, JICCA REA ', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(101, '106702090042', 'CALAGUAS, JICCA REA ', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(102, '106702090042', 'CALAGUAS, JICCA REA ', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(103, '106702090042', 'CALAGUAS, JICCA REA ', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(104, '106702090042', 'CALAGUAS, JICCA REA ', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(105, '106702090042', 'CALAGUAS, JICCA REA ', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(106, '106702090042', 'CALAGUAS, JICCA REA ', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(107, '106702090042', 'CALAGUAS, JICCA REA ', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(108, '106702090042', 'CALAGUAS, JICCA REA ', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(109, '100403090009', 'CARBONEL, ALAICA MAE S.', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(110, '100403090009', 'CARBONEL, ALAICA MAE S.', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(111, '100403090009', 'CARBONEL, ALAICA MAE S.', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(112, '100403090009', 'CARBONEL, ALAICA MAE S.', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(113, '100403090009', 'CARBONEL, ALAICA MAE S.', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(114, '100403090009', 'CARBONEL, ALAICA MAE S.', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(115, '100403090009', 'CARBONEL, ALAICA MAE S.', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(116, '100403090009', 'CARBONEL, ALAICA MAE S.', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(117, '100403090009', 'CARBONEL, ALAICA MAE S.', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(118, '106709090002', 'CASTAÑEDA, KATE BRITNEY M.', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(119, '106709090002', 'CASTAÑEDA, KATE BRITNEY M.', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(120, '106709090002', 'CASTAÑEDA, KATE BRITNEY M.', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(121, '106709090002', 'CASTAÑEDA, KATE BRITNEY M.', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(122, '106709090002', 'CASTAÑEDA, KATE BRITNEY M.', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(123, '106709090002', 'CASTAÑEDA, KATE BRITNEY M.', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(124, '106709090002', 'CASTAÑEDA, KATE BRITNEY M.', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(125, '106709090002', 'CASTAÑEDA, KATE BRITNEY M.', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(126, '106709090002', 'CASTAÑEDA, KATE BRITNEY M.', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(127, '401537150168', 'CUEVA, SHANAIA ISHI D.', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(128, '401537150168', 'CUEVA, SHANAIA ISHI D.', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(129, '401537150168', 'CUEVA, SHANAIA ISHI D.', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(130, '401537150168', 'CUEVA, SHANAIA ISHI D.', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(131, '401537150168', 'CUEVA, SHANAIA ISHI D.', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(132, '401537150168', 'CUEVA, SHANAIA ISHI D.', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(133, '401537150168', 'CUEVA, SHANAIA ISHI D.', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(134, '401537150168', 'CUEVA, SHANAIA ISHI D.', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(135, '401537150168', 'CUEVA, SHANAIA ISHI D.', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(136, '106731090024', 'CUSTODIO, JHEM D.', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(137, '106731090024', 'CUSTODIO, JHEM D.', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(138, '106731090024', 'CUSTODIO, JHEM D.', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(139, '106731090024', 'CUSTODIO, JHEM D.', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(140, '106731090024', 'CUSTODIO, JHEM D.', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(141, '106731090024', 'CUSTODIO, JHEM D.', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(142, '106731090024', 'CUSTODIO, JHEM D.', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(143, '106731090024', 'CUSTODIO, JHEM D.', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(144, '106731090024', 'CUSTODIO, JHEM D.', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(145, '105869090040', 'DALUSONG, JANELLE ANNE L.', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(146, '105869090040', 'DALUSONG, JANELLE ANNE L.', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(147, '105869090040', 'DALUSONG, JANELLE ANNE L.', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(148, '105869090040', 'DALUSONG, JANELLE ANNE L.', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(149, '105869090040', 'DALUSONG, JANELLE ANNE L.', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(150, '105869090040', 'DALUSONG, JANELLE ANNE L.', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(151, '105869090040', 'DALUSONG, JANELLE ANNE L.', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(152, '105869090040', 'DALUSONG, JANELLE ANNE L.', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(153, '105869090040', 'DALUSONG, JANELLE ANNE L.', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(154, '106767090065', 'DAMASCO, ERICKA L.', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(155, '106767090065', 'DAMASCO, ERICKA L.', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(156, '106767090065', 'DAMASCO, ERICKA L.', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(157, '106767090065', 'DAMASCO, ERICKA L.', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(158, '106767090065', 'DAMASCO, ERICKA L.', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(159, '106767090065', 'DAMASCO, ERICKA L.', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(160, '106767090065', 'DAMASCO, ERICKA L.', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(161, '106767090065', 'DAMASCO, ERICKA L.', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(162, '106767090065', 'DAMASCO, ERICKA L.', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(163, '106734090022', 'DAVID, TRIZIA EMMARINE D.', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(164, '106734090022', 'DAVID, TRIZIA EMMARINE D.', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(165, '106734090022', 'DAVID, TRIZIA EMMARINE D.', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(166, '106734090022', 'DAVID, TRIZIA EMMARINE D.', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(167, '106734090022', 'DAVID, TRIZIA EMMARINE D.', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(168, '106734090022', 'DAVID, TRIZIA EMMARINE D.', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(169, '106734090022', 'DAVID, TRIZIA EMMARINE D.', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(170, '106734090022', 'DAVID, TRIZIA EMMARINE D.', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(171, '106734090022', 'DAVID, TRIZIA EMMARINE D.', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(172, '136854120783', 'FAALA, LOVELY EUNICE R.', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(173, '136854120783', 'FAALA, LOVELY EUNICE R.', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(174, '136854120783', 'FAALA, LOVELY EUNICE R.', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(175, '136854120783', 'FAALA, LOVELY EUNICE R.', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(176, '136854120783', 'FAALA, LOVELY EUNICE R.', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(177, '136854120783', 'FAALA, LOVELY EUNICE R.', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(178, '136854120783', 'FAALA, LOVELY EUNICE R.', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(179, '136854120783', 'FAALA, LOVELY EUNICE R.', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(180, '136854120783', 'FAALA, LOVELY EUNICE R.', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(181, '106746090063', 'FERNANDEZ, IRA B.', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(182, '106746090063', 'FERNANDEZ, IRA B.', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(183, '106746090063', 'FERNANDEZ, IRA B.', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(184, '106746090063', 'FERNANDEZ, IRA B.', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(185, '106746090063', 'FERNANDEZ, IRA B.', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(186, '106746090063', 'FERNANDEZ, IRA B.', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(187, '106746090063', 'FERNANDEZ, IRA B.', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(188, '106746090063', 'FERNANDEZ, IRA B.', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(189, '106746090063', 'FERNANDEZ, IRA B.', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(190, '106718090024', 'GRANADOZO, GLAYZA L.', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(191, '106718090024', 'GRANADOZO, GLAYZA L.', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(192, '106718090024', 'GRANADOZO, GLAYZA L.', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(193, '106718090024', 'GRANADOZO, GLAYZA L.', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(194, '106718090024', 'GRANADOZO, GLAYZA L.', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(195, '106718090024', 'GRANADOZO, GLAYZA L.', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(196, '106718090024', 'GRANADOZO, GLAYZA L.', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(197, '106718090024', 'GRANADOZO, GLAYZA L.', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(198, '106718090024', 'GRANADOZO, GLAYZA L.', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(199, '106701090034', 'LIPATA, MYRA A.', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(200, '106701090034', 'LIPATA, MYRA A.', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(201, '106701090034', 'LIPATA, MYRA A.', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(202, '106701090034', 'LIPATA, MYRA A.', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(203, '106701090034', 'LIPATA, MYRA A.', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(204, '106701090034', 'LIPATA, MYRA A.', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(205, '106701090034', 'LIPATA, MYRA A.', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(206, '106701090034', 'LIPATA, MYRA A.', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(207, '106701090034', 'LIPATA, MYRA A.', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(208, '420057150051', 'LORENZO, HIDIE S.', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(209, '420057150051', 'LORENZO, HIDIE S.', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(210, '420057150051', 'LORENZO, HIDIE S.', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(211, '420057150051', 'LORENZO, HIDIE S.', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(212, '420057150051', 'LORENZO, HIDIE S.', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(213, '420057150051', 'LORENZO, HIDIE S.', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(214, '420057150051', 'LORENZO, HIDIE S.', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(215, '420057150051', 'LORENZO, HIDIE S.', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(216, '420057150051', 'LORENZO, HIDIE S.', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(217, '106797090138', 'MERCADO, SHERLYN MAE S.', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(218, '106797090138', 'MERCADO, SHERLYN MAE S.', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(219, '106797090138', 'MERCADO, SHERLYN MAE S.', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(220, '106797090138', 'MERCADO, SHERLYN MAE S.', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(221, '106797090138', 'MERCADO, SHERLYN MAE S.', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(222, '106797090138', 'MERCADO, SHERLYN MAE S.', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(223, '106797090138', 'MERCADO, SHERLYN MAE S.', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(224, '106797090138', 'MERCADO, SHERLYN MAE S.', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(225, '106797090138', 'MERCADO, SHERLYN MAE S.', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(226, '106728090045', 'MIRANDA, ELISABET G.', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(227, '106728090045', 'MIRANDA, ELISABET G.', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(228, '106728090045', 'MIRANDA, ELISABET G.', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(229, '106728090045', 'MIRANDA, ELISABET G.', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(230, '106728090045', 'MIRANDA, ELISABET G.', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(231, '106728090045', 'MIRANDA, ELISABET G.', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(232, '106728090045', 'MIRANDA, ELISABET G.', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(233, '106728090045', 'MIRANDA, ELISABET G.', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(234, '106728090045', 'MIRANDA, ELISABET G.', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(235, '106741070069', 'PUNZALAN, KRISTINE R.', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(236, '106741070069', 'PUNZALAN, KRISTINE R.', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(237, '106741070069', 'PUNZALAN, KRISTINE R.', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(238, '106741070069', 'PUNZALAN, KRISTINE R.', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(239, '106741070069', 'PUNZALAN, KRISTINE R.', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(240, '106741070069', 'PUNZALAN, KRISTINE R.', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(241, '106741070069', 'PUNZALAN, KRISTINE R.', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(242, '106741070069', 'PUNZALAN, KRISTINE R.', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(243, '106741070069', 'PUNZALAN, KRISTINE R.', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(244, '106704090135', 'TIGLAO, ERICA FAYE D.', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(245, '106704090135', 'TIGLAO, ERICA FAYE D.', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(246, '106704090135', 'TIGLAO, ERICA FAYE D.', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(247, '106704090135', 'TIGLAO, ERICA FAYE D.', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(248, '106704090135', 'TIGLAO, ERICA FAYE D.', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(249, '106704090135', 'TIGLAO, ERICA FAYE D.', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(250, '106704090135', 'TIGLAO, ERICA FAYE D.', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(251, '106704090135', 'TIGLAO, ERICA FAYE D.', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(252, '106704090135', 'TIGLAO, ERICA FAYE D.', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(253, '401537150150', 'CUNANAN, AKOL  ', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(254, '401537150150', 'CUNANAN, AKOL  ', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(255, '401537150150', 'CUNANAN, AKOL  ', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(256, '401537150150', 'CUNANAN, AKOL  ', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(257, '401537150150', 'CUNANAN, AKOL  ', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(258, '401537150150', 'CUNANAN, AKOL  ', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(259, '401537150150', 'CUNANAN, AKOL  ', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(260, '401537150150', 'CUNANAN, AKOL  ', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(261, '401537150150', 'CUNANAN, AKOL  ', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(262, '106701090009', 'ALOLOR, BASANGAN  ', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(263, '106701090009', 'ALOLOR, BASANGAN  ', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(264, '106701090009', 'ALOLOR, BASANGAN  ', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(265, '106701090009', 'ALOLOR, BASANGAN  ', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(266, '106701090009', 'ALOLOR, BASANGAN  ', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(267, '106701090009', 'ALOLOR, BASANGAN  ', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(268, '106701090009', 'ALOLOR, BASANGAN  ', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(269, '106701090009', 'ALOLOR, BASANGAN  ', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(270, '106701090009', 'ALOLOR, BASANGAN  ', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(271, '106674090014', 'TOLENADA, CASTRO  ', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(272, '106674090014', 'TOLENADA, CASTRO  ', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(273, '106674090014', 'TOLENADA, CASTRO  ', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(274, '106674090014', 'TOLENADA, CASTRO  ', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(275, '106674090014', 'TOLENADA, CASTRO  ', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(276, '106674090014', 'TOLENADA, CASTRO  ', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(277, '106674090014', 'TOLENADA, CASTRO  ', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(278, '106674090014', 'TOLENADA, CASTRO  ', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(279, '106674090014', 'TOLENADA, CASTRO  ', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(280, '489506150561', 'ZARATE, GARCIA  ', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(281, '489506150561', 'ZARATE, GARCIA  ', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(282, '489506150561', 'ZARATE, GARCIA  ', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(283, '489506150561', 'ZARATE, GARCIA  ', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(284, '489506150561', 'ZARATE, GARCIA  ', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(285, '489506150561', 'ZARATE, GARCIA  ', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(286, '489506150561', 'ZARATE, GARCIA  ', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(287, '489506150561', 'ZARATE, GARCIA  ', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(288, '489506150561', 'ZARATE, GARCIA  ', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(289, '106231090115', 'MELEGRITO, MANALASTAS  ', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(290, '106231090115', 'MELEGRITO, MANALASTAS  ', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(291, '106231090115', 'MELEGRITO, MANALASTAS  ', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(292, '106231090115', 'MELEGRITO, MANALASTAS  ', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(293, '106231090115', 'MELEGRITO, MANALASTAS  ', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(294, '106231090115', 'MELEGRITO, MANALASTAS  ', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(295, '106231090115', 'MELEGRITO, MANALASTAS  ', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(296, '106231090115', 'MELEGRITO, MANALASTAS  ', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(297, '106231090115', 'MELEGRITO, MANALASTAS  ', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(298, '106694090073', 'ATALIN, PAPIO  ', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(299, '106694090073', 'ATALIN, PAPIO  ', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(300, '106694090073', 'ATALIN, PAPIO  ', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(301, '106694090073', 'ATALIN, PAPIO  ', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(302, '106694090073', 'ATALIN, PAPIO  ', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(303, '106694090073', 'ATALIN, PAPIO  ', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(304, '106694090073', 'ATALIN, PAPIO  ', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(305, '106694090073', 'ATALIN, PAPIO  ', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(306, '106694090073', 'ATALIN, PAPIO  ', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(307, '101401090007', 'ROSETE, BAGNAS  ', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(308, '101401090007', 'ROSETE, BAGNAS  ', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(309, '101401090007', 'ROSETE, BAGNAS  ', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(310, '101401090007', 'ROSETE, BAGNAS  ', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', '');
INSERT INTO `grading` (`id`, `lrn_no`, `fullname`, `subject_code`, `subject_desc`, `units`, `first_or_3rd_Q`, `second_or_4th_Q`, `average`, `remarks`, `sem`, `grade_level`, `section`, `strand`, `sex`) VALUES
(311, '101401090007', 'ROSETE, BAGNAS  ', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(312, '101401090007', 'ROSETE, BAGNAS  ', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(313, '101401090007', 'ROSETE, BAGNAS  ', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(314, '101401090007', 'ROSETE, BAGNAS  ', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(315, '101401090007', 'ROSETE, BAGNAS  ', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(316, '401528150946', ', BARLAAN  ', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(317, '401528150946', ', BARLAAN  ', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(318, '401528150946', ', BARLAAN  ', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(319, '401528150946', ', BARLAAN  ', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(320, '401528150946', ', BARLAAN  ', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(321, '401528150946', ', BARLAAN  ', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(322, '401528150946', ', BARLAAN  ', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(323, '401528150946', ', BARLAAN  ', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(324, '401528150946', ', BARLAAN  ', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(325, '401216150512', ', BARTHOLOMEW  ', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(326, '401216150512', ', BARTHOLOMEW  ', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(327, '401216150512', ', BARTHOLOMEW  ', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(328, '401216150512', ', BARTHOLOMEW  ', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(329, '401216150512', ', BARTHOLOMEW  ', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(330, '401216150512', ', BARTHOLOMEW  ', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(331, '401216150512', ', BARTHOLOMEW  ', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(332, '401216150512', ', BARTHOLOMEW  ', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(333, '401216150512', ', BARTHOLOMEW  ', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(334, '106759130083', 'SALAZAR, BORDEOS  ', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(335, '106759130083', 'SALAZAR, BORDEOS  ', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(336, '106759130083', 'SALAZAR, BORDEOS  ', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(337, '106759130083', 'SALAZAR, BORDEOS  ', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(338, '106759130083', 'SALAZAR, BORDEOS  ', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(339, '106759130083', 'SALAZAR, BORDEOS  ', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(340, '106759130083', 'SALAZAR, BORDEOS  ', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(341, '106759130083', 'SALAZAR, BORDEOS  ', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(342, '106759130083', 'SALAZAR, BORDEOS  ', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(343, '106502090010', 'DIZON, CAPARAS  ', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(344, '106502090010', 'DIZON, CAPARAS  ', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(345, '106502090010', 'DIZON, CAPARAS  ', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(346, '106502090010', 'DIZON, CAPARAS  ', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(347, '106502090010', 'DIZON, CAPARAS  ', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(348, '106502090010', 'DIZON, CAPARAS  ', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(349, '106502090010', 'DIZON, CAPARAS  ', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(350, '106502090010', 'DIZON, CAPARAS  ', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(351, '106502090010', 'DIZON, CAPARAS  ', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(352, '106734090016', 'PEREZ, CORDOVA  ', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(353, '106734090016', 'PEREZ, CORDOVA  ', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(354, '106734090016', 'PEREZ, CORDOVA  ', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(355, '106734090016', 'PEREZ, CORDOVA  ', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(356, '106734090016', 'PEREZ, CORDOVA  ', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(357, '106734090016', 'PEREZ, CORDOVA  ', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(358, '106734090016', 'PEREZ, CORDOVA  ', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(359, '106734090016', 'PEREZ, CORDOVA  ', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(360, '106734090016', 'PEREZ, CORDOVA  ', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(361, '106724090004', 'BOGNOT, CUARESMA  ', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(362, '106724090004', 'BOGNOT, CUARESMA  ', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(363, '106724090004', 'BOGNOT, CUARESMA  ', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(364, '106724090004', 'BOGNOT, CUARESMA  ', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(365, '106724090004', 'BOGNOT, CUARESMA  ', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(366, '106724090004', 'BOGNOT, CUARESMA  ', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(367, '106724090004', 'BOGNOT, CUARESMA  ', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(368, '106724090004', 'BOGNOT, CUARESMA  ', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(369, '106724090004', 'BOGNOT, CUARESMA  ', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(370, '151520090013', 'MONTEMAYOR, DE VERA  ', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(371, '151520090013', 'MONTEMAYOR, DE VERA  ', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(372, '151520090013', 'MONTEMAYOR, DE VERA  ', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(373, '151520090013', 'MONTEMAYOR, DE VERA  ', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(374, '151520090013', 'MONTEMAYOR, DE VERA  ', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(375, '151520090013', 'MONTEMAYOR, DE VERA  ', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(376, '151520090013', 'MONTEMAYOR, DE VERA  ', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(377, '151520090013', 'MONTEMAYOR, DE VERA  ', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(378, '151520090013', 'MONTEMAYOR, DE VERA  ', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(379, '106696090127', 'RUBIO, DULAY  ', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(380, '106696090127', 'RUBIO, DULAY  ', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(381, '106696090127', 'RUBIO, DULAY  ', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(382, '106696090127', 'RUBIO, DULAY  ', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(383, '106696090127', 'RUBIO, DULAY  ', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(384, '106696090127', 'RUBIO, DULAY  ', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(385, '106696090127', 'RUBIO, DULAY  ', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(386, '106696090127', 'RUBIO, DULAY  ', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(387, '106696090127', 'RUBIO, DULAY  ', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(388, '106731090037', 'CAPULONG, ESTEBAN  ', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(389, '106731090037', 'CAPULONG, ESTEBAN  ', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(390, '106731090037', 'CAPULONG, ESTEBAN  ', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(391, '106731090037', 'CAPULONG, ESTEBAN  ', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(392, '106731090037', 'CAPULONG, ESTEBAN  ', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(393, '106731090037', 'CAPULONG, ESTEBAN  ', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(394, '106731090037', 'CAPULONG, ESTEBAN  ', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(395, '106731090037', 'CAPULONG, ESTEBAN  ', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(396, '106731090037', 'CAPULONG, ESTEBAN  ', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(397, '106674090024', 'GUERERO, FACUN  ', 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(398, '106674090024', 'GUERERO, FACUN  ', 'EARTHSCI 11-1', 'Earth and  Life Science', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(399, '106674090024', 'GUERERO, FACUN  ', 'GENMATH 11-1', 'General Mathematics', '0', '0', '0', '0', 'FAILED', '1st', '11', 'Hermes', 'ABM', ''),
(400, '106674090024', 'GUERERO, FACUN  ', 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(401, '106674090024', 'GUERERO, FACUN  ', 'ORALCOM 11-1', 'Oral Communication in Context', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(402, '106674090024', 'GUERERO, FACUN  ', 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(403, '106674090024', 'GUERERO, FACUN  ', 'PHYED1 11-1', 'Physical Education and Health 1', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(404, '106674090024', 'GUERERO, FACUN  ', 'EMTECH 11-1', 'Empowerment Technologies', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', ''),
(405, '106674090024', 'GUERERO, FACUN  ', 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '0', '0', '0', '0', '0', '1st', '11', 'Hermes', 'ABM', '');

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
(5, 'Hyperion', 'TVL - ICT', '11');

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
(3, 'TVL - ICT'),
(4, 'HUMSS'),
(5, 'TVL - HE');

-- --------------------------------------------------------

--
-- Table structure for table `student_profile`
--

CREATE TABLE `student_profile` (
  `id` int(11) NOT NULL,
  `reg_no` varchar(50) DEFAULT NULL,
  `goc_no` varchar(50) DEFAULT NULL,
  `lrn_no` varchar(20) DEFAULT NULL,
  `lname` varchar(225) DEFAULT NULL,
  `fname` varchar(225) DEFAULT NULL,
  `mname` varchar(225) DEFAULT NULL,
  `grade_level` varchar(50) DEFAULT NULL,
  `section` varchar(50) DEFAULT NULL,
  `sex` varchar(20) DEFAULT NULL,
  `academic_status` varchar(100) DEFAULT NULL,
  `strand` varchar(50) DEFAULT NULL,
  `student_type` varchar(50) DEFAULT NULL,
  `track` varchar(50) DEFAULT NULL,
  `department` varchar(50) DEFAULT NULL,
  `voucher_type` varchar(50) DEFAULT NULL,
  `semester` varchar(255) DEFAULT NULL,
  `date_of_birth` varchar(50) DEFAULT NULL,
  `place_of_birth` varchar(225) DEFAULT NULL,
  `religion` varchar(225) DEFAULT NULL,
  `nationality` varchar(225) DEFAULT NULL,
  `address` varchar(225) DEFAULT NULL,
  `mother_name` varchar(50) DEFAULT NULL,
  `mother_contact` varchar(50) DEFAULT NULL,
  `mother_work` varchar(50) DEFAULT NULL,
  `father_name` varchar(50) DEFAULT NULL,
  `father_contact` varchar(50) DEFAULT NULL,
  `father_work` varchar(50) DEFAULT NULL,
  `cperson_name` varchar(50) DEFAULT NULL,
  `cperson_address` varchar(255) DEFAULT NULL,
  `cperson_contact` varchar(50) DEFAULT NULL,
  `cperson_relationship` varchar(50) DEFAULT NULL,
  `previous_school` varchar(100) DEFAULT NULL,
  `previous_school_address` varchar(100) DEFAULT NULL,
  `psa` varchar(5) DEFAULT NULL,
  `psa_copy` varchar(5) DEFAULT NULL,
  `med_certificate` varchar(5) DEFAULT NULL,
  `report_card` varchar(5) DEFAULT NULL,
  `form_137` varchar(5) DEFAULT NULL,
  `good_moral` varchar(5) DEFAULT NULL,
  `entrance_exam` varchar(50) DEFAULT NULL,
  `ncae` varchar(5) DEFAULT NULL,
  `esc_voucher` varchar(11) DEFAULT NULL,
  `mop` varchar(20) DEFAULT NULL,
  `date_of_enrollment` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student_profile`
--

INSERT INTO `student_profile` (`id`, `reg_no`, `goc_no`, `lrn_no`, `lname`, `fname`, `mname`, `grade_level`, `section`, `sex`, `academic_status`, `strand`, `student_type`, `track`, `department`, `voucher_type`, `semester`, `date_of_birth`, `place_of_birth`, `religion`, `nationality`, `address`, `mother_name`, `mother_contact`, `mother_work`, `father_name`, `father_contact`, `father_work`, `cperson_name`, `cperson_address`, `cperson_contact`, `cperson_relationship`, `previous_school`, `previous_school_address`, `psa`, `psa_copy`, `med_certificate`, `report_card`, `form_137`, `good_moral`, `entrance_exam`, `ncae`, `esc_voucher`, `mop`, `date_of_enrollment`) VALUES
(1, NULL, 'GOC-2021-0002', '489521150056', 'BILLONES', ' JVEN', 'JALECO', '11', 'Hermes', 'Male', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:51'),
(2, NULL, 'GOC-2021-0004', '106720080044', 'FAALA', 'ALLEN JOSEPH', 'LAGROSA', '11', 'Hermes', 'Female', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:51'),
(3, NULL, 'GOC-2021-0006', '106720090038', 'FAALA', 'CHARLES BENEDICT', 'LAGROSA', '11', 'Hermes', 'Female', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:51'),
(4, NULL, 'GOC-2021-0008', '103840090273', 'PASCUAL', 'IVEZ', 'ACIO', '11', 'Hermes', 'Male', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:51'),
(5, NULL, 'GOC-2021-0010', '106746090141', 'RAMIREZ', 'JIN HOWELL', 'GONZALES', '11', 'Hermes', 'Female', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:51'),
(6, NULL, 'GOC-2021-0012', '420003150057', 'TOMAS', 'HAROLD', 'DANIPOG', '11', 'Hermes', 'Male', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:51'),
(7, NULL, 'GOC-2021-0014', '106329090007', 'ALTAREJOS', 'DANIELLE', 'GRAGANTA', '11', 'Hermes', 'Male', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:51'),
(8, NULL, 'GOC-2021-0016', '106705090004', 'AQUINO', 'ABIGAIL', 'TIPUNO', '11', 'Hermes', 'Female', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:51'),
(9, NULL, 'GOC-2021-0018', '106735090008', 'ARQUIZA', 'KHARISSA', 'BURGOS', '11', 'Hermes', 'Female', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:51'),
(10, NULL, 'GOC-2021-0020', '106752090019', 'BAQUING', 'SHEREE MYLES', 'DAVID', '11', 'Hermes', 'Female', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:51'),
(11, NULL, 'GOC-2021-0022', '108226090010', 'BAUTISTA', 'MARIEL', 'FELISILDA', '11', 'Hermes', 'Female', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:51'),
(12, NULL, 'GOC-2021-0024', '106702090042', 'CALAGUAS', 'JICCA REA', '', '11', 'Hermes', 'Male', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:51'),
(13, NULL, 'GOC-2021-0026', '100403090009', 'CARBONEL', 'ALAICA MAE', 'SOL', '11', 'Hermes', 'Female', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:51'),
(14, NULL, 'GOC-2021-0028', '106709090002', 'CASTAÑEDA', 'KATE BRITNEY', 'MACASAQUIT', '11', 'Hermes', 'Female', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:51'),
(15, NULL, 'GOC-2021-0030', '401537150168', 'CUEVA', 'SHANAIA ISHI', 'D', '11', 'Hermes', 'Male', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:51'),
(16, NULL, 'GOC-2021-0032', '106731090024', 'CUSTODIO', 'JHEM', 'DAVID', '11', 'Hermes', 'Female', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:51'),
(17, NULL, 'GOC-2021-0034', '105869090040', 'DALUSONG', 'JANELLE ANNE', 'LICUP', '11', 'Hermes', 'Female', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:51'),
(18, NULL, 'GOC-2021-0036', '106767090065', 'DAMASCO', 'ERICKA', 'LINTAG', '11', 'Hermes', 'Female', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:51'),
(19, NULL, 'GOC-2021-0038', '106734090022', 'DAVID', 'TRIZIA EMMARINE', 'DIZON', '11', 'Hermes', 'Female', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:51'),
(20, NULL, 'GOC-2021-0040', '136854120783', 'FAALA', 'LOVELY EUNICE', 'RELOSA', '11', 'Hermes', 'Male', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:51'),
(21, NULL, 'GOC-2021-0042', '106746090063', 'FERNANDEZ', 'IRA', 'BAUN', '11', 'Hermes', 'Male', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:52'),
(22, NULL, 'GOC-2021-0043', '106718090024', 'GRANADOZO', 'GLAYZA', 'LAGMAY', '11', 'Hermes', 'Male', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:52'),
(23, NULL, 'GOC-2021-0044', '106701090034', 'LIPATA', 'MYRA', 'ASIO', '11', 'Hermes', 'Male', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:52'),
(24, NULL, 'GOC-2021-0045', '420057150051', 'LORENZO', 'HIDIE', 'SUMAOANG', '11', 'Hermes', 'Male', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:52'),
(25, NULL, 'GOC-2021-0046', '106797090138', 'MERCADO', 'SHERLYN MAE', 'SULAY', '11', 'Hermes', 'Male', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:52'),
(26, NULL, 'GOC-2021-0047', '106728090045', 'MIRANDA', 'ELISABET', 'GARCIA', '11', 'Hermes', 'Male', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:52'),
(27, NULL, 'GOC-2021-0048', '106741070069', 'PUNZALAN', 'KRISTINE', 'RIOSA', '11', 'Hermes', 'Male', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:52'),
(28, NULL, 'GOC-2021-0049', '106704090135', 'TIGLAO', 'ERICA FAYE', 'DULAY', '11', 'Hermes', 'Male', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:52'),
(29, NULL, 'GOC-2021-0050', '401537150150', 'CUNANAN', 'AKOL', ' JOSEPH RAFAEL', '11', 'Hermes', 'Male', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:52'),
(30, NULL, 'GOC-2021-0051', '106701090009', 'ALOLOR', 'BASANGAN', ' JUSTIN LLOYD', '11', 'Hermes', 'Female', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:52'),
(31, NULL, 'GOC-2021-0052', '106674090014', 'TOLENADA', 'CASTRO', ' JHESMER', '11', 'Hermes', 'Male', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:52'),
(32, NULL, 'GOC-2021-0053', '489506150561', 'ZARATE', 'GARCIA', ' CHAMBERLAINE KYLE', '11', 'Hermes', 'Male', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:52'),
(33, NULL, 'GOC-2021-0054', '106231090115', 'MELEGRITO', 'MANALASTAS', ' ART', '11', 'Hermes', 'Female', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:52'),
(34, NULL, 'GOC-2021-0055', '106694090073', 'ATALIN', 'PAPIO', ' JOHN PAOLO', '11', 'Hermes', 'Male', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:52'),
(35, NULL, 'GOC-2021-0056', '101401090007', 'ROSETE', 'BAGNAS', ' HANNA LEA ', '11', 'Hermes', 'Female', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:52'),
(36, NULL, 'GOC-2021-0057', '401528150946', '', 'BARLAAN', ' KIRSTEN JOY', '11', 'Hermes', 'Male', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:52'),
(37, NULL, 'GOC-2021-0058', '401216150512', '', 'BARTHOLOMEW', ' HERSHE LEIN', '11', 'Hermes', 'Female', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:52'),
(38, NULL, 'GOC-2021-0059', '106759130083', 'SALAZAR', 'BORDEOS', ' BERNADETTE BEYONCE ', '11', 'Hermes', 'Male', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:52'),
(39, NULL, 'GOC-2021-0060', '106502090010', 'DIZON', 'CAPARAS', ' FRANCINE VANESS ', '11', 'Hermes', 'Female', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:52'),
(40, NULL, 'GOC-2021-0061', '106734090016', 'PEREZ', 'CORDOVA', ' KATHLEEN JADE ', '11', 'Hermes', 'Male', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:52'),
(41, NULL, 'GOC-2021-0062', '106724090004', 'BOGNOT', 'CUARESMA', ' SARAH MICHELLE ', '11', 'Hermes', 'Female', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:52'),
(42, NULL, 'GOC-2021-0063', '151520090013', 'MONTEMAYOR', 'DE VERA', ' ALLYSA JOYCE ', '11', 'Hermes', 'Male', 'Enrolled', 'ABM', 'Transferee', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:52'),
(43, NULL, 'GOC-2021-0064', '106696090127', 'RUBIO', 'DULAY', ' KYLE DIMPLES ', '11', 'Hermes', 'Male', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:52'),
(44, NULL, 'GOC-2021-0065', '106731090037', 'CAPULONG', 'ESTEBAN', ' KYLA ', '11', 'Hermes', 'Female', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:52'),
(45, NULL, 'GOC-2021-0066', '106674090024', 'GUERERO', 'FACUN', ' LAILANIE ', '11', 'Hermes', 'Male', 'Enrolled', 'ABM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:53'),
(46, NULL, 'GOC-2021-0067', '106746090064', 'LAQUINDANUM', 'FERRER', ' ALYANNA ANGEL ', '11', 'Zeus', 'Male', 'Enrolled', 'STEM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:53'),
(47, NULL, 'GOC-2021-0068', '106755090057', 'BRIONES', 'GUIAO', ' SOPHIA ', '11', 'Zeus', 'Male', 'Enrolled', 'STEM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:53'),
(48, NULL, 'GOC-2021-0069', '106746140212', 'BALINAS', 'MANALAD', ' NIKA MAE ', '11', 'Zeus', 'Male', 'Enrolled', 'STEM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:53'),
(49, NULL, 'GOC-2021-0070', '401532150797', 'RAZON', 'MANANQUIL', ' MIYAH ANGELA ', '11', 'Zeus', 'Female', 'Enrolled', 'STEM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:53'),
(50, NULL, 'GOC-2021-0071', '106696090323', 'MAAR', 'PEREZ', ' CHRISTINE MAE ', '11', 'Zeus', 'Male', 'Enrolled', 'STEM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:53'),
(51, NULL, 'GOC-2021-0075', '106763090224', 'SERRANO', 'ROBLES', ' LOVELY LYKA ', '11', 'Zeus', 'Female', 'Enrolled', 'STEM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:53'),
(52, NULL, 'GOC-2021-0079', '106745090051', 'BONDOC', 'SANTOS', ' CHELSIE VON ', '11', 'Zeus', 'Female', 'Enrolled', 'STEM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:53'),
(53, NULL, 'GOC-2021-0083', '124829090046', 'FERNANDEZ', 'TABOTABO', ' AUGUS TRICIA ', '11', 'Zeus', 'Female', 'Enrolled', 'STEM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:53'),
(54, NULL, 'GOC-2021-0087', '106716090095', 'MARTINEZ', 'TACADINO', ' NICOLE JOY', '11', 'Zeus', 'Male', 'Enrolled', 'STEM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:53'),
(55, NULL, 'GOC-2021-0091', '106730090054', 'BELTRAN', 'TONGOL', ' SCHARLETTE ', '11', 'Zeus', 'Male', 'Enrolled', 'STEM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:53'),
(56, NULL, 'GOC-2021-0095', '106755090112', 'BATALON', 'USI', ' JULLIA ', '11', 'Zeus', 'Female', 'Enrolled', 'STEM', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:53'),
(57, NULL, 'GOC-2021-0099', '106759090079', 'BARRO', 'YUMUL', ' ALLIAH JOY ', '11', 'Zeus', 'Female', 'Enrolled', 'STEM', 'Transferee', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:53'),
(58, NULL, 'GOC-2021-0103', '489506150552', 'UBAN', 'DALUMA', 'KHALID', '11', 'Athena', 'Female', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:53'),
(59, NULL, 'GOC-2021-0107', '106746130069', 'CARIN', 'DAVID', 'RENCY', '11', 'Athena', 'Male', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:53'),
(60, NULL, 'GOC-2021-0111', '106767090139', 'REYES', 'MAGSINO', 'LUIS GABRIEL', '11', 'Athena', 'Male', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:53'),
(61, NULL, 'GOC-2021-0115', '106710090054', 'CUNANAN', 'MANABAT', 'ELIJAH', '11', 'Athena', 'Female', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:53'),
(62, NULL, 'GOC-2021-0119', '300957150005', 'CORPUZ', 'MATEO', 'GIANLUCA', '11', 'Athena', 'Female', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:53'),
(63, NULL, 'GOC-2021-0123', '106695090078', 'CARREON', 'PEREZ', 'JOHN PAUL', '11', 'Athena', 'Female', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:53'),
(64, NULL, 'GOC-2021-0127', '106696090336', 'MANALO', 'PRADO', 'JOHN PAUL', '11', 'Athena', 'Male', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:53'),
(65, NULL, 'GOC-2021-0131', '106728090060', 'CATAMBING', 'SARMIENTO', 'ARJAY', '11', 'Athena', 'Male', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:53'),
(66, NULL, 'GOC-2021-0135', '489527150051', 'CORTEZ', 'TAMAYO', 'DIETHER', '11', 'Athena', 'Female', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:53'),
(67, NULL, 'GOC-2021-0139', '106696090418', 'RIGOR', 'TOLENTINO', 'NASER', '11', 'Athena', 'Female', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:53'),
(68, NULL, 'GOC-2021-0143', '106704090146', 'SANTIAGO', 'VENTENILLA', 'BRYCE ARMYAN ', '11', 'Athena', 'Female', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:53'),
(69, NULL, 'GOC-2021-0147', '106677090039', 'FERNANDEZ', 'OSERIN', 'LAURENCE DON', '11', 'Athena', 'Male', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:54'),
(70, NULL, 'GOC-2021-0151', '109494120310', 'LACSINA', 'DE GUZMAN', 'XAVIER LOUIS', '11', 'Athena', 'Male', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:54'),
(71, NULL, 'GOC-2021-0155', '106704090015', 'LUCIANO', 'BALICOCO', 'KATHLYN CAYLA', '11', 'Athena', 'Female', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:54'),
(72, NULL, 'GOC-2021-0159', '106742090020', 'DIZON', 'CABRERA', 'JUSTINE', '11', 'Athena', 'Female', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:54'),
(73, NULL, 'GOC-2021-0163', '107113090028', 'VALINO', 'CACHO', 'CHRISHA MHEYANNE', '11', 'Athena', 'Male', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:54'),
(74, NULL, 'GOC-2021-0167', '101748090016', 'SUPAN', 'CERVAS', 'RHEA ROSE', '11', 'Athena', 'Male', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:54'),
(75, NULL, 'GOC-2021-0171', '106682090007', 'FACUN', 'CORONEL', 'EMAROSE', '11', 'Athena', 'Male', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:54'),
(76, NULL, 'GOC-2021-0175', '106705090044', 'MARQUEZ', 'DE JESUS', 'SHEENA MAE', '11', 'Athena', 'Male', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:54'),
(77, NULL, 'GOC-2021-0179', '106696090116', 'JANEO', 'DELOS REYES', 'HERCELYN', '11', 'Athena', 'Male', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:54'),
(78, NULL, 'GOC-2021-0183', '106731120122', 'GARCIA', 'DOOC', 'ALTHEA MARIE', '11', 'Athena', 'Male', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:54'),
(79, NULL, 'GOC-2021-0187', '489506150602', 'DATANG', 'ESPINO', 'GLADYL HAZEL', '11', 'Athena', 'Male', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:54'),
(80, NULL, 'GOC-2021-0191', '106767090100', 'SICANGCO', 'FRANCO', 'ALICIA MAE', '11', 'Athena', 'Male', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:54'),
(81, NULL, 'GOC-2021-0195', '106738080034', 'CABULARES', 'GAJILA', 'PRINCESS DEE', '11', 'Athena', 'Female', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:54'),
(82, NULL, 'GOC-2021-0199', '106731090049', 'ORBETA', 'GONZALES', 'JOMAFEL', '11', 'Athena', 'Female', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:54'),
(83, NULL, 'GOC-2021-0203', '106609090030', 'PACLIBARE', 'JAVIER', 'VIEN MAEREN', '11', 'Athena', 'Female', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:54'),
(84, NULL, 'GOC-2021-0207', '106742090058', 'MUAN', 'LAHONG', 'MARIA YUEN', '11', 'Athena', 'Male', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:54'),
(85, NULL, 'GOC-2021-0211', '106696090207', '', 'LAPIRA', 'ANGEL', '11', 'Athena', 'Male', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:54'),
(86, NULL, 'GOC-2021-0215', '106785090014', 'SENADJAN', 'MEJIA', 'RONALYN GRACE', '11', 'Athena', 'Female', 'Enrolled', 'HUMSS', 'Transferee', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:54'),
(87, NULL, 'GOC-2021-0219', '106767090217', 'CRUZ', 'SANTOS', 'SARIAH ', '11', 'Athena', 'Male', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:54'),
(88, NULL, 'GOC-2021-0223', '106767090144', 'TANEDO', 'MANALILI', 'JENNILYN', '11', 'Athena', 'Female', 'Enrolled', 'HUMSS', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:54'),
(89, NULL, 'GOC-2021-0227', '106781090009', 'LORENO', 'BUERANO', 'MARK DENZEL', '11', 'Hyperion', 'Male', 'Enrolled', 'TVL - ICT', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:54'),
(90, NULL, 'GOC-2021-0231', '420022150118', 'GOMEZ', 'CORBADURA', 'JOSEPH ANDREW', '11', 'Hyperion', 'Male', 'Enrolled', 'TVL - ICT', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:54'),
(91, NULL, 'GOC-2021-0235', '106698090045', 'CASTILLO', 'GALAS', 'RAE ANGELO', '11', 'Hyperion', 'Female', 'Enrolled', 'TVL - ICT', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:54'),
(92, NULL, 'GOC-2021-0239', '106604090024', '', 'GAMBOA', 'CHRISTIAN DAVE', '11', 'Hyperion', 'Female', 'Enrolled', 'TVL - ICT', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:54'),
(93, NULL, 'GOC-2021-0243', '106477080033', 'GARCIA', 'LACAYANGA', 'MARK KENNETH', '11', 'Hyperion', 'Female', 'Enrolled', 'TVL - ICT', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:54'),
(94, NULL, 'GOC-2021-0247', '106696090218', 'CARREON', 'LUMIBAO', 'JAMES HERO', '11', 'Hyperion', 'Female', 'Enrolled', 'TVL - ICT', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:55'),
(95, NULL, 'GOC-2021-0251', '106730090023', 'GALANG', 'MAGAT', 'IAN PAULO', '11', 'Hyperion', 'Male', 'Enrolled', 'TVL - ICT', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:55'),
(96, NULL, 'GOC-2021-0255', '401537150162', 'VILLANUEVA', 'NICDAO', 'PETER JOHN', '11', 'Hyperion', 'Female', 'Enrolled', 'TVL - ICT', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:55'),
(97, NULL, 'GOC-2021-0259', '489515150093', 'JACOB', 'SALAS', 'BRENT JEMUEL', '11', 'Hyperion', 'Male', 'Enrolled', 'TVL - ICT', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:55'),
(98, NULL, 'GOC-2021-0263', '419507150230', 'MULANADI', 'TADENA', 'JEYCEE', '11', 'Hyperion', 'Female', 'Enrolled', 'TVL - ICT', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:55'),
(99, NULL, 'GOC-2021-0267', '489519150071', 'DELA CRUZ', 'TOLENTINO', 'GIAN FRANCO', '11', 'Hyperion', 'Male', 'Enrolled', 'TVL - ICT', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:55'),
(100, NULL, 'GOC-2021-0271', '106396090006', 'INACAY', 'AMURAO', 'ALEXA JOY', '11', 'Hyperion', 'Male', 'Enrolled', 'TVL - ICT', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:55'),
(101, NULL, 'GOC-2021-0275', '106696090044', 'SIMBULAN', 'CABRERA', 'MARIA SHEILA', '11', 'Hyperion', 'Male', 'Enrolled', 'TVL - ICT', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:55'),
(102, NULL, 'GOC-2021-0279', '489523150107', '', 'CALMA', 'KATE ANGEL NICOLE', '11', 'Hyperion', 'Male', 'Enrolled', 'TVL - ICT', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:55'),
(103, NULL, 'GOC-2021-0283', '489505150014', 'CURA', 'CUNANAN', 'WENNYLEI', '11', 'Hyperion', 'Male', 'Enrolled', 'TVL - ICT', 'Transferee', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:55'),
(104, NULL, 'GOC-2021-0287', '106772120002', '', 'DAIRO', 'JEUEL AILEN FAITH', '11', 'Hyperion', 'Male', 'Enrolled', 'TVL - HE', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:55'),
(105, NULL, 'GOC-2021-0291', '136400130106', 'JUCO', 'ESTEPA', 'EDZELLE KATE', '11', 'Hyperion', 'Male', 'Enrolled', 'TVL - HE', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:55'),
(106, NULL, 'GOC-2021-0295', '106490090007', 'CABALLERO', 'ESTEVES', 'ANGELICA MAE', '11', 'Hyperion', 'Male', 'Enrolled', 'TVL - HE', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:55'),
(107, NULL, 'GOC-2021-0299', '106746090085', 'ESCOPETE', 'HALILI', 'JANEL ', '11', 'Hyperion', 'Male', 'Enrolled', 'TVL - HE', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:56'),
(108, NULL, 'GOC-2021-0303', '401543150367', 'MAGAT', 'LULU', 'ALYSSA MARIE', '11', 'Hyperion', 'Male', 'Enrolled', 'TVL - HE', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:56'),
(109, NULL, 'GOC-2021-0307', '106747150099', 'CAYETANO', 'RODRIGUEZ', 'ASHLEY SHERYN', '11', 'Hyperion', 'Male', 'Enrolled', 'TVL - HE', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:56'),
(110, NULL, 'GOC-2021-0311', '106718120038', 'BARUELA', 'ROMBAOA', 'HAZEL ANNE', '11', 'Hyperion', 'Male', 'Enrolled', 'TVL - HE', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:56'),
(111, NULL, 'GOC-2021-0315', '106767090216', 'ALIVEN', 'SANTIAGO', 'ALEXA ', '11', 'Hyperion', 'Male', 'Enrolled', 'TVL - HE', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:56'),
(112, NULL, 'GOC-2021-0319', '106691090237', 'DADIOS', 'SANTOS', 'JULIANA', '11', 'Hyperion', 'Male', 'Enrolled', 'TVL - HE', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:56'),
(113, NULL, 'GOC-2021-0323', '401532150806', 'VELOSO', 'TIPAY', 'ZERRINE ', '11', 'Hyperion', 'Male', 'Enrolled', 'TVL - HE', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:56'),
(114, NULL, 'GOC-2021-0327', '105929090156', 'PASCUA', 'MARCELO', 'ARABELLA JAYRA', '11', 'Hyperion', 'Female', 'Enrolled', 'TVL - HE', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:56'),
(115, NULL, 'GOC-2021-0331', '106747090033', 'VARGAS', 'DELA CRUZ', 'KATHLEEN ', '11', 'Hyperion', 'Female', 'Enrolled', 'TVL - HE', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:56'),
(116, NULL, 'GOC-2021-0335', '106739090019', 'BONDOC', 'GEMINIANO', 'AIRA ', '11', 'Hyperion', 'Male', 'Enrolled', 'TVL - HE', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:56'),
(117, NULL, 'GOC-2021-0339', '106731090065', 'SALASAR', 'MAMASIG', 'ERIKA', '11', 'Hyperion', 'Female', 'Enrolled', 'TVL - HE', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:56'),
(118, NULL, 'GOC-2021-0343', '106767090245', '', 'VILLANUEVA', 'MARY HYACINTH', '11', 'Hyperion', 'Male', 'Enrolled', 'TVL - HE', 'New Student', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:56'),
(119, NULL, 'GOC-2021-0347', '106696090450', 'CANLAS', 'ZAPATA', 'MA. ANDREA LHEY', '11', 'Hyperion', 'Female', 'Enrolled', 'TVL - HE', 'Transferee', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2021-08-20 04:47:56');

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
(1, 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '11', 'CORE', 'ABM', '1st'),
(2, 'EARTHSCI 11-1', 'Earth and  Life Science', '11', 'CORE', 'ABM', '1st'),
(3, 'GENMATH 11-1', 'General Mathematics', '11', 'CORE', 'ABM', '1st'),
(4, 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '11', 'CORE', 'ABM', '1st'),
(5, 'ORALCOM 11-1', 'Oral Communication in Context', '11', 'CORE', 'ABM', '1st'),
(6, 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '11', 'CORE', 'ABM', '1st'),
(7, 'PHYED1 11-1', 'Physical Education and Health 1', '11', 'CORE', 'ABM', '1st'),
(8, 'EMTECH 11-1', 'Empowerment Technologies', '11', 'APPLIED', 'ABM', '1st'),
(9, 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '11', 'APPLIED', 'ABM', '1st'),
(10, 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '11', 'CORE', 'STEM', '1st'),
(11, 'EARTHSCI 11-1', 'Earth Science', '11', 'CORE', 'STEM', '1st'),
(12, 'GENMATH 11-1', 'General Mathematics', '11', 'CORE', 'STEM', '1st'),
(13, 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '11', 'CORE', 'STEM', '1st'),
(14, 'ORALCOM 11-1', 'Oral Communication in Context', '11', 'CORE', 'STEM', '1st'),
(15, 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '11', 'CORE', 'STEM', '1st'),
(16, 'PHYED1 11-1', 'Physical Education and Health 1', '11', 'CORE', 'STEM', '1st'),
(17, 'EMTECH 11-1', 'Empowerment Technologies', '11', 'APPLIED', 'STEM', '1st'),
(18, 'PRECALC 11-1', 'Pre-Calculus', '11', 'SPECIALIZED', 'STEM', '1st'),
(19, 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '11', 'CORE', 'HUMSS', '1st'),
(20, 'EARTHSCI 11-1', 'Earth and  Life Science', '11', 'CORE', 'HUMSS', '1st'),
(21, 'GENMATH 11-1', 'General Mathematics', '11', 'CORE', 'HUMSS', '1st'),
(22, 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '11', 'CORE', 'HUMSS', '1st'),
(23, 'ORALCOM 11-1', 'Oral Communication in Context', '11', 'CORE', 'HUMSS', '1st'),
(24, 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '11', 'CORE', 'HUMSS', '1st'),
(25, 'PHYED1 11-1', 'Physical Education and Health 1', '11', 'CORE', 'HUMSS', '1st'),
(26, 'EMTECH 11-1', 'Empowerment Technologies', '11', 'APPLIED', 'HUMSS', '1st'),
(27, 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '11', 'APPLIED', 'HUMSS', '1st'),
(28, 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '11', 'CORE', 'TVL - ICT', '1st'),
(29, 'EARTHSCI 11-1', 'Earth and  Life Science', '11', 'CORE', 'TVL - ICT', '1st'),
(30, 'GENMATH 11-1', 'General Mathematics', '11', 'CORE', 'TVL - ICT', '1st'),
(31, 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '11', 'CORE', 'TVL - ICT', '1st'),
(32, 'ORALCOM 11-1', 'Oral Communication in Context', '11', 'CORE', 'TVL - ICT', '1st'),
(33, 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '11', 'CORE', 'TVL - ICT', '1st'),
(34, 'PHYED1 11-1', 'Physical Education and Health 1', '11', 'CORE', 'TVL - ICT', '1st'),
(35, 'EMTECH 11-1', 'Empowerment Technologies', '11', 'APPLIED', 'TVL - ICT', '1st'),
(36, 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '11', 'APPLIED', 'TVL - ICT', '1st'),
(37, 'CONPHIL 11-2', 'Contemporary Philipine Arts from the Regions', '11', 'CORE', 'ABM', '2nd'),
(38, 'MIL 11-2', 'Media and Information Literacy', '11', 'CORE', 'ABM', '2nd'),
(39, 'FILI2 11-2', 'Pagbasa at Pagsusuri ng Ibat ibang Teksto  tungo sa pananaliksik', '11', 'CORE', 'ABM', '2nd'),
(40, 'PHYED2 11-2', 'Physical Educationand Health 2', '11', 'CORE', 'ABM', '2nd'),
(41, 'STATPRO 11-2', 'Statistics and Probability', '11', 'CORE', 'ABM', '2nd'),
(42, 'PR1 11-2', 'Practical Research 1', '11', 'APPLIED', 'ABM', '2nd'),
(43, 'BUSMATH 11-2', 'Business Math', '11', 'SPECIALIZED', 'ABM', '2nd'),
(44, 'ORGMAN 11-2', 'Organization and Management', '11', 'SPECIALIZED', 'ABM', '2nd'),
(45, 'FUNDACCTG 11-2', 'Fundamentals of Accounting, Business and Management 1', '11', 'SPECIALIZED', 'ABM', '2nd'),
(46, 'CONPHIL 11-2', 'Contemporary Philipine Arts from the Regions', '11', 'CORE', 'STEM', '2nd'),
(47, 'MIL 11-2', 'Media and Information Literacy', '11', 'CORE', 'STEM', '2nd'),
(48, 'FILI2 11-2', 'Pagbasa at Pagsusuri ng Ibat ibang Teksto  tungo sa pananaliksik', '11', 'CORE', 'STEM', '2nd'),
(49, 'PHYED2 11-2', 'Physical Educationand Health 2', '11', 'CORE', 'STEM', '2nd'),
(50, 'STATPRO 11-2', 'Statistics and Probability', '11', 'CORE', 'STEM', '2nd'),
(51, 'PR1 11-2', 'Practical Research 1', '11', 'APPLIED', 'STEM', '2nd'),
(52, 'FILPILING 11-2', 'Pagsulat ng Filipino sa Piling Larangan', '11', 'APPLIED', 'STEM', '2nd'),
(53, 'BCALCULUS 11-2', 'Basic Calculus', '11', 'SPECIALIZED', 'STEM', '2nd'),
(54, 'GENCHEM 11-2', 'General Chemistry 1', '11', 'SPECIALIZED', 'STEM', '2nd'),
(55, 'CONPHIL 11-2', 'Contemporary Philipine Arts from the Regions', '11', 'CORE', 'HUMSS', '2nd'),
(56, 'MIL 11-2', 'Media and Information Literacy', '11', 'CORE', 'HUMSS', '2nd'),
(57, 'FILI2 11-2', 'Pagbasa at Pagsusuri ng Ibat ibang Teksto  tungo sa pananaliksik', '11', 'CORE', 'HUMSS', '2nd'),
(58, 'PHYED2 11-2', 'Physical Educationand Health 2', '11', 'CORE', 'HUMSS', '2nd'),
(59, 'STATPRO 11-2', 'Statistics and Probability', '11', 'CORE', 'HUMSS', '2nd'),
(60, 'PR1 11-2', 'Practical Research 1', '11', 'APPLIED', 'HUMSS', '2nd'),
(61, 'CRWRIT 11-2', 'Creative Writing', '11', 'SPECIALIZED', 'HUMSS', '2nd'),
(62, 'DISS 11-2', 'Disciplines and Ideas in the Social Sciences', '11', 'SPECIALIZED', 'HUMSS', '2nd'),
(63, 'WORLDREL 11-2', 'Introduction to World Religions and Belief Systems', '11', 'SPECIALIZED', 'HUMSS', '2nd'),
(64, 'CONPHIL 11-2', 'Contemporary Philipine Arts from the Regions', '11', 'CORE', 'TVL - ICT', '2nd'),
(65, 'MIL 11-2', 'Media and Information Literacy', '11', 'CORE', 'TVL - ICT', '2nd'),
(66, 'FILI2 11-2', 'Pagbasa at Pagsusuri ng Ibat ibang Teksto  tungo sa pananaliksik', '11', 'CORE', 'TVL - ICT', '2nd'),
(67, 'PHYED2 11-2', 'Physical Educationand Health 2', '11', 'CORE', 'TVL - ICT', '2nd'),
(68, 'STATPRO 11-2', 'Statistics and Probability', '11', 'CORE', 'TVL - ICT', '2nd'),
(69, 'PR1 11-2', 'Practical Research 1', '11', 'APPLIED', 'TVL - ICT', '2nd'),
(70, 'JAVA1 11-2', 'Computer Programming (Java)', '11', 'SPECIALIZED', 'TVL - ICT', '2nd'),
(71, 'CONPHIL 11-2', 'Contemporary Philipine Arts from the Regions', '11', 'CORE', 'TVL - HE', '2nd'),
(72, 'MIL 11-2', 'Media and Information Literacy', '11', 'CORE', 'TVL - HE', '2nd'),
(73, 'FILI2 11-2', 'Pagbasa at Pagsusuri ng Ibat ibang Teksto  tungo sa pananaliksik', '11', 'CORE', 'TVL - HE', '2nd'),
(74, 'PHYED2 11-2', 'Physical Educationand Health 2', '11', 'CORE', 'TVL - HE', '2nd'),
(75, 'STATPRO 11-2', 'Statistics and Probability', '11', 'CORE', 'TVL - HE', '2nd'),
(76, 'PR1 11-2', 'Practical Research 1', '11', 'APPLIED', 'TVL - HE', '2nd'),
(77, 'Cookery1 11-2', 'Cookery 1', '11', 'SPECIALIZED', 'TVL - HE', '2nd'),
(78, 'WORLDLIT 11-1', '21st Century Literature from the Philippines and the World', '11', 'CORE', 'TVL - HE', '1st'),
(79, 'EARTHSCI 11-1', 'Earth and  Life Science', '11', 'CORE', 'TVL - HE', '1st'),
(80, 'GENMATH 11-1', 'General Mathematics', '11', 'CORE', 'TVL - HE', '1st'),
(81, 'KOMPAN 11-1', 'Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino', '11', 'CORE', 'TVL - HE', '1st'),
(82, 'ORALCOM 11-1', 'Oral Communication in Context', '11', 'CORE', 'TVL - HE', '1st'),
(83, 'PERDEV 11-1', 'Personal Development/ Pansariling Kaunlaran', '11', 'CORE', 'TVL - HE', '1st'),
(84, 'PHYED1 11-1', 'Physical Education and Health 1', '11', 'CORE', 'TVL - HE', '1st'),
(85, 'EMTECH 11-1', 'Empowerment Technologies', '11', 'APPLIED', 'TVL - HE', '1st'),
(86, 'FILPILING 11-1', 'Pagsulat sa Filipino sa Piling Larangan', '11', 'APPLIED', 'TVL - HE', '1st');

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
(2, 'APPLIED'),
(3, 'SPECIALIZED');

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
(5, '0002', 'admin', 'admin', 'Admin', 'Efraim G. Basilio'),
(7, 'SHS-21-0001', 'rramos', '123456', 'Teacher', 'Rodel I. Ramos'),
(8, 'SHS-21-0002', 'cmanuel', '123456', 'Teacher', 'Christian A. Manuel');

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `faculty_loads`
--
ALTER TABLE `faculty_loads`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `grade_level`
--
ALTER TABLE `grade_level`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `grading`
--
ALTER TABLE `grading`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=406;

--
-- AUTO_INCREMENT for table `section`
--
ALTER TABLE `section`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `strand`
--
ALTER TABLE `strand`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `student_profile`
--
ALTER TABLE `student_profile`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=120;

--
-- AUTO_INCREMENT for table `subject`
--
ALTER TABLE `subject`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `subjects`
--
ALTER TABLE `subjects`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=87;

--
-- AUTO_INCREMENT for table `subject_type`
--
ALTER TABLE `subject_type`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
