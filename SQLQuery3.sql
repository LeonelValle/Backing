
go
create table tb_User(id_user int primary key identity(1,1), name varchar(100), id int)


create table tb_Part(id_part int primary key identity(1,1), partno varchar(255), descr varchar(255), rev varchar(50), thickness varchar(100), msl varchar(100), level varchar(10))


create table tb_LotNo(id_lotno int primary key identity(1,1), lotno varchar(100) not null unique, startDate datetime, Due datetime, Paused time, employStart int, id_part int,  Bake varchar(50), hours int 
foreign key(employStart) references tb_User (id_user),
foreign key(id_part) references tb_Part (id_part))


create table tb_BackingTime(id_bt int primary key identity(1,1), thickLow float(2), thickHigh float(2), level varchar(10), bakeTime int)


create table tb_LogChangeBake(id_logcb int primary key identity(1,1), Quality int, Eng int,id_lotno int, DateChange datetime,
foreign key(Quality) references tb_User (id_user),
foreign key(Eng) references tb_User (id_user),
foreign key(id_lotno) references tb_LotNo (id_lotno))


select id_part, partno from tb_Part

select * from tb_BackingTime

select bakeTime from tb_BackingTime where thickLow <= '1.5' and thickHigh >= '1.5' and level = '3'