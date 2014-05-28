
CREATE PROCEDURE [dbo].[URUN_EKLE]
@u_kodu int,
@u_ad nvarchar(100),
@u_marka nvarchar(100),
@u_kategori nvarchar(100),
@u_aciklama nvarchar(100),
@u_adet int,
@u_alindigi_tarih datetime,
@u_alindigi_firma nvarchar(100),
@u_alindigi_firma_adres nvarchar(100),
@u_alindigi_firma_tel nvarchar(100),
@u_fiyat int
AS
BEGIN
INSERT INTO URUNLER(urun_kodu,urun_ad,urun_marka,urun_kategori,urun_aciklama,adet,alindigi_tarih,alindigi_firma,alindigi_firma_adres,alindigi_firma_tel,fiyat)
VALUES(@u_kodu,@u_ad,@u_marka,@u_kategori,@u_aciklama,@u_adet,@u_alindigi_tarih,@u_alindigi_firma,@u_alindigi_firma_adres,@u_alindigi_firma_tel,@u_fiyat)
END