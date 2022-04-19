const express = require("express")
const router = express.Router() // On récupére le routeur d'express

const controllerPath = "../controllers/"
const homeController = require(controllerPath + "homeController")
const errorController = require(controllerPath + "errorController")
const apiController = require(controllerPath + "apiController")

router.get('/', homeController.index)
router.get('/about', homeController.about)
router.get('/hello/:name', homeController.helloName)
router.get('/api', apiController.index)

router.all('*', errorController.error404)

module.exports = router
