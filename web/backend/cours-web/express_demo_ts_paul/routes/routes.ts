import express, { Router, Request, Response } from 'express'
import { home } from './home'
import { user } from './user'
import { staticFiles } from './staticFiles'
import { api } from './api'

export const router: Router = express.Router()

home(router)
user(router)
api(router)

staticFiles(router)
