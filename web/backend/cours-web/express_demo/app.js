const serverPort = '3000'

// Importation de la bibliothèque express
const express = require('express')
const bodyParser = require('body-parser')

// Création de l'instance de notre application
const app = express()

// body-parser : analyser le contenu d'une requete
app.use(bodyParser.urlencoded())
//app.use(bodyParser.json())

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

require('./middlewares/liquid')(app)

app.use('/', router)

app.listen(serverPort, () => {
    console.log(`Serveur disponible sur http://localhost:${serverPort}`)
})
