  const Employee = require('./Models/Employee.js');
  const Enterprise = require('./Models/Enterprise');


  var employe1 = new Employee(7, 'DEV', 'Mike', 'DWWM', 50000, new Date());

  const ets = new Enterprise();

  ets.create(employe1);
  ets.create(new Employee(2, 'RAB', 'IT', 'CDA', 60000, new Date()));


  let monFiltre = emp => emp.hiredate > new Date();

  let r1 = ets.readAll(monFiltre);
  let r2 = ets.readAll(emp => emp.hiredate < new Date());

  console.log(r1);
  console.log(r2);


  let myEmployee = ets.read(2);

  myEmployee.firstname = "OT";

  ets.update(myEmployee);


  myEmployee2 = new Employee();

  ets.update(myEmployee2);


  console.log();


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
  entr.create(employe1);

  /*
  for (let i = 0; i < this.employees; i++) {
    console.log(entr.readAll(salary));
  }  */



  let x = entr.readAll("salary");
  console.log(x);

  //console.log(entr.read(4));

  //entr.delete(3);
  //console.log(entr.employees);

  //console.log(entr.getHigherSalary());