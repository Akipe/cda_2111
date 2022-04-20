// On importe les données de la BDD
const database = require('./index')

exports.getAll = () => {
    return new Promise((resolve, reject) => {
        database.all( // Renvoit systèmatiquement un tableau
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
    return new Promise((resolve, reject) => {
        database.get( // renvoie une seul entrée
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
    })
}

exports.create = (model) => {
    return new Promise((resolve, reject) => {
        const sqlCommand = `INSERT INTO candidates (lastname, firstname, slogan) VALUES (?, ?, ?)`
        let sqlParams = [model.lastname, model.firstname, model.slogan]

        database.run(
            sqlCommand,
            sqlParams,
            function(err, result) {
                if (err) {
                    console.error('Erreur SQL : ' + err)
                    reject(false)
                } else {
                    // result contient le nombre de lignes insérés
                    resolve(this.lastID)
                }
            }
        )
    })
}

exports.update = (id, model) => {
    return new Promise((resolve, reject) => {
        const sqlCommand = `UPDATE candidates SET lastname=?, firstname=?, slogan=? WHERE id=?`
        console.log(model.lastname)
        let sqlParams = [model.lastname, model.firstname, model.slogan, id]

        database.run(sqlCommand, sqlParams, (err, result) => {
            if (err) {
                console.log('Erreur SQL : ' + err)
                reject(false)
            } else {
                resolve(true)
            }
        })
    })
}

exports.delete = (id) => {
    return new Promise((resolve, reject) => {
        database.run(
            'DELETE FROM candidates WHERE id=?',
            [id],
            (err, result) => {
                if (err) {
                    console.error('Erreur SQL : ' + err)
                    reject(false)
                } else {
                    // result contient le nombre de lignes insérés
                    console.log(database)
                    resolve(true)
                }
            }
        )
    })
}
