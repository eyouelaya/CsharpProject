# CsharpProject
#The following database must be created in Microsoft sql server for the database and the database added to data connections in the server explorer
create database Avita;
use Avita;

create table Users(
	num  int Identity(1,1) Primary key,
	UserID varchar(20),
	First_Name varchar(30),
	Last_Name varchar(30),
	User_Type varchar(15),
	Password varchar(32)
	)   
insert into users(UserID,First_Name,Last_Name,User_Type,Password)
	values('admin','admin','admin','admin','admin')

CREATE TABLE MedicineTable ( 
	MedicineID varchar(20) ,
	Medicine_Name varchar(40) , 
	Category varchar(40) ,
	Quantity INT  ,
	Manufacturer VARCHAR(30) ,
	Entry_Date DATE , 
	Production_Date DATE ,
	Expiring_Date DATE , 
	Selling_Price float ,
	Buying_Price float , 
	PRIMARY KEY (MedicineID)
	);  
create table SalesReport(
	ID int identity(1,1) primary key,
	Buyer varchar(70),
	Seller varchar(20),
	Medicine_Name varchar(40) , 
	Category varchar(40) , 
	Manufacturer VARCHAR(30) ,
	Production_Date DATE ,
	Expiring_Date DATE , 
	Quantity INT  ,
	Selling_Price float ,
	Buying_Price float ,	
	Profit_Gained float,
	Date_Of_Sale DATE
	);
