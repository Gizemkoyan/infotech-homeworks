CREATE DATABASE InfotechFieldServiceDb;
GO

USE InfotechFieldServiceDb;
GO

CREATE TABLE ServiceRegions
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Code NVARCHAR(10) NOT NULL UNIQUE,
    Name NVARCHAR(100) NOT NULL,
    City NVARCHAR(50) NOT NULL
);

    INSERT INTO ServiceRegions (Code, Name, City)
    VALUES (N'MRM', N'Marmara Servis Bölgesi', N'İstanbul');

    INSERT INTO ServiceRegions (Code, Name, City)
    VALUES (N'EGE', N'Ege Servis Bölgesi', N'İzmir');

    INSERT INTO ServiceRegions (Code, Name, City)
    VALUES (N'ICA', N'İç Anadolu Servis Bölgesi', N'Ankara');

    INSERT INTO ServiceRegions (Code, Name, City)
    VALUES (N'AKD', N'Akdeniz Servis Bölgesi', N'Antalya');

    SELECT * FROM ServiceRegions;

CREATE TABLE FaultCategories
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Code NVARCHAR(10) NOT NULL UNIQUE,
    Name NVARCHAR(100) NOT NULL
);

    INSERT INTO FaultCategories (Code, Name)
    VALUES (N'ELEC', N'Elektrik ve UPS');

    INSERT INTO FaultCategories (Code, Name)
    VALUES (N'MECH', N'Mekanik / Jeneratör');

    INSERT INTO FaultCategories (Code, Name)
    VALUES (N'AUTO', N'Otomasyon ve SCADA');

    INSERT INTO FaultCategories (Code, Name)
    VALUES (N'COOL', N'Soğutma ve HVAC');

    SELECT * FROM FaultCategories;

