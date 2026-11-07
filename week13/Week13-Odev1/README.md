
# Week13 - Ödev 1: Otel Rezervasyon Sistemi

## Kullanılan Teknolojiler
- ASP.NET Core MVC
- Entity Framework Core
- PostgreSQL
- Docker

## Migration İncelemesi

InitialCreate migration dosyasında RoomTypes ve Rooms tablolarının oluşturulması, aralarındaki foreign key ilişkisinin kurulması ve başlangıç verilerinin eklenmesi için gerekli işlemler tanımlanmıştır.

## Docker Veri Kalıcılığı

PostgreSQL verileri Docker volume üzerinde saklandığı için konteyner durdurulup yeniden başlatıldığında veritabanı ve başlangıç
verileri korunmuştur.
