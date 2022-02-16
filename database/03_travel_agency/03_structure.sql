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
);

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

CREATE TABLE propose (
    trip_code INT NOT NULL,
    theme_code INT NOT NULL,
    CONSTRAINT PK_propose_id PRIMARY KEY (trip_code, theme_code),
    CONSTRAINT FK_propose_trip_code FOREIGN KEY (trip_code) REFERENCES trips(trip_code),
    CONSTRAINT FK_propose_theme_code FOREIGN KEY (theme_code) REFERENCES themes(theme_code)
)

CREATE TABLE benefits (
    benefit_code INT IDENTITY(1,1),
    benefit_name VARCHAR(32) NOT NULL,
    benefit_description VARCHAR(max) NULL,
    benefit_score TINYINT NOT NULL,
    benefit_commentary VARCHAR(255) NULL,
    CONSTRAINT PK_benefits_benefit_code PRIMARY KEY (benefit_code)
);

CREATE TABLE provide (
    trip_code INT NOT NULL,
    benefit_code INT NOT NULL,
    CONSTRAINT PK_provide_id PRIMARY KEY (trip_code, benefit_code),
    CONSTRAINT FK_provide_trip_code FOREIGN KEY (trip_code) REFERENCES trips(trip_code),
    CONSTRAINT FK_benefit_code FOREIGN KEY (benefit_code) REFERENCES benefits(benefit_code)
);

CREATE TABLE sales_people (
    com_code CHAR(5) NOT NULL,
    com_name VARCHAR(64) NOT NULL,
    com_password VARCHAR(60) NOT NULL,
    com_code_substitute CHAR(5) NULL,
    CONSTRAINT PK_sales_people_com_code PRIMARY KEY (com_code),
    CONSTRAINT FK_sales_people_com_code_substitute FOREIGN KEY (com_code_substitute) REFERENCES sales_people(com_code)
);

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
);


CREATE TABLE book (
    client_id INT NOT NULL,
    trip_code INT NOT NULL,
    order_quantity TINYINT NOT NULL,
    order_paid BIT NOT NULL DEFAULT 0,
    CONSTRAINT PK_books_ids PRIMARY KEY (client_id, trip_code),
    CONSTRAINT FK_books_client_id FOREIGN KEY (client_id) REFERENCES clients(client_id),
    CONSTRAINT FK_books_trip_code FOREIGN KEY (trip_code) REFERENCES trips(trip_code)
);


-- affichage des tables

SELECT * FROM provide;
SELECT * FROM book;
SELECT * FROM propose;
SELECT * FROM transit;
SELECT * FROM trips;
SELECT * FROM cities;
SELECT * FROM countries;
SELECT * FROM clients;
SELECT * FROM sales_people;
SELECT * FROM themes;
SELECT * FROM benefits;
