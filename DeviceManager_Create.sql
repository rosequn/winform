-- Tạo cơ sở dữ liệu
CREATE DATABASE PumpStationManagement;
GO

-- Xóa database
USE master;
GO
DROP DATABASE PumpStationManagement;
GO
-- Sử dụng cơ sở dữ liệu
USE PumpStationManagement;
GO

-- Bảng Người dùng (User)
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(100) NOT NULL,
    FullName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100),
    PhoneNumber NVARCHAR(20),
    Role INT NOT NULL Default 0, -- User, Admin, SystemAdmin
    IsActive BIT DEFAULT 1,
	IsDelete BIT NOT NULL DEFAULT 0,
    CreatedOn DATETIME DEFAULT GETDATE(),
	CreatedBy INT NOT NULL,
    LastLogin DATETIME NULL,
	ModifiedBy INT,
    ModifiedOn DATETIME
);

-- Bảng Trạm bơm (Pump Station)
CREATE TABLE PumpStations (
    StationID INT IDENTITY(1,1) PRIMARY KEY,
    StationName NVARCHAR(100) NOT NULL,
    Location NVARCHAR(200) NOT NULL,
    Description NVARCHAR(500),
    Status INT NOT NULL DEFAULT 0, -- Active, Maintenance, Inactive
	IsDelete BIT NOT NULL DEFAULT 0,
    CreatedBy INT FOREIGN KEY REFERENCES Users(UserID),
    CreatedOn DATETIME DEFAULT GETDATE(),
    ModifiedBy INT FOREIGN KEY REFERENCES Users(UserID),
    ModifiedOn DATETIME
);

-- Bảng Máy bơm (Pump)
CREATE TABLE Pumps (
    PumpID INT IDENTITY(1,1) PRIMARY KEY,
    StationID INT FOREIGN KEY REFERENCES PumpStations(StationID),
    PumpName NVARCHAR(100) NOT NULL,
    PumpType INT NOT NULL DEFAULT 0, -- Loại máy bơm
    Capacity FLOAT, -- Công suất
    Status INT NOT NULL DEFAULT 0, -- Running, Stopped, Maintenance, Failed
	IsDelete BIT NOT NULL DEFAULT 0,
    Manufacturer NVARCHAR(100),
    SerialNumber NVARCHAR(100),
    WarrantyExpireDate DATETIME DEFAULT GETDATE(),
    Description NVARCHAR(500),
    CreatedBy INT FOREIGN KEY REFERENCES Users(UserID),
    CreatedOn DATETIME DEFAULT GETDATE(),
    ModifiedBy INT FOREIGN KEY REFERENCES Users(UserID),
    ModifiedOn DATETIME
);

-- Bảng Dữ liệu vận hành (Operating Data)
CREATE TABLE OperatingData (
    DataID INT IDENTITY(1,1) PRIMARY KEY,
    PumpID INT FOREIGN KEY REFERENCES Pumps(PumpID),
    RecordTime DATETIME NOT NULL DEFAULT GETDATE(),
    FlowRate FLOAT, -- Lưu lượng (m³/h)
    Pressure FLOAT, -- Áp suất (bar)
    PowerConsumption FLOAT, -- Công suất tiêu thụ (kW)
    Temperature FLOAT, -- Nhiệt độ (°C)
    RunningHours FLOAT, -- Số giờ hoạt động liên tục
    Efficiency FLOAT, -- Hiệu suất (%)
	IsDelete BIT NOT NULL DEFAULT 0,
    CreatedOn DATETIME DEFAULT GETDATE(),
    ModifiedOn DATETIME
);

-- Bảng Lịch sử bảo trì (Maintenance History)
CREATE TABLE MaintenanceHistory (
    MaintenanceID INT IDENTITY(1,1) PRIMARY KEY,
    PumpID INT FOREIGN KEY REFERENCES Pumps(PumpID),
    MaintenanceType INT NOT NULL DEFAULT 0, -- Preventive, Corrective, Emergency
    StartDate DATETIME NOT NULL,
    EndDate DATETIME,
    Description NVARCHAR(500),
    Status INT NOT NULL DEFAULT 0, -- Completed, In Progress, Scheduled
    PerformedBy INT FOREIGN KEY REFERENCES Users(UserID),	
	IsDelete BIT NOT NULL DEFAULT 0,
    CreatedOn DATETIME DEFAULT GETDATE()
);

