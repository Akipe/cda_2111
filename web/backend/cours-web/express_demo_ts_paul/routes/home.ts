import { Router } from "express"
import { homeController } from "../controllers/HomeController"

export const home = (router: Router) => {
    router.get('/', homeController.showHome)
}
