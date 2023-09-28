function validarContraseña(contra) {
    let countCaracteres = 0;
    const caracteresMin = 8;
    let especial = false;
    let mayus = false;
    while (countCaracteres < contra.length) {
        mayus = contra[countCaracteres] === contra[countCaracteres].toUpperCase() && contra[countCaracteres] !== contra[countCaracteres].toLowerCase();
        especial = /[^a-zA-Z0-9\s]/.test(contra[countCaracteres]);
        if (countCaracteres >= caracteresMin && especial && mayus) return true;
        countCaracteres++;
    }
    return false;
}



