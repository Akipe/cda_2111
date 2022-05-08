import { Request } from "express";
import { randomBytes } from "crypto";
import CookieSessionObject from "cookie-session";
import { Session } from "inspector";

export class tokenCSRF
{
    private currentSession: any

    constructor(req: Request)
    {
        if (req.session) {
            this.currentSession = req.session
            this.generateTokenIfNotExist()
        } else {
            throw new Error("There is no session available!")
        }
    }

    public getToken(): string
    {
        return this.currentSession.tokenCsrf
    }

    public isEqual(userToken: string)
    {
        return this.currentSession.tokenCsrf === userToken
    }

    private generateTokenIfNotExist()
    {
        if (this.currentSession.tokenCsrf === undefined) {
            this.generateToken()
        }
    }

    private generateToken(): void
    {
        this.currentSession.tokenCsrf = randomBytes(100).toString('base64')
    }
}
