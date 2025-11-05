--CREATE DATABASE OmanClinic;
--USE OmanClinic;

--CREATE TABLE Doctors(
--Doctors_ID bigint primary key identity(1,1),
--First_Name nvarchar(90) not null,
--Last_Name nvarchar(90) not null,
--Specialty nvarchar(60) not null
--);

--SET IDENTITY_INSERT Doctors ON;  

--INSERT into Doctors (Doctors_ID, First_Name, Last_Name, Specialty)
--values(1, 'Amal', 'Al salimai', 'Pediatrics')

--INSERT into Doctors (Doctors_ID, First_Name, Last_Name, Specialty)
--values(2, 'faiza', 'Al Hanthali', 'Cardiology')

--INSERT into Doctors (Doctors_ID, First_Name, Last_Name, Specialty)
--values(3, 'Asma', 'Al alawi', 'Dermatology')

--SET IDENTITY_INSERT Doctors OFF;  


SET IDENTITY_INSERT Patients ON;

INSERT into Patients (Patient_ID, First_Name, Last_Name, Age, Gender, Phone, Email)
values(1, 'Ali', 'Al salimai', '25', 'male', '95632124', 'ali@gmail.com')

INSERT into Patients (Patient_ID, First_Name, Last_Name, Age, Gender, Phone, Email)
values(2, 'Aseal', 'Al maqbali', '20', 'female', '95782124', 'aseal25@gmail.com')

INSERT into Patients (Patient_ID, First_Name, Last_Name, Age, Gender, Phone, Email)
values(3, 'Ahmed', 'Al alawi', '35', 'male', '95294324', 'a25hm@gmail.com')

SET IDENTITY_INSERT Patients OFF;  

CREATE TABLE Patients(
Patient_ID bigint primary key identity(1,1),
First_Name nvarchar(90) not null,
Last_Name nvarchar(90) not null,
Age nvarchar(60),
Gender nvarchar(90),
Phone nvarchar(60),
Email nvarchar(90),
Doctor_ID bigint foreign key references Doctors(Doctors_ID)
);


CREATE TABLE Appointments(
Appointments_ID bigint primary key identity(1,1),
App_Date Date,
App_Time time,
Patient_ID bigint foreign key references Patients(Patient_ID),
Doctor_ID bigint foreign key references Doctors(Doctors_ID)
);

--SET IDENTITY_INSERT Appointments ON;

--INSERT into Appointments (Appointments_ID, App_Date, App_Time)
--values(1, '2015-5-6', '20:55')

--INSERT into Appointments (Appointments_ID, App_Date, App_Time)
--values(2, '2015-9-8', '20:55')

--INSERT into Appointments (Appointments_ID, App_Date, App_Time)
--values(3, '2025-10-8', '9:55')

--SET IDENTITY_INSERT Appointments OFF;  
