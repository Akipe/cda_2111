"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.liquidjs = void 0;
const liquidjs_1 = require("liquidjs");
const path_1 = __importDefault(require("path"));
const viewRootDirectory = path_1.default.join(__dirname, '../', 'views');
const viewFilesExtension = 'html';
const liquidjs = (app) => {
    const viewEngine = new liquidjs_1.Liquid({
        root: viewRootDirectory,
        extname: '.' + viewFilesExtension
    });
    app.engine(viewFilesExtension, viewEngine.express());
    app.set('view engine', viewFilesExtension);
};
exports.liquidjs = liquidjs;
