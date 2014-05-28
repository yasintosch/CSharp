CREATE TABLE URUNLER
(
urun_id int identity(1,1)not null,
urun_kodu int not null UNIQUE,
urun_ad nvarchar(100) not null,
urun_marka nvarchar(100) not null,
urun_kategori nvarchar(100) not null,
urun_aciklama nvarchar(100),
adet int not null,
alindigi_tarih datetime not null,
alindigi_firma nvarchar(100),
alindigi_firma_adres nvarchar(100),
alindigi_firma_tel nvarchar(30),
fiyat int,
primary key(urun_id),


)





CREATE TABLE STOK
(
stok_id int identity(1,1)not null primary key,
urun_id int,
adet int,
foreign key(urun_id)references URUNLER(urun_id),

)

CREATE TABLE IHALELER
(
ihale_id int identity(1,1),
ihale_ad nvarchar(100) not null,
tarih datetime not null,
primary key(ihale_id),
)

CREATE TABLE TEKLIFLER
(
teklif_id int identity(1,1) primary key,
teklif_ad nvarchar(100) not null,
teklif_tarih datetime not null,
ihale_id int,
gonderen_ad nvarchar(100) not null,
gonderen_tel nvarchar(100),
gonderen_email nvarchar(100),
gonderilen_ad nvarchar(100) not null,
gonderilen_firma nvarchar(100) not null,
foreign key(ihale_id)references IHALELER(ihale_id),



)


CREATE TABLE SATILAN_URUNLER
(
sat_urun_id int identity(1,1),
urun_id int not null,
teklif_id int not null,
adet int not null,
teklif_onay int default(0),
primary key(sat_urun_id),
foreign key(urun_id)references URUNLER(urun_id),
foreign key(teklif_id)references TEKLIFLER(teklif_id),

)
