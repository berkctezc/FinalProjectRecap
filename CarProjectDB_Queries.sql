--Database Creation
create database CarProjectDB;
use CarProjectDB;

--Car Table
create table Cars(
    Id int,
    BrandId int,
    ColorId int,
    ModelYear varchar(4),
    DailyPrice int,
    Description varchar(100)
);

--Brand Table
create table Brands(
       Id int,
       Name varchar(100)
);

--Color table
create table Colors(
       Id int,
       Name varchar(100)
);

--User Table
create table Users(
    Id int,
    FirstName varchar(20),
    LastName varchar(20),
    Email varchar(30),
    Password varchar(40)
);

--Customer Table
create table Customers(
    Id int,
    UserId int,
    CompanyName varchar(30)
);

--Rental Table
create table Rentals(
    Id int,
    CarId int,
    CustomerId int,
    RentDate date, 
    ReturnDate date
);

--Truncate Tables
use CarProjectDB;

truncate table brands;
truncate table colors;
truncate table cars;
truncate table users;
truncate table customers;