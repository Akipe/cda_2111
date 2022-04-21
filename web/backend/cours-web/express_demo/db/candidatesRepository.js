// On importe les données de la BDD
const database = require('./index')
let repo = require('./baseRepository')

exports.getAll = async () => {
    return await repo.getAll(
        "SELECT id, lastname, firstname, slogan FROM candidates"
    )

    //console.log(test)
    //return test
}

exports.getCandidasA = () => {
    return repo.getAll(
        "SELECT id, lastname, firstname, slogan FROM candidates WHERE lastname LIKE ?",
        ['%a']
    )
}

exports.getById = (id) => {
    return repo.getOne(
        "SELECT id, lastname, firstname, slogan FROM candidates WHERE id=?",
        [id]
    )
}

exports.create = (model) => {
    return new Promise((resolve, reject) => {
        const sql = `INSERT INTO candidates (lastname, firstname, slogan) VALUES (?, ?, ?)`
        let params = [model.lastname, model.firstname, model.slogan]

        return repo.execute(sql, params)
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
