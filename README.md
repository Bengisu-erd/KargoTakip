Hızlı Kargo Takip Sistemi (Console Application)

Bu proje, C# ile konsol ortamında geliştirilmiş temel bir kargo kayıt, takip ve gün sonu raporlama uygulamasıdır. Kullanıcıdan alınan kargo girdilerini işleyerek teslimat sürelerini hesaplar, detaylı kargo dökümü sunar ve şube bazlı gün sonu istatistiklerini listeler.

Proje Hakkında

Hızlı Kargo Takip Sistemi, C# dilinin temel yapı taşlarını (diziler, veri türleri, tip dönüşümleri ve DateTime / TimeSpan işlemleri) pekiştirmek amacıyla tasarlanmış bir başlangıç/orta seviye konsol projesidir.

 Temel Özellikler

Kargo Verisi Girişi: Müşteri adı, takip kodu, varış şehri, ağırlık ve sigorta durumu gibi bilgilerin dinamik olarak alınması.

Tarih & Teslimat Hesaplama: DateTime ve TimeSpan kullanılarak gönderim tarihine bağlı tahmini teslimat tarihi ve taşıma süresi hesaplaması.

Biçimlendirilmiş Çıktı: Her kargo için ayrı ayrı düzenlenmiş şık bilgi kartları.

Gün Sonu Özeti:

Şube ve çalışan bilgisi gösterimi,

Toplam gönderi sayısı hesabı,

Toplam ve ortalama kargo ağırlığı istatistikleri.

 Kullanılan Teknolojiler

Dil: C# (.NET Core / .NET 6+)

Uygulama Tipi: Konsol Uygulaması (Console Application)

Kullanılan Yapılar:

string[], decimal[], bool[], DateTime[] dizileri

DateTime, TimeSpan tarih-saat işlemleri

Convert sınıfı ile tür dönüşümleri (ToDecimal, ToBoolean, ToDateTime)

Metin manipülasyonu (Trim(), ToUpper())

 Kurulum ve Çalıştırma

Projeyi yerel ortamınızda çalıştırmak için aşağıdaki adımları izleyebilirsiniz:

Depoyu klonlayın:

git clone https://github.com/KULLANICI_ADINIZ/KargoTakip.git


Proje dizinine gidin:

cd KargoTakip


Projeyi derleyin ve çalıştırın:

dotnet run


 Örnek Kullanım Akışı

Konsol ekranında sırasıyla 3 kargo için bilgiler girilir:

Müşteri Adı: Ahmet Yılmaz

Takip Kodu: TR123456

Teslimat Şehri: Ankara

Kargo Ağırlığı: 4.5

Sigortalı mı?: True

Gönderim Tarihi: 2026-10-15

Program otomatik olarak tahmini teslimat tarihini hesaplar (+3 gün).

3 kargonun kartları ve ardından şube bazlı gün sonu özeti ekrana yazdırılır.

 Gelecek Geliştirmeler (To-Do)

[ ] Tekrarlayan kod bloklarını for / foreach döngüleri ile dinamik hale getirmek.

[ ] Dizi (Array) yerine nesne yönelimli programlama (OOP) mantığıyla Kargo sınıfı (Class) ve List<Kargo> yapısına geçiş.

[ ] Hatalı kullanıcı girişleri için try-catch veya TryParse ile veri doğrulama eklemek.
