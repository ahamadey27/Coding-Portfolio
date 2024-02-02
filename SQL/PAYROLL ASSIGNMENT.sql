CREATE TABLE tbl_employee(
	employee_id INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	job_id INT NOT NULL,
	first_name VARCHAR(50) NOT NULL, 
	last_name VARCHAR(50) NOT NULL,
	date_of_hire DATE
);

CREATE TABLE tbl_job(
	job_id INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	job_title VARCHAR(50) NOT NULL,
	job_dept VARCHAR(50) NOT NULL, 
	salary_id INT NOT NULL
);

CREATE TABLE tbl_salary(
	salary_id INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	hourly_rate MONEY NOT NULL
);


CREATE TABLE tbl_payroll(
	payroll_date DATE NOT NULL,
	employee_id INT NOT NULL,
	hours_worked INT NOT NULL
);

ALTER TABLE tbl_employee 
ADD FOREIGN KEY (job_id) REFERENCES tbl_job(job_id); 

ALTER TABLE tbl_payroll
ADD FOREIGN KEY (employee_id) REFERENCES tbl_employee(employee_id); 

ALTER TABLE tbl_job
ADD FOREIGN KEY (salary_id) REFERENCES tbl_salary(salary_id); 

INSERT INTO tbl_salary
VALUES
(19.50),
(20.50), 
(21.50), 
(22.50), 
(23.50)
;

INSERT INTO tbl_job
VALUES
('AR Director', 'Accounting', 2), 
('HR Direector', 'Human Resources', 4),
('DEV', 'IT', 5),
('Customer Service', 'Operations', 3),
('Sales', 'Sales and Marketing', 1);



INSERT INTO tbl_employee
VALUES
(1, 'Sam', 'Smith', '2018-11-25'),
(4, 'Gam', 'Smitd', '2013-11-25'),
(3, 'Wam', 'Std', '2013-10-25'),
(2, 'Weny', 'Smfd', '2012-11-21'),
(5, 'Bill', 'Fel', '2012-09-25');

INSERT INTO tbl_payroll 
VALUES
('2023-06-07', 1, 40),
('2023-06-07', 2, 30),
('2023-06-07', 3, 55),
('2023-06-07', 4, 22),
('2023-06-07', 5, 56);


SELECT * FROM tbl_employee --adding all tables together
	INNER JOIN tbl_payroll ON tbl_employee.employee_id = tbl_payroll.employee_id
	INNER JOIN tbl_job ON tbl_employee.job_id = tbl_job.job_id
	INNER JOIN tbl_salary ON tbl_job.salary_id = tbl_salary.salary_id;


SELECT * FROM tbl_salary;
SELECT * FROM tbl_job;
SELECT * FROM tbl_employee;


