import { Express } from "express"
import { liquidjs } from "./liquidjs"

export const middleware = (app: Express): void => {
    liquidjs(app)
}
