create database "190716043"
use "190716043"

create table salon(
salon_id int identity(1,1) primary key,
salon_adi nvarchar(250) null,
)
create table seans(
seans_id int identity(1,1) primary key,
seans_adi nvarchar(150) null,
seans_tarih nvarchar(150) null,
seans_saat nvarchar(150) null,
)
create table filmler(
film_id int identity(1,1) primary key,
seans_id int  references seans(seans_id) null,
salon_id int references salon(salon_id) null,
film_adi nvarchar(150) null,
film_turu nvarchar(150) null,
yonetmen nvarchar(50) null,
afis nvarchar(250) null,
)
create table satis(
satis_id int identity(1,1) primary key,
film_id int references filmler(film_id) null,
seans_id int null,
salon_id int null,
kisi_adi nvarchar(150) null,
kisi_soyadi nvarchar(150) null,
)

--salon tablosu insert

insert into salon(salon_adi)
values('Salon1')

insert into salon(salon_adi)
values('Salon2')

insert into salon(salon_adi)
values('Salon3')

insert into salon(salon_adi)
values('Salon4')

insert into salon(salon_adi)
values('Salon5')

--seans tablosu insert

insert into seans(seans_adi,seans_tarih,seans_saat)
values('Seans 1','10.05.2020','17:00')

insert into seans(seans_adi,seans_tarih,seans_saat)
values('Seans 2','11.07.2020','13:00')

insert into seans(seans_adi,seans_tarih,seans_saat)
values('Seans 3','9.09.2020','11:44')

insert into seans(seans_adi,seans_tarih,seans_saat)
values('Seans 4','17.06.2020','19:00')

insert into seans(seans_adi,seans_tarih,seans_saat)
values('Seans 5','27.06.2020','20:00')

--filmler tablosu insert

insert into filmler(seans_id,salon_id,film_adi,film_turu,yonetmen,afis)
values (3,2,'Joker','Dram','Todd Phillips','Joker.jpg')

insert into filmler(seans_id,salon_id,film_adi,film_turu,yonetmen,afis)
values (1,1,'Aquaman','Aksiyon','James Wan','aquaman.jpg')

insert into filmler(seans_id,salon_id,film_adi,film_turu,yonetmen,afis)
values (2,3,'Örümcek Adam Örümcek Evreninde','Animasyon','Peter Ramsey','Spiderman.jpg')

insert into filmler(seans_id,salon_id,film_adi,film_turu,yonetmen,afis)
values (1,1,'Wonder Women ','Aksiyon','Patty Jenkins','wonder.jpg')

insert into filmler(seans_id,salon_id,film_adi,film_turu,yonetmen,afis)
values (4,5,'12 Years a Slave ','Dram','Patty Jenkins','years.jpg')

--satis tablosu insert

insert into satis(film_id,seans_id,salon_id,kisi_adi,kisi_soyadi)
values(1,1,1,'Hasan','Ercan')


insert into satis(film_id,seans_id,salon_id,kisi_adi,kisi_soyadi)
values(2,3,2,'Mehmetcan','Akten')


insert into satis(film_id,seans_id,salon_id,kisi_adi,kisi_soyadi)
values(3,2,3,'Ali','Erbaþ')


insert into satis(film_id,seans_id,salon_id,kisi_adi,kisi_soyadi)
values(5,4,4,'Hüseyin','Taþ')


insert into satis(film_id,seans_id,salon_id,kisi_adi,kisi_soyadi)
values(4,5,5,'Ahmet','Ersoy')
