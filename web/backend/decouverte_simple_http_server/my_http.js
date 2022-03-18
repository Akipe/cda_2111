const http = require('http');

// On va créer un serveur http qui va recevoir les requêtes web
http.createServer((request, response) => {

    // On défini le header de la requête
    response.writeHead(200, {
        'Content-Type': 'text/plain'
    });

    // On défini ensuite le contenu de la page
    response.write('Bravo! Tu es sur un serveur http nodejs. \n');

    // On termine la page
    response.end();
}).listen(7777); // On spécifie sur quel port le serveur http sera executé
