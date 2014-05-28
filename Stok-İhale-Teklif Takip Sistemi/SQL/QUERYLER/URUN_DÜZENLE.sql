CREATE PROCEDURE URUN_DUZENLE
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
UPDATE URUNLER
SET urun_kodu=@u_kodu,
    urun_ad=@u_ad,
	urun_marka=@u_marka,
	urun_kategori=@u_kategori,
	urun_aciklama=@u_aciklama,
	adet=@u_adet,
	alindigi_tarih=@u_alindigi_tarih,
	alindigi_firma=@u_alindigi_firma,
	alindigi_firma_adres=@u_alindigi_firma_adres,
	alindigi_firma_tel=@u_alindigi_firma_tel
WHERE urun_kodu=@u_kodu
    



END
