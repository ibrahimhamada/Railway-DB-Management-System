-------------Database creation-------------

----< drop all tables >----
create database Railway_DB
Go

use Railway_DB;

------------Table Creation-----------------

create table Users
(
user_id int ,
user_name varchar(30) not null,
user_email varchar(50),
password varchar(60) not null,
user_age int,
user_sex varchar(1),   /*M -> Male, F -> Female*/  
user_phone int,
Priv int not null, /* priviledges */

primary key (user_id)
);


create table Passenger
(
pass_id int ,
pass_name varchar(30) not null,
pass_age int,      
pass_sex varchar(1),   /*M -> Male, F -> Female*/   
u_id int,


primary key (pass_id),
Foreign key (u_id) references Users
);


create table Employee
(
employee_id int not null,
employee_name varchar(30) not null,
emp_bdate date,
emp_role varchar(1) not null,     /*D -> Driver, O -> Officier*/   
emp_sex char(1),         /*M -> Male, F -> Female*/  
emp_salary int,
super_ssn int,

primary key (employee_id),
Foreign key (super_ssn) references Employee
);



create table Track
(
track_num int not null,
track_name varchar(80) not null,

primary key (track_num)
);


create table Station
(
station_num int not null,
station_name varchar(20) not null,

primary key (station_num)
);


create table Trip_Duration
(
duration_id int not null,
track_no int,
departue_time time,
arrival_time time,

primary key (duration_id),
Foreign key (track_no) references Track
);


create table Train
(
train_no int not null,
available_seats int not null,
model_year int,
dura_id int,
driver_no int,
stop_station_id int,
start_station_id int,
track_num int,

primary key (train_no),
Foreign key (dura_id) references Trip_Duration,
Foreign key (driver_no) references Employee,
Foreign key (stop_station_id) references Station,
Foreign key (start_station_id) references Station,
Foreign key (track_num) references Track
);


create table Ticket
(
ticket_no int not null,
price int,
ticket_type varchar(20),
resrve_date date,
trip_number int,
user_no int,
pass_no int,
from_station int,
to_station int,
track_n int,
employee_no int,

primary key (ticket_no),
Foreign key (user_no) references Users,
Foreign key (pass_no) references Passenger,
Foreign key (from_station) references Station,
Foreign key (to_station) references Station,
Foreign key (track_n) references Track,
Foreign key (employee_no) references Employee,
Foreign key (trip_number) references Trip_Duration
);



create table BELONGS
(
track_num int not null,
stat_num int,
station_order int,

Foreign key (stat_num) references Station,
primary key (track_num, stat_num)
);

/*
create table HAS
(
emp_id int not null,
ticket_id int,

primary key (emp_id),
Foreign key (ticket_id) references Ticket
);
*/

create table Statistic
(
stat_year int not null,
from_month int not null,
till_month int not null,
most_start_station varchar(30),
most_end_station varchar(30),
most_sex varchar(1),
most_month int, 
most_trip int,
e_id int,

primary key (stat_year, from_month, till_month),
Foreign key (e_id) references Employee,
Foreign key (most_trip) references Trip_Duration
);

create table Requests
(
request_id int not null,
request varchar(300),
e_id int,
superssn int, 
req_status varchar(30),

Foreign key (e_id) references Employee,
Foreign key (superssn) references Employee,
primary key (request_id)

);


/*
----------- inserting Employee Foreign key to Department --------------
alter table Employee add foreign key (DNO) references Department
*/



insert into Users values
(1, 'Ahmed Mohamed', 'ahmed@gmail.com', 'am1234', 17, 'M', 01152487215, 1),    /*Employees*/

(2, 'Mohamed Islam', 'misla2m@gmail.com', 'mi1234', 23, 'M', 01052487215, 2),  /*Users*/
(3, 'Ahmed Fathy', 'afathy45@gmail.com', 'af1234', 19, 'M', 01252487215, 2), 
(4, 'Ismael Mohamed', 'imohamed12@gmail.com', 'im1234', 20, 'M', 01178587215, 2), 
(5, 'Ibrahim Ahmed', 'imohamed1241@gmail.com', 'ia1234', 21, 'M', 01012487215, 2), 
(6, 'Nada Omar', 'nadaomar25@gmail.com', 'no1234', 17, 'F', 01024487215, 2), 
(7, 'Amr Ali', 'amrali12@gmail.com', 'aa1234', 27, 'M', 01152487245, 2), 
(8, 'Shady Abdelrahman', 'shady25@gmail.com', 'sa1234', 25, 'M', 01022484655, 2),
(9, 'Atef Mohamed', 'atef@gmail.com', 'at1234', 17, 'M', 01178487215, 3);    /*Admin*/



