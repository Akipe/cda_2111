import express, { Router, Request, Response } from 'express'
import { home } from './home'
import { staticFiles } from './staticFiles'

export const router: Router = express.Router()

home(router)
staticFiles(router)
