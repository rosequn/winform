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
    CreatedOn DATETIME DEFAULT GETDATE(),
	CreatedBy INT NOT NULL,
    LastLogin DATETIME NULL,
	ModifiedBy INT,
    ModifiedOn DATETIME DEFAULT GETDATE()
);

-- Bảng Trạm bơm (Pump Station)
CREATE TABLE PumpStations (
    StationID INT IDENTITY(1,1) PRIMARY KEY,
    StationName NVARCHAR(100) NOT NULL,
    Location NVARCHAR(200) NOT NULL,
    Description NVARCHAR(500),
    Status INT NOT NULL DEFAULT 0, -- Active, Maintenance, Inactive
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
    PumpCode NVARCHAR(50) NOT NULL,
    PumpType INT NOT NULL DEFAULT 0, -- Loại máy bơm
    Capacity FLOAT, -- Công suất
    Status INT NOT NULL DEFAULT 0, -- Running, Stopped, Maintenance, Failed
    Manufacturer NVARCHAR(100),
    Model NVARCHAR(100),
    SerialNumber NVARCHAR(100),
    WarrantyExpireDate DATE,
    Description NVARCHAR(500),
    CreatedBy INT FOREIGN KEY REFERENCES Users(UserID),
    CreatedOn DATETIME DEFAULT GETDATE(),
    ModifiedBy INT FOREIGN KEY REFERENCES Users(UserID),
    ModifiedOn DATETIME DEFAULT GETDATE()
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
    CreatedOn DATETIME DEFAULT GETDATE()
);

-- Bảng Cảnh báo (Alerts)
CREATE TABLE Alerts (
    AlertID INT IDENTITY(1,1) PRIMARY KEY,
    PumpID INT FOREIGN KEY REFERENCES Pumps(PumpID),
    AlertType INT NOT NULL DEFAULT 0, -- Critical, Warning, Info
    AlertMessage NVARCHAR(500) NOT NULL,
    AlertTime DATETIME NOT NULL DEFAULT GETDATE(),
    ResolvedTime DATETIME NULL,
    Status INT NOT NULL DEFAULT 0, -- Active, Resolved, Ignored
    ResolvedBy INT FOREIGN KEY REFERENCES Users(UserID) NULL
);



--Tạo dữ liêu giả
INSERT INTO Users (Username, Password, FullName, CreatedBy)
VALUES ('admin', '123', N'Quản trị viên', 1);

INSERT INTO PumpStations (StationName, Location, Description, CreatedBy)
VALUES 
(N'Trạm A', N'Hà Nội', N'Trạm trung tâm', 1),
(N'Trạm B', N'TP.HCM', N'Trạm phụ', 1),
(N'Trạm C', N'Đà Nẵng', N'Trạm miền Trung', 1);

Update PumpStations Set Description = N'Á đù' Where StationID = 15

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

---- Tạo Stored Procedure để lấy danh sách trạm bơm với số lượng máy bơm
--CREATE PROCEDURE GetPumpStationsList
--AS
--BEGIN
--    SELECT 
--        ps.StationID,
--        ps.StationName,
--        ps.Location,
--        ps.Description,
--        ps.Status,
--        ps.InstallationDate,
--        ps.Capacity,
--        ps.LastMaintenanceDate,
--        COUNT(p.PumpID) AS PumpCount,
--        SUM(CASE WHEN p.Status = 'Running' THEN 1 ELSE 0 END) AS RunningPumps
--    FROM PumpStations ps
--    LEFT JOIN Pumps p ON ps.StationID = p.StationID
--    GROUP BY 
--        ps.StationID,
--        ps.StationName,
--        ps.Location,
--        ps.Description,
--        ps.Status,
--        ps.InstallationDate,
--        ps.Capacity,
--        ps.LastMaintenanceDate
--    ORDER BY ps.StationName;
--END;
--GO

---- Tạo Stored Procedure để lấy danh sách máy bơm theo trạm
--CREATE PROCEDURE GetPumpsByStation
--    @StationID INT
--AS
--BEGIN
--    SELECT 
--        p.PumpID,
--        p.PumpName,
--        p.PumpCode,
--        p.PumpType,
--        p.Capacity,
--        p.Status,
--        p.InstallationDate,
--        p.Manufacturer,
--        p.Model,
--        p.SerialNumber,
--        p.WarrantyExpireDate,
--        p.Description,
--        ps.StationName
--    FROM Pumps p
--    JOIN PumpStations ps ON p.StationID = ps.StationID
--    WHERE p.StationID = @StationID
--    ORDER BY p.PumpName;
--END;
--GO

