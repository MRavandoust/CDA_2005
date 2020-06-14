const Employee = require('./Models/Employee.js');
const Manager = require('./Models/Manager.js');
const Enterprise = require('./Models/Enterprise.js');


let emp = new Employee();
let man = new Manager();
emp.setEmail("email@new.com");
man.setEmail("manager@super.fr");

console.log(emp instanceof Employee); // true
console.log(emp instanceof Manager); // false
console.log(man instanceof Manager); // true
console.log(man instanceof Employee); // true

console.log();