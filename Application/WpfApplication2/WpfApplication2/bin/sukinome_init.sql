create database sukinome_database;
use sukinome_database;

create table customer_table(
store_name char(40),
store_owner char(50) NOT NULL,
store_mobile varchar(10) NOT NULL,
store_address varchar(100) NOT NULL,
store_email varchar(30),
PRIMARY KEY(store_name));

create table warehouse_table(
product_name varchar(70),
product_quantity int NOT NULL,
product_pricepbox int,
product_manufacturer varchar(50) NOT NULL,
product_qtypbox int,	
PRIMARY KEY(product_name));

create table bill_table(
bill_id varchar(11),
bill_customer_name char(40),
bill_amt double,
bill_date varchar(30),
bill_status char(20) DEFAULT "Created",
bill_amtdue double,
bill_tax double,
FOREIGN KEY(bill_customer_name) REFERENCES customer_table(store_name),	
PRIMARY KEY(bill_id));

create table billxproduct_table(
bill_id varchar(11),
product_name varchar(70),	
product_qty int,
pricepproduct int,
amount double,
FOREIGN KEY(bill_id) REFERENCES bill_table(bill_id),
FOREIGN KEY(product_name) REFERENCES warehouse_table(product_name),	
PRIMARY KEY(bill_id,product_name));

create table info(
id varchar(30) PRIMARY KEY,
datavalue varchar(30)
);


create table log_table(
dateti varchar(30) primary key,
actions varchar(50),
what varchar(30)
);







