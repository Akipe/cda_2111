const express = require("express")
const router = express.Router() // On récupére le routeur d'express
const { validationResult } = require('express-validator')
const path = require("path")

//const controllerPath = "../controllers"
const homeController = require(`../controllers/homeController`)
const errorController = require(`../controllers/errorController`)
const apiController = require(`../controllers/apiController`)
const CandidateController = require(`../controllers/CandidateController`)
const candidateValidator = require('../form/candidateValidator')
//console.log(candidateValidator)

let candidateController = new CandidateController()


router.get('/', homeController.index)
router.get('/about', homeController.about)
router.get('/hello/:name', homeController.helloName)



router.get('/candidates/edit/:id', candidateController.update.bind(candidateController))
router.post('/candidates/edit/:id', candidateValidator, candidateController.updatePost.bind(candidateController))
router.get('/candidates/delete/:id', candidateController.remove.bind(candidateController))
router.post('/candidates/delete/:id', candidateValidator, candidateController.removePost.bind(candidateController))
router.get('/candidates/add', candidateController.add.bind(candidateController))
router.post('/candidates/add', candidateValidator, candidateController.addPost.bind(candidateController))
router.get('/candidates/:id', candidateController.getById.bind(candidateController))
router.get('/candidates', candidateController.listAll.bind(candidateController))



router.get('/api', apiController.index)
router.post('/api', apiController.add)

router.get('/api/:id', apiController.getById)
router.put('/api/:id', apiController.update)
router.delete('/api/:id', apiController.remove)

const staticPath = path.join(__dirname, '../', 'public')
router.use('/public', express.static(staticPath))

router.all('*', errorController.error404)

module.exports = router
