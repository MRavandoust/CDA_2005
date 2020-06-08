const Point = require('./models/Point.js');
const Area = require('./models/Area.js');




let A = new Area(6, 6);
//A[0] = p1;
console.log(A.point);
let p0 = new Point(2, 0);
let p1 = new Point(4, 3);
let p2 = new Point(2, 5);
let p3 = new Point(0, 5);
let p4 = new Point(2, 8);
let p5 = new Point(6, 0);
let p6 = new Point(6, 2);
let p7 = new Point(6, 2);

//console.log(p1.distance(p2));
A.addPoint(p1);
A.addPoint(p2);
A.addPoint(p3);
A.point[5] = 'xxx';
A.addPoint(p4);
A.addPoint(p6);
A.addPoint(p7);
A.addPoint(p0);
A.addPoint(p5);
console.log(A.point);
console.log('p1 (avant move) : ' + p1.toString());
let p8 = new Point(3, 3);
A.movePoint(p1, p8);
console.log('p1 (après move) : ' + p1.toString());
console.log(A.point);
console.log();
console.log(A.needAllInside());
console.log(A.point);