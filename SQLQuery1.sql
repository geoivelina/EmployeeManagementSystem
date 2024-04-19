CREATE TABLE Users
(
	id INT PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(MAX) NULL,
	password VARCHAR(MAX) NULL,
	date_register DATE NULL
)	

SELECT * FROM Users

CREATE TABLE Employees
(
	id INT PRIMARY KEY IDENTITY(1,1),
	employee_id VARCHAR(MAX) NULL,
	full_name VARCHAR(MAX) NULL,
	gender VARCHAR(MAX) NULL,
	phone_number VARCHAR(MAX) NULL,
	position VARCHAR(MAX) NULL,
	image VARCHAR(MAX) NULL,
	salary INT NULL,
	insert_date DATE NULL,
	update_date DATE NULL,
	delete_date DATE NULL,
)

SELECT * FROM Employees

ALTER TABLE Employees
ADD  status VARCHAR(MAX) NULL

SELECT * FROM Employees WHERE delete_date IS NULL

DELETE FROM Employees