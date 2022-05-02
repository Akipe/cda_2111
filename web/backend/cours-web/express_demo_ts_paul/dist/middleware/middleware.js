"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.middleware = void 0;
const liquidjs_1 = require("./liquidjs");
const middleware = (app) => {
    (0, liquidjs_1.liquidjs)(app);
};
exports.middleware = middleware;
