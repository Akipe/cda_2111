import express, { Router, Request, Response } from 'express'
import { home } from './home'
import { user } from './user'
import { staticFiles } from './staticFiles'

export const router: Router = express.Router()

home(router)
user(router)

staticFiles(router)
