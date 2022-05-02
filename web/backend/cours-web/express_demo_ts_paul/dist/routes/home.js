"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.home = void 0;
const HomeController_1 = require("../controllers/HomeController");
const home = (router) => {
    router.get('/', HomeController_1.homeController.showHome);
};
exports.home = home;
