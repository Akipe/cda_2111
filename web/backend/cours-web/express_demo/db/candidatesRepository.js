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

exports.create = (model) => {

}

exports.update = (model) => {

}

exports.delete = (id) => {

}
