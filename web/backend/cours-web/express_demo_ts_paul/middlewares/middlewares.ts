import { Express } from "express"
import { liquidjs } from "./liquidjs"
import { logs } from "./logs"

export const middleware = (app: Express): void => {
    liquidjs(app)
    logs(app)
}
