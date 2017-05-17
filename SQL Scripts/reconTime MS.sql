CREATE TABLE Employees
(
EmployeeID int NOT NULL PRIMARY KEY,
FirstName varchar(50) NOT NULL,
LastName varchar(50) NOT NULL,
Active int NOT NULL,
)

CREATE TABLE Timestamps
(
CheckIn datetime NOT NULL PRIMARY KEY,
CheckOut datetime,
CheckInMethode tinyint NOT NULL,
CheckOutMethode tinyint,
EmployeeID int FOREIGN KEY REFERENCES Employees(EmployeeID)
)
Create Table WorkDuration
(
Date datetime NOT NULL PRIMARY KEY,
Duration time NOT NULL,
CheckInMethode tinyint NOT NULL,
EmployeeID int FOREIGN KEY REFERENCES Employees(EmployeeID)
)