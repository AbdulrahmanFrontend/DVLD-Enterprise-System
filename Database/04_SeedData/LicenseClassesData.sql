USE DVLDSystemDb
GO

INSERT INTO LicenseClasses
VALUES ('Class 1 - Small Motorcycle',
		'It allows the driver to drive small motorcycles, It is suitable for motorcycles with small capacity and limited power.', 18, 5, 15),
('Class 2 - Heavy Motorcycle License', 'Heavy Motorcycle License (Large Motorcycle License)', 21, 5, 30),
('Class 3 - Ordinary driving license', 'Ordinary driving license (car licence)', 18, 10, 20),
('Class 4 - Commercial', 'Commercial driving license (taxi/limousine)', 21, 10, 200),
('Class 5 - Agricultural', 'Agricultural and work vehicles used in farming or construction, (tractors / tillage machinery)', 21, 10, 50),
('Class 6 - Small and medium bus', 'Small and medium bus license', 21, 10, 250),
('Class 7 - Truck and heavy vehicle', 'Truck and heavy vehicle license', 21, 10, 300);