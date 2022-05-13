import { BaseRepository } from "./BaseRepository";
import { User } from "./User"

export class UserRepository extends BaseRepository
{
    constructor()
    {
        super("users")
    }

    public async getAll(): Promise<Array<User>|null>
    {
        try {
            let arrayUsers: Array<User> = []
            let arrayRawResult = await this.repository.getAll(
                `SELECT id, name, password, quote FROM ${this.table}`
            )

            if (arrayRawResult === undefined) {
                return null
            }

            arrayRawResult.forEach((userRaw) => {
                arrayUsers.push(new User(
                    userRaw.name,
                    userRaw.password,
                    userRaw.quote,
                    userRaw.id
                ))
            })

            return arrayUsers
        } catch (error) {
            console.error(`Error to retrieve all users : ${error}`)
            return null
        }
    }

    public async getById(id: number): Promise<User|null>
    {
        try {
            let rawResult = await this.repository.getOne(
                `SELECT id, name, password, quote FROM ${this.table} WHERE id=?`,
                [String(id)]
            )
    
            if (rawResult === undefined) {
                return null
            }
    
            return new User(
                rawResult.name,
                rawResult.password,
                rawResult.quote,
                rawResult.id
            )
        } catch (error) {
            console.error(`Error to retrieve an user with ID ${id} : ${error}`)
            return null
        }
    }

    public async add(user: User): Promise<void>
    {
        try {
            await this.repository.execute(
                `INSERT INTO ${this.table} (name, password, quote) VALUES (?, ?, ?)`,
                [user.name, user.password, user.quote]
            )
        } catch (error) {
            console.error(`Error to add an user (id : ${user.id}): ${error}`)
        }
    }

    public async update(id: number, user: User): Promise<boolean>
    {
        try {
            let currentUser = await this.getById(id)

            if (!currentUser) {
                return false
            }

            this.repository.execute(
                `UPDATE ${this.table} SET name=?, password=?, quote=? WHERE id=?`,
                [user.name, user.password, user.quote, String(id)]
            )

            return true
        } catch (error) {
            console.error(`Error to update an user (id : ${id}): ${error}`)
            return false
        }
    }

    public async deleteById(id: number): Promise<boolean>
    {
        try {
            let currentUser = await this.getById(id)

            if (!currentUser) {
                return false
            }

            await this.repository.execute(
                `DELETE FROM ${this.table} WHERE id=?`,
                [String(id)]
            )
            return true
        } catch (error) {
            console.error(`Error to remove user with id ${id}: ${error}`)
            return false
        }
    }
}

export const userRepository = new UserRepository()
