let str = 'Le a. contenu.'.toLowerCase();

let search = 'a'.toLowerCase();

let lastIndex = str.length - 1; //dernier index du tableu de caracter

let lastCharacter = str[lastIndex];

let result = 0;

if (str.length < 1) {
    console.log('La chaine est vide (1) !');
    return false;
}

if (str === '.') {
    console.log('La chaine est vide (2) !');
    return false;
}

if (lastCharacter !== '.') {
    console.log('La chaine dois terminer par un point !');
    return false;
}

result = str.split(search).length - 1;

/*
for (let i = 0; i < str.length; i++) {
    if (str[i] === search) {
        result++;
    }

    // if (str.charAt(i) === search) {
    //    result++;
    // }
} 

*/
if (result > 0) {
    console.log('La lettre \'' + search + '\' a été trouve ' + result + ' fois.')
} else {
    console.log('Non trouvé');
}