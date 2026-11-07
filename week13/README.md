# Week 13 - Docker PostgreSQL Ödevleri

## Projelerin Port Numaraları

| Ödev | Proje Adı | PostgreSQL Portu |

| Ödev 1 | Otel Rezervasyon Sistemi | 5433 |
| Ödev 2 | Kütüphane Yönetim Sistemi | 5434 |
| Ödev 3 | Restoran Menü Sistemi | 5435 |
| Ödev 4 | Film Arşiv Sistemi | 5436 |
| Ödev 5 | Spor Merkezi Dersleri | 5437 |

## Port Numaraları Neden Farklı?

Aynı bilgisayarda birden fazla PostgreSQL Docker konteynerinin aynı anda çalışabilmesi ve port çakışması yaşanmaması için her projenin farklı bir host port numarası kullanması gerekir.