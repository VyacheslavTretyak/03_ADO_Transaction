create database RefregeratorShop on primary
(name = RefregeratorShop,
filename = 'C:\Program Files\Microsoft SQL Server\MSSQL14.STEP_SQL_SERVER\MSSQL\DATA\RefregeratorShop.mdf',
size = 2MB,
maxsize = 6MB,
filegrowth = 1MB)
LOG ON
(name = RefregeratorShopB_log,
filename = 'C:\Program Files\Microsoft SQL Server\MSSQL14.STEP_SQL_SERVER\MSSQL\DATA\RefregeratorShop_log.ldf',
size = 2MB,
maxsize = 6MB,
filegrowth = 1MB)
collate Ukrainian_CI_AS;
go
use RefregeratorShop;
create table Customers
(id_customer int primary key identity(1, 1),
[name] nvarchar(30) not null,
[buyAmount] int null);

create table Salers
(id_saler int primary key identity(1, 1),
[name] nvarchar(30) not null,
[saleAmount] int null);

create table Items
(id_items int primary key identity(1, 1),
[name] nvarchar(30) not null,
[price] int null,
[description] nvarchar(100) null,
[count] int not null);

create table Deals
(id_deal int primary key identity(1, 1),
[date] date not null,
[saler_id] int not null,
[customer_id] int not null,
[item_id] int not null,
[count] int not null);
go  

use RefregeratorShop;
insert into Customers values
 ('Kostya', 1),
 ('Valera', 0);
 insert into Salers values
 ('Chack Noris', 9999),
 ('jackie chan', 1);
 insert into Items values
 ('Rostov', 9999.99, 'the best refregerator', 99),
 ('Nord', 19999.99, 'very cold', 9);
 insert into Deals values
 ('2018-07-04', 0, 1, 0, 9),
 ('2018-07-05', 1, 0, 1, 1);


use RefregeratorShop;
go 
create view DealsView as
select d.id_deal as 'id', s.[name] as 'saler', c.[name] as 'customer', i.[name] as Item, d.[count]
from deals as d
join salers as s on s.id_saler = d.saler_id
join Customers as c on c.id_customer = d.customer_id
join Items as i on i.id_items = d.item_id;


 
