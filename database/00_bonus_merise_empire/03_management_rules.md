Meurise empire - gest
===========

**une personne** conduit 0 ou plusieurs **vaisseau**
// Un pilote ne peut conduire qu'un seul vaisseau à la fois, en même temps.
**un vaisseau** est conduit par 0 ou plusieurs **personnes**

**Un vaisseau** est spécialisé dans 1 **type de mission**.
**Un type de mission** spécialise 0 ou plusieurs **vaisseaux**.

**Une personne** est qualifié pour 1 ou plusieurs **types de mission**.
**Un type de mission** qualifie 0 ou plusieurs **personnes**.

// todo dans dico data
**Une planete** appartient à 1 **système solaire**.
**Un système solaire** contient 1 ou plusieurs **planetes**.

**une étoile** appartient à 1 **galaxie**
**une galaxie** a 2 ou plusieurs **étoile**
// end todo

**un empire** s'allie à 0 ou plusieurs **empires**.

**un empire** soumet 0 ou plusieurs **planetes**.
**une planete** est soumis à 0 ou 1 **empire**.

**un type de mission** défini 0 ou plusieurs **mission**.
**une mission** est défini par 1 **type de mission**.

**une mission** requiers 1 ou plusieurs **vaisseau**.
**un vaisseau** est requis sur 0 ou plusieurs **missions**.
// Un vaisseau ne peut réaliser qu'une seul mission à la fois, tant qu'elle n'est pas terminé.

**une mission** se focalise sur 0 ou 1 **planete**.
**une planete** est focalisé sur 0 ou 1 **mission**.

// Définir où est "l'espace" à la place de galaxie ?
**une mission** se focalise sur 0 ou 1 **galaxie**.
**une galaxie** est facalisé sur 0 ou 1 **mission**.

**un équipage** est enrolé dans 0 ou plusieurs **vaisseaux**
// Un équipage ne peut être enrolé sur une seul vaisseaux à la fois.
**un vaisseau** enrole 0 ou 1 **équipage**.

// Un équipage est composé de pirates
**un équipage** regroupe 1 ou plusieurs **personnes**
**une personne** est regroupé dans 0 ou plusieurs **équipages**
// Une personne ne peut être regroupé dans un seul équipage à la fois.

// Une personne peut être un pilote, un pirate
**une personne** est spécifié en 1 **rôle**.
**une rôle** spécifie 0 ou plusieurs **personnes**.

// Un équipage regroupe :
    - les mêmes types de compétences 
    - partagé par le type de mission du vaisseau 
    - et participe à des missions qui requirent ce type
