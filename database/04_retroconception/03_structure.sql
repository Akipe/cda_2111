IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'db_horses_courses')
    BEGIN
        CREATE DATABASE [db_horses_courses];
    END
GO

DROP TABLE IF EXISTS care;
DROP TABLE IF EXISTS Horses;
DROP TABLE IF EXISTS is_part_of;
DROP TABLE IF EXISTS represent;
DROP TABLE IF EXISTS People;
DROP TABLE IF EXISTS Compagnies;

CREATE TABLE Horses(
    horse_registration_id INT UNIQUE NOT NULL,
    horse_birthday DATE NOT NULL,
    horse_breed VARCHAR(20) NULL,
    horse_primary_color VARCHAR(10) NOT NULL,
    horse_gender CHAR(1) NOT NULL,
    horse_birth_location VARCHAR(20) NOT NULL,
    CONSTRAINT PK_Horses_horse_registration_id PRIMARY KEY (horse_registration_id)
);

CREATE TABLE People(
    person_id INT IDENTITY,
    person_lastname VARCHAR(32) NOT NULL,
    person_firstname VARCHAR(32) NULL,
    person_street VARCHAR(255) NOT NULL,
    person_city VARCHAR(32) NULL,
    person_zipcode VARCHAR(5) NOT NULL,
    CONSTRAINT PK_People_person_id PRIMARY KEY (person_id)
);

CREATE TABLE care(
    care_horse_registration_id INT UNIQUE NOT NULL,
    care_person_id INT UNIQUE NOT NULL,
    care_activity_name ENUM NOT NULL,
    care_activity_date DATE NOT NULL,

)
