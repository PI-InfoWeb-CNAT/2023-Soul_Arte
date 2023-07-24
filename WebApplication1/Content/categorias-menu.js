function abrir(){
  document.getElementById('migalha').style.marginTop = '36.5em';
   document.getElementById('cat-escondido').style.visibility = 'visible';
}
function fechar(){
  document.getElementById('migalha').style.marginTop = '25px';
  document.getElementById('cat-escondido').style.visibility = 'hidden';
}
function abrirdenuncia() {
    document.getElementById('denuncia').style.visibility = 'visible';
    document.getElementById('esmaecer').style.visibility = 'visible';
}
function fechardenuncia() {
    document.getElementById('denuncia').style.visibility = 'hidden';
    document.getElementById('esmaecer').style.visibility = 'hidden';
}