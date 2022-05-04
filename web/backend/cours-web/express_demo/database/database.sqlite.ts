import { Database } from 'sqlite3'
import path from 'path'
import process from 'process'

/*const databasePath = path.join(
    process.cwd(),
    "vars",
    "database.db"
)*/

export const database = new Database(path.join(
    process.cwd(),
    "vars",
    "database.db"
)/*, (err) => {
    if (err) {
        return console.error(`Error to load database : ${err}`)
    } else {
        console.log('Database loaded.')
        return (err)
    }
}*/)
