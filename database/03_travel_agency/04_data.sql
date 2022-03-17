USE db_travel_agency;

-- données

INSERT INTO countries(country_name) VALUES
	(N'France'),
	(N'Belgique');

INSERT INTO cities(city_name, country_code) VALUES
	(N'Paris', (SELECT country_code FROM countries WHERE country_name = N'France')),
	(N'Marseille', (SELECT country_code FROM countries WHERE country_name = N'France'));

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

INSERT INTO themes(
		theme_name,
		theme_description
	) VALUES (
		(N'Montagne'),
		(N'Aller à la montagne pour prendre de la hauteur...')
	), (
		(N'Mer'),
		(N'Aller à la mer pour prendre le large...')
	);

INSERT INTO propose(
	trip_code,
	theme_code
	) VALUES (
		(SELECT trip_code FROM trips WHERE trip_title = N'Cap Yolo'),
		(SELECT theme_code FROM themes WHERE theme_name = N'Montagne')
	)

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
