const Point = require("./Path.js");

/**
 * La classe arrivée
 */

 class Goal extends Point {

    #success

    constructor(_x, _y) {
        super(_x, _y);
        this.#success = false;
    }

    getSuccess() {
        return this.#success;
    }

 }

 module.exports = Goal;