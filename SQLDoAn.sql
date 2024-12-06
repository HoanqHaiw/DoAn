CREATE DATABASE hostel
use hostel

-- CREATE TABLE ROOMS
CREATE TABLE rooms (
	roomNo BIGINT not null PRIMARY KEY, 
	roomStatus VARCHAR(250) NOT NULL,
	Booked VARCHAR(150) DEFAULT 'NO'
)


-- CREATE TABLE NEW STUDENT
CREATE TABLE newStudent (
	id INT IDENTITY(1, 1) PRIMARY KEY,
	mobile BIGINT NOT NULL,
	name VARCHAR(250) NOT NULL,
	fname VARCHAR(250) NOT NULL,
	mname VARCHAR(250) NOT NULL,
	email VARCHAR(250) NOT NULL,
	paddress VARCHAR(250) NOT NULL,
	college VARCHAR(250) NOT NULL,
	idproof VARCHAR(250) NOT NULL,
	roomNo BIGINT NOT NULL,
	living VARCHAR(250) DEFAULT 'YES',
	FOREIGN KEY (roomNo) REFERENCES rooms(roomNo)
)

-- CREATE TABLE FEES
CREATE TABLE fees (
	mobileNo BIGINT NOT NULL,
	fmonth VARCHAR(60) NOT NULL,
	amount BIGINT NOT NULL
)


-- CREATE TABLE NEWEMPLOYEE 
CREATE TABLE newEmployee (
	id INT IDENTITY(1, 1) PRIMARY KEY,
	emobile BIGINT NOT NULL,
	ename VARCHAR(250) NOT NULL,
	efname VARCHAR(250) NOT NULL,
	emname VARCHAR(250) NOT NULL,
	eemail VARCHAR(250) NOT NULL,
	epaddress VARCHAR(250) NOT NULL,
	eidproof VARCHAR(250) NOT NULL,
	edesignation VARCHAR(250) NOT NULL,
	working VARCHAR(50) DEFAULT 'Yes'
)

-- CREATE TABLE CONTRACTS (Bảng hợp đồng)
CREATE TABLE contracts (
    contractId INT IDENTITY(1,1) PRIMARY KEY,   -- Mã hợp đồng (tự động tăng)
    studentId INT NOT NULL,                     -- Mã sinh viên (liên kết với bảng newStudent)
    roomNo BIGINT NOT NULL,                     -- Số phòng (liên kết với bảng rooms)
    startDate DATE NOT NULL,                    -- Ngày bắt đầu hợp đồng
    endDate DATE NOT NULL,                      -- Ngày kết thúc hợp đồng
    rentalAmount BIGINT NOT NULL,               -- Số tiền thuê phòng
    status VARCHAR(50) DEFAULT 'Active',        -- Trạng thái hợp đồng (Active, Expired, Terminated) đang hoạt động , đã hết hạn và đã chấm dứt
    FOREIGN KEY (studentId) REFERENCES newStudent(id), -- Liên kết với bảng newStudent
    FOREIGN KEY (roomNo) REFERENCES rooms(roomNo)      -- Liên kết với bảng rooms
);

-- CREATE TABLE ISSUES (Sự cố)
CREATE TABLE issues (
    issueId INT IDENTITY(1,1) PRIMARY KEY,  -- Mã sự cố (tự động tăng)
    roomNo BIGINT NOT NULL,                  -- Số phòng liên quan
    description VARCHAR(500) NOT NULL,       -- Mô tả sự cố
    reportDate DATE NOT NULL,                -- Ngày báo cáo sự cố
    status VARCHAR(100) DEFAULT 'Pending',   -- Trạng thái (Mặc định: Pending)
    employeeInCharge INT NOT NULL,                    -- Nhân viên phụ trách
    -- Khóa ngoại liên kết với bảng rooms và newEmployee
    FOREIGN KEY (roomNo) REFERENCES rooms(roomNo), -- liên kết với bảng rooms
    FOREIGN KEY (employeeInCharge) REFERENCES newEmployee(id) -- liên kết với bảng newEmployee
);




SELECT COLUMN_NAME
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'newEmployee';


SELECT COLUMN_NAME
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'newStudent';


EXEC sp_rename 'newEmployee.employeeInCharge', 'id', 'COLUMN';
EXEC sp_rename 'newStudent.studentId', 'id', 'COLUMN';


