-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 20, 2024 at 05:33 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.0.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hms`
--

-- --------------------------------------------------------

--
-- Table structure for table `doctor`
--

CREATE TABLE `doctor` (
  `DoctorID` char(10) NOT NULL,
  `Specialization` char(100) DEFAULT NULL,
  `LicenseNumber` int(11) DEFAULT NULL,
  `Certification` char(100) DEFAULT NULL,
  `YearsOfExperience` smallint(6) DEFAULT NULL,
  `ConsultingFee` int(11) DEFAULT NULL,
  `EmployeeID` char(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `doctor`
--

INSERT INTO `doctor` (`DoctorID`, `Specialization`, `LicenseNumber`, `Certification`, `YearsOfExperience`, `ConsultingFee`, `EmployeeID`) VALUES
('D001', 'Cardiology', 12345, 'Board Certified', 10, 200, 'E001'),
('D002', 'Neurology', 67890, 'Board Certified', 8, 180, 'E002'),
('D003', 'Orthopedics', 13579, 'Board Certified', 15, 250, 'E003');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `EmployeeID` char(10) NOT NULL,
  `FirstName` char(20) DEFAULT NULL,
  `LastName` char(20) DEFAULT NULL,
  `EmployeeType` char(14) DEFAULT NULL,
  `DateOfBirth` date DEFAULT NULL,
  `Gender` char(10) DEFAULT NULL,
  `ContactNumber` char(15) DEFAULT NULL,
  `Email` char(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`EmployeeID`, `FirstName`, `LastName`, `EmployeeType`, `DateOfBirth`, `Gender`, `ContactNumber`, `Email`) VALUES
('E001', 'John', 'Doe', 'Doctor', '1980-05-15', 'Male', '555-1234', 'john.doe@example.com'),
('E002', 'Jane', 'Smith', 'Doctor', '1985-07-20', 'Female', '555-5678', 'jane.smith@example.com'),
('E003', 'Alice', 'Brown', 'Doctor', '1975-03-30', 'Female', '555-9012', 'alice.brown@example.com');

-- --------------------------------------------------------

--
-- Table structure for table `manager`
--

CREATE TABLE `manager` (
  `ManagerialRole` char(20) DEFAULT NULL,
  `Department` char(20) DEFAULT NULL,
  `HireDate` date DEFAULT NULL,
  `Salary` int(11) DEFAULT NULL,
  `ManagerID` char(10) NOT NULL,
  `EmployeeID` char(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `manager`
--

INSERT INTO `manager` (`ManagerialRole`, `Department`, `HireDate`, `Salary`, `ManagerID`, `EmployeeID`) VALUES
('Head of Cardiology', 'Cardiology', '2010-01-01', 100000, 'M001', 'E001'),
('Head of Neurology', 'Neurology', '2012-06-15', 95000, 'M002', 'E002'),
('Head of Orthopedics', 'Orthopedics', '2008-09-20', 110000, 'M003', 'E003');

-- --------------------------------------------------------

--
-- Table structure for table `medicine`
--

CREATE TABLE `medicine` (
  `Medicine_ID` char(10) NOT NULL,
  `Medicine_name` char(50) DEFAULT NULL,
  `Medicine_expirydate` date DEFAULT NULL,
  `Medicince_manufdate` date DEFAULT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `Unit_price` decimal(18,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `medicine`
--

INSERT INTO `medicine` (`Medicine_ID`, `Medicine_name`, `Medicine_expirydate`, `Medicince_manufdate`, `Quantity`, `Unit_price`) VALUES
('M001', 'Paracetamol', '2024-12-31', '2023-01-01', 96, 50),
('M002', 'Aspirin', '2025-06-30', '2023-02-15', 134, 30),
('M003', 'Amoxicillin', '2024-08-15', '2023-03-20', 8, 11);

-- --------------------------------------------------------

--
-- Table structure for table `medicinesale`
--

CREATE TABLE `medicinesale` (
  `SaleID` int(11) NOT NULL,
  `CustomerName` varchar(100) DEFAULT NULL,
  `Phone` varchar(20) DEFAULT NULL,
  `SaleDate` date DEFAULT NULL,
  `TotalPrice` decimal(10,2) DEFAULT NULL,
  `Seller` varchar(30) NOT NULL
) ;

--
-- Dumping data for table `medicinesale`
--

INSERT INTO `medicinesale` (`SaleID`, `CustomerName`, `Phone`, `SaleDate`, `TotalPrice`, `Seller`) VALUES
(4, 'Emily Brown', '987-654-3210', '2024-05-23', 150.00, 'Puja'),
(5, 'Michael Wilson', '321-654-9870', '2024-05-24', 75.80, 'Puja'),
(6, 'Sarah Taylor', '654-987-0123', '2024-05-25', 300.25, 'Puja'),
(7, 'David Lee', '012-345-6789', '2024-05-26', 180.90, 'Puja'),
(8, 'Emma Martinez', '876-543-2109', '2024-05-27', 220.40, 'Puja'),
(9, 'James Jackson', '234-567-8901', '2024-05-28', 95.60, 'Puja'),
(10, 'Olivia White', '567-890-1234', '2024-05-29', 175.20, 'Puja'),
(11, 'Rahat', '0230934859357', '2024-05-20', 190.00, 'Puja'),
(12, 'Jahinn', '011888222', '2024-05-20', 220.00, 'Puja'),
(13, 'Xahin', '01544533645', '2024-05-20', 60.00, 'a');

-- --------------------------------------------------------

--
-- Table structure for table `patient`
--

CREATE TABLE `patient` (
  `PatientID` char(10) NOT NULL,
  `FirstName` char(20) DEFAULT NULL,
  `LastName` char(20) DEFAULT NULL,
  `DateOfBirth` date DEFAULT NULL,
  `Gender` char(10) DEFAULT NULL,
  `ContactNumber` char(15) DEFAULT NULL,
  `Issue` char(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `patient`
--

INSERT INTO `patient` (`PatientID`, `FirstName`, `LastName`, `DateOfBirth`, `Gender`, `ContactNumber`, `Issue`) VALUES
('P001', 'Tom', 'Harris', '1990-04-10', 'Male', '555-2345', 'Chest Pain'),
('P002', 'Lucy', 'Gray', '1982-11-23', 'Female', '555-6789', 'Migraine'),
('P003', 'Kevin', 'White', '1978-02-18', 'Male', '555-3456', 'Knee Pain');

-- --------------------------------------------------------

--
-- Table structure for table `patientserved`
--

CREATE TABLE `patientserved` (
  `ServiceID` char(10) DEFAULT NULL,
  `QueueID` char(10) DEFAULT NULL,
  `ServiceCost` char(10) DEFAULT NULL,
  `FollowUpRequired` char(10) DEFAULT NULL,
  `TreatmentGiven` char(10) DEFAULT NULL,
  `DiagnosedCondition` char(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `patientserved`
--

INSERT INTO `patientserved` (`ServiceID`, `QueueID`, `ServiceCost`, `FollowUpRequired`, `TreatmentGiven`, `DiagnosedCondition`) VALUES
('S001', 'Q001', '100', 'Yes', 'Medication', 'Angina'),
('S002', 'Q002', '150', 'No', 'Therapy', 'Migraine'),
('S003', 'Q003', '120', 'Yes', 'Surgery', 'Arthritis');

-- --------------------------------------------------------

--
-- Table structure for table `pharmacist`
--

CREATE TABLE `pharmacist` (
  `Ph_id` char(10) NOT NULL,
  `ph_firstname` char(20) DEFAULT NULL,
  `ph_lastname` char(20) DEFAULT NULL,
  `ph_gender` char(10) DEFAULT NULL,
  `ph_contact` char(20) DEFAULT NULL,
  `ph_salary` decimal(18,0) DEFAULT NULL,
  `ph_username` char(10) DEFAULT NULL,
  `ph_password` char(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pharmacist`
