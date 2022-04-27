/**
 * Exercice d'entrainerment JS de MDN Network
 * https://developer.mozilla.org/fr/docs/Learn/JavaScript/Client-side_web_APIs/Manipulating_documents
 * 
 * On veut pouvoir :
 * - ajouter des articles dynamiquement, avec un formulaire et un bouton
 * - chaque article doit pouvoir être supprimé
 * - après l'ajout d'un article, le formulaire doit être vider et avoir le focus
 * 
 * L'application doit ressembler à ceci : https://developer.mozilla.org/en-US/docs/Learn/JavaScript/Client-side_web_APIs/Manipulating_documents/shopping-list.png
 * 
 */
"use strict";

let addItemShop = (event, item) => {
    event.preventDefault();
    console.log(event);
};

let removeItemShop = (item) => {

};

let focusFormShop = (formElement) => {

};

let clearFormShop = (formElement) => {

};

let enableListShop = (formElement) => {
    console.log(formElement);
    formElement.addEventListener('onsubmit', addItemShop)
};

const formElementShop = document.getElementById("formShop");
const listItemShop = document.getElementById("listItemShop");

enableListShop(formElementShop);