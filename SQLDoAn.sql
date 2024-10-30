﻿CREATE DATABASE hostel


-- CREATE TABLE ROOMS
CREATE TABLE rooms (
	roomNo BIGINT not null PRIMARY KEY, 
	roomStatus VARCHAR(250) NOT NULL,
	Booked VARCHAR(150) DEFAULT 'No'
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
	living VARCHAR(250) DEFAULT 'Yes',
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




-- CREATE TABLE EMPLOYEESALARY
CREATE TABLE employeeSalary (
	mobileNo BIGINT NOT NULL,
	fmonth VARCHAR(60) NOT NULL,
	amount BIGINT NOT NULL
)
-- CREATE TABLE ISSUES (Sự cố)
CREATE TABLE issues (
    issueId INT IDENTITY(1,1) PRIMARY KEY,  -- Mã sự cố (tự động tăng)
    roomNo BIGINT NOT NULL,                  -- Số phòng liên quan
    description VARCHAR(500) NOT NULL,       -- Mô tả sự cố
    reportDate DATE NOT NULL,                -- Ngày báo cáo sự cố
    status VARCHAR(100) DEFAULT 'Pending',   -- Trạng thái (Mặc định: Pending)
    employeeInCharge INT NOT NULL,                    -- Nhân viên phụ trách
    -- Khóa ngoại liên kết với bảng rooms và newEmployee
    FOREIGN KEY (roomNo) REFERENCES rooms(roomNo),
    FOREIGN KEY (employeeInCharge) REFERENCES newEmployee(id)
);
