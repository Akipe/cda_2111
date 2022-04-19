const path = require("path")
const sqlite3 = require('sqlite3')

const databasePath = path.join(__dirname, "data", "votes.db")

const database = new sqlite3.Database(databasePath, (err) => {
    if (err) {
        return console.error(`Erreur SQL : ${err}`)
    }
    console.log("Base de données connectée")
})

module.exports = database