-- Bảng Cảnh báo (Alerts)
CREATE TABLE Alerts (
    AlertID INT IDENTITY(1,1) PRIMARY KEY,
    PumpID INT FOREIGN KEY REFERENCES Pumps(PumpID),
    AlertType INT NOT NULL DEFAULT 0, -- Critical, Warning, Info
    AlertMessage NVARCHAR(500) NOT NULL,
    Status INT NOT NULL DEFAULT 0, -- Active, Resolved, Ignored
	IsDelete BIT NOT NULL DEFAULT 0,
	CreatedBy INT FOREIGN KEY REFERENCES Users(UserID) NULL,
    CreatedOn DATETIME DEFAULT GETDATE(),
    ModifiedBy INT FOREIGN KEY REFERENCES Users(UserID) NULL,
    ModifiedOn DATETIME
);



--Tạo dữ liêu giả
INSERT INTO Users (Username, Password, FullName, CreatedBy)
VALUES ('admin', '123', N'Quản trị viên', 1);

INSERT INTO PumpStations (StationName, Location, Description, CreatedBy)
VALUES 
(N'Trạm A', N'Hà Nội', N'Trạm trung tâm', 1),
(N'Trạm B', N'TP.HCM', N'Trạm phụ', 1),
(N'Trạm C', N'Đà Nẵng', N'Trạm miền Trung', 1);

-- Thêm dữ liệu mẫu cho máy bơm
INSERT INTO Pumps (StationID, PumpName, PumpType, Capacity, Status, IsDelete, Manufacturer, SerialNumber, WarrantyExpireDate, Description)
VALUES
(1, 'Pump A1', 1, 100.5, 0, 0, 'Grundfos', 'SN-A1001', DATEADD(YEAR, 2, GETDATE()), 'High-capacity pump for Station 1'),

(1, 'Pump A2', 2, 80.0, 1, 0, 'Siemens', 'SN-A1002', DATEADD(YEAR, 1, GETDATE()), 'Medium pump with backup'),

(2, 'Pump B1', 1, 120.75, 2, 0, 'Pentair', 'SN-B1001', DATEADD(MONTH, 18, GETDATE()), 'Under maintenance'),

(2, 'Pump B2', 0, 95.0, 0, 0, 'Hitachi', 'SN-B1002', DATEADD(YEAR, 3, GETDATE()), 'Normal operation'),

(3, 'Pump C1', 2, 110.2, 3, 0, 'Ebara', 'SN-C1001', DATEADD(YEAR, 2, GETDATE()), 'Failed due to overload');


-- Thêm dữ liệu mẫu cho PumpID = 1 và 2
INSERT INTO OperatingData (PumpID, RecordTime, FlowRate, Pressure, PowerConsumption, Temperature, RunningHours, Efficiency)
VALUES 
(1, '2025-04-13 08:00:00', 120.5, 2.5, 15.2, 35.0, 5.5, 85.6),
(1, '2025-04-13 12:00:00', 125.0, 2.6, 16.0, 36.2, 6.0, 86.0),
(1, '2025-04-13 16:00:00', 122.3, 2.4, 15.8, 34.5, 5.8, 84.7),
(2, '2025-04-13 08:00:00', 110.0, 2.3, 14.5, 33.0, 4.5, 83.2),
(2, '2025-04-13 12:00:00', 112.8, 2.4, 14.8, 33.8, 4.8, 84.0);


INSERT INTO Alerts (PumpID, AlertType, AlertMessage, Status, IsDelete)
VALUES
(1, 0, N'Nhiệt độ bơm vượt mức cho phép', 0, 0),
(1, 1, N'Áp suất đầu ra thấp hơn bình thường', 1, 0),
(2, 2, N'Thông báo kiểm tra định kỳ sắp đến hạn', 0, 0),
(3, 0, N'Lỗi động cơ - cần kiểm tra ngay', 0, 0),
(3, 1, N'Cảnh báo dòng điện không ổn định', 2, 0),
(4, 2, N'Thông báo cập nhật firmware', 1, 0),
(5, 0, N'Ngừng hoạt động bất thường', 0, 0),
(5, 1, N'Cảnh báo bảo trì quá hạn', 1, 0);

