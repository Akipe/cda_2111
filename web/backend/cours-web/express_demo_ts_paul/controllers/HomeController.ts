import { Request, Response } from "express";
import { productRepository } from "../database/ProductRepository";
import { userRepository } from "../database/UserRepository";

export class HomeController
{
    async showHome(req: Request, res: Response): Promise<void>
    {
        let allUsers = await userRepository.getAll()
        console.log(allUsers)

        let allProducts = await productRepository.getById(1)
        console.log(allProducts)

        res.render('home/show')
    }
}

export const homeController = new HomeController()
