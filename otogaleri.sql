create database otoGaleri ;
USE otoGaleri
GO
CREATE TABLE kullanici(
kullaniciAdi varchar(25) Primary Key,
adiSoyadi varchar(30),
eposta varchar(50),
sifre varchar(12)

)

CREATE  TABLE araba (
id tinyint identity(1,1), 
plaka  varchar(14) Primary Key ,
marka varchar(20),
model varchar(25),
yil varchar (10),
yakit varchar(25),
km int ,
vitestip varchar (35),
renk varchar(15),
motorhacmi varchar(15),
motorgucu varchar(15),
hasarKaydi varchar(10),
kiralamaFiyat int,
fiyat int,
aciklama varchar(100),
durum varchar(10))

CREATE TABLE musteri (
tc varchar(11) Primary Key,
adsoyad VARCHAR(30),
cinsiyet VARCHAR(5),
dtarihi VARCHAR(15),
dyeri VARCHAR(15),
ehliyetBelgeNo varchar(10),
telefon VARCHAR(15),
ctelefon varchar(11),
adres VARCHAR(200),
email varchar(25))



CREATE TABLE KiralamaRaporu(
id tinyint identity(1,1), 
plaka varchar(14) ,
tc varchar(11) ,
kiralamaTarih datetime,
teslimTarih datetime,
kiralamaFiyat int,
kalanGun int)

CREATE TABLE SatisRaporu(
plaka varchar(14) ,
tc varchar(11) ,
satisTarih datetime,
odemetip varchar(10),
taksitSayisi tinyint,
satisFiyat int)



create table Rapor(
id tinyint identity(1,1), 
plaka varchar(14),
tc varchar(11),
tarih datetime,
fiyat int ,
kazanctipi varchar(12))

--Araç kiralandýðýnda Rapor tablosuna kiralama bilgilerinin girilmesi için yazýlan Trigger
go
create trigger kiralaninca on KiralamaRaporu
for insert
as
begin
declare @plaka varchar(14),@tc varchar(11), @tarih Datetime ,@fiyat int 
select @plaka=plaka ,@tc =tc,@tarih=kiralamaTarih,@fiyat=kiralamaFiyat from inserted
insert into Rapor values(@plaka,@tc,@tarih,@fiyat,'Kiral ile')
end
--Araç satýldýðýnda Rapor tablosuna satýþ bilgilerinin girilmesi için yazýlan Trigger
go
create trigger satilinca on SatisRaporu
for insert
as
begin
declare @plaka varchar(14),@tc varchar(11),@tarih Datetime ,@fiyat int
select @plaka=plaka,@tc=tc,@tarih=satisTarih,@fiyat=satisFiyat from inserted
insert into Rapor values(@plaka,@tc,@tarih,@fiyat,'Satýþ ile')
end
--Aracýn kiralama bilgileri güncellendiðinde Rapor tablosunda olusacak deðiþiklikler için yazýlan Trigger
go
CREATE TRIGGER GuncellemeOlunca on KiralamaRaporu
after update
as
begin
declare @YeniFiyat int , @YeniTarih datetime, @plaka varchar(14),@tc varchar(11)
select @YeniFiyat=kiralamaFiyat , @YeniTarih=kiralamaTarih,@plaka=plaka, @tc=tc from inserted
if update(kiralamaFiyat)
begin
update Rapor 
set tarih=@YeniTarih ,fiyat=@YeniFiyat
where plaka=@plaka and tc=@tc
end
end


select distinct * from SatisRaporu
select * from musteri
select * from araba
select * from kullanici
select * from Rapor
select * from KiralamaRaporu







