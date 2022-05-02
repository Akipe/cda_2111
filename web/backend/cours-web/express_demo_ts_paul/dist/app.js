"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
const express_1 = __importDefault(require("express"));
const routes_1 = require("./routes/routes");
const middlewares_1 = require("./middlewares/middlewares");
const app = (0, express_1.default)();
const port = 3000;
(0, middlewares_1.middleware)(app);
app.use('/', routes_1.router);
app.listen(port, () => {
    console.log(`Server running at http://localhost:${port}`);
});
