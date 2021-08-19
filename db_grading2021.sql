-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 19, 2021 at 10:10 AM
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
  `goc_no` varchar(255) DEFAULT NULL,
  `lrn_no` varchar(255) DEFAULT NULL,
  `fname` varchar(255) DEFAULT NULL,
  `mname` varchar(255) DEFAULT NULL,
  `lname` varchar(255) DEFAULT NULL,
  `grade_level` varchar(255) DEFAULT NULL,
  `section` varchar(255) DEFAULT NULL,
  `strand` varchar(255) DEFAULT NULL,
  `academic_status` varchar(255) DEFAULT NULL,
  `sex` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student_profile`
--

INSERT INTO `student_profile` (`id`, `goc_no`, `lrn_no`, `fname`, `mname`, `lname`, `grade_level`, `section`, `strand`, `academic_status`, `sex`) VALUES
(1, 'GOC-2021-0002', '489521150056', ' JVEN', 'JALECO', 'BILLONES', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(2, 'GOC-2021-0004', '106720080044', 'ALLEN JOSEPH', 'LAGROSA', 'FAALA', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(3, 'GOC-2021-0006', '106720090038', 'CHARLES BENEDICT', 'LAGROSA', 'FAALA', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(4, 'GOC-2021-0008', '103840090273', 'IVEZ', 'ACIO', 'PASCUAL', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(5, 'GOC-2021-0010', '106746090141', 'JIN HOWELL', 'GONZALES', 'RAMIREZ', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(6, 'GOC-2021-0012', '420003150057', 'HAROLD', 'DANIPOG', 'TOMAS', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(7, 'GOC-2021-0014', '106329090007', 'DANIELLE', 'GRAGANTA', 'ALTAREJOS', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(8, 'GOC-2021-0016', '106705090004', 'ABIGAIL', 'TIPUNO', 'AQUINO', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(9, 'GOC-2021-0018', '106735090008', 'KHARISSA', 'BURGOS', 'ARQUIZA', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(10, 'GOC-2021-0020', '106752090019', 'SHEREE MYLES', 'DAVID', 'BAQUING', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(11, 'GOC-2021-0022', '108226090010', 'MARIEL', 'FELISILDA', 'BAUTISTA', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(12, 'GOC-2021-0024', '106702090042', 'JICCA REA', '', 'CALAGUAS', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(13, 'GOC-2021-0026', '100403090009', 'ALAICA MAE', 'SOL', 'CARBONEL', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(14, 'GOC-2021-0028', '106709090002', 'KATE BRITNEY', 'MACASAQUIT', 'CASTAÑEDA', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(15, 'GOC-2021-0030', '401537150168', 'SHANAIA ISHI', 'D', 'CUEVA', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(16, 'GOC-2021-0032', '106731090024', 'JHEM', 'DAVID', 'CUSTODIO', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(17, 'GOC-2021-0034', '105869090040', 'JANELLE ANNE', 'LICUP', 'DALUSONG', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(18, 'GOC-2021-0036', '106767090065', 'ERICKA', 'LINTAG', 'DAMASCO', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(19, 'GOC-2021-0038', '106734090022', 'TRIZIA EMMARINE', 'DIZON', 'DAVID', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(20, 'GOC-2021-0040', '136854120783', 'LOVELY EUNICE', 'RELOSA', 'FAALA', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(21, 'GOC-2021-0042', '106746090063', 'IRA', 'BAUN', 'FERNANDEZ', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(22, 'GOC-2021-0043', '106718090024', 'GLAYZA', 'LAGMAY', 'GRANADOZO', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(23, 'GOC-2021-0044', '106701090034', 'MYRA', 'ASIO', 'LIPATA', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(24, 'GOC-2021-0045', '420057150051', 'HIDIE', 'SUMAOANG', 'LORENZO', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(25, 'GOC-2021-0046', '106797090138', 'SHERLYN MAE', 'SULAY', 'MERCADO', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(26, 'GOC-2021-0047', '106728090045', 'ELISABET', 'GARCIA', 'MIRANDA', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(27, 'GOC-2021-0048', '106741070069', 'KRISTINE', 'RIOSA', 'PUNZALAN', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(28, 'GOC-2021-0049', '106704090135', 'ERICA FAYE', 'DULAY', 'TIGLAO', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(29, 'GOC-2021-0050', '401537150150', 'AKOL', ' JOSEPH RAFAEL', 'CUNANAN', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(30, 'GOC-2021-0051', '106701090009', 'BASANGAN', ' JUSTIN LLOYD', 'ALOLOR', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(31, 'GOC-2021-0052', '106674090014', 'CASTRO', ' JHESMER', 'TOLENADA', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(32, 'GOC-2021-0053', '489506150561', 'GARCIA', ' CHAMBERLAINE KYLE', 'ZARATE', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(33, 'GOC-2021-0054', '106231090115', 'MANALASTAS', ' ART', 'MELEGRITO', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(34, 'GOC-2021-0055', '106694090073', 'PAPIO', ' JOHN PAOLO', 'ATALIN', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(35, 'GOC-2021-0056', '101401090007', 'BAGNAS', ' HANNA LEA ', 'ROSETE', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(36, 'GOC-2021-0057', '401528150946', 'BARLAAN', ' KIRSTEN JOY', '', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(37, 'GOC-2021-0058', '401216150512', 'BARTHOLOMEW', ' HERSHE LEIN', '', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(38, 'GOC-2021-0059', '106759130083', 'BORDEOS', ' BERNADETTE BEYONCE ', 'SALAZAR', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(39, 'GOC-2021-0060', '106502090010', 'CAPARAS', ' FRANCINE VANESS ', 'DIZON', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(40, 'GOC-2021-0061', '106734090016', 'CORDOVA', ' KATHLEEN JADE ', 'PEREZ', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(41, 'GOC-2021-0062', '106724090004', 'CUARESMA', ' SARAH MICHELLE ', 'BOGNOT', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(42, 'GOC-2021-0063', '151520090013', 'DE VERA', ' ALLYSA JOYCE ', 'MONTEMAYOR', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(43, 'GOC-2021-0064', '106696090127', 'DULAY', ' KYLE DIMPLES ', 'RUBIO', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(44, 'GOC-2021-0065', '106731090037', 'ESTEBAN', ' KYLA ', 'CAPULONG', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(45, 'GOC-2021-0066', '106674090024', 'FACUN', ' LAILANIE ', 'GUERERO', '11', 'Hermes', 'ABM', 'Enrolled', ''),
(46, 'GOC-2021-0067', '106746090064', 'FERRER', ' ALYANNA ANGEL ', 'LAQUINDANUM', '11', 'Zeus', 'STEM', 'Enrolled', ''),
(47, 'GOC-2021-0068', '106755090057', 'GUIAO', ' SOPHIA ', 'BRIONES', '11', 'Zeus', 'STEM', 'Enrolled', ''),
(48, 'GOC-2021-0069', '106746140212', 'MANALAD', ' NIKA MAE ', 'BALINAS', '11', 'Zeus', 'STEM', 'Enrolled', ''),
(49, 'GOC-2021-0070', '401532150797', 'MANANQUIL', ' MIYAH ANGELA ', 'RAZON', '11', 'Zeus', 'STEM', 'Enrolled', ''),
(50, 'GOC-2021-0071', '106696090323', 'PEREZ', ' CHRISTINE MAE ', 'MAAR', '11', 'Zeus', 'STEM', 'Enrolled', ''),
(51, 'GOC-2021-0075', '106763090224', 'ROBLES', ' LOVELY LYKA ', 'SERRANO', '11', 'Zeus', 'STEM', 'Enrolled', ''),
(52, 'GOC-2021-0079', '106745090051', 'SANTOS', ' CHELSIE VON ', 'BONDOC', '11', 'Zeus', 'STEM', 'Enrolled', ''),
(53, 'GOC-2021-0083', '124829090046', 'TABOTABO', ' AUGUS TRICIA ', 'FERNANDEZ', '11', 'Zeus', 'STEM', 'Enrolled', ''),
(54, 'GOC-2021-0087', '106716090095', 'TACADINO', ' NICOLE JOY', 'MARTINEZ', '11', 'Zeus', 'STEM', 'Enrolled', ''),
(55, 'GOC-2021-0091', '106730090054', 'TONGOL', ' SCHARLETTE ', 'BELTRAN', '11', 'Zeus', 'STEM', 'Enrolled', ''),
(56, 'GOC-2021-0095', '106755090112', 'USI', ' JULLIA ', 'BATALON', '11', 'Zeus', 'STEM', 'Enrolled', ''),
(57, 'GOC-2021-0099', '106759090079', 'YUMUL', ' ALLIAH JOY ', 'BARRO', '11', 'Zeus', 'STEM', 'Enrolled', ''),
(58, 'GOC-2021-0103', '489506150552', 'DALUMA', 'KHALID', 'UBAN', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(59, 'GOC-2021-0107', '106746130069', 'DAVID', 'RENCY', 'CARIN', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(60, 'GOC-2021-0111', '106767090139', 'MAGSINO', 'LUIS GABRIEL', 'REYES', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(61, 'GOC-2021-0115', '106710090054', 'MANABAT', 'ELIJAH', 'CUNANAN', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(62, 'GOC-2021-0119', '300957150005', 'MATEO', 'GIANLUCA', 'CORPUZ', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(63, 'GOC-2021-0123', '106695090078', 'PEREZ', 'JOHN PAUL', 'CARREON', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(64, 'GOC-2021-0127', '106696090336', 'PRADO', 'JOHN PAUL', 'MANALO', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(65, 'GOC-2021-0131', '106728090060', 'SARMIENTO', 'ARJAY', 'CATAMBING', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(66, 'GOC-2021-0135', '489527150051', 'TAMAYO', 'DIETHER', 'CORTEZ', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(67, 'GOC-2021-0139', '106696090418', 'TOLENTINO', 'NASER', 'RIGOR', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(68, 'GOC-2021-0143', '106704090146', 'VENTENILLA', 'BRYCE ARMYAN ', 'SANTIAGO', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(69, 'GOC-2021-0147', '106677090039', 'OSERIN', 'LAURENCE DON', 'FERNANDEZ', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(70, 'GOC-2021-0151', '109494120310', 'DE GUZMAN', 'XAVIER LOUIS', 'LACSINA', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(71, 'GOC-2021-0155', '106704090015', 'BALICOCO', 'KATHLYN CAYLA', 'LUCIANO', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(72, 'GOC-2021-0159', '106742090020', 'CABRERA', 'JUSTINE', 'DIZON', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(73, 'GOC-2021-0163', '107113090028', 'CACHO', 'CHRISHA MHEYANNE', 'VALINO', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(74, 'GOC-2021-0167', '101748090016', 'CERVAS', 'RHEA ROSE', 'SUPAN', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(75, 'GOC-2021-0171', '106682090007', 'CORONEL', 'EMAROSE', 'FACUN', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(76, 'GOC-2021-0175', '106705090044', 'DE JESUS', 'SHEENA MAE', 'MARQUEZ', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(77, 'GOC-2021-0179', '106696090116', 'DELOS REYES', 'HERCELYN', 'JANEO', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(78, 'GOC-2021-0183', '106731120122', 'DOOC', 'ALTHEA MARIE', 'GARCIA', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(79, 'GOC-2021-0187', '489506150602', 'ESPINO', 'GLADYL HAZEL', 'DATANG', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(80, 'GOC-2021-0191', '106767090100', 'FRANCO', 'ALICIA MAE', 'SICANGCO', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(81, 'GOC-2021-0195', '106738080034', 'GAJILA', 'PRINCESS DEE', 'CABULARES', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(82, 'GOC-2021-0199', '106731090049', 'GONZALES', 'JOMAFEL', 'ORBETA', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(83, 'GOC-2021-0203', '106609090030', 'JAVIER', 'VIEN MAEREN', 'PACLIBARE', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(84, 'GOC-2021-0207', '106742090058', 'LAHONG', 'MARIA YUEN', 'MUAN', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(85, 'GOC-2021-0211', '106696090207', 'LAPIRA', 'ANGEL', '', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(86, 'GOC-2021-0215', '106785090014', 'MEJIA', 'RONALYN GRACE', 'SENADJAN', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(87, 'GOC-2021-0219', '106767090217', 'SANTOS', 'SARIAH ', 'CRUZ', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(88, 'GOC-2021-0223', '106767090144', 'MANALILI', 'JENNILYN', 'TANEDO', '11', 'Athena', 'HUMSS', 'Enrolled', ''),
(89, 'GOC-2021-0227', '106781090009', 'BUERANO', 'MARK DENZEL', 'LORENO', '11', 'Hyperion', 'TVL - ICT', 'Enrolled', ''),
(90, 'GOC-2021-0231', '420022150118', 'CORBADURA', 'JOSEPH ANDREW', 'GOMEZ', '11', 'Hyperion', 'TVL - ICT', 'Enrolled', ''),
(91, 'GOC-2021-0235', '106698090045', 'GALAS', 'RAE ANGELO', 'CASTILLO', '11', 'Hyperion', 'TVL - ICT', 'Enrolled', ''),
(92, 'GOC-2021-0239', '106604090024', 'GAMBOA', 'CHRISTIAN DAVE', '', '11', 'Hyperion', 'TVL - ICT', 'Enrolled', ''),
(93, 'GOC-2021-0243', '106477080033', 'LACAYANGA', 'MARK KENNETH', 'GARCIA', '11', 'Hyperion', 'TVL - ICT', 'Enrolled', ''),
(94, 'GOC-2021-0247', '106696090218', 'LUMIBAO', 'JAMES HERO', 'CARREON', '11', 'Hyperion', 'TVL - ICT', 'Enrolled', ''),
(95, 'GOC-2021-0251', '106730090023', 'MAGAT', 'IAN PAULO', 'GALANG', '11', 'Hyperion', 'TVL - ICT', 'Enrolled', ''),
(96, 'GOC-2021-0255', '401537150162', 'NICDAO', 'PETER JOHN', 'VILLANUEVA', '11', 'Hyperion', 'TVL - ICT', 'Enrolled', ''),
(97, 'GOC-2021-0259', '489515150093', 'SALAS', 'BRENT JEMUEL', 'JACOB', '11', 'Hyperion', 'TVL - ICT', 'Enrolled', ''),
(98, 'GOC-2021-0263', '419507150230', 'TADENA', 'JEYCEE', 'MULANADI', '11', 'Hyperion', 'TVL - ICT', 'Enrolled', ''),
(99, 'GOC-2021-0267', '489519150071', 'TOLENTINO', 'GIAN FRANCO', 'DELA CRUZ', '11', 'Hyperion', 'TVL - ICT', 'Enrolled', ''),
(100, 'GOC-2021-0271', '106396090006', 'AMURAO', 'ALEXA JOY', 'INACAY', '11', 'Hyperion', 'TVL - ICT', 'Enrolled', ''),
(101, 'GOC-2021-0275', '106696090044', 'CABRERA', 'MARIA SHEILA', 'SIMBULAN', '11', 'Hyperion', 'TVL - ICT', 'Enrolled', ''),
(102, 'GOC-2021-0279', '489523150107', 'CALMA', 'KATE ANGEL NICOLE', '', '11', 'Hyperion', 'TVL - ICT', 'Enrolled', ''),
(103, 'GOC-2021-0283', '489505150014', 'CUNANAN', 'WENNYLEI', 'CURA', '11', 'Hyperion', 'TVL - ICT', 'Enrolled', ''),
(104, 'GOC-2021-0287', '106772120002', 'DAIRO', 'JEUEL AILEN FAITH', '', '11', 'Hyperion', 'TVL - HE', 'Enrolled', ''),
(105, 'GOC-2021-0291', '136400130106', 'ESTEPA', 'EDZELLE KATE', 'JUCO', '11', 'Hyperion', 'TVL - HE', 'Enrolled', ''),
(106, 'GOC-2021-0295', '106490090007', 'ESTEVES', 'ANGELICA MAE', 'CABALLERO', '11', 'Hyperion', 'TVL - HE', 'Enrolled', ''),
(107, 'GOC-2021-0299', '106746090085', 'HALILI', 'JANEL ', 'ESCOPETE', '11', 'Hyperion', 'TVL - HE', 'Enrolled', ''),
(108, 'GOC-2021-0303', '401543150367', 'LULU', 'ALYSSA MARIE', 'MAGAT', '11', 'Hyperion', 'TVL - HE', 'Enrolled', ''),
(109, 'GOC-2021-0307', '106747150099', 'RODRIGUEZ', 'ASHLEY SHERYN', 'CAYETANO', '11', 'Hyperion', 'TVL - HE', 'Enrolled', ''),
(110, 'GOC-2021-0311', '106718120038', 'ROMBAOA', 'HAZEL ANNE', 'BARUELA', '11', 'Hyperion', 'TVL - HE', 'Enrolled', ''),
(111, 'GOC-2021-0315', '106767090216', 'SANTIAGO', 'ALEXA ', 'ALIVEN', '11', 'Hyperion', 'TVL - HE', 'Enrolled', ''),
(112, 'GOC-2021-0319', '106691090237', 'SANTOS', 'JULIANA', 'DADIOS', '11', 'Hyperion', 'TVL - HE', 'Enrolled', ''),
(113, 'GOC-2021-0323', '401532150806', 'TIPAY', 'ZERRINE ', 'VELOSO', '11', 'Hyperion', 'TVL - HE', 'Enrolled', ''),
(114, 'GOC-2021-0327', '105929090156', 'MARCELO', 'ARABELLA JAYRA', 'PASCUA', '11', 'Hyperion', 'TVL - HE', 'Enrolled', ''),
(115, 'GOC-2021-0331', '106747090033', 'DELA CRUZ', 'KATHLEEN ', 'VARGAS', '11', 'Hyperion', 'TVL - HE', 'Enrolled', ''),
(116, 'GOC-2021-0335', '106739090019', 'GEMINIANO', 'AIRA ', 'BONDOC', '11', 'Hyperion', 'TVL - HE', 'Enrolled', ''),
(117, 'GOC-2021-0339', '106731090065', 'MAMASIG', 'ERIKA', 'SALASAR', '11', 'Hyperion', 'TVL - HE', 'Enrolled', ''),
(118, 'GOC-2021-0343', '106767090245', 'VILLANUEVA', 'MARY HYACINTH', '', '11', 'Hyperion', 'TVL - HE', 'Enrolled', ''),
(119, 'GOC-2021-0347', '106696090450', 'ZAPATA', 'MA. ANDREA LHEY', 'CANLAS', '11', 'Hyperion', 'TVL - HE', 'Enrolled', '');

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

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
