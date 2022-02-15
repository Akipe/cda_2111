Horses(**<ins>horses_registration_id<ins>**, **horse_birthday**, horse_breed, **horse_primary_color**, **horse_gender**, **horse_birth_location**);

People(**<ins>person_id<ins>**, **person_lastname**, person_firstname, **person_street**, person_city, **person_zipcode**);

care(**<ins>#horses_registration_id<ins>**, **<ins>#person_id<ins>**, **activity_name**, **activity_date**);


Companies(**<ins>company_siren<ins>**, **company_name**, ***#company_represent_id***);

is_part_of(**<ins>#person_id<ins>**, **<ins>#company_siren<ins>**);
