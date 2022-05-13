import { Router } from "express";
import { apiUserController } from "../controllers/ApiUserController";

export const apiRoutesURL = {
    user: {
        all: '/api/user',
        oneById: '/api/user/:id',
    }
}

export const api = (router: Router) => {
    router.get(apiRoutesURL.user.all, apiUserController.getAll.bind(apiUserController))
    router.post(apiRoutesURL.user.all, apiUserController.add.bind(apiUserController))
    router.get(apiRoutesURL.user.oneById, apiUserController.getOneById.bind(apiUserController))
    router.put(apiRoutesURL.user.oneById, apiUserController.editById.bind(apiUserController))
    router.delete(apiRoutesURL.user.oneById, apiUserController.deleteById.bind(apiUserController))
}