CREATE TABLE Technicians
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    RegionId INT NOT NULL,
    LeadTechnicianId INT NULL,
    FullName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(150) NOT NULL UNIQUE,
    HireDate DATE NOT NULL,
    SkillLevel INT NOT NULL,

    CONSTRAINT FK_Technicians_ServiceRegions
        FOREIGN KEY (RegionId)
        REFERENCES ServiceRegions(Id),

    CONSTRAINT FK_Technicians_LeadTechnician
        FOREIGN KEY (LeadTechnicianId)
        REFERENCES Technicians(Id),

    CONSTRAINT CK_Technicians_SkillLevel
        CHECK (SkillLevel BETWEEN 1 AND 5)
);

    INSERT INTO Technicians
    (RegionId, LeadTechnicianId, FullName, Email, HireDate, SkillLevel)
    VALUES
    (1, NULL, N'Serdar Koç', 'serdar.koc@infotechservice.local', '2018-03-01', 5);

    INSERT INTO Technicians
    (RegionId, LeadTechnicianId, FullName, Email, HireDate, SkillLevel)
    VALUES
    (1, 1, N'Burcu Yıldız', 'burcu.yildiz@infotechservice.local', '2020-06-15', 4);

    INSERT INTO Technicians
    (RegionId, LeadTechnicianId, FullName, Email, HireDate, SkillLevel)
    VALUES
    (1, 1, N'Emre Aktaş', 'emre.aktas@infotechservice.local', '2021-01-10', 3);

    INSERT INTO Technicians
    (RegionId, LeadTechnicianId, FullName, Email, HireDate, SkillLevel)
    VALUES
    (1, 2, N'Cem Özkan', 'cem.ozkan@infotechservice.local', '2022-09-01', 3);

    INSERT INTO Technicians
    (RegionId, LeadTechnicianId, FullName, Email, HireDate, SkillLevel)
    VALUES
    (1, 2, N'Deniz Arslan', 'deniz.arslan@infotechservice.local', '2023-04-20', 2);

    INSERT INTO Technicians
    (RegionId, LeadTechnicianId, FullName, Email, HireDate, SkillLevel)
    VALUES
    (2, NULL, N'Aylin Demir', 'aylin.demir@infotechservice.local', '2019-07-12', 5);

    INSERT INTO Technicians
    (RegionId, LeadTechnicianId, FullName, Email, HireDate, SkillLevel)
    VALUES
    (2, 6, N'Kerem Şahin', 'kerem.sahin@infotechservice.local', '2020-11-03', 4);

    INSERT INTO Technicians
    (RegionId, LeadTechnicianId, FullName, Email, HireDate, SkillLevel)
    VALUES
    (2, 6, N'Selin Kaya', 'selin.kaya@infotechservice.local', '2022-02-18', 3);

    INSERT INTO Technicians
    (RegionId, LeadTechnicianId, FullName, Email, HireDate, SkillLevel)
    VALUES
    (2, 7, N'Umut Polat', 'umut.polat@infotechservice.local', '2023-08-05', 2);

    INSERT INTO Technicians
    (RegionId, LeadTechnicianId, FullName, Email, HireDate, SkillLevel)
    VALUES
    (3, NULL, N'Hakan Güneş', 'hakan.gunes@infotechservice.local', '2017-05-20', 5);

    INSERT INTO Technicians
    (RegionId, LeadTechnicianId, FullName, Email, HireDate, SkillLevel)
    VALUES
    (3, 10, N'İpek Tunç', 'ipek.tunc@infotechservice.local', '2021-12-01', 4);

    INSERT INTO Technicians
    (RegionId, LeadTechnicianId, FullName, Email, HireDate, SkillLevel)
    VALUES
    (3, 10, N'Onur Kurt', 'onur.kurt@infotechservice.local', '2022-06-30', 3);

    INSERT INTO Technicians
    (RegionId, LeadTechnicianId, FullName, Email, HireDate, SkillLevel)
    VALUES
    (3, 11, N'Pelin Uçar', 'pelin.ucar@infotechservice.local', '2024-01-15', 2);

    INSERT INTO Technicians
    (RegionId, LeadTechnicianId, FullName, Email, HireDate, SkillLevel)
    VALUES
    (4, NULL, N'Tolga Erdem', 'tolga.erdem@infotechservice.local', '2019-09-10', 5);

    INSERT INTO Technicians
    (RegionId, LeadTechnicianId, FullName, Email, HireDate, SkillLevel)
    VALUES
    (4, 14, N'Ece Karaca', 'ece.karaca@infotechservice.local', '2021-03-22', 4);

    INSERT INTO Technicians
    (RegionId, LeadTechnicianId, FullName, Email, HireDate, SkillLevel)
    VALUES
    (4, 14, N'Kaan Yıldırım', 'kaan.yildirim@infotechservice.local', '2023-01-08', 3);

    INSERT INTO Technicians
    (RegionId, LeadTechnicianId, FullName, Email, HireDate, SkillLevel)
    VALUES
    (4, 15, N'Zeynep Çelik', 'zeynep.celik@infotechservice.local', '2024-05-01', 2);

    SELECT * FROM Technicians
    ORDER BY Id;

CREATE TABLE WorkOrders
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    TechnicianId INT NOT NULL,
    FaultCategoryId INT NOT NULL,
    SiteName NVARCHAR(150) NOT NULL,
    OpenedAt DATETIME2 NOT NULL,
    Status NVARCHAR(30) NOT NULL,
    Priority NVARCHAR(20) NOT NULL,
    EstimatedHours DECIMAL(5,2) NOT NULL,
    ActualHours DECIMAL(5,2) NULL,

    CONSTRAINT FK_WorkOrders_Technicians
        FOREIGN KEY (TechnicianId)
        REFERENCES Technicians(Id),

    CONSTRAINT FK_WorkOrders_FaultCategories
        FOREIGN KEY (FaultCategoryId)
        REFERENCES FaultCategories(Id),

    CONSTRAINT CK_WorkOrders_EstimatedHours
        CHECK (EstimatedHours > 0)
);

