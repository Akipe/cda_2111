const url_zipcode_api = 'https://raw.githubusercontent.com/ARFP/TP_WEB/serie_1/frontend-js/TP1_ZipCodes/zipcodes.json';
const zipcodes_datalist = document.querySelector('#zipcode_list');
const zipcodes_all_options = document.createDocumentFragment();

fetch(url_zipcode_api) // On récupére la ressource avec une requête
    .then((response) => { // On selectionne le JSON
        return response.json();
    })
    .then((json_zipcodes) => { // On traite le JSON
        json_zipcodes.map((zipcode) => { // Pour chacun des codes postaux
            // On créer la balise option
            let zipcodes_option = document.createElement('option');

            // On configure la balise avec les références du code postal
            zipcodes_option.innerHTML = `${zipcode.nomCommune}`;
            zipcodes_option.value = `${zipcode.codePostal}`;

            // On intégre l'option à la liste
            zipcodes_all_options.appendChild(zipcodes_option);
        });

        // Enfin, on ajoute l'ensemble des options dans la balise datalist
        zipcodes_datalist.appendChild(zipcodes_all_options);
    })
    .catch((error) => { // On gére les erreurs
        console.log(`Error : ${error}`);
    });
