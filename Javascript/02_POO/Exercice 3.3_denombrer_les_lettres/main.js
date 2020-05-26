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

const nombres = [];
for (let i = 0; i < str.length; i++) {
    search = str.charAt(i);
    result = str.split(search).length - 1;
    nombres.push(result);
}

for (let i = 0; i < nombres.length; i++) {
    console.log('Lettre ' + str[i] + ' a trouve ' + nombres[i] + ' fois dans le text.');

}