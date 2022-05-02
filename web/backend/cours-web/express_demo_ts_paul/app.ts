import express, { Express } from "express";
import { router } from "./routes/routes"
import { middleware } from './middlewares/middlewares'

const app: Express = express()
const port: number = 3000

middleware(app)

app.use('/', router)

app.listen(port, (): void => {
    console.log(`Server running at http://localhost:${port}`)
})
