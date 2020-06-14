const Point = require('./Point.js');

/**
 * Class Area
 * Un "Point" est un objet représentant des coordonnées (x,y) dans un espace à 2 dimensions
 * Une "Area" est un objet représentant une zone à 2 dimensions (coïncidence?)
 * Une "Area" est obligatoirement définie par une largeur (nombre de colonnes) et une hauteur (nombre de lignes) pour former une grille.
 * On peut ajouter, déplacer et supprimer des "Point" à l'intérieur d'une Area (1 seul "Point" par coordonnée).
 * Une "Area" ne peut contenir plus de "Point" que de coordonnées disponibles dans la zone.
 * (une zone 4x4 est limitée à 16 points)
 * Les "Point" ajoutés peuvent se situer en dehors des limites de la zone (la limite du nombre de point par zone ne peut pas être dépassée !).
 * 
 * Le "Point" d'origine (0,0) d'une "Area" est situé au coin supérieur gauche
 * Le "Point" d'origine existe toujours (créé dans le constructeur) et ne peut être supprimé
 * A partir du "Point" d'origine, la zone s'étend vers la droite pour les abscisses et vers le bas pour les ordonnées
 *
 *
 * ALGORITHME AJOUTER/DEPLACER UN POINT DANS UNE AREA: 
 *
 * 1) En cas d'ajout, si la zone (Area) est pleine (Toutes les coordonnées "dans les limites" sont occupées par un "Point")
 *    1.1) Ajout impossible, renvoyer false
 *
 * 2) Si un "Point" existe déjà aux mêmes coordonnées:
 *    2.1) Rechercher la position libre la plus proche du "Point" d'origine (0,0)
 *    2.2) Si 2 positions son éligibles (distance égale), celle la plus proche du bord supérieur de la zone est privilégiée
 *       
 * 3) Enregistrer le "Point" dans la zone
 * 
 * 4) Renvoyer true
 */
class Area {
    /**
     * Constructeur: Initialise une nouvelle instance de la classe "Area"
     * La largeur et la hauteur définissent respectivement le nombre de colonnes et de lignes. 
     * @param int _width largeur de la zone
     * @param int _height hauteur de la zone
     */
    constructor(_width, _height) {
        // A vous de jouer
        this.width = parseInt(_width);
        this.height = parseInt(_height);
        this.size = this.height * this.width;
        this.points = [];
        this.points.push(new Point(0, 0));
    }



    /**
     * Vérifie si la zone dispose d'emplacements libres
     * @returns Boolean true si au moins 1 emplacement est disponible. false si la zone est pleine
     */
    hasFreeSpace() {
        return (this.points.length < this.size);
    }

    /**
     * Vérifie la disponibilité de l'emplacement aux coordonnées indiquées en argument.
     * @param int _x abscisses
     * @param int _y ordonnées
     * @returns Boolean true si l'emplacement est libre, sinon false.
     */
    isFreeXY(_x, _y) {
        return this.points.find(p => p.x === _x && p.y === _y) === undefined;
    }

    /**
     * Vérifie si l'emplacement aux coordonnées du point fourni en argument est libre.
     * @param Point _point le Point qui contient les coordonnées à contrôler
     * @returns Boolean true si l'emplacement est libre, sinon false.
     */
    isFree(_point) {
        return this.isFreeXY(_point.x, _point.y);
    }

    /**
     * Retourne la 1ère position libre dans la zone
     */
    firstFreeLocation() {

        let result = [];

        for (let x = 0; x < this.width; x++) {
            for (let y = 0; y < this.height; y++) {
                if (this.isFreeXY(x, y)) {
                    result.push(new Point(x, y));
                }
            }
        }

        return result.sort(this.closestFromOrigin)[0];
    }

    /**
     * Vérifie la disponibilité des coordonnées du Point en argument
     * Si emplacement utilisé, déplace le Point vers un emplacement libre
     * @param Point _point 
     */
    moveToFreeLocation(_point) {

        if (!this.isFree(_point)) {
            let free = this.firstFreeLocation();

            if (free !== undefined) {
                _point.copy(free);
            }
        }
    }





    /**
     * Ajoute un "Point" dans la zone
     * Le "Point" peut se trouver hors des limites de la zone
     * @param Point _point 
     * @returns Boolean true en cas de succès, false si l'ajout est impossible 
     */
    addPoint(_point) {
        if (!(_point instanceof Point) || this.length >= this.size) { // || !this.point.includes(undefined)
            return false;
        }

        let m = _point.y * this.width + _point.x;
        if (m < this.size && this.points[m] == undefined) {
            this.points.splice(m, 1, _point);
            return true;
        } else {
            for (let i = 0; i < this.size; i++) {
                if (this.points[i] == undefined) {
                    this.points.splice(i, 1, _point);
                    return true;
                }
            }
        }
    }



    /**
     * Déplace un point existant dans la zone vers de nouvelles coordonnées
     * Les nouvelles coordonnées peuvent se trouver hors limites
     * @returns Boolean true en cas de succès, false en cas d'échec
     */
    movePoint(_p1, _point) {
        if (!(_point instanceof Point)) {
            return false;
        }
        // implémenter la méthode
        let m = _point.y * this.width + _point.x;
        if (this.points[m] == undefined) {
            _p1.x = _point.x;
            _p1.y = _point.y;
            return true;
        } else {
            return false;
        }


    }


    /**
     * Vérifie la position de chaque "Point" existant dans la zone
     * Chaque Point hors des limites est automatiquement déplacé dans les limites vers la position libre la plus proche
     * @returns int le nombre de points déplacés
     */
    needAllInside() {
        // implémenter la méthode
        let nombre = 0;
        for (let i = 0; i < this.size; i++) {
            if (this.points[i] != undefined) {
                if (this.points[i].x > this.width - 1 || this.points[i].y > this.height - 1) {
                    //let m = this.point[i].y * this.width + this.point[i].x;
                    this.points[i].x = i % this.width;
                    this.points[i].y = Math.floor(i / this.width);
                    nombre += 1;
                }
            }
        }
        return nombre;
    }




    /**
     * Callback de tri par distance par rapport au point d'origine (à utiliser avec Point[].sort())
     * @param {Point} _p1 
     * @param {Point} _p2 
     */
    closestFromOrigin(_p1, _p2) {

        let compareDistance = (_x1, _x2) => (_x1 < _x2 ? -1 : (_x1 > _x2 ? 1 : 0));

        let d1 = _p1.distanceFromOrigin();
        let d2 = _p2.distanceFromOrigin();
        let d = compareDistance(d1, d2);

        switch (d) {
            case 0:
                return compareDistance(_p1.x, _p2.x);
            default:
                return d;
        }
    }
}


module.exports = Area;