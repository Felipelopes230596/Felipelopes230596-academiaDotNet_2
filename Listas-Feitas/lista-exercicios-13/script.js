//Exercicio 01 e 02
function redColor() {
  document.body.style.backgroundColor = "red";
}

function greenColor() {
  document.body.style.backgroundColor = "green";
}

function blueColor() {
  document.body.style.backgroundColor = "blue";
}

function yellowColor() {
  document.body.style.backgroundColor = "yellow";
}

//Exercicio 03
function radioSelect() {
  var opcao = document.getElementsByName("opcao");
  for (var i = 0; i < opcao.length; i++) {
    if (opcao[i].checked) {
      if (opcao[i].value === "red") {
        document.body.style.backgroundColor = "red";
      } else if (opcao[i].value === "green") {
        document.body.style.backgroundColor = "green";
      } else if (opcao[i].value === "blue") {
        document.body.style.backgroundColor = "blue";
      } else {
        document.body.style.backgroundColor = "yellow";
      }
    }
  }
}

//Exercicio 04
function mudaEstado() {
  var op = document.getElementById("texto04");
  if (op.style.display === "none") {
    op.style.display = "block";
  } else {
    op.style.display = "none";
  }
}

//Exercicio 05
function mudaEstadoBotao() {
  var x = document.getElementsByName("op");
  var botao = document.getElementById("botao");
  var check = 0;
  for (var i = 0; i < x.length; i++) {
    if (x[i].checked) {
      check++;
    }
    if (check === 2) {
      botao.disabled = false;
    } else {
      botao.disabled = true;
    }
  }
}

//Exercicio 06, 07 e 08
function blackF() {
  document.getElementById("texto06").style.color = "black";
}
function whiteF() {
  document.getElementById("texto06").style.color = "white";
}
function blackP() {
  document.getElementById("texto06").style.backgroundColor = "black";
}
function whiteP() {
  document.getElementById("texto06").style.backgroundColor = "white";
}

var tamanho = 16;

function aumenta() {
  tamanho = tamanho + 2;
  document.getElementById("texto06").style.fontSize = tamanho + "px";
}
function diminui() {
  tamanho = tamanho - 2;
  document.getElementById("texto06").style.fontSize = tamanho + "px";
}

function maiusculo() {
  document.getElementById("texto06").style.textTransform = "uppercase";
}
function minusculo() {
  document.getElementById("texto06").style.textTransform = "lowercase";
}

//Exercicio 09
function verificaOpcoes(e) {
  var l = document.getElementById("login");
  var s = document.getElementById("senha");
  var cS = document.getElementById("cSenha");
  var msg = document.getElementById("msg");
  var form = document.getElementById("form");
  var erro = 0;
  if (l.value === "") {
    l.style.backgroundColor = "red";
    msg.innerHTML = "Campo obrigatório em vermelho.";
    erro++;
  }
  if (s.value === "") {
    s.style.backgroundColor = "red";
    erro++;
  }
  if (cS.value === "") {
    cS.style.backgroundColor = "red";
    erro++;
  }
  if (cS.value !== s.value) {
    s.style.backgroundColor = "red";
    cS.style.backgroundColor = "red";
    msg.innerHTML = "Senhas divergentes.";
    erro++;
  }
  if (erro === 0) {
    e.submit();
  }
}

//Exercício 10
function validaRadio() {
  if (document.getElementById("fisica").checked) {
    document.getElementById("cpf").disabled = false;
    document.getElementById("cnpj").disabled = true;
  } else if (document.getElementById("juridica").checked) {
    document.getElementById("cnpj").disabled = false;
    document.getElementById("cpf").disabled = true;
  }
}
function validaCampos() {
  document.getElementById("nome").style.backgroundColor = null;
  document.getElementById("nascimento").style.backgroundColor = null;
  document.getElementById("endereco").style.backgroundColor = null;
  document.getElementById("cep").style.backgroundColor = null;
  document.getElementById("tel").style.backgroundColor = null;
  document.getElementById("email").style.backgroundColor = null;
  var erro = 0;
  if (document.getElementById("nome").value === "") {
    document.getElementById("nome").style.backgroundColor = "red";
    erro++;
  }
  if (
    document.getElementById("cnpj").disabled === true &&
    document.getElementById("cpf").disabled === true
  ) {
    document.getElementById("msg2").innerHTML = "Selecione uma das opções";
  }
  if (
    document.getElementById("fisica").checked &&
    document.getElementById("cpf").value === ""
  ) {
    document.getElementById("cpf").style.backgroundColor = "red";
    document.getElementById("cnpj").style.backgroundColor = null;
    document.getElementById("msg2").innerHTML = "";
    erro++;
  } else if (
    document.getElementById("juridica").checked &&
    document.getElementById("cnpj").value === ""
  ) {
    document.getElementById("cnpj").style.backgroundColor = "red";
    document.getElementById("cpf").style.backgroundColor = null;
    erro++;
  }
  if (document.getElementById("nascimento").value === "") {
    document.getElementById("nascimento").style.backgroundColor = "red";
    erro++;
  }
  if (document.getElementById("endereco").value === "") {
    document.getElementById("endereco").style.backgroundColor = "red";
    erro++;
  }
  if (document.getElementById("cep").value === "") {
    document.getElementById("cep").style.backgroundColor = "red";
    erro++;
  }
  if (document.getElementById("tel").value === "") {
    document.getElementById("tel").style.backgroundColor = "red";
    erro++;
  }
  if (document.getElementById("email").value === "") {
    document.getElementById("email").style.backgroundColor = "red";
    erro++;
  }

  if (erro > 0) {
    document.getElementById("msg").innerHTML = "Digite os campos em vermelho";
  } else {
    e.submit();
  }
}
