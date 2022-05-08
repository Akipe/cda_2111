import { checkSchema } from "express-validator";
import { Schema } from "express-validator/src/middlewares/schema";
import { AlphaLocale } from "express-validator/src/options";

const localeFrench: AlphaLocale = "fr-FR"

const userSchema: Schema = {
    name: {
        trim: true,
        escape: true,
        notEmpty: {
            options: {
                ignore_whitespace: true
            },
            errorMessage: "Le nom est requis"
        },
        isAlpha: {
            options: [
                localeFrench,
                {
                    ignore: ' -'
                }
            ],
            errorMessage: "Le nom ne doit contenir que des caractères alphabétiques, des espaces des tirets '-'"
        },
        isLength: {
            options: {
                min: 2,
                max: 32
            },
            errorMessage: "Le nom doit contenir entre 2 et 32 caractères"
        }
    },
    password: {
        escape: true,
        notEmpty: {
            options: {
                ignore_whitespace: true
            },
            errorMessage: "Le mot de passe est requis"
        },
        isStrongPassword: {
            options: {
                minLength: 8,
                minLowercase: 1,
                minUppercase: 1,
                minSymbols: 1,
                minNumbers: 1
            },
            errorMessage: "Le mot de passe doit avoir une taille minimal de 8, avoir au moin une majuscule, une minuscule, un caractère spécial et un chiffre"
        },
        isLength: {
            options: {
                min: 8,
                max: 64
            },
            errorMessage: "Le mot de passe doit contenir entre 8 et 64 caractères"
        }
    },
    quote: {
        trim: true,
        escape: true,
        notEmpty: {
            options: {
                ignore_whitespace: true
            },
            errorMessage: "La citation est requis"
        },
        isAlpha: {
            options: [
                localeFrench,
                {
                ignore: ` -,.!?:\'`
            }],
            errorMessage: "La citation ne doit contenir que des caractères alphabétiques, des espaces et les caractères: '-,.!?:'"
        },
        isLength: {
            options: {
                min: 2,
                max: 32
            },
            errorMessage: "Le nom doit contenir entre 2 et 32 caractères"
        }
    }
}

const userIdSchema: Schema = {
    id: {
        trim: true,
        escape: true,
        toInt: true,
        isInt: {
            errorMessage: "L'ID de l'utilisateur doit être un nombre"
        },
        notEmpty: {
            options: {
                ignore_whitespace: true
            },
            errorMessage: "L'ID de l'utilisateur doit être défini"
        }
    }
}

export const userValidator = checkSchema(userSchema)
export const userIdValidator = checkSchema(userIdSchema)
