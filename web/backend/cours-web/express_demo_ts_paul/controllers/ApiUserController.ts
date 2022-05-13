import { Request, Response } from "express";
import { User } from "../database/User";
import { userRepository } from "../database/UserRepository";
import { HttpReturn } from "../services/HttpApiReturn";

export class ApiUserController
{
    async getAll(req: Request, res: Response): Promise<void>
    {
        try {
            let allUsers = await userRepository.getAll()

            res.status(HttpReturn.Created)
            res.json(allUsers)
        } catch (err) {
            this.returnServerError(res, err)
        }
    }

    async add(req: Request, res: Response)
    {
        try {
            if (!this.isUserPropertiesExistFromRequest(req)) {
                this.returnNotFound(res)
            } else {
                let newUser = this.getUserFromRequest(req)
                await userRepository.add(newUser)

                res.status(HttpReturn.Created)
                res.json(newUser)
            }
        } catch(err) {
            this.returnServerError(res, err)
        }
    }

    async getOneById(req: Request, res: Response)
    {
        const { id } = req.params

        try {
            let user = await userRepository.getById(Number.parseInt(id))

            if (user === null) {
                this.returnNotFound(res)
            } else {
                res.status(HttpReturn.Ok)
                res.json(user)
            }
        } catch (err) {
            this.returnServerError(res, err)
        }
    }

    async deleteById(req: Request, res: Response)
    {
        const { id } = req.params

        try {
            let result = await userRepository.deleteById(Number.parseInt(id))
            if (!result) {
                this.returnNotFound(res)
            } else {
                res.status(HttpReturn.Ok)
                res.json({ id: id })
            }
        } catch(err) {
            this.returnServerError(res, err)
        }
    }

    editById(req: Request, res: Response)
    {

    }

    private returnServerError(res: Response, error: any)
    {
        console.error(error)
        res.status(HttpReturn.ServerError)
        res.json({message: `Error 500: internal error`})
    }

    private returnNotFound(res: Response)
    {
        res.status(404)
        res.json({message: `Error 404: not found`})
    }

    private getUserFromRequest(req: Request): User
    {
        const { name, password, quote } = req.body

        return new User(name, password, quote)
    }

    private isUserPropertiesExistFromRequest(req: Request)
    {
        console.log(req.body)
        const { name, password, quote } = req.body
        console.log(`${name} ${password} ${quote}`)

        return this.isExist(name)
            && this.isExist(password)
            && this.isExist(quote)
    }

    private isExist(variable: any)
    {
        return variable !== undefined && variable !== null
    }
}

export const apiUserController = new ApiUserController()
