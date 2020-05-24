class Employees {
    constructor(_id, _lastname, _firstname, _role, _salary, _hiredate) {
        this.id = _id;
        this.lastname = _lastname;
        this.firstname = _firstname;
        this.role = _role;
        this.salary = _salary;
        this.hiredate = _hiredate;
        this.email = _firstname.charAt(0).toLowerCase() + _lastname.toLowerCase() + '@email.fr';
    }


    getMonthlySalary() {
        return (this.salary / 12) * 0.75;
    }

    getSeniority() {
        let now = new Date();
        let embaucheDate = new Date(this.hiredate.replace('-', ','));
        let diff = now.getTime() - embaucheDate.getTime();
        diff = Math.floor(diff / (1000 * 60 * 60 * 24));
        let ans = Math.floor(diff / 365);
        diff = diff - ans * 365;
        let mois = Math.floor(diff / 30);
        diff = diff - mois * 30;
        let jour = diff;
        if (jour > 0 && mois > 0 && ans > 0) {
            return ans + " ans et " + mois + " mois et " + jour + " jours ";
        } else if (jour > 0 && mois > 0 && ans == 0) {
            return mois + " mois et " + jour + " jours ";
        } else if (jour > 0 && mois == 0 && ans == 0) {
            return jour + " jours ";
        }
    }

    getSeniorityChiffre() {
        let now = new Date();
        let embaucheDate = new Date(this.hiredate.replace('-', ','));
        let diff = now.getTime() - embaucheDate.getTime();
        return diff;
    }


}

//Le tableau de 5 employés

const employees = [
    new Employees(01, 'THOUVENOT', 'Nicolas', 'employe', 33500, '2017-04-19'),
    new Employees(02, 'HAMZA', 'Reda', 'employe', 35000, '2015-09-15'),
    new Employees(03, 'BOUDIER', 'Aurelien', 'employe', 35100, '2013-07-21'),
    new Employees(04, 'RAVANDOUST', 'Masoud', 'employe', 33500, '2018-08-22'),
    new Employees(05, 'JENNIARD', 'Jonathan', 'employe', 32000, '2015-04-19'),
]

console.log();

//Parcourir le tableau d'employés
for (let i = 0; i < employees.length; i++) {
    console.log(i + 1 + ' - ' + employees[i].lastname +
        ' ' + employees[i].firstname +
        ', ' + employees[i].email +
        ', ' + employees[i].getSeniority() +
        ', ' + employees[i].getMonthlySalary() + '€');
}

console.log();

//L'employé ayant le plus d'ancienneté
{
    let max = 0;
    let j = -1;
    for (let i = 0; i < employees.length; i++) {
        if (employees[i].getSeniorityChiffre() > max) {
            max = employees[i].getSeniorityChiffre();
            j = i;
        }
    }
    console.log(employees[j].lastname + ' ' + employees[j].firstname + ' a le plus d\'anciennté');
}

console.log();

//L'employé avec le plus haut salaire
{
    let max = 0;
    let j = -1;
    for (let i = 0; i < employees.length; i++) {
        if (employees[i].getMonthlySalary() > max) {
            max = employees[i].getMonthlySalary();
            j = i;
        }
    }
    console.log(employees[j].lastname + ' ' + employees[j].firstname + ' a le plus haut salaire');
}

console.log();

//L'employé avec le plus bas salaire

{
    let min = employees[0].getMonthlySalary();
    let j = 0;
    for (let i = 0; i < employees.length; i++) {
        if (employees[i].getMonthlySalary() < min) {
            min = employees[i].getMonthlySalary();
            j = i;
        }
    }
    console.log(employees[j].lastname + ' ' + employees[j].firstname + ' a le plus bas salaire');
}

console.log();

//La différence de salaire entre les 2 précédents 
{
    let min = employees[0].getMonthlySalary();
    let j = 0;
    for (let i = 0; i < employees.length - 1; i++) {
        console.log('La différence de salaire entre ' + i + ' et ' +
            (i + 1) + ' est :' + Math.abs(employees[i].getMonthlySalary() - employees[i + 1].getMonthlySalary()));
    }
}

console.log();