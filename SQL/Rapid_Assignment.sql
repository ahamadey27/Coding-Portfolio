CREATE DATABASE db_contacts

CREATE TABLE tbl_agency(
	agency_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	agency_name VARCHAR(50) NOT NULL,
	agency_email VARCHAR(50) NOT NULL,
	agency_company VARCHAR(50) NOT NULL
); 

CREATE TABLE tbl_gaming(
	gaming_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	gaming_name VARCHAR(50) NOT NULL,
	gaming_email VARCHAR(50) NOT NULL,
	gaming_company VARCHAR(50) NOT NULL

); 

INSERT INTO tbl_agency
	(agency_name, agency_email, agency_company)
	VALUES
	('Jon Smith', 'jon@agency.com', 'agency20'),
	('Bill Smith', 'jbill@agency.com', 'agency3'),
	('Stacey Smith', 'st@agency.com', 'agency54'),
	('Same Smith', 'sam@agency.com', 'agency24'),
	('Pol Smith', 'pol@agency.com', 'agency62')
;

INSERT INTO tbl_gaming
	(gaming_name, gaming_email, gaming_company)
	VALUES
	('Jon medow', 'jon@game.com', 'gaming20'),
	('Bill medoez', 'jbill@game.com', 'gaming3'),
	('Stacey martinez', 'st@game.com', 'gaming54'),
	('Same fello', 'sam@game.com', 'gaming24'),
	('Pol boo', 'pol@game.com', 'gaming62')
;

SELECT * FROM tbl_agency;
SELECT * FROM tbl_gaming;



