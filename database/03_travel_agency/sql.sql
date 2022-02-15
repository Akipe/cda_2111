-- IF NOT EXISTS
-- (
-- 	SELECT name FROM master.dbo.sysdatabases
-- 	WHERE name = N'db_travel_agency'
-- )
-- CREATE DATABASE [db_travel_agency];

USE db_travel_agency;


-- suppression de la structure

DROP TABLE IF EXISTS provide;
DROP TABLE IF EXISTS book;
DROP TABLE IF EXISTS propose;
DROP TABLE IF EXISTS transit;
DROP TABLE IF EXISTS trips;
DROP TABLE IF EXISTS cities;
DROP TABLE IF EXISTS countries;
DROP TABLE IF EXISTS clients;
DROP TABLE IF EXISTS sales_people;
DROP TABLE IF EXISTS themes;
DROP TABLE IF EXISTS benefits;


-- creation de la structure

CREATE TABLE countries (
	country_code INT IDENTITY(1,1),
	country_name VARCHAR(128) NOT NULL,
	CONSTRAINT PK_countries_country_code PRIMARY KEY (country_code)
);

CREATE TABLE cities (
	city_code INT IDENTITY(1,1),
	city_name VARCHAR(128) NOT NULL,
	country_code INT NOT NULL,
	CONSTRAINT PK_cities_city_code PRIMARY KEY (city_code),
	CONSTRAINT FK_cities_country_code FOREIGN KEY (country_code) REFERENCES countries(country_code)
);

CREATE TABLE trips (
    trip_code INT IDENTITY(1,1),
    trip_title VARCHAR(128) NOT NULL,
    trip_available INT NOT NULL,
    trip_start DATETIME NOT NULL,
    trip_end DATETIME NOT NULL,
    trip_price DECIMAL(7,2) NOT NULL,
    trip_overview VARCHAR(max) NOT NULL,
    trip_description VARCHAR(max) NULL,
    CONSTRAINT PK_trips_trip_code PRIMARY KEY (trip_code)
)

CREATE TABLE transit (
	city_code INT NOT NULL,
	trip_code INT NOT NULL,
	step_start DATETIME NOT NULL,
	step_end DATETIME NOT NULL,
	CONSTRAINT PK_transit_id PRIMARY KEY (city_code, trip_code),
	CONSTRAINT FK_transit_city_code FOREIGN KEY (city_code) REFERENCES cities(city_code),
	CONSTRAINT FK_transit_trip_code FOREIGN KEY (trip_code) REFERENCES trips(trip_code)
)

CREATE TABLE themes (
    theme_code INT IDENTITY(1,1),
    theme_name VARCHAR(32) NOT NULL,
    theme_description VARCHAR(max) NULL,
    CONSTRAINT PK_themes_theme_code PRIMARY KEY (theme_code)
)

CREATE TABLE benefits (
    benefit_code INT IDENTITY(1,1),
    benefit_name VARCHAR(32) NOT NULL,
    benefit_description VARCHAR(max) NULL,
    benefit_score TINYINT NOT NULL,
    benefit_commentary VARCHAR(255) NULL,
    CONSTRAINT PK_benefits_benefit_code PRIMARY KEY (benefit_code)
)

CREATE TABLE provide (
    trip_code INT NOT NULL,
    benefit_code INT NOT NULL,
    CONSTRAINT PK_provide_id PRIMARY KEY (trip_code, benefit_code),
    CONSTRAINT FK_provide_trip_code FOREIGN KEY (trip_code) REFERENCES trips(trip_code),
    CONSTRAINT FK_benefit_code FOREIGN KEY (benefit_code) REFERENCES benefits(benefit_code)
)

CREATE TABLE sales_people (
    com_code CHAR(5) NOT NULL,
    com_name VARCHAR(64) NOT NULL,
    com_password VARCHAR(60) NOT NULL,
    com_code_substitute CHAR(5) NULL,
    CONSTRAINT PK_sales_people_com_code PRIMARY KEY (com_code),
    CONSTRAINT FK_sales_people_com_code_substitute FOREIGN KEY (com_code_substitute) REFERENCES sales_people(com_code)
)

CREATE TABLE clients (
    client_id INT IDENTITY(1,1),
    client_lastname VARCHAR(32) NOT NULL,
    client_firstname VARCHAR(32) NOT NULL,
    client_email VARCHAR(128) NOT NULL,
    client_phone CHAR(16) NOT NULL,
    client_added DATE NOT NULL,
    client_password VARCHAR(60) NOT NULL,
    com_code CHAR(5) NOT NULL,
    CONSTRAINT PK_clients_client_id PRIMARY KEY (client_id),
    CONSTRAINT FK_clients_com_code FOREIGN KEY (com_code) REFERENCES sales_people(com_code)
)


CREATE TABLE book (
    client_id INT NOT NULL,
    trip_code INT NOT NULL,
    order_quantity TINYINT NOT NULL,
    order_paid BIT NOT NULL DEFAULT 0,
    CONSTRAINT PK_books_ids PRIMARY KEY (client_id, trip_code),
    CONSTRAINT FK_books_client_id FOREIGN KEY (client_id) REFERENCES clients(client_id),
    CONSTRAINT FK_books_trip_code FOREIGN KEY (trip_code) REFERENCES trips(trip_code)
)


-- données

INSERT INTO countries(country_name) VALUES
	(N'France'),
	(N'Belgique');

INSERT INTO cities(city_name, country_code) VALUES
	(N'Paris', 1),
	(N'Marseille', 1);

INSERT INTO trips(
		trip_title,
		trip_available,
		trip_start,
		trip_end,
		trip_price,
		trip_overview,
		trip_description
	) VALUES (
		N'Cap Yolo',
		15,
		'2013-04-02 12:45:34',
		GETDATE(),
		750.12,
		N'Ce voyage est vraiment trop cool',
		N'Ce voyage vous fera décrouvrir des univers trop stylés B)'
	);

INSERT INTO transit(
		city_code,
		trip_code,
		step_start,
		step_end
	) VALUES (
		1,
		1,
		'2013-04-02 12:45:34',
		GETDATE()
	);

-- affichage des données

SELECT * FROM countries;
SELECT * FROM cities;
SELECT * FROM trips;
SELECT * FROM transit;
