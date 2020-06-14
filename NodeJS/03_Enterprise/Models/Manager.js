const Employee = require("./Employee");

/**
 * Class Manager
 * Le mamager est un employé qui gère une équipe
 */
class Manager extends Employee {

    #team;

    constructor(_employee) {
        super(_employee);
        this.#team = [];
        //this.team.push(new Employee());
    }
    /**
     * 
     */
    getTeam() {
        return this.#team;

    }

    /**
     * 
     * @param Employee[] _team 
     */
    setTeam(_team) {

    }

    /**
     * 
     * @param Employee _emp 
     */
    addEmployee(_emp) {

    }

    /**
     * 
     * @param string _email 
     */
    setEmail(_email) {
        super.setEmail(_email);
    }


}

module.exports = Manager; 