insert into Passenger values

(2, 'Mohamed Islam', 23, 'M', 2), 

(3, 'Samir Fathy', 35, 'M', null),
(4, 'Wafaa Ahmed', 39, 'F', 5),
(5, 'Ibrahim Ahmed', 21, 'M', 5),
(6, 'Shady Abdelrahman', 25, 'M', 8),
(7, 'Nada Omar', 17, 'F', 6),

(8, 'Alaa Mohamed', 16, 'F', null),
(9, 'Aya Khaled', 22, 'F', null),
(10, 'Sara Mostafa', 27, 'F', null);



insert into Employee values
(111111, 'Wael Mostafa', '1985-10-11', 'O', 'M', 4500, null),
(111112, 'Abeer Ahmed', '1989-08-02', 'O', 'F', 3500, null),
(111113, 'Ashraf Mohamed', '1986-10-04', 'O', 'M', 3500, null),
(111114, 'Mahmoud Mostafa', '1985-04-06', 'O', 'M', 3500, null),
(111115, 'Menna Ahmed', '1989-12-11', 'O', 'F', 3500, null),
(111116, 'Ibrahim Ahmed', '1985-10-11', 'O', 'M', 3500, null),
(111117, 'Ahmed Elsayed', '1990-01-01', 'O', 'M', 3600, null),



(222221, 'Mostafa Mohamed', '1985-02-11', 'O', 'M', 5000, null),
(222222, 'Ahmed Amr', '1989-12-11', 'D', 'M', 4000, null),
(222223, 'Omar Mohamed', '1989-12-11', 'D', 'M', 4000, null),
(222224, 'Zeyad Mahmoud', '1989-12-11', 'D', 'M', 4000, null),
(222225, 'Gamal Ahmed', '1989-02-16', 'D', 'M', 4000, null),
(222226, 'Islam Ahmed', '1989-05-12', 'D', 'M', 4000, null),
(222227, 'Elsayed Saad', '1989-02-17', 'D', 'M', 4000, null),
(222228, 'Zaki Ahmed', '1989-12-19', 'D', 'M', 4000, null),
(222229, 'Abdallah Ahmed', '1989-12-22', 'D', 'M', 4000, null),
(222230, 'Tarek Saad', '1989-12-23', 'D', 'M', 4000, null),


(222231, 'Mohamed Mostafa', '1989-05-11', 'O', 'M', 5000, null),
(222232, 'Amr Ahmed', '1990-10-16', 'D', 'M', 4000, null),
(222233, 'Mohamed Omar', '1992-12-11', 'D', 'M', 4000, null),
(222234, 'Mahmoud Zeyad', '1993-12-11', 'D', 'M', 4000, null),
(222235, 'Ahmed Gamal', '1989-12-11', 'D', 'M', 4000, null),
(222236, 'Ahmed Islam', '1987-12-11', 'D', 'M', 4000, null),
(222237, 'Saad Elsayed', '1989-12-11', 'D', 'M', 4000, null),
(222238, 'Ahmed Zaki', '1991-12-11', 'D', 'M', 4000, null),
(222239, 'Ahmed Abdallah', '1993-12-11', 'D', 'M', 4000, null),
(222240, 'Saad Tarek', '1989-12-11', 'D', 'M', 4000, null),


