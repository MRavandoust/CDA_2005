const Employee = require('./Employee.js');

/**
 * Gestion d'employés
 */
class Enterprise {
    constructor() {
        this.employees = new Employee();
    }

    /**
     * 
     * @param  _filter 
     */
    readAll(_filter) {
        let tabl = [];
        for (let i = 0; i < this.employees.length; i++) {
            tabl.push(this.employees[i]._filter)
        }
        return tabl;
        //this.employees.sort((a, b) => a._filter - b._filter);
        //return this.employees[this.employees.length - 1]._filter;
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
    delete(_id) {
        _id = parseInt(_id);
        let index = this.employees.findIndex(employee => employee.id == _id);
        this.employees.splice(index, 1);
    }


    /**
     * 
     */
    getHigherSalary() {
        this.employees.sort((a, b) => a.salary - b.salary);
        return this.employees[this.employees.length - 1].salary;
    }

    /**
     * 
     */
    getLowerSalary() {
        this.employees.sort((a, b) => a.salary - b.salary);
        return this.employees[0].salary;
    }

    /**
     * 
     */
    getSalaryGap() {
        return this.employees.getHigherSalary - this.employees.getLowerSalary;
    }

}


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


for (let i = 0; i < this.employees; i++) {
    console.log(entr.readAll(salary));
}

let x = entr.readAll(this.id)
console.log(x);

//console.log(entr.read(4));

//entr.delete(3);
//console.log(entr.employees);

//console.log(entr.getHigherSalary());


module.exports = Enterprise;