--CREATE DATABASE OmanClinic;
--USE OmanClinic;

CREATE TABLE Doctors(
Doctors_ID bigint primary key identity(1,1),
First_Name nvarchar(90) not null,
Last_Name nvarchar(90) not null,
Specialty nvarchar(60) not null
);



--CREATE TABLE Patients(
--Patient_ID bigint primary key identity(1,1),
--First_Name nvarchar(90) not null,
--Last_Name nvarchar(90) not null,
--Age nvarchar(60),
--Gender nvarchar(90),
--Phone nvarchar(60),
--Email nvarchar(90),
--Doctor_ID bigint foreign key references Doctors(Doctors_ID)
--);

CREATE TABLE Appointments(
Appointments_ID bigint primary key identity(1,1),
App_Date Date,
App_Time time,
Patient_ID bigint foreign key references Patients(Patient_ID),
Doctor_ID bigint foreign key references Doctors(Doctors_ID)
);

