class User 
{
    //#namePrivate; // Attribut privé, pas encore implémenté par tous les navigateurs

    constructor() { // Constructeur
        //this.#namePrivate = "toto"; // Utilisation d'attribut privé
        this.name = "toto" // On créer et initialise l'attribut publique
    }

    getName() { // Methode
        return this.name;
    }
}

const User2 = function()
{
    this.name = "toto";

    this.getName = () => { // Duplication de cet methode pour chaque objet
        return this.name;
    }// Pour ce faire, il faut le déclarer dans le prototype pour éviter de répéter
}

User2.prototype.getName = () => {
    return this.name;
}

User2.name;
User2.prototype.name;

const User3 = function()
{
    this.name = "toto";
}

let u1 = new User();
let u2 = new User2();
let u3 = new User3();

console.log(u1.getName());
console.log(u2.getName());

// On peut modifier un prototype à tout moment
User2.prototype.getName = null

console.log(u1, u2, u3);

let a = [];
a.push("toto");
console.log(a);

// On peut également supprimer des methodes du langage JS.
// Il faut faire attention à la porté de nos modifications
// autorisé par le système de prototype du langage.
Array.prototype.push = function(item) {
    console.log("NON " + item);
};

a.push("titi");
console.log(a);
