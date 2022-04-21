const express = require("express")
const router = express.Router() // On récupére le routeur d'express

//const controllerPath = "../controllers"
const homeController = require(`../controllers/homeController`)
const errorController = require(`../controllers/errorController`)
const apiController = require(`../controllers/apiController`)
const candidateController = require(`../controllers/candidateController`)

router.get('/', homeController.index)
router.get('/about', homeController.about)
router.get('/hello/:name', homeController.helloName)



router.get('/candidates/:id', candidateController.getById)
router.put('/candidates/:id', candidateController.update)
router.delete('/candidates/:id', candidateController.remove)

router.get('/candidates', candidateController.index)
router.post('/candidates', candidateController.add)



router.get('/api', apiController.index)
router.post('/api', apiController.add)

router.get('/api/:id', apiController.getById)
router.put('/api/:id', apiController.update)
router.delete('/api/:id', apiController.remove)



router.all('*', errorController.error404)

module.exports = router
