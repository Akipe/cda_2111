import { Database } from "sqlite3";
import { localdb as defaultDatabase } from "./localdb"

export class CommonRepository {
    protected database: Database

    constructor(_database = defaultDatabase)
    {
        this.database = _database
    }

    public getAll(_sql: string, _params: Array<string> = []): Promise<Array<any>>
    {
        return new Promise((resolve, reject) => {
            this.database.all(
                _sql,
                _params,
                (error: any, result: any) => {
                    if (error) {
                        console.log(`Database error : ${error}`)
                        reject(error)
                    } else {
                        resolve(result)
                    }
                }
            )
        })
    }

    public async getOne(_sql: string, _params: Array<string>): Promise<any>
    {
        return new Promise((resolve, reject) => {
            this.database.get(
                _sql,
                _params,
                (error: any, result: any) => {
                    if (error) {
                        console.log(`Database error : ${error}`)
                        reject(error)
                    } else {
                        resolve(result)
                    }
                }
            )
        })
    }

    public async execute(_sql: string, _params: Array<string>): Promise<any>
    {
        return new Promise((resolve, reject) => {
            this.database.run(
                _sql,
                _params,
                (error: any, result: any) => {
                    if (error) {
                        console.log(`Database error : ${error}`)
                        reject(error)
                    } else {
                        resolve(result)
                    }
                }
            )
        })
    }
}

export const commonRepository = new CommonRepository()
