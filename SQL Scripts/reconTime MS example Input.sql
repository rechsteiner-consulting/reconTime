INSERT INTO Employees (EmployeeID, FirstName, LastName, Active)
VALUES (999, 'Max', 'Mustermann', 0)

INSERT INTO	Timestamps (CheckIn, CheckOut, CheckInMethode, CheckOutMethode, EmployeeID)
Values(convert(datetime, '18-06-12 10:34:09 PM',5), convert(datetime, '18-06-12 12:34:09 PM',5), 1, 1, 999)