# Exercice 3 : Poupées russes 1

On veut écrire un programme simulant des poupées russes de différentes tailles. Chaque poupée a une taille donnée,
peut s’ouvrir ou se fermer, peut contenir une autre poupée et être contenue dans une autre poupée.

Faire le diagramme de classe de la classe PoupeeRusse contenant les méthodes suivantes :
- un constructeur
- void Ouvrir() : ouvre la poupée si elle n’est pas déjà ouverte et si elle ne se trouve pas à l’intérieur d’une autre
  poupée.
- void Fermer() : ferme la poupée si elle n'est pas déjà fermée et si elle ne se trouve pas à l'intérieur d'une autre
  poupée.
- void PlacerDans(PoupeeRusse p) : place la poupée courante dans la poupée p si c'est possible. Il faut que la
  poupée courante soit fermée et ne soit pas déjà dans une autre poupée, que la poupée p soit ouverte et ne
  contienne aucune poupée, et que p soit d'une taille supérieure à la poupée courante.
- void sortirDe(PoupeeRusse p) : sort la poupée courante de la poupée p si elle est dans p et si p est ouverte.

Une fois le diagramme de classe validé, implémenter cette classe PoupeeRusse. Créer 3 poupées russes de taille
différentes. Essayer de mettre les poupées les unes dans les autres puis de les ressortir.