import { Database } from 'sqlite3'
import path from 'path'
import process from 'process'

const databasePath = path.join(
    process.cwd(),
    "vars",
    "database.db"
)

console.log(databasePath)

export const localdb = new Database(databasePath, (err) => {
    if (err) {
        return console.error(`Error to load database : ${err}`)
    } else {
        console.log('Database loaded.')
        return (err)
    }
})
