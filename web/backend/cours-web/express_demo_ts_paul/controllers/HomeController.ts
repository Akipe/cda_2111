import { Request, Response } from "express";
import { baseRepository } from "../database/BaseRepository";

export class HomeController
{
    async showHome(req: Request, res: Response): Promise<void>
    {
        let testDatabase = await baseRepository.getAll("SELECT * FROM users")
        console.log(testDatabase)
        res.render('home/show')
    }
}

export const homeController = new HomeController()