INSERT INTO WorkOrders
(TechnicianId, FaultCategoryId, SiteName, OpenedAt, Status, Priority, EstimatedHours, ActualHours)
VALUES
(2, 1, N'Kocaeli OSB — Fabrika A', '2025-01-05 08:30', N'Tamamlandı', N'Kritik', 6.00, 5.50),

(3, 2, N'Gebze Lojistik Merkezi', '2025-01-08 09:15', N'Tamamlandı', N'Yüksek', 4.00, 4.25),

(4, 3, N'Tuzla Kimya Tesisi', '2025-01-10 14:00', N'Devam Ediyor', N'Normal', 8.00, NULL),

(5, 4, N'Silivri Soğuk Depo', '2025-01-12 07:45', N'Açık', N'Yüksek', 5.00, NULL),

(2, 1, N'Pendik Veri Merkezi', '2025-01-15 11:20', N'Tamamlandı', N'Normal', 3.00, 2.75);

INSERT INTO WorkOrders
(TechnicianId, FaultCategoryId, SiteName, OpenedAt, Status, Priority, EstimatedHours, ActualHours)
VALUES
(7, 2, N'İzmir Aliağa Rafineri', '2025-01-18 08:00', N'Tamamlandı', N'Kritik', 10.00, 11.00),

(8, 1, N'Çiğli Üretim Hattı', '2025-01-20 10:30', N'Beklemede', N'Normal', 4.00, NULL),

(9, 3, N'Bornova Teknopark B Blok', '2025-01-22 13:45', N'Tamamlandı', N'Düşük', 2.00, 1.50),

(7, 4, N'Menemen Gıda Deposu', '2025-01-25 06:30', N'İptal', N'Normal', 6.00, 0.00),

(11, 1, N'Ankara Sincan OSB', '2025-02-01 09:00', N'Tamamlandı', N'Yüksek', 5.00, 4.80);

INSERT INTO WorkOrders
(TechnicianId, FaultCategoryId, SiteName, OpenedAt, Status, Priority, EstimatedHours, ActualHours)
VALUES
(12, 2, N'Etimesgut Jeneratör Odası', '2025-02-03 15:20', N'Devam Ediyor', N'Kritik', 7.00, NULL),

(13, 3, N'Polatlı Tarım Silosu', '2025-02-06 08:45', N'Tamamlandı', N'Normal', 3.50, 3.00),

(11, 4, N'Çankaya İş Merkezi HVAC', '2025-02-08 12:00', N'Açık', N'Düşük', 2.50, NULL),

(15, 1, N'Antalya Serbest Bölge', '2025-02-10 07:15', N'Tamamlandı', N'Normal', 4.00, 3.75),

(16, 2, N'Manavgat Otel Jeneratör', '2025-02-12 16:30', N'Tamamlandı', N'Yüksek', 6.00, 6.50);

INSERT INTO WorkOrders
(TechnicianId, FaultCategoryId, SiteName, OpenedAt, Status, Priority, EstimatedHours, ActualHours)
VALUES
(17, 3, N'Alanya Liman Otomasyon', '2025-02-15 09:40', N'Beklemede', N'Kritik', 9.00, NULL),

(15, 4, N'Kemer Soğutma Ünitesi', '2025-02-18 11:10', N'Tamamlandı', N'Normal', 3.00, 2.50),

(3, 1, N'Sakarya Otomotiv Yan San.', '2025-02-20 08:20', N'Tamamlandı', N'Normal', 4.00, 3.25),

(4, 2, N'Dilovası Liman Elektrik', '2025-02-22 14:50', N'Açık', N'Yüksek', 5.50, NULL),

(8, 3, N'Torbalı Tekstil Fabrikası', '2025-02-25 10:05', N'Tamamlandı', N'Düşük', 2.00, 2.00);

INSERT INTO WorkOrders
(TechnicianId, FaultCategoryId, SiteName, OpenedAt, Status, Priority, EstimatedHours, ActualHours)
VALUES
(12, 4, N'Kırıkkale Gıda İşleme', '2025-02-28 07:30', N'İptal', N'Normal', 4.00, 0.00),

