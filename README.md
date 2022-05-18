# Otomasyon_Sinav
## Projemiz Hakkında
- Projemiz genel haliyle bir online sınav otomasyonu olarak tasarlanmıştır.
- 3 farklı *kullanıcı tipi* mevcuttur. Admin, Sınav Sorumlusu ve Öğrenci. 
- Sisteme **Sınav Sorumlusu** olarak giriş yapan bir kullanıcı, öğrenciler için sorular ekler. Burada eklediği sorunun doğru cevabını da belirtir ve soruyu kaydeder.
- **Admin** kullanıcısının görevi de sınav sorumlusu tarafında hazırlanıp kaydedilen soruları, soru havuzuna gitmesi için onaylamaktır.
- **Öğrenci** ise sınav ekranına giriş yaptığında formda bulunan *Sınava Başla* butonu ile sınavını başlatır, belirtilen süre içerinde de bitirmesi gerekmektedir.

## Nasıl Çalışır
- Giriş ekranında *Kullanıcı Tipi* seçtikten sonra *Giriş Yap* bölümünden sisteme giriş yapabilir, eğer kaydınız yoksa da *Kayıt Ol* butonu ile kaydınızı gerçekleştirebilirsiniz. Bu kayıtların hepsi veritabanına kaydedililr.
- Şifrenizi unutmanız durumunda *şifremi unuttum* ile mail adresinize gelecek kod ile şifrenizi yenileyebilirsiniz, yenilenen şifreniz ile tekrar giriş yapabilirsiniz.
- **Sınav Sorumlusu** ekranındaki PictureBox'a seçtiği sorunun foroğrafını koyar ve *Resmi Kaydet* ile bunu veritabanına kaydeder. Altta bulunan TextBox'lara da şıkları yazar, sorunun doğru cevabını RadioButton ile işaretler ve *Soruyu Ekle* butonu ile soruları Admin onayına gönderir.
- **Admin** *Kayıyları Görüntüle* butonu ile şu an hazır olarak bulunan 100 soru ve ilave edilecek yeni soruları ekranda görüntüler. Hatasız gördüğü soruları işaretler ve *Onayla* butonu ile bu soruları veritabanındaki soru havuzuna gönderir.
- **Öğrenci** kullanıcıları, *Sınava Başla* butonuna bastıkları anda süreleri başlar ve çözmeleri gereken 10 soru veritabanından rastgele olarak önlerine düşer. sınavı bitirdiklerinde *Sınavı Bitir* butonu ile giriş sayfasına yönlendirilirler. Eğer verilen sürede sorular bitmemiş ise hata mesajı ile yine giriş sayfasına yönlendirilirler.
-  
