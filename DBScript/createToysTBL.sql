create database wolverine;
go

use wolverine;
go
 
 create table Toys(
 id int NOT NULL,
 price decimal,
 aisle_id int NULL,
 name varchar(255),
 quantity_in_stock varchar(255),
 description varchar(255)
 Primary Key (id)
 );

 GO 




 create table Aisle(
 id int NOT NULL,
 name varchar(255)
 Primary Key (id)
 )

 go


insert into [dbo].[Aisle]
values(1,'One')

insert into [dbo].[Aisle]
values(2,'Two')

insert into [dbo].[Aisle]
values(3,'Three')

insert into [dbo].[Aisle]
values(4,'Four')

insert into [dbo].[Aisle]
values(5,'Five');

go



 alter table Toys
 Add constraint FK_ToyAisle
 Foreign Key(aisle_id) references Aisle(id);

 go



 insert into [dbo].[Toys]
Values(11, 9.99, 5, 'Gargoyles', 100, 'Action-Figure: 8 & up')


insert into [dbo].[Toys]
Values(12, 9.99, 4, 'DarkWing Duck', 100, 'Action-Figure: 5 & up')


insert into [dbo].[Toys]
Values(13, 29.99, 3, 'Scooter', 25, 'Riding Toy: 13 & under.')


insert into [dbo].[Toys]
Values(14, 7.99, 3, 'Legos', 200, 'LEGOS multi-pack: 8 & up')


insert into [dbo].[Toys]
Values(15, 13.99, 2, 'Teddy The Bear', 30, 'Teddy Bear for 8 & up')



insert into [dbo].[Toys]
Values(1, 3.99, 1, 'TeddyBear', 30, 'Teddy Bear : 5 & up')

insert into [dbo].[Toys]
Values(2, 13.99, 2, 'WowWee', 50, 'Small Toy : 7 & up')

insert into [dbo].[Toys]
Values(3, 3.99, 3, 'G.I. Joe', 300, 'Action-Figure : 8 & up')

insert into [dbo].[Toys]
Values(4, 3.99, 4, 'Gremlin', 100, 'Small Toy : 11 & up')

insert into [dbo].[Toys]
Values(5, 3.99, 5, 'Transformer', 60, 'Action-Figure : 6 & up')


insert into [dbo].[Toys]
Values(6, 3.99, 2, 'Rainbow Brite', 70, 'Plush toy : 6 & up')


insert into [dbo].[Toys]
Values(7, 3.99, 3, 'Han Solo', 100, 'Action-Figure : 8 & up')


insert into [dbo].[Toys]
Values(8, 3.99, 3, 'R2-D2', 100, 'Action-Figure: 8 & up')


insert into [dbo].[Toys]
Values(9, 3.99, 4, 'Elmo', 50, 'Plush Toy: 8 & up')


insert into [dbo].[Toys]
Values(10, 12.99, 5, 'Winni-Pooh', 30, 'Plush Toy: 5 & up');

go

Select name, description, aisle_id, quantity_in_stock
from [dbo].[Toys]
order by aisle_id;

Go

delete from Toys 
where name IN ('Han Solo', 'Elmo');

go

Select name, description, aisle_id, quantity_in_stock
from [dbo].[Toys]
order by aisle_id;


update Toys
set quantity_in_stock = 350
where name = 'G.I. Joe'

update Toys
set quantity_in_stock = 150
where name = 'Rainbow Brite'


Select name, description, aisle_id, quantity_in_stock
from [dbo].[Toys]
order by aisle_id;