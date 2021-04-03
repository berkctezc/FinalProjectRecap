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

--Truncate Table Cars