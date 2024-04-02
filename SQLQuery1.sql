create database PetShop;
go

use PetShop;
go

create table Categories(
	CategoryID int primary key identity(1,1),
	CategoryName varchar(50) not null
);
go

create table Products(
	ProductID int primary key identity(1,1),
	ProductName varchar(50) not null,
	CategoryID int,
	Price decimal(10,2),
	Constraint FK_Category_Product foreign key (CategoryID) references Categories(CategoryID) 
);
go

create table Warehouse(
	WarehouseID int primary key identity(1,1),
	ProductID int,
	Quantity int,
	Constraint FK_Product_Warehouse foreign key (ProductID) references Products(ProductID) 
);
go

insert into Categories(CategoryName)
values
	('�����'),
	('��������'),
	('�������'),
	('���������� � ��������������');
go

insert into Products(ProductName, CategoryID, Price)
values
	('����� ���� ��� �����', 1, 200.00),
	('����� ���� ��� �����', 1, 299.00),
	('�������', 2, 499.99),�
	('����� �� �������� �����', 3, 580.00),
	('�����', 3, 350.00),
	('�����-���������', 4, 2499.00),
	('����������', 4, 699.00),
	('�������', 4, 685.99);
go

insert into Warehouse(ProductID, Qua ntity)
values
	(1, 50),
	(2, 20),
	(3, 30),
	(4, 60),
	(5, 10),
	(6, 70),
	(7, 5),
	(8, 15);
go




