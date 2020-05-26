function somme(a, b) {
    if (b === 0) return a;
    else
        return somme(a + 1, b - 1);
}


function produit(a, b) {
    if (b === 0) return 0;
    else
        return a + produit(a, b - 1);
}

function puissance(a, b) {
    if (b === 0) return 1;
    else
        return a * puissance(a, b - 1);
}





let x = somme(5, 8);
console.log(x);

let y = produit(3, 6);
console.log(y);

let z = puissance(3, 3);
console.log(z);