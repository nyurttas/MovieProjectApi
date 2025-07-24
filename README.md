# Film Veritabanı .NET Core Web API

Bu proje, bir film veritabanı üzerinde CRUD (Create, Read, Update, Delete) işlemlerini gerçekleştirebilen .NET Core tabanlı bir Web API'dir. Katmanlı mimari prensiplerine uygun olarak geliştirilmiş ve Entity Framework Core kullanılarak veri erişimi sağlanmıştır. Swagger ile otomatik API dokümantasyonu sunulmaktadır.

## Özellikler

- **Katmanlı Mimari**: Proje, Presentation (API), Business, DataAccess ve Entities katmanlarından oluşmaktadır.
- **Entity Framework Core**: Veritabanı işlemleri için EF Core kullanılmıştır.
- **CRUD İşlemleri**: Filmler üzerinde ekleme, listeleme, güncelleme ve silme işlemleri yapılabilir.
- **Swagger Desteği**: API uç noktaları Swagger arayüzü ile test edilebilir ve belgelenmiştir.

## Katmanlar

- **Entities**: Temel veri modellerinin tanımlandığı katman.
- **DataAccess**: EF Core ile veritabanı işlemlerinin gerçekleştirildiği katman.
- **Business**: İş kurallarının ve servislerinin bulunduğu katman.
- **Web (API)**: HTTP isteklerinin karşılandığı, dış dünya ile iletişimi sağlayan katman.

