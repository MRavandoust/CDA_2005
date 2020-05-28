// Modéle récursif
{
    function palindrome(str) {
        let l = str.length;
        if (l == 1) return str;
        else {
            return palindrome(str.substring(l, l - 1)) + palindrome(str.substring(l - 1, 0));
        }
    }

    let str = 'radar';
    if (str === palindrome(str))
        console.log('Le mot "' + str + '" est un palindrome.');
    else
        console.log('Le mot "' + str + '" n\'est pas un palindrome.');
}


// Modéle non récursif
function isPalindrome(str) {
    let str1 = '';
    for (let i = str.length; i > 0; i--) {
        str1 += str.substring(i, i - 1);
    }
    if (str1 === str)
        console.log('Le mot "' + str + '" est un palindrome.');
    else
        console.log('Le mot "' + str + '" n\'est pas un palindrome.');
}


isPalindrome('masoud');




//Permutation des caractères

function Permutn(str, ans) {

    if (str.length == 0) {
        console.log(ans + " ");
        return;
    }

    for (let i = 0; i < str.length; i++) {
        let ch = str.charAt(i);
        let ros = str.substring(0, i) + str.substring(i + 1);
        Permutn(ros, ans + ch);
    }
}

console.log(Permutn('abc', ''));