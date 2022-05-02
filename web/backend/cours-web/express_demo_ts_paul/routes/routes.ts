import express, { Router, Request, Response } from 'express'
import { home } from './home'

export const router: Router = express.Router()

home(router)
