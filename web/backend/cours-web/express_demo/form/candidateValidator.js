const { checkSchema } = require('express-validator')

// https://express-validator.github.io/docs/schema-validation.html
module.exports = checkSchema({
    id: {
        isInt: true,
        toInt: true
    },
    firstname: { // Le champ est requis, aucun chiffre, autorise les espaces et les tirets "-".
        notEmpty : {
            options: {
                ignore_whitespace: true
            },
            errorMessage: "Le prénom est requis"
        },
        isLength: {
            options: {
                min: 4,
                max: 24
            },
            errorMessage: "Le prénom doit être avoir entre 4 et 24 caractères."
        },
        isAlpha: {
            locale: 'fr-FR',
            options: {
                ignore: '\-'
            },
            errorMessage: "Le prénom ne doit contenir que des lettres."
        }
    },
    lastname: { // Le champ est requis, aucun chiffre, autorise les espaces et les tirets "-".
        notEmpty : {
            options: {
                ignore_whitespace: true
            },
            errorMessage: "Le prénom est requis"
        },
        isLength: {
            options: {
                min: 4,
                max: 24
            },
            errorMessage: "Le prénom doit être avoir entre 4 et 24 caractères."
        },
        /*isAlpha: {
            locale: 'fr-FR',
            options: {
                ignore: ["-", " "]
            },
            errorMessage: "Le prénom ne doit contenir que des lettres."
        }*/
    },
    slogan: { // Le champ est requis, aucun chiffre, autorise les espaces.
        notEmpty : {
            options: {
                ignore_whitespace: true
            },
            errorMessage: "Le prénom est requis"
        },
        isLength: {
            options: {
                min: 4,
                max: 24
            },
            errorMessage: "Le prénom doit être avoir entre 4 et 24 caractères."
        },
        /*isAlpha: {
            locale: 'fr-FR',
            options: {
                ignore: " "
            },
            errorMessage: "Le prénom ne doit contenir que des lettres."
        }*/
    }
})