const { Liquid } = require('liquidjs')
const path = require('path')
//viens on fout le bordel ici

const viewPath = path.join(__dirname, '../', 'views')

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
    app.engine('html', viewEngine.express())
    // Le moteur de vue principal sera celui défini pour les fichiers d'extension .html
    app.set('view engine', 'html')
    // coucou
    //tu fais quoi ici
    // slt BB
}
