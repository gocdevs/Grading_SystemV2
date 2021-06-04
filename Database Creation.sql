CREATE TABLE `subject` (
  `id` int(11) NOT NULL,
  `subject_code` varchar(255) NOT NULL,
  `subject_name` varchar(255) NOT NULL,
  `subject_type` varchar(255) NOT NULL,
  `semester` varchar(255) NOT NULL,
  `grade_level` varchar(255) NOT NULL,
  `strand` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `faculty` (
  `id` int(11) NOT NULL,
  `faculty_id` varchar(255) NOT NULL,
  `fname` varchar(255) NOT NULL,
  `lname` varchar(255) NOT NULL,
  `mname` varchar(255) NOT NULL,
  `course` varchar(255) NOT NULL,
  `specialize_subject` varchar(255) NOT NULL
  `adviser_of` varchar(255) NOT NULL
  `employement_status` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `section` (
  `id` int(11) NOT NULL,
  `section_name` varchar(255) NOT NULL,
  `strand` varchar(255) NOT NULL,
  `department` varchar(255) NOT NULL,
  `grade_level` varchar(255) NOT NULL,
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `student_profile` (
  `id` int(11) NOT NULL,
  `goc_no` varchar(255) NOT NULL,
  `lrn_no` varchar(255) NOT NULL,
  `fname` varchar(255) NOT NULL,
  `mname` varchar(255) NOT NULL,
  `lname` varchar(255) NOT NULL,
  `grade_level` varchar(255) NOT NULL,
  `section` varchar(255) NOT NULL,
  `strand` varchar(255) NOT NULL,
  `academic_status` varchar(255) NOT NULL, 
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `faculty_loads` (
  `id` int(11) NOT NULL,
  `faculty_id` varchar(255) NOT NULL,
  `fname` varchar(255) NOT NULL,
  `mname` varchar(255) NOT NULL,
  `lname` varchar(255) NOT NULL,
  `subject_code` varchar(255) NOT NULL,
  `section` varchar(255) NOT NULL,
  `strand` varchar(255) NOT NULL,
  `semester` varchar(255) NOT NULL,
  `note` varchar(255) NOT NULL,
  `date_assigned` varchar(255) NOT NULL, 
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE TABLE `faculty_loads` (
  `id` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `user_type` varchar(255) NOT NULL,
  `faculty_id` varchar(255) NOT NULL,
  `fname` varchar(255) NOT NULL,
  `mname` varchar(255) NOT NULL,
  `lname` varchar(255) NOT NULL,
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `academic_grades` (
  `id` int(11) NOT NULL,
  `goc_no` varchar(255) NOT NULL,
  `student_name` varchar(255) NOT NULL,
  `subject_name` varchar(255) NOT NULL,
  `sem_grade1` varchar(255) NOT NULL,
  `sem_grade2` varchar(255) NOT NULL,
  `average` varchar(255) NOT NULL,
  `grade_level` varchar(255) NOT NULL,
  `section` varchar(255) NOT NULL,
  `strand` varchar(255) NOT NULL,
  `term` varchar(255) NOT NULL,
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `char_grades_and_attendance` (
  `id` int(11) NOT NULL,
  `goc_no` varchar(255) NOT NULL,
  `student_name` varchar(255) NOT NULL,
  `1st_md1` varchar(5) NOT NULL,
  `2nd_md1` varchar(5) NOT NULL,
  `3rd_md1` varchar(5) NOT NULL,
  `4th_md1` varchar(5) NOT NULL,
  `1st_md2` varchar(5) NOT NULL,
  `2nd_md2` varchar(5) NOT NULL,
  `3rd_md2` varchar(5) NOT NULL,
  `4th_md2` varchar(5) NOT NULL,
  `1st_mt1` varchar(5) NOT NULL,
  `2nd_mt1` varchar(5) NOT NULL,
  `3rd_mt1` varchar(5) NOT NULL,
  `4th_mt1` varchar(5) NOT NULL,
  `1st_mt2` varchar(5) NOT NULL,
  `2nd_mt2` varchar(5) NOT NULL,
  `3rd_mt2` varchar(5) NOT NULL,
  `4th_mt2` varchar(5) NOT NULL,
  `1st_mk1` varchar(5) NOT NULL,
  `2nd_mk1` varchar(5) NOT NULL,
  `3rd_mk1` varchar(5) NOT NULL,
  `4th_mk1` varchar(5) NOT NULL,
  `1st_mk2` varchar(5) NOT NULL,
  `2nd_mk2` varchar(5) NOT NULL,
  `3rd_mk2` varchar(5) NOT NULL,
  `4th_mk2` varchar(5) NOT NULL,
  `1st_mb1` varchar(5) NOT NULL,
  `2nd_mb1` varchar(5) NOT NULL,
  `3rd_mb1` varchar(5) NOT NULL,
  `4th_mb1` varchar(5) NOT NULL,
  `1st_mb2` varchar(5) NOT NULL,
  `2nd_mb2` varchar(5) NOT NULL,
  `3rd_mb2` varchar(5) NOT NULL,
  `4th_mb2` varchar(5) NOT NULL,
  `month1` int(5) NOT NULL,
  `month2` int(5) NOT NULL,
  `month3` int(5) NOT NULL,
  `month4` int(5) NOT NULL,
  `month5` int(5) NOT NULL,
  `month6` int(5) NOT NULL,
  `month7` int(5) NOT NULL,
  `month8` int(5) NOT NULL,
  `month9` int(5) NOT NULL,
  `month10` int(5) NOT NULL,
  `total_abs` int(5) NOT NULL,
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `character_grades` (
  `id` int(11) NOT NULL,
  `goc_no` varchar(255) NOT NULL,
  `student_name` varchar(255) NOT NULL,
  `subject_name` varchar(255) NOT NULL,
  `sem_grade1` varchar(255) NOT NULL,
  `sem_grade2` varchar(255) NOT NULL,
  `average` varchar(255) NOT NULL,
  `grade_level` varchar(255) NOT NULL,
  `section` varchar(255) NOT NULL,
  `strand` varchar(255) NOT NULL,
  `term` varchar(255) NOT NULL,
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
