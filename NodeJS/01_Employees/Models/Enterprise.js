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
        for (let i = 0; i < this.employees.length; i++) {
            console.log(entr.employees[i]);
        }
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

        _id = parseInt(_id);

        let result = this.employees.find(employee => employee.id == _id);

        return result;

        /*let m = 0,
            for (let i = 0; i < Employees.length; i++) {
                if (Employees[i].id = _id)
                    m = i;
            }
        return Employees[m];*/
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
    /*  delete(_id) {
        let m = 0,
            for (let i = 0; i < this.employees.length; i++) {
                if (Employees[i].id = _id)
                    m = i;
            }
        Employees.splice(m, 1);
    }
*/

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


const employees1 = [
    new Employee(01, 'THOUVENOT', 'Nicolas', 'employe', 33500, new Date('2017-04-19')),
    new Employee(02, 'HAMZA', 'Reda', 'employe', 35000, new Date('2015-09-15')),
    new Employee(03, 'BOUDIER', 'Aurelien', 'employe', 35100, new Date('2013-07-21')),
    new Employee(04, 'RAVANDOUST', 'Masoud', 'employe', 33500, new Date('2018-08-22')),
    new Employee(05, 'JENNIARD', 'Jonathan', 'employe', 32000, new Date('2015-04-19'))
]

const entr = new Enterprise();
entr.employees = employees1;

entr.create(new Employee(6, 'Emill', 'Nakarian', 'Developpeur', 40000, new Date('2010-05-26')));

entr.readAll(this.id);
module.exports = Enterprise;