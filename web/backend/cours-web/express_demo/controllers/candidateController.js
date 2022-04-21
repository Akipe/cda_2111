/*
    index   Lister les candidats (accueil du controlleur)
    getById Afficher les détailles d'un candidat
    add     Ajouter un candidat
    update  Modifier un candidat existant
    remove  Supprimer un candidat existant
*/

const repository = require('../db/candidatesRepository')

module.exports = {
    async index(req, res) {
        // Si sous répertoir
        // res.render('dossier/index')

        try {
            let result = await repository.getAll()
            res.render(
                'candidat/index',
                {
                    model: result,
                    title: "Liste des candidats"
                }
            )
        } catch (err) {
            res.status(500).end()
        }
    },

    async getById(req, res) {
        const { id } = req.params

        try {
            let result = await repository.getById(id)

            console.log(result)
            if (result === undefined) {
                res.status(404)
                res.render(
                    'candidat/notFound',
                    {
                        candidat_id: id,
                    }
                )
            } else {
                res.render(
                    'candidat/showById',
                    {
                        model: result
                    }
                )
            }
        } catch (err) {
            res.status(500).end()
        }
    },

    add(req, res) {

    },

    update(req, res) {

    },

    remove(req, res) {

    }
}