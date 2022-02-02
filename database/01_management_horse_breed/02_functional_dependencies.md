Cas Horses - functional dependencies
========

## Simple
**registration_id** -> horse_birthday, horse_breed, horse_primary_color, horse_gender, horse_birth_location
**person_id** -> person_lastname, person_firstname, person_street, person_zipcode, person_job_name
**company_siren_number** -> company_name

## Compound
**horse_registration_id, person_id, company_siren_number** -> activity_name , activity _date