(222241, 'Ahmed Mostafa', '1989-12-11', 'O', 'M', 5000, null),
(222242, 'Amr Mohamed', '1989-12-11', 'D', 'M', 4000, null),
(222243, 'Mahmoud Omar', '1989-12-11', 'D', 'M', 4000, null),
(222244, 'Mahmoud Zakarya', '1989-12-11', 'D', 'M', 4000, null),
(222245, 'Yahya Gamal', '1989-12-11', 'D', 'M', 4000, null),
(222246, 'Omar Islam', '1989-12-11', 'D', 'M', 4000, null),
(222247, 'Amr Elsayed', '1989-12-11', 'D', 'M', 4000, null),
(222248, 'Sayed Zaki', '1989-12-11', 'D', 'M', 4000, null),
(222249, 'Saaed Abdallah', '1989-12-11', 'D', 'M', 4000, null),
(222250, 'Saad Mohamed', '1989-12-11', 'D', 'M', 4000, null),


(222251, 'Hani Mostafa', '1989-12-11', 'O', 'M', 5000, null),
(222252, 'Hazem Mohamed', '1989-12-11', 'D', 'M', 4000, null),
(222253, 'Hatem Omar', '1989-02-11', 'D', 'M', 4000, null),
(222254, 'Gaber Zakarya', '1989-03-11', 'D', 'M', 4000, null),
(222255, 'Gabr Gamal', '1989-12-11', 'D', 'M', 4000, null),
(222256, 'Omar Mohamed', '1989-12-11', 'D', 'M', 4000, null);


insert into Track values
(1, 'Cairo - Alexandria'),
(2, 'New Borg Al-Arab - Sedi Gaber'),
(3, 'Wasta - Elfayoum'),
(4, 'Cairo - Luxor - Aswan - El Sad Elali');


insert into Station values
(1, 'Cairo'),
(2, 'Shobra El Kheima'),
(3, 'Qalyub'),
(4, 'Qaha'),
(5, 'Toukh'),
(6, 'Qesna'),
(7, 'Berket El Sabaa'),
(8, 'Tanta'),
(9, 'Kafr El Zayat'),
(10, 'El Tawfikya'),
(11, 'Etay El Baroud'),
(12, 'Damanhour'),
(13, 'Abo Homous'),
(14, 'Kafr El Dawar'),
(15, 'Sedi Gaber'),
(16, 'Alexandria'),


(17, 'Sedi Gaber'),
(18, 'Moharm Bek'),
(19, 'Abbd El Kader'),
(20, 'King Maryout'),
(21, 'Maryout'),
(22, 'Borg Al Arab Airport'),
(23, '25th January'),
(24, 'New Borg Al Arab'),


(25, 'Wasta'),
(26, 'Karam Abo Rady'),
(27, 'Elwerash'),
(28, 'Elrous'),
(29, 'El Nasryia'),
(30, 'Seela'),
(31, 'El Adwa'),
(32, 'Ameryat Elfayoum'),
(33, 'Elfayoum'),

(34, 'Cairo'),
(35, 'Giza'),
(36, 'Hawmdyia'),
(37, 'Badrasheen'),
(38, 'Mazghota'),
(39, 'Ayaat'),
(40, 'Kafr Amar'),
(41, 'Naser'),
(42, 'Beni Suyef'),
(43, 'ElFashn'),
(44, 'Matay'),
(45, 'Samalout'),
(46, 'ElMenya'),
(47, 'AlRawda'),
(48, 'Malawy'),
(49, 'Dyrout'),
(50, 'Asyut'),
(51, 'Sohag'),
(52, 'Qena'),
(53, 'Luxor'),
(54, 'Aswan'),
(55, 'El Sad Elali');



insert into Trip_Duration values 
(1, 1, '12:30', '15:30'),
(2, 1, '14:30', '17:30'),
(3, 1, '16:30', '19:30'),
(4, 1, '18:30', '21:30'),
(5, 1, '20:30', '23:30'),

(6, 2, '12:30', '14:00'),
(7, 2, '14:30', '16:00'),
(8, 2, '16:30', '18:00'),
(9, 2, '18:30', '20:00'),
(10, 2, '20:30', '22:00'),

(11, 3, '12:30', '14:30'),
(12, 3, '14:30', '16:30'),
(13, 3, '16:30', '18:30'),
(14, 3, '18:30', '20:30'),
(15, 3, '20:30', '22:30'),

(16, 4, '12:30', '2:30'),
(17, 4, '16:30', '8:30'),
(18, 4, '6:30', '20:30');





