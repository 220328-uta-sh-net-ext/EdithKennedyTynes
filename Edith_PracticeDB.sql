

GO
-- #1 drop constraints
if exists(select * from INFORMATION_SCHEMA.TABLE_CONSTRAINTS where CONSTRAINT_NAME = 'fk_vehicles_customer_id')
alter table vehicles drop constraint fk_vehicles_customer_id
 --#2 drop table
--drop table/  // to insert or 
drop table if exists customers
drop table if exists vehicles

-- #3 create table 
go
create table customers (
    id int IDENTITY not null, --surrogate key also IDENTITY is for id to auto number in numerical order
    email varchar(100) not null,
    first_name varchar(50) not null,
    last_name varchar(50) not null,
    constraint pk_customers_id primary key (id),
    constraint u_constraint_email unique(email) 
)
insert into customers 
    (email, first_name, last_name) values 
    ('macar@dayrep.com', 'Mac', 'Arrone'),
    ('wshore@gmail.com', 'Wendy', 'Shores'),
    ('ekm@gmail.com', 'Eden', 'Kennedy'),
    ('ctyze@teleworm.us','Chaz','Tyze')


--or insert into customers write them individually over again
    --(email, first_name, last_name) values 
select * from customers

GO
create table vehicles (
    id int IDENTITY not null, --surrogate key
    vin VARCHAR(20) not null,
    make VARCHAR(20) not null,
    model VARCHAR (20) not null,
    mileage int not null,
    last_visit date not NULL,
    customer_id int null --foreign key for referring table customer..if you write a constraint to this column it must match a value in antoher table  
    constraint pk_vehicle_id primary key(id),
    constraint u_vehicles_vin unique (vin),
    constraint ck_vehicles_mileage_gt_or_eq_0 check ( mileage >=0 )
    /*constraints can be added to create table*/
)
insert into vehicles (vin, make, model, mileage, last_visit) values
('12346', 'Subaru', ' Outback', 123060, '2021-01-27'),
('12345', 'Chevy', ' Traverse', 20992 , '1/28/2021'),
('12348', 'Chevy', ' Tahoe', 35045, '1/30/2021' ),
('12347','Ford','F150',87600,'1/31/2021')

select * from vehicles

-- part 2 if you choose to use contraints at "create table <name>" you wont need to alter table with these constraints
/*alter table vehicles drop column customer_id --name of column 
alter table vehicles
    add customer_id int null  -- no need to specify column must name column

alter table vehicles
    add constraint u_vehicles_vin unique (vin)

alter table vehicles 
    add constraint ck_vehicles_mileage_gt_or_eq_0 check (mileage <= 0)

insert into vehicles (vin, make, model, mileage, last_visit)
VALUES
('1234A','Subaru', 'Forrester',-100,'2021-01-27')

alter table customers add u_constraint email unique(email)*/

--#4 add FK constraints
--foreign key contstrain
alter table vehicles add CONSTRAINT fk_vehicles_customer_id
    foreign key (customer_id) /*column*/ references customers(id) --refences id from customers table 


--part 3 update to edit data 
-- drop foreign key constraint before you drop the table in attempts to drop object refenced by a foreign key constraint
/* up/down Script Approach: 
1. Alter tables drop foreign keys 
2. Drop Tables
3 Create tables
4 Alter tables add Foreign keys*/

update vehicles set customer_id = 1 where vin ='12346'
update vehicles set customer_id = 2 where make='Chevy'
update vehicles set customer_id =3,  mileage = 88956 where vin = '12347'

 select * from vehicles

 delete from vehicles -- deletes the whole vehicle table must be specific to delete row


 
--delete from vehicles where vin = '12345'  

select * from INFORMATION_SCHEMA.TABLES-- Get a list of tables and views in the current database
SELECT table_catalog [database], table_schema [schema], table_name [name], table_type [type]
FROM INFORMATION_SCHEMA.TABLES
GO

select * from INFORMATION_SCHEMA.TABLES 
    where table_name = 'customers'

select * from INFORMATION_SCHEMA.TABLES 
    where table_name = 'oil_changes'

select * from INFORMATION_SCHEMA.COLUMNS
    where table_name ='vehicles'

select * from INFORMATION_SCHEMA.CHECK_CONSTRAINTS

select * from INFORMATION_SCHEMA.TABLE_CONSTRAINTS
