import { Router } from "express";
import { userController } from "../controllers/UserController";
import { userValidator } from "../form/userValidator";

export const userRoutesURL = {
    showAll: "/user/",
    add: "/user/add"
}

export const user = (router: Router) => {
    router.get(userRoutesURL.showAll, userController.showAll)
    router.get(userRoutesURL.add, userController.showAddUserForm)
    router.post(userRoutesURL.add, userValidator, userController.addUser)
}