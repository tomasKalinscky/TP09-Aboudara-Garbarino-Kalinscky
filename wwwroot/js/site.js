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

var working = false;
$('.login').on('submit', function(e) {
  e.preventDefault();
  if (working) return;
  working = true;
  var $this = $(this),
    $state = $this.find('button > .state');
  $this.addClass('loading');
  $state.html('Authenticating');
  setTimeout(function() {
    $this.addClass('ok');
    $state.html('Welcome back!');
    setTimeout(function() {
      $state.html('Log in');
      $this.removeClass('ok loading');
      working = false;
    }, 4000);
  }, 3000);
});

function mostrarMensajeDeError() {
  var mensajeAnterior = document.querySelector(".mensaje-error");
  if (mensajeAnterior) {
      mensajeAnterior.remove();
  }
  var mensajeDeError = document.createElement("h2");
  mensajeDeError.textContent = "Contraseña o usuario incorrecto";
  mensajeDeError.classList.add("mensaje-error");

  var primerGrupo = document.querySelector(".group");
  primerGrupo.parentElement.insertBefore(mensajeDeError, primerGrupo);
}