---- Tạo Stored Procedure để lấy dữ liệu vận hành của máy bơm theo khoảng thời gian
--CREATE PROCEDURE GetPumpOperatingData
--    @PumpID INT,
--    @StartDate DATETIME,
--    @EndDate DATETIME
--AS
--BEGIN
--    SELECT 
--        od.DataID,
--        od.PumpID,
--        od.RecordTime,
--        od.FlowRate,
--        od.Pressure,
--        od.PowerConsumption,
--        od.Temperature,
--        od.RunningHours,
--        od.Efficiency,
--        od.Vibration,
--        od.CurrentDrawn,
--        od.Comments,
--        p.PumpName,
--        p.PumpCode
--    FROM OperatingData od
--    JOIN Pumps p ON od.PumpID = p.PumpID
--    WHERE od.PumpID = @PumpID
--    AND od.RecordTime BETWEEN @StartDate AND @EndDate
--    ORDER BY od.RecordTime DESC;
--END;
--GO

---- Tạo Stored Procedure để lấy lịch sử bảo trì của máy bơm
--CREATE PROCEDURE GetPumpMaintenanceHistory
--    @PumpID INT
--AS
--BEGIN
--    SELECT 
--        mh.MaintenanceID,
--        mh.PumpID,
--        mh.MaintenanceType,
--        mh.StartDate,
--        mh.EndDate,
--        mh.Description,
--        mh.PartsReplaced,
--        mh.Cost,
--        mh.Technician,
--        mh.CompletionStatus,
--        u.FullName AS PerformedByUser,
--        p.PumpName,
--        p.PumpCode
--    FROM MaintenanceHistory mh
--    JOIN Pumps p ON mh.PumpID = p.PumpID
--    JOIN Users u ON mh.PerformedBy = u.UserID
--    WHERE mh.PumpID = @PumpID
--    ORDER BY mh.StartDate DESC;
--END;
--GO

---- Tạo Stored Procedure để lấy cảnh báo của máy bơm
--CREATE PROCEDURE GetPumpAlerts
--    @PumpID INT = NULL,
--    @Status NVARCHAR(50) = NULL
--AS
--BEGIN
--    SELECT 
--        a.AlertID,
--        a.PumpID,
--        a.AlertType,
--        a.AlertMessage,
--        a.AlertTime,
--        a.ResolvedTime,
--        a.Status,
--        a.Resolution,
--        p.PumpName,
--        p.PumpCode,
--        ps.StationName,
--        u.FullName AS ResolvedByUser
--    FROM Alerts a
--    JOIN Pumps p ON a.PumpID = p.PumpID
--    JOIN PumpStations ps ON p.StationID = ps.StationID
--    LEFT JOIN Users u ON a.ResolvedBy = u.UserID
--    WHERE (@PumpID IS NULL OR a.PumpID = @PumpID)
--    AND (@Status IS NULL OR a.Status = @Status)
--    ORDER BY a.AlertTime DESC;
--END;
--GO

---- Tạo Stored Procedure để tìm kiếm trạm bơm
--CREATE PROCEDURE SearchPumpStations
--    @SearchTerm NVARCHAR(100)
--AS
--BEGIN
--    SELECT 
--        ps.StationID,
--        ps.StationName,
--        ps.Location,
--        ps.Description,
--        ps.Status,
--        ps.InstallationDate,
--        ps.Capacity,
--        ps.LastMaintenanceDate,
--        COUNT(p.PumpID) AS PumpCount,
--        SUM(CASE WHEN p.Status = 'Running' THEN 1 ELSE 0 END) AS RunningPumps
--    FROM PumpStations ps
--    LEFT JOIN Pumps p ON ps.StationID = p.StationID
--    WHERE ps.StationName LIKE '%' + @SearchTerm + '%'
--    OR ps.Location LIKE '%' + @SearchTerm + '%'
--    OR ps.Status LIKE '%' + @SearchTerm + '%'
--    OR ps.Description LIKE '%' + @SearchTerm + '%'
--    GROUP BY 
--        ps.StationID,
--        ps.StationName,
--        ps.Location,
--        ps.Description,
--        ps.Status,
--        ps.InstallationDate,
--        ps.Capacity,
--        ps.LastMaintenanceDate
--    ORDER BY ps.StationName;
--END;
--GO

---- Tạo Stored Procedure để tìm kiếm máy bơm
--CREATE PROCEDURE SearchPumps
--    @SearchTerm NVARCHAR(100)
--AS
--BEGIN
--    SELECT 
--        p.PumpID,
--        p.PumpName,
--        p.PumpCode,
--        p.PumpType,
--        p.Capacity,
--        p.Status,
--        p.InstallationDate,
--        p.Manufacturer,
--        p.Model,
--        p.SerialNumber,
--        p.WarrantyExpireDate,
--        p.Description,
--        ps.StationName,
--        ps.StationID
--    FROM Pumps p
--    JOIN PumpStations ps ON p.StationID = ps.StationID
--    WHERE p.PumpName LIKE '%' + @SearchTerm + '%'
--    OR p.PumpCode LIKE '%' + @SearchTerm + '%'
--    OR p.Status LIKE '%' + @SearchTerm + '%'
--    OR p.PumpType LIKE '%' + @SearchTerm + '%'
--    OR ps.StationName LIKE '%' + @SearchTerm + '%'
--    ORDER BY ps.StationName, p.PumpName;
--END;
--GO

ALTER LOGIN sa ENABLE;
ALTER LOGIN sa WITH PASSWORD = 'YourStrongPassword';



