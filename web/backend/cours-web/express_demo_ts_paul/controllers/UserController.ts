import { Request, Response } from "express";
import { validationResult } from "express-validator";
import { userRoutesURL } from "../routes/user";

export class UserController
{
    showAll(req: Request, res: Response): void
    {
        res.render('user/showAll')
    }

    showAddUserForm(req: Request, res: Response): void
    {
        res.render(
            'user/add',
            {
                form_destination: userRoutesURL.add,
                form_send_method: "post"
            }
        )
    }

    addUser(req: Request, res: Response)
    {
        const { name, password, quote } = req.body
        const validationErrors = validationResult(req)

        if (!validationErrors.isEmpty()) {
            res.render(
                'user/add',
                {
                    form_destination: userRoutesURL.add,
                    form_send_method: "post",
                    form_errors: validationErrors.mapped(),
                    user: {
                        name: name,
                        password: password,
                        quote: quote
                    }
                }
            )
        } else {
            res
                .send(`L'utilisateur ${name} a bien été créer.`)
                .status(200)
                .end()
            //res.redirect(userRoutesURL.showAll)
        }
    }
}

export const userController = new UserController()