--

INSERT INTO `pharmacist` (`Ph_id`, `ph_firstname`, `ph_lastname`, `ph_gender`, `ph_contact`, `ph_salary`, `ph_username`, `ph_password`) VALUES
('', 'a', 'a', 'Male', '', 3445, 'a', 'a'),
('P001', 'John', 'Doefdf', 'Male', '1234567890', 60000, 'jdoe', 'pass123'),
('P002', 'Jane', 'Smith', 'Female', '0987654321', 65000, 'jsmith', 'pass456'),
('P003', 'Alice', 'Johnson', 'Female', '1122334455', 70000, 'ajohnson', 'pass789');

-- --------------------------------------------------------

--
-- Table structure for table `prescription`
--

CREATE TABLE `prescription` (
  `PrescriptionID` char(10) NOT NULL,
  `ServiceID` char(10) DEFAULT NULL,
  `Prescription` char(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `prescription`
--

INSERT INTO `prescription` (`PrescriptionID`, `ServiceID`, `Prescription`) VALUES
('PR001', 'S001', 'Nitroglycerin'),
('PR002', 'S002', 'Sumatriptan'),
('PR003', 'S003', 'Ibuprofen');

-- --------------------------------------------------------

--
-- Table structure for table `queue`
--

CREATE TABLE `queue` (
  `QueueID` char(10) NOT NULL,
  `PatientID` char(10) DEFAULT NULL,
  `DoctorID` char(10) DEFAULT NULL,
  `SymptomDescription` char(100) DEFAULT NULL,
  `PriorityLevel` smallint(6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `queue`
--

INSERT INTO `queue` (`QueueID`, `PatientID`, `DoctorID`, `SymptomDescription`, `PriorityLevel`) VALUES
('Q001', 'P001', 'D001', 'Severe chest pain', 1),
('Q002', 'P002', 'D002', 'Severe headache', 2),
('Q003', 'P003', 'D003', 'Severe knee pain', 3);

-- --------------------------------------------------------

--
-- Table structure for table `receptionist`
--

CREATE TABLE `receptionist` (
  `ReceptionistID` char(10) NOT NULL,
  `ShiftTiming` text DEFAULT NULL,
  `Salary` int(11) DEFAULT NULL,
  `EmployeeID` char(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `receptionist`
--

INSERT INTO `receptionist` (`ReceptionistID`, `ShiftTiming`, `Salary`, `EmployeeID`) VALUES
('R001', 'Morning', 30000, 'E004'),
('R002', 'Afternoon', 32000, 'E005'),
('R003', 'Evening', 31000, 'E006');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `doctor`
--
ALTER TABLE `doctor`
  ADD PRIMARY KEY (`DoctorID`),
  ADD KEY `FK_Doctor_Employee` (`EmployeeID`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`EmployeeID`);

--
-- Indexes for table `manager`
--
ALTER TABLE `manager`
  ADD PRIMARY KEY (`ManagerID`);

--
-- Indexes for table `medicine`
--
ALTER TABLE `medicine`
  ADD PRIMARY KEY (`Medicine_ID`);

--
-- Indexes for table `medicinesale`
--
ALTER TABLE `medicinesale`
  ADD PRIMARY KEY (`SaleID`);

--
-- Indexes for table `patient`
--
ALTER TABLE `patient`
  ADD PRIMARY KEY (`PatientID`);

--
-- Indexes for table `pharmacist`
--
ALTER TABLE `pharmacist`
  ADD PRIMARY KEY (`Ph_id`);

--
-- Indexes for table `prescription`
--
ALTER TABLE `prescription`
  ADD PRIMARY KEY (`PrescriptionID`);

--
-- Indexes for table `queue`
--
ALTER TABLE `queue`
  ADD PRIMARY KEY (`QueueID`);

--
-- Indexes for table `receptionist`
--
ALTER TABLE `receptionist`
  ADD PRIMARY KEY (`ReceptionistID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `medicinesale`
--
ALTER TABLE `medicinesale`
  MODIFY `SaleID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `doctor`
--
ALTER TABLE `doctor`
  ADD CONSTRAINT `FK_Doctor_Employee` FOREIGN KEY (`EmployeeID`) REFERENCES `employee` (`EmployeeID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
