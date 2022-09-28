

--1
create database Shopping
go
use Shopping
--2,3
create table customer(
custid int,
custname varchar(20),
city varchar(20),
state varchar(20)
)
--4
create table products(
prodid int,
prodname varchar(20),
unitprice int,
UnitOfMeasurement varchar(20),
QtyinStock int
)
--5,6
create table sales_header(
invno int,
invdate date,
invamnt int,
disPercent int)
--7,8,9
create table sales_detail(
invno int,
custid int ,
prodid int ,
qtysold int
primary key(invno,custid,prodid))
--10
add foreign key(invno) references sales_header (invno);
--12
alter table sales_detail
drop column qtysold;
--14
alter table sales_detail
add Qty int;
--15
alter table sales_detail
rename column Qty to Quantity;



