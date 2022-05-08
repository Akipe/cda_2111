import express, { Express } from 'express'

export const bodyParser = (app: Express): void => {
    app.use(express.urlencoded({extended: true}))
}