insert into Train values 
(1111, 900, 1996, 1, 222221, 1, 16,1),
(1112, 900, 2000, 2, 222222, 1, 16,1),
(1113, 900, 2002, 3, 222223, 1, 16,1),
(1114, 900, 1996, 4, 222224, 1, 16,1),
(1115, 900, 2005, 5, 222225, 1, 16,1),
(1116, 900, 1996, 1, 222226, 16, 1,1),
(1117, 900, 2000, 2, 222227, 16, 1,1),
(1118, 900, 2002, 3, 222228, 16, 1,1),
(1119, 900, 1996, 4, 222229, 16, 1,1),
(1120, 900, 2005, 5, 222230, 16, 1,1),

(1121, 900, 1996, 6, 222231, 17, 24,2),
(1122, 900, 2000, 7, 222232, 17, 24,2),
(1123, 900, 2002, 8, 222233, 17, 24,2),
(1124, 900, 1996, 9, 222234, 17, 24,2),
(1125, 900, 2005, 10, 222235, 17, 24,2),
(1126, 900, 1996, 6, 222236, 24, 17,2),
(1127, 900, 2000, 7, 222237, 24, 17,2),
(1128, 900, 2002, 8, 222238, 24, 17,2),
(1129, 900, 1996, 9, 222239, 24, 17,2),
(1130, 900, 2005, 10, 222240, 24, 17,2),


(1131, 900, 1996, 11, 222241, 25, 33,3),
(1132, 900, 2000, 12, 222242, 25, 33,3),
(1133, 900, 2002, 13, 222243, 25, 33,3),
(1134, 900, 1996, 14, 222244, 25, 33,3),
(1135, 900, 2005, 15, 222245, 25, 33,3),
(1136, 900, 1996, 11, 222246, 33, 25,3),
(1137, 900, 2000, 12, 222247, 33, 25,3),
(1138, 900, 2002, 13, 222248, 33, 25,3),
(1139, 900, 1996, 14, 222249, 33, 25,3),
(1140, 900, 2005, 15, 222250, 33, 25,3),


(1141, 900, 1996, 16, 222251, 34, 55,4),
(1142, 900, 2005, 17, 222252, 34, 55,4),
(1143, 900, 1996, 18, 222253, 34, 55,4),
(1144, 900, 2000, 16, 222254, 55, 34,4),
(1145, 900, 2002, 17, 222255, 55, 34,4),
(1146, 900, 1996, 18, 222256, 55, 34,4);

/* u2 p2      u null p3  u5 p4         u5 p5     u8 p6         u6 p7     u null p8            unull p9  unull p10
 */ 
insert into Ticket values 
(1111111, 20, 'Normal', '2020-05-12', 1, 2, 2, 2, 8, 1, null),
(1111112, 60, 'VIP', '2020-05-12', 7, null, 3, 17, 24, 2, 111111),
(1111113, 20, 'Normal', '2020-05-12', 7, 5, 4, 19, 22, 2, null),
(1111114, 180, 'VIP', '2020-05-12', 17, 5, 5, 34, 52, 4, null),
(1111115, 40, 'Normal', '2020-05-12', 11, 8, 6, 25, 30, 3, null),
(1111116, 60, 'VIP', '2020-05-12', 7, 6, 7, 17, 20, 2, null),
(1111117, 180, 'VIP', '2020-05-12', 17, null, 8, 35, 50, 4, 111112),
(1111118, 150, 'VIP', '2020-05-12', 17, null, 9, 40, 50, 4, 111112),
(1111119, 60, 'Normal', '2020-05-12', 17, null, 10, 40, 50, 4, 111112);



insert into BELONGS values 

(1, 1, 1),
(1, 2, 2),
(1, 3, 3),
(1, 4, 4),
(1, 5, 5),
(1, 6, 6),
(1, 7, 7),
(1, 8, 8),
(1, 9, 9),
(1, 10, 10),
(1, 11, 11),
(1, 12, 12),
(1, 13, 13),
(1, 14, 14),
(1, 15, 15),
(1, 16, 17),


(2, 17, 1),
(2, 18, 2),
(2, 19, 3),
(2, 20, 4),
(2, 21, 5),
(2, 22, 6),
(2, 23, 7),
(2, 24, 8),

