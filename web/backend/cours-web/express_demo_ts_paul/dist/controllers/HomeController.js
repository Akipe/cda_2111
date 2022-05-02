"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.homeController = exports.HomeController = void 0;
class HomeController {
    showHome(req, res) {
        res.render('home/show');
    }
}
exports.HomeController = HomeController;
exports.homeController = new HomeController();
