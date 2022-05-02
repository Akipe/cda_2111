const express = require('express')
const bodyParser = require('body-parser')

/* Configuration */
const serverPort = '5000'

/* Instanciation de l'application */
const app = express()

/* Middleware */
require('./middlewares/log')(app)
require('./middlewares/bodyparser')(app)
require('./middlewares/liquid')(app)
require('./middlewares/cookie.js')(app)
require('./middlewares/csrf.js')(app)

/* Router */
const router = require('./routes/index.js')
app.use('/', router)

/* Lancement de l'application */
app.listen(serverPort, () => {
    console.log(`Serveur disponible sur http://localhost:${serverPort}`)
})
