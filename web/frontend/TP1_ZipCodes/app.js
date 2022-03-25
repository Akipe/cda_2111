const url_zipcode_api = 'https://raw.githubusercontent.com/ARFP/TP_WEB/serie_1/frontend-js/TP1_ZipCodes/zipcodes.json';
const zipcodes_datalist = document.querySelector('#zipcode-datalist');
const zipcodes_all_options = document.createDocumentFragment();
const zipcode_info_element = document.createDocumentFragment();
const zipcode_ask_info = document.querySelector('#zipcode-ask_info');
const zipcode_user_choice = document.querySelector('#zipcode-user_choice');
const zipcode_show_info_zone = document.querySelector('#zipcode-show_info');

function appendZipCodeSuggestion(_api_json_zipcode, _datalist_element, _all_options_element) {
    for (let zipcode of _api_json_zipcode)
    {
        let zipcodes_option = document.createElement('option');

        // On configure la balise avec les références du code postal
        zipcodes_option.innerHTML = zipcode.nomCommune;
        zipcodes_option.value = zipcode.codePostal;

        // On intégre l'option à la liste
        _all_options_element.appendChild(zipcodes_option);
    }

    // Enfin, on ajoute l'ensemble des options dans la balise datalist
    _datalist_element.appendChild(_all_options_element);
}

function showInformationsAboutZipCode(zipcode, _information_element)
{
    let element_code_postal = document.getElementById("zipcode-show_info_codePostal");
    element_code_postal.innerHTML  = zipcode.codePostal;

    let element_code_commune = document.getElementById("zipcode-show_info_codeCommune");
    element_code_commune.innerHTML  = zipcode.codeCommune;

    let element_nom_commune = document.getElementById("zipcode-show_info_nomCommune");
    element_nom_commune.innerHTML  = zipcode.nomCommune;

    let element_libelle_acheminement = document.getElementById("zipcode-show_info_libelleAcheminement");
    element_libelle_acheminement.innerHTML  = zipcode.libelleAcheminement;

    _information_element.style.visibility = 'visible';
}

function hideInformationsAboutZipCode(_information_element)
{
    _information_element.style.visibility = 'hidden';
}

let all_json_zipcode;

fetch(url_zipcode_api) // On récupére la ressource avec une requête
    .then((response) => { // On selectionne le JSON
        return response.json();
    })
    .then((json_zipcodes) => { // On traite le JSON
        all_json_zipcode = json_zipcodes;

        appendZipCodeSuggestion(json_zipcodes, zipcodes_datalist, zipcodes_all_options)
    })
    .catch((error) => { // On gére les erreurs
        console.log(`Error : ${error}`);
    });

let zipcode_found = false;

zipcode_ask_info.addEventListener("click", function() {
    if (zipcode_user_choice.value) {
        for (let zipcode of all_json_zipcode) {
            if (zipcode.codePostal == zipcode_user_choice.value)
            {
                showInformationsAboutZipCode(zipcodes_all_options);
                zipcode_found = true;
            }
        }
        if (!zipcode_found)
        {
            hideInformationsAboutZipCode(zipcodes_all_options);
            console.log("City not found");
        }
        zipcode_found = false;
    }
});