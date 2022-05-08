import { Express } from "express";
import cookieParser from "cookie-parser";
import cookieSession from "cookie-session";

export const cookie = (app: Express) => {
    app.use(cookieParser())
    app.use(cookieSession({
        name: "session",
        secret: "GENERATE_ME_PLZ",
        maxAge: 1000 * 60 * 15, // 15 minutes,
        sameSite: 'strict',
        path: '/',
        secure:  process.env.NODE_ENV === 'production',
        httpOnly: true
    }))
}