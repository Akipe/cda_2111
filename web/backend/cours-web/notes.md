Cours web
=========

# Node

## Présentation
Détourner le langage JS en langage server. Le moteur JS dans Node est le même que celui de Chromium : V8.

Electron, framework pour application desktop, tourne sous electron.

Patterne MVC : Modèle Vue Controlleur.

## Initier une application
Modules sont géré par https://www.npmjs.com/ et npm. Npm permet de gérer les dépendances Nodes

Initialiser une application :
```bash
npm init
```
Un fichier `package.json` sera générer et contient la description et la liste des dépendances de notre application.

```bash
npm install NOM_MODULE
```

Il ne faut pas enregistrer auprès de Git les modules du projet (dans le dossier node_modules). Il suffira de lancer la commande `npm install`.

Pour ce faire on créer un fichier .gitignore :
```gitignore
node_modules # On ne prend pas en charge le dossier
```

Démarrer une application :
```bash
node app.js
```

On peut définir des commandes node dans notre manifeste, à la section "scripts" :
```json
"scripts": {
    "start": "node app",
    "test": "echo \"Error: no test specified\" && exit 1"
  },
```
On peut ensuite executer la commande :
```bash
npm run start # Exécute la commande "node app"
```

## Nodemon
Permet de surveiller un projet node pour le relancer en cas de modification du code source.

```bash
npm install -g nodemon

nodemon app.js # au lieu de "node app.js"
```

# Express

## Présentation

Bibliothéque JS qui permet de créer un serveur web.

