database = require('./index')

class BaseRepository
{
    // #id; // Exemple d'attribut privé

    /**
     * 
     * @param {sqlite3.Database} _database 
     */
    constructor(_database)
    {
        // this.#id = 1 // Exemple d'utilisation d'attribut privé
        this.database = _database
    }

    /**
     * Execute une requete de lecture et retourne le jeu de résultats sous forme de tableau
     * @param {String} _sql la requête SQL
     * @param {Array} _params le tableau des paramètres de la requête SQL
     * @returns 
     */
    getAll(_sql, _params = [])
    {
        return new Promise((resolve, reject) => {
            this.database.all(
                _sql,
                _params,
                (err, result) => {
                    if (err) {
                        console.error('Erreur SQL : ' + err)
                        reject(err)
                    } else {
                        resolve(result)
                    }
                }
            )
        })
    }

    /**
     * 
     * @param {*} _sql 
     * @param {*} _params 
     * @returns 
     */
    getOne(_sql, _params = [])
    {
        return new Promise((resolve, reject) => {
            this.database.get(
                _sql,
                _params,
                (err, result) => {
                    console.log(result)
                    console.log(err)
                    if (err) {
                        console.error('Erreur SQL : ' + err)
                        reject(err)
                    } else {
                        resolve(result)
                    }
                }
            )
        })
    }

    execute(_sql, _params)
    {
        return new Promise((resolve, reject) => {
            this.database.run(
                _sql,
                _params,
                (err, result) => {
                    if (err) {
                        console.error('Erreur SQL : ' + err)
                        reject(false)
                    } else {
                        resolve(true)
                    }
                }
                /*
                    récuperer valeur sans callback
                */
            )
        })
    }
}

module.exports = new BaseRepository(database)
