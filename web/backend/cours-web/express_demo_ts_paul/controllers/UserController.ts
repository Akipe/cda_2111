import { Request, Response } from "express";
import { validationResult } from "express-validator";
import { userRoutesURL } from "../routes/user";
import { TokenCsrf } from "../services/TokenCsrf"

export class UserController
{
    showAll(req: Request, res: Response): void
    {
        res.render('user/showAll')
    }

    showAddUserForm(req: Request, res: Response): void
    {
        const serverTokenCsrf = new TokenCsrf(req)

        res.render(
            'user/add',
            {
                form_destination: userRoutesURL.add,
                form_send_method: "post",
                tokenCsrf: serverTokenCsrf.getToken()
            }
        )
    }

    addUser(req: Request, res: Response)
    {
        const { name, password, quote, tokenCsrf } = req.body
        const validationErrors = validationResult(req)
        const serverTokenCsrf = new TokenCsrf(req)

        if (!serverTokenCsrf.isEqual(tokenCsrf)) {
            res.render(
                'user/add',
                {
                    form_destination: userRoutesURL.add,
                    form_send_method: "post",
                    tokenCsrf: serverTokenCsrf.getToken()
                }
            )
        } else if (!validationErrors.isEmpty()) {
            res.render(
                'user/add',
                {
                    form_destination: userRoutesURL.add,
                    form_send_method: "post",
                    form_errors: validationErrors.mapped(),
                    tokenCsrf: serverTokenCsrf.getToken(),
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
