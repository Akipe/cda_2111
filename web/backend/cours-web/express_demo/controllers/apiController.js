// La logique de d'interargir à la BDD reste dans le repository
const database = require('../db');
const repository = require('../db/candidatesRepository')

// Le controlleur : il met en relation les données avec les vues

exports.index = async (req, res) => {

    /* similaire au block suivant
    repository.getAll()
    .then(result => {
        res.json(result)
    }).catch((err) => {
        console.error(err)
    })*/

    try {
        let result = await repository.getAll()
        
        res.json(result);
        res.end(); // On est obliger de forcer la fin de la requete
    } catch(err) {
        console.error(err)
        res.status(500).end()
    }
}

exports.getById = async (req, res) => {
    const { id } = req.params // Desctructuration

    try {
        let result = await repository.getById(id)

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

exports.add = async (req, res) => {
    console.log(req.body)
    // controle de saisie dans l'objet req.body
    const model = req.body // On vérifie et on formate de la bonne manière les données
    let result = await repository.create(model)
    res.json(result)
}

exports.update = async (req, res) => {
    const { id } = req.params
    console.log(req.body)
    const model = req.body

    try {
        let result = await repository.update(id, model)

        //console.log(result.lastID)
        res.json({ done: true })
        res.status(201)
        res.end()
    } catch (err) {
        console.error(err)
        res.status(500).end()
    }
}

exports.remove = async (req, res) => {
    const { id } = req.params
    
    try {
        let result = await repository.delete(id)

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