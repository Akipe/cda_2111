import { Database } from "sqlite3";
import { database as defaultDatabase } from "./database.sqlite"

/*interface RepositoryDatabaseCallbackType {
    (this: Statement, err: Error | null, row: any): void;
}

interface RepositorySqlRequestType {
    (_sql: string, _params: Array<string>, _callback?: RepositoryDatabaseCallbackType): Database
}*/

export class BaseRepository {
    //private database: Database

    /*constructor()
    {
        this.database = defaultDatabase
    }*/

    public getAll(_sql: any, _params: any = []): Promise<any>
    {
        /*return await this.sqlRequest(
            this.database.all,
            _sql,
            _params
        )*/

        return new Promise((resolve, reject) => {
            defaultDatabase.all(
                _sql,
                _params,
                /*(error: any, result: any) => {
                    if (error) {
                        console.log(`Database error : ${error}`)
                        reject(error)
                    } else {
                        resolve(result)
                    }
                }*/
            )
        })
    }

    /*public async getOne(_sql: string, _params: Array<string>): Promise<Database>
    {
        return await this.sqlRequest(
            this.database.get,
            _sql,
            _params
        )
    }

    public async execute(_sql: string, _params: Array<string>): Promise<Database>
    {
        return await this.sqlRequest(
            this.database.run,
            _sql,
            _params
        )
    }

    private sqlRequest(
        sqliteAction: RepositorySqlRequestType,
        sql: string,
        parameters: Array<string>,
        callback?: | RepositoryDatabaseCallbackType
    ): Promise<any>
    {
        return new Promise((resolve, reject) => {
            sqliteAction(
                sql,
                parameters,
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
    }*/
}
