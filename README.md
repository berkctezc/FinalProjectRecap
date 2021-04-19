# Yazılımcı Geliştirici Yetiştirme Kampı Ödev Projesi

------

[TOC]

## Gün 7 

### Ödev 2 ✔

```csharp
/* 
Kampımızla beraber paralelde geliştireceğimiz bir projemiz daha olacak. Araba kiralama sistemi yazıyoruz.

Yepyeni bir proje oluşturunuz. Adı ReCapProject olacak. (Tekrar ve geliştirme projesi)

Entities, DataAccess, Business ve Console katmanlarını oluşturunuz.

Bir araba nesnesi oluşturunuz. "Car"

Özellik olarak : Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanlarını ekleyiniz. (Brand = Marka)

InMemory formatta GetById, GetAll, Add, Update, Delete oprasyonlarını yazınız.

Consolda test ediniz.

Önemli: Copy-Paste yasak fakat kamp projesinden destek almak serbest.

Kodlarınızı Github'a aktarıp paylaşınız. İncelediğiniz arkadaşlarınıza yıldız vermeyi unutmayınız. 
*/
```

[Commit](https://github.com/berkctezc/FinalProjectRecap/commit/ad7f2f932fdf77db02d4dcb750f9bb2c663b8d5a)

## Gün 8 

### Ödev 1 ✔

```c#
/*
Araba Kiralama projemiz üzerinde çalışmaya devam edeceğiz.

Car nesnesine ek olarak;

1) Brand ve Color nesneleri ekleyiniz(Entity)

Brand-->Id,Name

Color-->Id,Name

2) Sql Server tarafında yeni bir veritabanı kurunuz. Cars,Brands,Colors tablolarını oluşturunuz. (Araştırma)

3) Sisteme Generic IEntityRepository altyapısı yazınız.

4) Car, Brand ve Color nesneleri için Entity Framework altyapısını yazınız.

5) GetCarsByBrandId , GetCarsByColorId servislerini yazınız.

6) Sisteme yeni araba eklendiğinde aşağıdaki kuralları çalıştırınız.

Araba ismi minimum 2 karakter olmalıdır

Araba günlük fiyatı 0'dan büyük olmalıdır.

Ödevinize ait github linkini paylaşınız.
*/
```

[Commit](https://github.com/berkctezc/FinalProjectRecap/commit/a0a15887ec6b98d8e7bb7cbeeb2bdd4cab223a49)

## Gün 9 

### Ödev 1 ✔

```c#
/*
Not : İsteyenler Northwind projesindeki Core katmanını da ekleyebilir ama pekiştirmek için yeniden yazmanızı öneririm. Bu şekilde yapmak isteyenler CarRental/Solution Explorer Sağ Tık / Add /Existing Project/ Northwind içindeki Core klasöründe Core.csproj dosyasını ekleyebilirler. Bu şekilde yapanlar aşağıdaki 3. adımdan devam edebilirler.

Önerim aşağıdaki gibi yeniden yapmanızdır.

CarRental Projenizde Core katmanı oluşturunuz.
IEntity, IDto, IEntityRepository, EfEntityRepositoryBase dosyalarınızı 9. gün dersindeki gibi oluşturup ekleyiniz.
Car, Brand, Color sınıflarınız için tüm CRUD operasyonlarını hazır hale getiriniz.
Console'da Tüm CRUD operasyonlarınızı Car, Brand, Model nesneleriniz için test ediniz. GetAll, GetById, Insert, Update, Delete.
Arabaları şu bilgiler olacak şekilde listeleyiniz. CarName, BrandName, ColorName, DailyPrice. (İpucu : IDto oluşturup 3 tabloya join yazınız)
Kodlarınızı Github hesabınızda paylaşıp link veriniz.
Başkalarının kodlarını inceleyiniz. Beğenirseniz yıldız veriniz.
*/
```

[Commit](https://github.com/berkctezc/FinalProjectRecap/commit/185c97f49f08cefa242e6efacf33dfef497dce74)

## Gün 10 

### Ödev 1 ✔

```c#
/*
Car Rental Projenizde;

Core katmanında Results yapılandırması yapınız.
Daha önce geliştirdiğiniz tüm Business sınıflarını bu yapıya göre refactor (kodu iyileştirme) ediniz.
*/
```

[Commit](https://github.com/berkctezc/FinalProjectRecap/commit/a07c70c9f9de71cc31d1ad3b7851f67236aac528)

### Ödev 4 ✔

```csharp
/*
CarRental projenizde;

- Kullanıcılar tablosu oluşturunuz. Users-->Id,FirstName,LastName,Email,Password
- Müşteriler tablosu oluşturunuz. Customers-->UserId,CompanyName
- *****Kullanıcılar ve müşteriler ilişkilidir.
- Arabanın kiralanma bilgisini tutan tablo oluşturunuz. Rentals-->Id, CarId, CustomerId, RentDate(Kiralama Tarihi), ReturnDate(Teslim Tarihi). Araba teslim edilmemişse ReturnDate null'dır.
- Projenizde bu entity'leri oluşturunuz.
- CRUD operasyonlarını yazınız.
- Yeni müşteriler ekleyiniz.
- Arabayı kiralama imkanını kodlayınız. Rental-->Add
- Arabanın kiralanabilmesi için arabanın teslim edilmesi gerekmektedir.
*/
```

[Commit](https://github.com/berkctezc/FinalProjectRecap/commit/85df9ae03a636b6241b5b325804cf767581433db)

## Gün 11

### Ödev 1 ✔

```c#
/*
CarRental projenizde;

WebAPI katmanını kurunuz.
Business katmanındaki tüm servislerin Api karşılığını yazınız.
Postman'de test ediniz.
Kodlarınızı paylaşınız.
*/
```

[Commit](https://github.com/berkctezc/FinalProjectRecap/commit/153f788c92e4ca1d43bfa91e748447708697c1d3)

## Gün 12

### Ödev 1 ✔

```csharp
/*
Car Rental Projenize Autofac desteği ekleyiniz.

Yazdığınız kodların Github linkini paylaşınız.
*/
```

[Commit](https://github.com/berkctezc/FinalProjectRecap/commit/af249f2f639219a111d824f00cfff6b994530b59)

### Ödev 2 ✔

```csharp
/*
Car Rental Projenize FluentValidation desteği ekleyiniz.

Yazdığınız kodların Github linkini paylaşınız.
*/
```

[Commit](https://github.com/berkctezc/FinalProjectRecap/commit/a1bcd20b553bc8b8e0a245ddfbe00894c47bbd5c)

### Ödev 3 ✔

```csharp
/*
Car Rental Projenize AOP desteği ekleyiniz.

ValidationAspect ekleyiniz.

Yazdığınız kodların Github linkini paylaşınız.
*/
```

[Commit](https://github.com/berkctezc/FinalProjectRecap/commit/99612f39ad9c61962881be4f68019bc5541f73a1)

## Gün 13

### Ödev 1 ✔

```csharp
/*
Artık araştırma yapıp, yeni işlemleri projeye ekleyebilmemiz gerekiyor.

RentACar projenizde;

CarImages (Araba Resimleri) tablosu oluşturunuz. (Id,CarId,ImagePath,Date) Bir arabanın birden fazla resmi olabilir.
Api üzerinden arabaya resim ekleyecek sistemi yazınız.
Resimler projeniz içerisinde bir klasörde tutulacaktır. Resimler yüklendiği isimle değil, kendi vereceğiniz GUID ile dosyalanacaktır.
Resim silme, güncelleme yetenekleri ekleyiniz.
Bir arabanın en fazla 5 resmi olabilir.
Resmin eklendiği tarih sistem tarafından atanacaktır.
Bir arabaya ait resimleri listeleme imkanı oluşturunuz. (Liste)
Eğer bir arabaya ait resim yoksa, default bir resim gösteriniz. Bu resim şirket logonuz olabilir. (Tek elemanlı liste)
Github linkinizi paylaşınız.
*/
```

[Commit]()