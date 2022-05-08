import { Express } from "express"
import { bodyParser } from "./bodyParser"
import { liquidjs } from "./liquidjs"
import { logs } from "./logs"

export const middleware = (app: Express): void => {
    liquidjs(app)
    logs(app)
    bodyParser(app)
}
