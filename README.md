# Blockchain : La technologie a adopter pour votre projet.

Avant de commencer, je suis certain que vous avez déjà entendu parler de la Blockchain ou chaine de bloc en français que ce soit dans plusieurs articles ou dans des conférences dédiées à cette technologie.

La sécurité et du stockage de données vous à convaincu ? Si oui, je pourrai vous aider à en savoir plus sur le sujet mais pour les nouveaux, nous allons revenir sur : 

## Une Blockchain, Qu'est-ce que c'est ?

Imaginer une pièce (bureau, salle de réunion, ...) avec 6 personnes. Chaque personne possède un livre vide. Dans ce livre, chaque personne ajoutera des pages avec une description de se qui se passe dans la pièce.

_Ex : La personne 1 donne son stylo à la personne 3._

Ceci est une transaction, Chaque personne dans la pièce va écrire sur une page cette transaction sur la première ligne et continuera à écrire les transactions suivantes jusqu'à remplir la page en entier, la page est donc considérée comme un Bloc, dès que le Bloc est terminé, on le valide en cryptant son contenu (**hash**). Une seul personne aura l'occasion de crypté cette page et de la distribuer aux autres personnes pour la placer dans leur livre respectif et on passe à la nouvelle page.

> Le hash est une suite de chiffres et de lettres dont la taille varie généralement entre 64 et 256 caractères. Cette méthode de hachage utilise un algorithme spécifique à chaque blockchain

> Ex : Le Bitcoin utilise l'algorithme suivant : SHA-256

Pour le bloc suivant c'est pratiquement identique à par une chose, au moment de valider le bloc, nous allons récupérer la valeur cryptée du bloc précèdent et l'ajouter à la valeur cryptée de la page courante. Ce qui permet la sécurité de la blockchain car si les transactions sont modifiées, la valeur du **hash** sera modifié et tous les blocs suivants auront un **hash** erroné, ce qui provoquera un blocage de la blockchain. 

Si tout est correct, on attache le bloc courant à la suite du livre, à la chaine les uns après les autres. C'est ce qu'on appelle une chaine de bloc.

![](https://blockchainfrance.files.wordpress.com/2015/09/blck-schema.png)

### _Mais pourquoi chaque personne doivent posséder ce livre ?_

Parce que la blockchain est une technologie décentralisé, elle n'appartient à personne, ce qui permet une sécurité renforcé, imaginé que la personne 6 écrit sur sa page : 

> "La personne 1 donne son stylo à la personne 6" au lieu de "La personne 1 donne son stylo à la personne 3".

La personne 6 n'ayant pas le même contenu, n'aura pas non plus le même hash que les autres personnes, ce qui rendra le contenu de sa page corrompu et ne sera pas ajouté au livre.

Ce livre est comparable à un grand registre virtuel.

Ce qui rend pratiquement la blockchain inaltérable parce que tout le monde la possède et personne ne peut modifier son contenu. Nous allons revenir un peu plus tard sur une possibilité qui est de moins en moins courante "L'attaque des 51%"

Et comme une image et mieux qu'un long discours, voici le principe général d’une blockchain en image :

![](https://blockchainfrance.files.wordpress.com/2015/09/fonctionnement-blockchain1.png)

## Les différentes technologies Blockchain


