// La logique de d'interargir à la BDD reste dans le repository
const database = require('../db');
const CandidatesRepository = require('../db/CandidatesRepository')

let candidatesRepository = new CandidatesRepository()

// Le controlleur : il met en relation les données avec les vues

exports.index = (req, res) => {

    /* similaire au block suivant
    repository.getAll()
    .then(result => {
        res.json(result)
    }).catch((err) => {
        console.error(err)
    })*/

    try {
        let result = candidatesRepository.getAll()
        
        res.json(result);
        res.end(); // On est obliger de forcer la fin de la requete
    } catch(err) {
        console.error(err)
        res.status(500).end()
    }
}

exports.getById = (req, res) => {
    const { id } = req.params // Desctructuration

    try {
        let result = candidatesRepository.getById(id)

        if (result === undefined) {
            res.status(404)
            result = {error: "404"}
        }

        res.json(result)
        res.end();
    } catch (err) {
        console.error(err)
        res.status(500).end()
    }
}

exports.add = (req, res) => {
    console.log(req.body)
    // controle de saisie dans l'objet req.body
    const model = req.body // On vérifie et on formate de la bonne manière les données
    let result = candidatesRepository.create(model)
    res.json(result)
}

exports.update = (req, res) => {
    const { id } = req.params
    console.log(req.body)
    const model = req.body

    try {
        let result = candidatesRepository.update(id, model)

        //console.log(result.lastID)
        res.json({ done: true })
        res.status(201)
        res.end()
    } catch (err) {
        console.error(err)
        res.status(500).end()
    }
}

exports.remove = (req, res) => {
    const { id } = req.params
    
    try {
        let result = candidatesRepository.delete(id)

        if (result === undefined) {
            result = {error: "404"}
        }

        res.json(result)
        res.status(404)
        res.end()
    } catch (err) {
        console.error(err)
        res.status(500).end()
    }
}