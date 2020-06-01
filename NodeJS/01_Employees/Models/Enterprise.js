const Employee = require('./Employee.js');

/**
 * Gestion d'employés
 */
class Enterprise {
    constructor() {
        this.employees = [];
    }

    /**
     * 
     * @param  _filter 
     */
    readAll(_filter) {
        let f = function(a, b) {
            return a._filter - b._filter;
        }
        this.employees.sort(f);
    }

    /**
     * Créer un employé
     * @param Employee _employee 
     */
    create(_employee) {
        this.employees.push(_employee);
    }

    /**
     * 
     * @param int _id 
     */
    read(_id) {
        let m = 0,
            for (let i = 0; i < Employees.length; i++) {
                if (Employees[i].id = _id)
                    m = i;
            }
        return Employees[m];
    }

    /**
     * Met à jour un employé
     * @param Employee _employee 
     */
    update(_employee) {
        _employee.salary = newSalary;

    }

    /**
     * Supprime un employé
     * @param int _id 
     */
    delete(_id) {
        let m = 0,
            for (let i = 0; i < Employees.length; i++) {
                if (Employees[i].id = _id)
                    m = i;
            }
        Employees.splice(m, 1);
    }


    /**
     * 
     */
    getHigherSalary() {
        this.employees.sort((a, b) => a.salary - b.salary);
        return this.employees[this.employees.length - 1];
    }

    /**
     * 
     */
    getLowerSalary() {
        this.employees.sort((a, b) => a.salary - b.salary);
        return this.employees[0];
    }

    /**
     * 
     */
    getSalaryGap() {
        return this.employees.getHigherSalary - this.employees.getLowerSalary;
    }






}


module.exports = Enterprise;