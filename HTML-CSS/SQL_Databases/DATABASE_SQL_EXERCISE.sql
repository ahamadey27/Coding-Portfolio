USE db_zoo2

CREATE PROC createZoodb
AS
BEGIN


CREATE TABLE tbl_animalia (
	animalia_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	animalia_type VARCHAR(50) NOT NULL
);

INSERT INTO tbl_animalia
	(animalia_type)
	VALUES
		('vertebrate'),
		('invertebrate')
; 

CREATE TABLE tbl_class (
    class_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
    class_type VARCHAR(50) NOT NULL
);


INSERT INTO tbl_class
    (class_type)
    VALUES
    ('bird'),
    ('reptilian'),
    ('mamal'),
    ('arthropod'),
    ('fish'),
    ('worm'),
    ('cnidaria'),    
    ('echinoderm')
;

CREATE TABLE tbl_order (
	order_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	order_type VARCHAR(50) NOT NULL
); 

CREATE TABLE tbl_care(
	care_id VARCHAR(50) PRIMARY KEY NOT NULL,
	care_type VARCHAR(50) NOT NULL, 
	care_specialist VARCHAR(50) NOT NULL
);

CREATE TABLE tbl_nutrition(
	nutrition_id INT PRIMARY KEY NOT NULL IDENTITY (2200,1),
	nutrition_type VARCHAR(50) NOT NULL, 
	nutrition_cost MONEY NOT NULL
);

CREATE TABLE tbl_habitat(
	habitat_id INT PRIMARY KEY NOT NULL IDENTITY (5000,1),
	habitat_type VARCHAR(50) NOT NULL,
	habitat_cost MONEY NOT NULL
);

CREATE TABLE tbl_specialist(
	specialist_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	specialist_fname VARCHAR(50) NOT NULL,
	specialist_lname VARCHAR(50) NOT NULL,
	specialist_contact VARCHAR(50) NOT NULL
);

INSERT INTO tbl_order
	(order_type)
	VALUES
	('carnivore'),
	('herbivore'),
	('omnivore')
;

INSERT INTO tbl_care
	(care_id, care_type, care_specialist)
	VALUES
	('care_0', 'repalce something', 1),
	('care_1', 'replace broken toys', 4),
	('care_2', 'feed vitamins', 1),
	('care_3', 'clean poo', 2),
	('care_4', 'have playtime', 1),
	('care_5', 'goof around', 3),
	('care_6', 'throw ball', 1),
	('care_7', 'wrestle', 3)
; 

INSERT INTO tbl_nutrition 
	(nutrition_type, nutrition_cost)
	VALUES
	('raw fish', 1500),
	('rodents', 1200),
	('chicken', 1700),
	('feed', 870),
	('bananas', 250),
	('turkey', 2200),
	('sardines', 1300),
	('grain', 500)
;

INSERT INTO tbl_habitat
	(habitat_type, habitat_cost)
	VALUES
	('tundra', 6500),
	('water', 4200),
	('grass', 8700),
	('hills', 970),
	('trees', 950),
	('fields', 9200),
	('salt water', 8300),
	('cement', 5500)
;

INSERT INTO tbl_specialist
	(specialist_fname, specialist_lname, specialist_contact)
	VALUES
	('bill', 'sam', '459-937-3853'),
	('ryan', 'weed', '459-937-3543'),
	('stacy', 'fellow', '359-987-5763'),
	('sara', 'billard', '659-657-3495'),
	('tom', 'bryant', '454-267-9526')
;

CREATE TABLE tbl_species(
    species_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
    species_name VARCHAR(50) NOT NULL, 
    species_animalia INT NOT NULL CONSTRAINT fk_animalia_id FOREIGN KEY REFERENCES tbl_animalia(animalia_id) ON UPDATE CASCADE ON DELETE CASCADE, 
    species_class INT NOT NULL CONSTRAINT fk_class_id FOREIGN KEY REFERENCES tbl_class(class_id) ON UPDATE CASCADE ON DELETE CASCADE, 
    species_order INT NOT NULL CONSTRAINT fk_order_id FOREIGN KEY REFERENCES tbl_order(order_id) ON UPDATE CASCADE ON DELETE CASCADE,
    species_habitat INT NOT NULL CONSTRAINT fk_habitat_id FOREIGN KEY REFERENCES tbl_habitat(habitat_id) ON UPDATE CASCADE ON DELETE CASCADE,
    species_nutrition INT NOT NULL CONSTRAINT fk_nutrition_id FOREIGN KEY REFERENCES tbl_nutrition(nutrition_id) ON UPDATE CASCADE ON DELETE CASCADE,
    species_care VARCHAR(50) NOT NULL CONSTRAINT fk_care_id FOREIGN KEY REFERENCES tbl_care(care_id) ON UPDATE CASCADE ON DELETE CASCADE
);

INSERT INTO tbl_species
    (species_name, species_animalia, species_class, species_order, species_habitat, species_nutrition, species_care)
    VALUES
    ('brown bear', 1, 1, 3, 5000, 2200, 'care_1'), 
    ('jaguar', 1, 2, 1, 5007, 2200, 'care_4'),
    ('penguin', 1, 5, 1, 5003, 2202, 'care_6'),
    ('bat', 1, 3, 1, 5007, 2204, 'care_2'),
    ('chicken', 1, 3, 3, 5006, 2202, 'care_0'), 
    ('panda', 1, 4, 1, 5001, 2204, 'care_5'),
    ('bobcat', 1, 2, 3, 5001, 2204, 'care_5'),
    ('grey wolf', 1, 3, 3, 5003, 2201, 'care_4')
; 

SELECT 
	a1.species_name, a2.animalia_type,
	a3.class_type, a4.order_type, a5.habitat_type,
	a6.nutrition_type, a7.care_type
	FROM tbl_species a1
	INNER JOIN tbl_animalia a2 ON a2.animalia_id =a1.species_animalia
	INNER JOIN tbl_class a3 ON a3.class_id =a1.species_class
	INNER JOIN tbl_order a4 ON a4.order_id =a1.species_order
	INNER JOIN tbl_habitat a5 ON a5.habitat_id =a1.species_habitat
	INNER JOIN tbl_nutrition a6 ON a6.nutrition_id =a1.species_nutrition
	INNER JOIN tbl_care a7 ON a7.care_id =a1.species_care
	WHERE species_name = 'brown bear'
;

SELECT 
	a1.species_name, a2.habitat_type, a2.habitat_cost,
	a3.nutrition_type, a3.nutrition_cost
	FROM tbl_species a1
	INNER JOIN tbl_habitat a2 ON a2.habitat_id = a1.species_habitat
	INNER JOIN tbl_nutrition a3 ON a3.nutrition_id = a1.species_nutrition
	WHERE species_name = 'bat'
;

SELECT * FROM tbl_nutrition
INNER JOIN tbl_species ON tbl_species.species_nutrition = tbl_nutrition.nutrition_id;


-- Optionally, select data from tables to verify
SELECT * FROM tbl_animalia;
SELECT * FROM tbl_class;
SELECT * FROM tbl_order;
SELECT * FROM tbl_nutrition;
SELECT * FROM tbl_habitat;
SELECT * FROM tbl_specialist;
SELECT * FROM tbl_care;
SELECT * FROM tbl_species;