---- Bảng Lịch bảo trì dự kiến (Scheduled Maintenance)
--CREATE TABLE ScheduledMaintenance (
--    ScheduleID INT IDENTITY(1,1) PRIMARY KEY,
--    PumpID INT FOREIGN KEY REFERENCES Pumps(PumpID),
--    ScheduledDate DATETIME NOT NULL,
--    MaintenanceType NVARCHAR(100) NOT NULL,
--    EstimatedDuration INT, -- Thời gian dự kiến (giờ)
--    Description NVARCHAR(500),
--    Status NVARCHAR(50) NOT NULL, -- Scheduled, Completed, Cancelled
--    CreatedBy INT FOREIGN KEY REFERENCES Users(UserID),
--    CreatedDate DATETIME DEFAULT GETDATE()
--);

---- Bảng Nhật ký hoạt động (Activity Log)
--CREATE TABLE ActivityLog (
--    LogID INT IDENTITY(1,1) PRIMARY KEY,
--    UserID INT FOREIGN KEY REFERENCES Users(UserID),
--    ActivityTime DATETIME NOT NULL DEFAULT GETDATE(),
--    ActivityType NVARCHAR(100) NOT NULL, -- Login, Logout, Create, Update, Delete
--    EntityType NVARCHAR(100) NOT NULL, -- User, Station, Pump, etc.
--    EntityID INT,
--    Description NVARCHAR(500),
--    IPAddress NVARCHAR(50)
--);

---- Tạo dữ liệu mẫu cho Người dùng
--INSERT INTO Users (Username, Password, FullName, Email, PhoneNumber, Role)
--VALUES 
--('admin', 'hashed_password', N'Quản trị viên', 'admin@example.com', '0123456789', 'Admin'),
--('operator1', 'hashed_password', N'Nhân viên vận hành 1', 'operator1@example.com', '0987654321', 'Operator'),
--('viewer1', 'hashed_password', N'Người xem 1', 'viewer1@example.com', '0909090909', 'Viewer');

---- Tạo dữ liệu mẫu cho Trạm bơm
--INSERT INTO PumpStations (StationName, Location, Description, Status, InstallationDate, Capacity, CreatedBy, ModifiedBy)
--VALUES 
--(N'Trạm bơm số 1', N'Quận 1, TP.HCM', N'Trạm bơm chính khu vực trung tâm', 'Active', '2020-01-15', 1000.0, 1, 1),
--(N'Trạm bơm số 2', N'Quận 7, TP.HCM', N'Trạm bơm khu vực nam thành phố', 'Active', '2021-03-20', 800.0, 1, 1),
--(N'Trạm bơm số 3', N'Quận 9, TP.HCM', N'Trạm bơm khu vực đông thành phố', 'Maintenance', '2019-07-10', 1200.0, 1, 1);

---- Tạo dữ liệu mẫu cho Máy bơm
--INSERT INTO Pumps (StationID, PumpName, PumpCode, PumpType, Capacity, Status, InstallationDate, Manufacturer, Model, CreatedBy, ModifiedBy)
--VALUES 
--(1, N'Máy bơm 1A', 'PMP001', N'Máy bơm ly tâm', 250.0, 'Running', '2020-01-20', 'Grundfos', 'CR 95-2', 1, 1),
--(1, N'Máy bơm 1B', 'PMP002', N'Máy bơm ly tâm', 250.0, 'Stopped', '2020-01-20', 'Grundfos', 'CR 95-2', 1, 1),
--(1, N'Máy bơm 1C', 'PMP003', N'Máy bơm ly tâm', 500.0, 'Running', '2020-02-05', 'Grundfos', 'CR 120-1', 1, 1),
--(2, N'Máy bơm 2A', 'PMP004', N'Máy bơm chìm', 400.0, 'Running', '2021-03-25', 'Wilo', 'EMU FA 15', 1, 1),
--(2, N'Máy bơm 2B', 'PMP005', N'Máy bơm chìm', 400.0, 'Maintenance', '2021-03-25', 'Wilo', 'EMU FA 15', 1, 1),
--(3, N'Máy bơm 3A', 'PMP006', N'Máy bơm trục đứng', 600.0, 'Failed', '2019-07-15', 'KSB', 'Sewatec', 1, 1),
--(3, N'Máy bơm 3B', 'PMP007', N'Máy bơm trục đứng', 600.0, 'Running', '2019-07-15', 'KSB', 'Sewatec', 1, 1);

ALTER LOGIN sa ENABLE;
ALTER LOGIN sa WITH PASSWORD = 'YourStrongPassword';



