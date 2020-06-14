/**
 * Class Employee 
 * 
 * Attributs privés
 * 
 * Les attributs privés se déclarent dans le corps de la classe et par convention, juste après l'accolade ouvrante de la classe
 * En Javascript, Le nom des attributs privés est précédé d'un "#".
 * Dans un langage fortement typé (C#, Java), les attributs privés sont précédés du mot clé "private".
 * Les attributs privés sont accessibles uniquement à l'intérieur du bloc de code de la classe.
 * C'est le principe d'encapsulation.
 * 
 * L'encapsulation signifie que l'état d'un objet ne peut être modifié que par les méthodes de cet objet. 
 * Par "état" il faut entendre la valeur des attributs à un intant "T".
 * En d'autres termes, la classe est seul mâitre des données qu'elle contient.
 * 
 * Pour permettre l'accès aux attributs privés à partir de l'extérieur de la classe (par exemple à partir du "main"),
 * il est nécessaire d'implémenter des accesseurs (getters) et mutateurs (setters).
 * 
 * - Accesseurs :  
 *      Un accesseur (getter) est une méthode retournant la valeur d'un attribut (lecture).
 *      Par convention, on nomme un accesseur de cette manière : getAttribut ("get" suivi du nom de l'attribut en respectant le camelCase).
 *      Typiquement, un accesseur accepte 0 argument.
 * 
 * - Mutateurs
 *      Un mutateur (setter) est une méthode qui assignera à un attribut une nouvelle valeur passée en argument
 *      Par convention, on nomme un accesseur de cette manière: setAttribut ("set" suivi du nom de l'attribut en respectant le camelCase)
 *      Typiquement, un mutateur accepte 1 argument : la nouvelle valeur à appliquer à l'attribut. Le type de l'argument correspond au type de l'attribut cible.
 *      Le passage par un mutateur pour assigner une nouvelle valeur à un attribut va permettre d'effectuer un certains nombre de vérifications.
 *      Par exemple, s'assurer que la donnée fournie en argument correspond au format attendu pour l'attribut cible.
 * 
 * Les accesseurs et mutateurs sont généralement des méthodes publiques (public) mais il est parfois nécessaire de limiter leur portée à l'arbre d'héritage (protected).
 * 
 * /!\ Tous les attributs n'ont pas nécessairement besoin d'accesseur ou de mutateur.
 *      Pour chaque attribut d'un objet :
 *      - J'implémente un ACCESSEUR uniquement si je souhaite permettre la LECTURE      de la valeur d'un attribut à partir d'un autre contexte (autre objet, contexte global).
 *      - J'implémente un MUTATEUR  uniquement si je souhaite permettre la MODIFICATION de la valeur d'un attribut partir d'un autre contexte (autre objet, contexte global).
 * 
 * 
 * @version 2.0.0
 * @authors DEV2005
 * 
 */
class Employee {
    /** @var int id Identifiant de l'employé */
    #id;

    /** @var string lastname Patronyme de l'employé */
    #lastname;

    /** @var string firstname Prénom de l'employé */
    #firstname;

    /** @var string email Adresse email de l'employé */
    #email;

    /** @var string role Fonction de l'employé dans l'entreprise (emploi occupé) */
    #role;

    /** @var int salary Salaire Annuel Brut de l'employé */
    #salary;

    /**
     * 
     * @param Object _employee un objet quelconque // ex: { lastname: "Joe", ....}
     */
    constructor(_employee) {
       // si l'argument _employee n'est pas fourni, _employee = un objet litéral vide
       _employee = _employee || {};

       this.#id         = parseInt(_employee.id || 0); 
       this.#lastname   = _employee.lastname || "Doe";
       this.#firstname  = _employee.firstname || "John";
       this.#role       = _employee.role || "Unknown";
       this.#salary     = parseInt(_employee.salary || 0);

       // Calcul de l'email
       this.#email      = (this.#firstname[0] + this.#lastname).toLowerCase() + "@email.fr";

       // Recréation de l'objet Date à partir de la date fournie
       if(_employee.hiredate !== undefined) {
           this.hiredate = new Date(_employee.hiredate);
       }
    }

    /**
     * Retourne l'email de l'employé
     * ACCESSEUR pour l'attribut #email
     * @returns string l'email de l'employé
     */
    getEmail() {
        // Notez la présence du # devant le nom des attributs après le . du this
        return this.#email;
    }

    /**
     * Redéfinit l'email de l'employé
     * MUTATEUR pour l'attribut #email
     * @param string _email le nouvel email de l'employé
     */
    setEmail(_email) {
        if (typeof _email !== 'string') { // si _email n'est pas un string
            return;
        }

        if (_email.length < 7) { // si l'email est trop court
            return;
        }

        if (!/^[a-z0-9._-]+@[a-z0-9._-]+\.[a-z]{2,6}$/.test(_email)) { /** @todo REGEX si l'email ne correspond pas au format email attendu */
            return;
        }

        // Arrivé à ce point du code, le format de la valeur du paramètre _email est considérée comme "valide"

        this.#email = _email; // assignation de la nouvelle valeur à l'attribut correspondant
    }



} // fin classe Employee

// export en tant que module nodejs
module.exports = Employee;