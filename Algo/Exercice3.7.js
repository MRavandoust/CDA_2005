// Recherche par dichotomie d'un élément dans un tableau classé
let tableau = ['agathe', 'berthe', 'chloe', 'cunegonde', 'olga', 'raymonde', 'sidonie'];
let gauche = 0;
let droite = 6;
let milieu = -1;
let motRecherche = 'ogla';
let trouv = false;

while (gauche <= droite && !trouv) {
    milieu = (gauche + droite) / 2;
    if (tableau[milieu] === motRecherche) {
        trouv = true;
    } else if (tableau[milieu] > motRecherche) {
        droite = milieu - 1;
    } else if (tableau[milieu] < motRecherche) {
        gauche = milieu + 1;
    }
}
console.log("Le mot Recherché se trouve à l'indice " + milieu);