(2, 2, N'İstanbul Havalimanı Yedek', '2025-03-02 05:00', N'Tamamlandı', N'Kritik', 12.00, 13.50),

(5, 1, N'Hadımköy Savunma Sanayi', '2025-03-05 09:30', N'Devam Ediyor', N'Yüksek', 6.00, NULL),

(7, 4, N'Bergama Rüzgar Santrali', '2025-03-08 11:45', N'Tamamlandı', N'Normal', 5.00, 4.50),

(11, 1, N'ASO 1 OSB UPS Odası', '2025-03-11 08:15', N'Tamamlandı', N'Yüksek', 4.00, 3.80);

INSERT INTO WorkOrders
(TechnicianId, FaultCategoryId, SiteName, OpenedAt, Status, Priority, EstimatedHours, ActualHours)
VALUES
(16, 2, N'Kaş Marina Jeneratör', '2025-03-14 13:20', N'Açık', N'Normal', 3.00, NULL),

(17, 3, N'Side Otel SCADA Panel', '2025-03-17 10:00', N'Tamamlandı', N'Yüksek', 7.00, 6.75),

(13, 1, N'Beypazarı Maden Tesisi', '2025-03-20 07:50', N'Beklemede', N'Kritik', 8.00, NULL),

(3, 3, N'İzmit Petrokimya SCADA', '2025-03-25 15:30', N'Tamamlandı', N'Kritik', 9.00, 8.25),

(4, 4, N'Çayırova Soğuk Zincir', '2025-03-28 08:00', N'Açık', N'Yüksek', 5.00, NULL),

(9, 1, N'Kemalpaşa OSB Elektrik', '2025-04-01 09:15', N'Tamamlandı', N'Normal', 3.50, 3.00),

(12, 2, N'Yenimahalle Belediye Jeneratör', '2025-04-03 14:00', N'Devam Ediyor', N'Normal', 4.00, NULL),

(15, 3, N'Kumluca Seracılık Otomasyon', '2025-04-05 11:30', N'Tamamlandı', N'Yüksek', 6.00, 5.50),

(17, 1, N'Alanya Plaza UPS', '2025-04-08 08:45', N'İptal', N'Düşük', 2.00, 0.00);

SELECT * FROM WorkOrders
ORDER BY Id;


-- SORU 01 : Tüm servis bölgelerini listeleyin. Tüm sütunlar.
    SELECT * FROM ServiceRegions;

-- SORU 02 : Yalnızca **bölge kodu** ve **bölge adı** sütunlarını getirin.
    SELECT Code, Name
    FROM ServiceRegions;

-- SORU 03 : **Marmara** servis bölgesine (`RegionId = 1`) bağlı teknisyenlerin adını, e-postasını ve işe giriş tarihini listeleyin.
    SELECT FullName, Email, HireDate
    FROM Technicians
    WHERE RegionId = 1;

-- SORU 04 : `SkillLevel` **3 veya üzeri** **ve** **2022 ve sonrasında** işe girmiş teknisyenlerin adını ve `SkillLevel` değerini listeleyin.
    SELECT FullName, SkillLevel
    FROM Technicians
    WHERE SkillLevel >= 3
    AND HireDate >= '2022-01-01';

-- SORU 05 : **Ege** (`RegionId = 2`) veya **Akdeniz** (`RegionId = 4`) bölgesindeki teknisyenlerin adını ve `RegionId` değerini listeleyin.
    SELECT FullName, RegionId
    FROM Technicians
    WHERE RegionId = 2 OR RegionId = 4;


-- SORU 06 : Adında **"Demir"** geçen teknisyenlerin adını ve e-postasını listeleyin.
    SELECT FullName, Email
    FROM Technicians
    WHERE FullName LIKE N'%Demir%';

-- SORU 07 : `RegionId` değeri **1, 2 veya 3** olan teknisyenlerin adını ve `RegionId` değerini listeleyin.
    SELECT FullName, RegionId
    FROM Technicians
    WHERE RegionId IN (1, 2, 3);

