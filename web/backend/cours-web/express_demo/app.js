// Importation de la bibliothèque express
const express = require('express')

// Création de l'instance de notre application
const app = express()

// Middleware qui affiche dans la 
// ! importance de l'ordre de définition des methodes
// toujours mettre les middleware avant
app.use((req, res, next) => {
    // Récupération de la route
    let method = req.method
    let path = req.originalUrl
    console.log(`${method} ${path}`)
    next() // Tu passe à la fonction middleware suivante ou à la route
})

const router = require('./routes')

// Ressources web statiques
app.use('/public', express.static(__dirname + '/public'))

app.use('/', router)

app.listen(3000, () => {
    console.log("Serveur disponible sur http://localhost:3000")
})