Documentation officiel : [http://expressjs.com/](http://expressjs.com/)

## Installation
```bash
npm install express
```

Exemple de base :
```js
const express = require('express')
const app = express()
const port = 3000

app.get('/', (req, res) => {
  res.send('Hello World!')
})

app.listen(port, () => {
  console.log(`Example app listening on port ${port}`)
})
```

## Importation / Exportations
Similaire aux using en C# :

```js
const express = require('express') //Pour les applications
// ou pour les modules :
import express from 'express' // Uniquement pour les modules node, PAS les applications
```

## Commandes

### Générer le projet

```bash
npx express-generator
# Ou
npm install -g express-generator
express
# avec pug
express --view=pug myapp
```

```bash
npm install
```

```bash
# MacOS et Linux
DEBUG=myapp:* npm start
# Windows CMD
set DEBUG=myapp:* & npm start
# Windows Powershell
$env:DEBUG='myapp:*'; npm start

```

Express utilise son propre serveur web :

```js
// app.listen : on va "écouter" sur un port (3000)
app.listen(3000, () => {
    // ...
})
```

## Gérer des pages

```js
app.get('/route', (req, res) => {
    res.send('A propos')
})
```

Les marqueurs de route commences par `:` : `:name`.
```js
app.get('/hello/:name/edit/:id', (req, res) => {
    let name = req.params.name // req.params.name récupére ':name'
    let id = req.params.id // req.params.id récupére ':id'
})
```


## Verbes HTTP

Tableau : get et post

Valeurs simple : get post put delete


### Get
Récupérer une page ou en API un élément.

```js
// req : requette, créer par express avec toutes infos de la requette
// res : response, réponse à la requette
// next : pour un enchainement de requettes
app.get('/', (req, res) => {

})
```
### Post
Formulaire et ajout d'un éléments en API

### Put
API : mettre à jour

**patch** : mettre à jour certains éléments d'un document : on envoie que les éléments à changer

**put** : servait à remplacer un document par un autre : on envoit donc toutes les données dans le put, notamment les éléments non modifiés

### Delete
API : supprimer un élément

## Bodyparser
Module Nodejs qui permet d'analyser le corp d'une requete, quel que soit le verbe utilisé.

```bash
npm install body-parser
```

## Middlewares

Pour chacune de mes routes, j'aimerai afficher le chemin dans le terminal : utilisation d'un middleware.

bout de code qui s'executeront à un événement défini, par exemple sur expressjs par rapport aux routes.

Elle s'executeront selon le contexte.

Associé à un chemin : executer uniquement sur le chemin
Non associé : executer sur toutes les routes.

Il est important de définir les middlewares avant la définition des pages, car elle seront executé avant.

```js
app.use((req, res, next) => { // Création du middleware
    
    next() // Tu passe à la fonction middleware suivante ou à la route
})
```

## Routeur

Il doit mettre en relation un chemin (url) du site avec un controlleur.

Possible de les définir dans un autre fichier pour une meilleures organisation, dans une dossier "/routes/index.js" et en plusieurs fichiers.

```js
// /routes/index.js
const express = require("express")
const router = express.Router() // On récupére le routeur d'express

router.get('/', (request, response) => {
    response.send("Accueil") // On envoie le contenu de la réponse
                             // c'est à dire la page à afficher
})

router.get('/about', (req, res) => {
    res.send('A propos')
})

// sur l'entrée :name sera appliqué la fonction "trim"
router.get('/hello/:name', (req, res) => {
    let name = req.params.name // On récupére le marqueur "name" de la route
    res.send(`Hello ${name} !`)
})


/* première posibilité */
// dans /app.js
require('./routes') // Si index.js
// similaire à
require('./routes/index.js')

/* deuxième posibilité */

// dans /routes/index.js
module.exports = router

// dans /app.js
const router = require('./routes')


/* ensuite on indique vouloir utiliser les routes*/
app.use('/' router) // "/" correspond au chemin sur lequel on appliques les routes
```

Définir une route par défaut : il faut la spécifier après toutes les autres routes.
```js
router.all('', (req, resp) => {}) // Possibilité de mettre des Regex et des jockers
router.all('*', (req, res) => {
    res.status(404).send("Erreur 404: page non trouvé")
})
```

### Fichiers statiques
Il faut indiquer quels fichiers statiques on autorise avec Express.

```js
app.use('/public', express.static(__dirname + '/public'))
// premier argument correspond au chemin URL virtuel sur lequel on souhaite définir l'accés aux ressources
// __dirname correspond au chemin du fichier actuelle
// on rajoute le dossier contenant les ressources
```

## Controlleurs

Il met en relation les données avec les vues.

C'est le code qui prend en charge la requette et la réponse aproprié : "Un chemin améne à une fonction".

Ils ne contiennent que des fonctions de rappelles.

On suffixe les contolleurs par "Controller", ex: "homeController.js"

Utilisable avec les classes ou en mode Nodejs :
```js
// Orienté classe, utilisable dans d'autre contexte

class HomeController {

    index(req, res) {
        res.send("Accueil du controlleur")
    }
}

module.exports = new HomeController(); 
```

```js
// Utilisable uniquement en Nodejs

exports.index = (req, res) => {
    res.send("Accueil du controlleur")
}
```

## Base de données

Modèles : c'est un objet métier d'intérét, qui a de l'importance dans l'application.

Un modèle correspond à une table dans notre base de donnée. On fera le lien entre le modèle et la base de donnée

En MVC :  
DAO (classe d'accés aux données), les repository et les modèles.

La récupération des données de la BDD se réalise à partir des controlleurs, qui appélent des classes repository qui réalisent des crud dans la BDD.

### SQLite
Pour utiliser SQLlite avec nodejs :
```bash
npm install sqlite3
```

https://www.npmjs.com/package/sqlite3

```js
// Fichier qui va charger la base de donnée SQLite
const path = require("path")
const sqlite3 = require('sqlite3')

const databasePath = path.join(__dirname, "data", "vote.db")

const database = new sqlite3.Database(databasePath, (err) => {
    if (err) {
        return console.error(`Erreur SQL : ${err}`)
    }
    console.log("Base de données connectée")
})

module.exports = database

```

### Repository

Il gére l'interraction à la BDD d'une entité.

Un repository par table, qui s'occupe du crud de la table. On aura un repository par table.

Il existe des couches d'absctraction car les repository sont très similaires, on peut donc les simplifier (à voir prochainement).

On défini également les requêtes spécifique dans le repository (exemple : récupérer les nom commençant par une certaine lettre, etc).

Plusieurs variant de nommage des methodes :
- create
- get / select
- (get / select) all
- put
- delete

Lors d'un appel à la base de donnée, JS risque de se bloqué car il n'est pas multitache, il faut donc créer une fonction asynchrone qui permet de ne pas bloquer le reste de l'application.

On utilise les promesses : on ne sait pas quand la réponse se termine et si elle se réalisera correctement.

Classe DAO : Direct Access Object : à préciser.

```js
// candidatesRepository.js

// On importe les données de la BDD
const database = require('./index')

exports.getAll = () => {
    return new Promise((resolve, reject) => {
        database.all(
            "SELECT id, lastname, firstname, slogan FROM candidates", // Requete SQL
            [], // Parametres pour la requete SQL
            (err, rows) => { // Fonction exécuté lors du traitement
                if (err) {
                    console.error('Erreur SQL : ' + err)
                    reject(err)
                } else {
                    resolve(rows)
                }
            }
        )
    })
}

exports.getById = (id) => {
    database.all(
        "SELECT id, lastname, firstname, slogan FROM candidates WHERE id=?", // Requete SQL
        [id], // Parametres pour la requete SQL
        (err, rows) => { // Fonction exécuté lors du traitement
            if (err) {
                console.error('Erreur SQL : ' + err)
                reject(err)
            } else {
                resolve(rows)
            }
        }
    )
}

exports.create = (model) => {}

exports.update = (model) => {}

exports.delete = (id) => {}

```

Pour les requetes préparé en SQLite 3 :
```js
database.all(
    "SELECT id, lastname, firstname, slogan FROM candidates WHERE id=?", // id=? récupére l'id dans les paramètres
    [id], // Parametres envoyé à la requete SQL
    (err, row) => { // Fonction de traitement

    }
)
```

## ORM

Object relation mapper.

Sur nodejs, le plus connu est Sequelize [https://sequelize.org/](https://sequelize.org/).

## Les vue

### LiquidJS
[https://liquidjs.com/](https://liquidjs.com/)

```bash
npm install liquidjs
```

```js
const { Liquid } = require('liquidjs')
const path = require('path')

const viewPath = path.join(__dirname, '../', 'view')

const viewEngine = new Liquid({
    root: viewPath, // Répértoire où chercher les vues
    extname: '.html'
})

// Sans l'application
//module.exports = viewEngine

// Avec l'application
// pour avoir accés à l'instance d'ExpressJS
module.exports = (app) => {
    // Créer l'instance de l'app de gestion de vue
    const viewEngine = new Liquid({
        root: viewPath, // Répértoire où chercher les vues
        extname: '.html' // Nos fichier liquidjs auront l'extension .html (coté liquijs)
    })
    
    // On précise à ExpressJS qu'il faudra executer viewEngine (liquidjs) pour les fichier .html
    app.engine('html', viewEngine)
    // Le moteur de vue principal sera celui défini pour les fichiers d'extension .html
    app.set('view engine', 'html')
}
```

## Postman

Outil pour tester les requetes vers les API.
[https://www.postman.com/downloads/?utm_source=postman-home](https://www.postman.com/downloads/?utm_source=postman-home)

## Autre
Pour définir une valeur par défaut en JS :
```js
let name = variable_maybe_null ?? "toto"
```

L'utilisation des `use` de express sont insensible à l'ordre.

__dirname : correspond au repertoire du fichier actuelle.

Si on ne termine pas les requetes (avec `res.end()`) le navigateur attendra la fin de la requete. 

### Trim
Supprime les espaces en début et fin de chaine de caractère.

### Destructuration
```js
const { id } = req.params
// similaire à
const id = req.params.id

const { id, name } = req.params
// ==
const id = req.params.id
const name = req.params.name
```


## Générateur de base express

# Node

## import/ exportation

### Fonction
```js
exports.functionA = () => {}
exports.functionB = (id) => {}
exports.functionC = (model) => {}
// ==
module.exports = {
    functionA(id) {

    },

    functionB(model) {

    },

    functionC() {

    }
}
```
### Class

```js
class Test {}

// Export de la classe
module.exports = Test;
// Export d'une instance
module.exports = new Test();
```

### Importation
```js
require('./mon/fichier')
let parametre
require('./mon/fichier')(parametre)
```


# TLDR

## Arborescence
```
app/
    controllers/                    # Controleurs
        ...
    db/                             # Base de données
        data/                       # Stockage de la base de donnée
            example.db              # ex: sqlite
        candidatesRepository.js     # Repository de l'entité
        index.js                    # Chargement de la base de donnée
    node_modules/                   # Ensemble des bibliothèques externes
    public/                         # Fichiers statiques
        assets/
            css/
            js/
            ...
    routes/                         # Ensemble de la configuration des routes
        index.js
        ...
    app.js                          # Point d'entrée de notre site
    package-lock.json
    package.json                    # Configuration de notre site
```

```bash
npm install express-generator -g
express
npm install
```

Avec typescript

```bash
npm install --save-dev typescript
npm install -save-dev @types/express
```