
CREATE PROCEDURE [dbo].[URUN_SILME]
@u_kodu int


AS
BEGIN
DELETE  FROM URUNLER
WHERE @u_kodu=urun_kodu


END