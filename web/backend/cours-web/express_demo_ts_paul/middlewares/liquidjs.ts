import { Liquid } from "liquidjs"
import { Express } from "express"
import path from "path"

const viewRootDirectory = path.join(
    __dirname,
    '../',
    'views'
)
const viewFilesExtension = 'html'

export const liquidjs = (app: Express): void => {
    const viewEngine = new Liquid({
        root: viewRootDirectory,
        extname: '.' + viewFilesExtension
    })

    app.engine(viewFilesExtension, viewEngine.express())
    app.set('view engine', viewFilesExtension)
}
