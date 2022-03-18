#!/usr/bin/env node
'use strict';

let username = process.argv[2]; // Récupérant le premier argument (nommé "username") lors de l'execution du script

if (!username) { // Si l'argument n'est pas spécifié, on va généré une erreur
    let appName = process.argv[1].split(require('path').sep).pop();
    console.error('Missing argument! Example: %s YOUR_NAME', appName);
    process.exit(1);
}

// Si l'argument a bien été spécifié :
console.log('Salut %s !', username); // On affiche le message de bienvenu avec l'argument
