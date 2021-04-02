--Database Creation
create database CarProjectDB;

--Car Table
create table Cars(
    Id int PRIMARY KEY not null,
    BrandId int,
    ColorId int,
    ModelYear varchar(4),
    DailyPrice int,
    Description varchar(100)
);

--Brand Table
create table Brands(
       Id int PRIMARY KEY not null,
       Name varchar(100)
);

--Color table
create table Colors(
       Id int PRIMARY KEY not null,
       Name varchar(100)
);