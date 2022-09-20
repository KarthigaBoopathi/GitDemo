create database Shopping

create table Customer
(
custid int primary key,
custname varchar(20),
city varchar(20),
state varchar(20)
)

create table Products
(
prodid int primary key,
prodname varchar(20),
unitprice int,
unitofMeasurement varchar(20),
QtyinStock int
)

create table sales_header
(
invno int primary key,
invdate int,
invamt float,
disPercent int
)

create table sales_detail
(
invno int,
custid int,
prodid int,
qtysold int
)


--drop table dbo.Customer
--drop table dbo.Products
--drop table dbo.sales_detail
--drop table dbo.sales_header

create table sales
(invoice int primary key)


alter table sales_detail
add foreign key(invno) references sales(invoice)

alter table sales_detail
add foreign key(custid) references sales(invoice)
add foreign key(prodid) references sales(invoice)

alter table sales_detail
drop column qtysold

alter table sales_detail
add Qty int

alter table sales_detail
rename column Qty to Quantity