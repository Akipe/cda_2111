import { Request, Response } from "express";

export class HomeController
{
    showHome(req: Request, res: Response): void
    {
        res.render('home/show')
    }
}

export const homeController = new HomeController()