(3, 25, 1),
(3, 26, 2),
(3, 27, 3),
(3, 28, 4),
(3, 29, 5),
(3, 30, 6),
(3, 31, 7),
(3, 32, 8),
(3, 33, 8),


(4, 34, 1),
(4, 35, 2),
(4, 36, 3),
(4, 37, 4),
(4, 38, 5),
(4, 39, 6),
(4, 40, 7),
(4, 41, 8),
(4, 42, 9),
(4, 43, 10),
(4, 44, 11),
(4, 45, 12),
(4, 46, 13),
(4, 47, 14),
(4, 48, 15),
(4, 49, 17),
(4, 50, 18),
(4, 51, 19),
(4, 52, 20),
(4, 53, 21),
(4, 54, 22),
(4, 55, 23);




insert into Statistic values 
(2016, 1, 6, 'Cairo', 'Alexandria', 'M', 4, 2, 111111),
(2016, 6, 12, 'Cairo', 'Damanhour', 'F', 9, 3, 111111),
(2017, 1, 6, 'Giza', 'Luxor', 'M', 2, 17, 111112),
(2017, 6, 12, 'Cairo', 'Alexandria', 'M', 8, 1, 111112),
(2018, 1, 6, 'Sedi Gaber', 'New Borg Al Arab', 'M', 3, 8, 111113),
(2018, 6, 12, 'Cairo', 'Beni Suyef', 'F', 7, 18, 111114),
(2019, 1, 6, 'Cairo', 'Damanhour', 'M', 5, 5, 111115),
(2019, 6, 12, 'Cairo', 'Kafr El Zayat', 'F', 11, 2, 111116);




/* Here is the update of Super_SSN of table Employee */
update Employee set super_ssn = 111111	where employee_id = 111112
update Employee set super_ssn = 111111	where employee_id = 111113
update Employee set super_ssn = 111111	where employee_id = 111114
update Employee set super_ssn = 111111	where employee_id = 111115
update Employee set super_ssn = 111111	where employee_id = 111116
update Employee set super_ssn = 111111	where employee_id = 111117


update Employee set super_ssn = 222221	where employee_id = 222222
update Employee set super_ssn = 222221	where employee_id = 222223
update Employee set super_ssn = 222221	where employee_id = 222224
update Employee set super_ssn = 222221	where employee_id = 222225
update Employee set super_ssn = 222221	where employee_id = 222226
update Employee set super_ssn = 222221	where employee_id = 222227
update Employee set super_ssn = 222221	where employee_id = 222228
update Employee set super_ssn = 222221	where employee_id = 222229
update Employee set super_ssn = 222221	where employee_id = 222230

update Employee set super_ssn = 222231	where employee_id = 222232
update Employee set super_ssn = 222231	where employee_id = 222233
update Employee set super_ssn = 222231	where employee_id = 222234
update Employee set super_ssn = 222231	where employee_id = 222235
update Employee set super_ssn = 222231	where employee_id = 222236
update Employee set super_ssn = 222231	where employee_id = 222237
update Employee set super_ssn = 222231	where employee_id = 222238
update Employee set super_ssn = 222231	where employee_id = 222239
update Employee set super_ssn = 222231	where employee_id = 222240


update Employee set super_ssn = 222241	where employee_id = 222242
update Employee set super_ssn = 222241	where employee_id = 222243
update Employee set super_ssn = 222241	where employee_id = 222244
update Employee set super_ssn = 222241	where employee_id = 222245
update Employee set super_ssn = 222241	where employee_id = 222246
update Employee set super_ssn = 222241	where employee_id = 222247
update Employee set super_ssn = 222241	where employee_id = 222248
update Employee set super_ssn = 222241	where employee_id = 222249
update Employee set super_ssn = 222241	where employee_id = 222250


update Employee set super_ssn = 222251	where employee_id = 222252
update Employee set super_ssn = 222251	where employee_id = 222253
update Employee set super_ssn = 222251	where employee_id = 222254
update Employee set super_ssn = 222251	where employee_id = 222255
update Employee set super_ssn = 222251	where employee_id = 222256
