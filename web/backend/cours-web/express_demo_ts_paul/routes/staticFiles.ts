import path from "path"
import express, { Router, Request, Response } from "express"
import process from "process"


const staticFilesRootPath = path.join(process.cwd(), 'public')

export const staticFiles = (router: Router) => {
    router.use('/public', express.static(staticFilesRootPath))
}