-- SORU 08 : **2022 – 2023** yılları arasında işe girmiş teknisyenlerin adını ve `HireDate` değerini listeleyin.
    SELECT FullName, HireDate
    FROM Technicians
    WHERE HireDate BETWEEN '2022-01-01' AND '2023-12-31';

-- SORU 09 : Bölge **ekip lideri** olmayan teknisyenleri bulun (`LeadTechnicianId IS NULL`). Ad, e-posta ve `RegionId` gösterin.
    SELECT FullName, Email, RegionId
    FROM Technicians
    WHERE LeadTechnicianId IS NULL;

-- SORU 10 : Tüm teknisyenleri **yetkinlik seviyesine göre artan** sırada listeleyin (`SkillLevel ASC`). Ad ve `SkillLevel` yeterli.
    SELECT FullName, SkillLevel
    FROM Technicians
    ORDER BY SkillLevel ASC;

-- SORU 11 : Tüm teknisyenleri önce **bölgeye göre artan**, aynı bölgede **işe giriş tarihine göre azalan** sırada listeleyin. Ad, `RegionId` ve `HireDate` gösterin.
    SELECT FullName, RegionId, HireDate
    FROM Technicians
    ORDER BY RegionId ASC, HireDate DESC;

-- SORU 12 : En eski işe giriş tarihine sahip **ilk 5** teknisyeni listeleyin. Ad ve `HireDate`.
    SELECT TOP 5 FullName, HireDate
    FROM Technicians
    ORDER BY HireDate ASC;

-- SORU 13 : İş emirlerinde kullanılmış **benzersiz** `Status` değerlerini listeleyin.
    SELECT DISTINCT Status
    FROM WorkOrders;

-- SORU 14 : Her `RegionId` için teknisyen sayısını hesaplayın. Sütun alias: `TeknisyenSayisi`.
    SELECT RegionId, COUNT(*) AS TeknisyenSayisi
    FROM Technicians
    GROUP BY RegionId;

-- SORU 15 : Her bölge (`RegionId`) için teknisyenlerin `SkillLevel` değerlerinin **toplamını** ve **ortalamasını** hesaplayın.
    SELECT
        RegionId,
        SUM(SkillLevel) AS ToplamSkillLevel,
        AVG(CAST(SkillLevel AS DECIMAL(5,2))) AS OrtalamaSkillLevel
    FROM Technicians
    GROUP BY RegionId;

-- SORU 16 : En az **5 teknisyeni** olan bölgeleri listeleyin (`RegionId` + teknisyen sayısı).
    SELECT
        RegionId,
        COUNT(*) AS TeknisyenSayisi
    FROM Technicians
    GROUP BY RegionId
    HAVING COUNT(*) >= 5;

-- SORU 17 : Saha adında (`SiteName`) **"Soğuk"** geçen iş emirlerinin saha adını ve `Status` değerini listeleyin.
    SELECT SiteName, Status
    FROM WorkOrders
    WHERE SiteName LIKE N'%Soğuk%';

-- SORU 18 : Durumu `Tamamlandı`, `Devam Ediyor` veya `Açık` olan iş emirlerinin `Id`, `SiteName` ve `Status` değerlerini listeleyin.
    SELECT Id, SiteName, Status
    FROM WorkOrders
    WHERE Status IN (N'Tamamlandı', N'Devam Ediyor', N'Açık');

-- SORU 19 : **1 Ocak 2025 – 31 Ocak 2025** arasında açılmış iş emirlerinin saha adını ve `OpenedAt` değerini listeleyin.
    SELECT SiteName, OpenedAt
    FROM WorkOrders
    WHERE OpenedAt >= '2025-01-01'
    AND OpenedAt < '2025-02-01';

-- SORU 20 : Her `Status` değeri için kaç iş emri olduğunu sayın. Sütun alias: `IsEmriSayisi`.
    SELECT Status, COUNT(*) AS IsEmriSayisi
    FROM WorkOrders
    GROUP BY Status;
