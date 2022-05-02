const { checkSchema } = require('express-validator')

// https://express-validator.github.io/docs/schema-validation.html
module.exports = checkSchema({
    /*id: {
        isInt: true,
        toInt: true
    },*/
    firstname: { // Le champ est requis, aucun chiffre, autorise les espaces et les tirets "-".
        matches: {
            options: '^[a-zA-ZÀ-ÿ]+(-| )?[a-zA-ZÀ-ÿ]+$',
            errorMessage: "Le prénom ne doit contenir que des lettres."
        },
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
    },
    lastname: { // Le champ est requis, aucun chiffre, autorise les espaces et les tirets "-".
        matches: {
            options: '^[a-zA-ZÀ-ÿ]+(-| )?[a-zA-ZÀ-ÿ]+$',
            errorMessage: "Le nom ne doit contenir que des lettres."
        },
        notEmpty : {
            options: {
                ignore_whitespace: true
            },
            errorMessage: "Le nom est requis"
        },
        isLength: {
            options: {
                min: 4,
                max: 24
            },
            errorMessage: "Le nom doit être avoir entre 4 et 24 caractères."
        },
    },
    slogan: { // Le champ est requis, aucun chiffre, autorise les espaces.
        matches: {
            options: '^[a-zA-ZÀ-ÿ\-, ]*$',
            errorMessage: "Le slogan ne doit contenir que des lettres."
        },
        notEmpty : {
            options: {
                ignore_whitespace: true
            },
            errorMessage: "Le slogan est requis"
        },
        isLength: {
            options: {
                min: 4,
                max: 24
            },
            errorMessage: "Le slogan doit être avoir entre 4 et 24 caractères."
        },
    }
})