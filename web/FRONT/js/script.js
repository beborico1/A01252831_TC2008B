function primerNoRepetido() {
    const MiInput = document.getElementById("textinput_primerNoRepetido");
    const str = MiInput.value;
    for (const char of str) {
        const count = str.split(char).length - 1;
        if (count == 1) { // Si no esta repetido
            document.getElementById("resultado_primerNoRepetido").textContent=char;
            return;
        }
    }
    document.getElementById("resultado_primerNoRepetido").textContent = "No se encontró el carácter";
}

function bubbleSort() {
    const MiInput = document.getElementById("textinput_bubbleSort");
    const texto = MiInput.value; // obtener texto
    
    lista_de_strings = texto.split(","); // separar por comas
    lista_de_numeros = [];

    for (const str of lista_de_strings) {
      try{
        numeros = str.match(/(\d+)/); // dejar solo numeros
        numero = Number(numeros[0]);
        lista_de_numeros.push(numero);
      } catch {
        console.log("No habia numeros");
      }
    }

    const len = lista_de_numeros.length;

    for (let i = 0; i < len; i++) {
      for (let j = 0; j < len - 1; j++) {
        if (lista_de_numeros[j] > lista_de_numeros[j + 1]) {
          const temp = lista_de_numeros[j];
          lista_de_numeros[j] = lista_de_numeros[j + 1];
          lista_de_numeros[j + 1] = temp;
        }
      }
    }

    result_string = "";

    for (const num of lista_de_numeros) { // Creamos un string con el resultado
      result_string+=String(num)+", ";
    }

    if (result_string.length >= 2) {  // Quitamos la ultima coma
      result_string = result_string.substring(0,result_string.length-2);
    }

    document.getElementById("resultado_bubbleSort").textContent = result_string;
}

// Escribe dos funciones: la primera que 
// invierta un arreglo de números y regrese 
// un nuevo arreglo con el resultado; la segunda 
// que modifique el mismo arreglo que se pasa como argumento. 
// No se permite usar la función integrada "reverse".

function regresaUnNuevoArreglo() {
  const MiInput = document.getElementById("textinput_reverse");
  const texto = MiInput.value;
  const arr = texto.split(",");

  let newArr=[];

  for (const elemento of arr) {
    newArr.unshift(elemento);//Inserta elemento al principio
  }

  arr_string = "";
  for (const elemento of arr) { // Creamos un string con el resultado
    arr_string+=String(elemento)+", ";
  }
  if (arr_string.length >= 2) {  // Quitamos la ultima coma
    arr_string = arr_string.substring(0,arr_string.length-2);
  }

  newArr_string = "";

  for (const elemento of newArr) { // Creamos un string con el resultado
    newArr_string+=String(elemento)+", ";
  }
  if (newArr_string.length >= 2) {  // Quitamos la ultima coma
    newArr_string = newArr_string.substring(0,newArr_string.length-2);
  }

  console.log(newArr_string)

  document.getElementById("resultado_reverseOG").textContent = arr_string;
  document.getElementById("resultado_reverse").textContent = newArr_string;
}

function editarArreglo() {
  const MiInput = document.getElementById("textinput_reverse");
  const texto = MiInput.value;

  let arr = texto.split(",");
  
  for (let i = 0; i < Math.floor(arr.length / 2); i++) {
    const temp = arr[i]; // almacenar temporalmente el elemento actual
    arr[i] = arr[arr.length - 1 - i]; // reemplazar el elemento actual con el elemento simétrico del final
    arr[arr.length - 1 - i] = temp; // reemplazar el elemento simétrico del final con el elemento almacenado temporalmente
  }

  arr_string = "";
  for (const elemento of arr) { // Creamos un string con el resultado
    console.log("Hola")
    arr_string+=String(elemento)+", ";
  }
  if (arr_string.length >= 2) {  // Quitamos la ultima coma
    arr_string = arr_string.substring(0,arr_string.length-2);
  }

  document.getElementById("resultado_reverseOG").textContent = arr_string;
}

// Escribe una función que reciba 
// una cadena de texto y regrese una nueva 
// con la primer letra de cada palabra en mayúscula.
function capitalizar() {
  const MiInput = document.getElementById("textinput_capitalize");
  const texto = MiInput.value;

  let splitStr = texto.toLowerCase().split(" ");

  for (let i = 0; i < splitStr.length; i++) {
      splitStr[i] = splitStr[i].charAt(0).toUpperCase() + splitStr[i].substring(1);     
  }

  const textoCapitalizado = splitStr.join(" "); 
  document.getElementById("resultado_capitalize").textContent = textoCapitalizado;
}

// Escribe una función que calcule el máximo común divisor de dos números.

function maximoComunDivisior() {
  const num1 = document.getElementById("textinput_num1").value;
  const num2 = document.getElementById("textinput_num2").value;

  let mayor = 0;
  if (num1 > num2) {
    mayor = num1;
  } else {
    mayor = num2;
  }

  let mayorDivisor = -1;

  for (let i = 0; i < mayor; i++) {
    if (num1 % i == 0 && num2 % i == 0) {
      mayorDivisor = i;
    }
  }
  document.getElementById("resultado_mayorDivisor").textContent = String(mayorDivisor);
}

function HackerSpeak() {
  str = document.getElementById("textinput_hackerspeak").value;
  let hackerStr = "";

  for (let i = 0; i < str.length; i++) {
      const char = str.charAt(i);
      switch (char) {
          case "a":
          hackerStr += "@";
          break;
          case "e":
          hackerStr += "3";
          break;
          case "i":
          hackerStr += "1";
          break;
          case "o":
          hackerStr += "0";
          break;
          case "s":
          hackerStr += "$";
          break;
          default:
            hackerStr += char;
      }
  }

  document.getElementById("resultado_hackerspeak").textContent = hackerStr;
}

function Factores() {
  try {
    valor = document.getElementById("textinput_factor").value;
    valor_num = valor.match(/(\d+)/); // dejar solo numeros
  
    let factores = [];
  
    for (let i = 1; i <= valor; i++) {
        if (valor % i === 0) {
            factores.push(String(i));
        }
    }
  
    const factores_string = factores.join(", "); 
    document.getElementById("resultado_factor").textContent = factores_string;
  } catch (error) {
    console.log("No se encontraron numeros",error);
  }
}

function Duplicados() {
  const MiInput = document.getElementById("textinput_noduplicados");
  const texto = MiInput.value;

  let arr = texto.split(",");
  let NoDuplicados = [];

  for (let i = 0; i < arr.length; i++) {
      if (NoDuplicados.indexOf(arr[i]) === -1) {
          NoDuplicados.push(arr[i]);
      }
  }

  const noduplicados_string = NoDuplicados.join(", "); 
  document.getElementById("resultado_noduplicados").textContent = noduplicados_string;
}

function Longitud() {
  const MiInput = document.getElementById("textinput_longitud");
  const texto = MiInput.value;
  let lista = texto.split(",");

  let longitud1 = Infinity;
  for (let i = 0; i < lista.length; i++) {
      if (lista[i].length < longitud1) {
          longitud1 = lista[i].length;
      }
  }

  document.getElementById("resultado_longitud").textContent = String(longitud1);
}

function EsPalindromo() {
  str = document.getElementById("textinput_palindromo").value.replace(/[\W_]/g, '').toLowerCase(); // Eliminamos los caracteres no alfanuméricos y convertimos a minúsculas
  document.getElementById("resultado_palindromo").textContent = (str === str.split('').reverse().join('')) ? "Si" : "No"; // Comparamos el string original con su reverso
}

function ordenarAZList() {
  const MiInput = document.getElementById("textinput_ordenarAZList");
  const texto = MiInput.value.replace(/\s+/g, '');
  let lista = texto.split(",");
  document.getElementById("resultado_ordenarAZList").textContent= lista.sort().join(", ");
}

function MedianaYModa() {
  listaString = document.getElementById("textinput_medianaymoda").value.replace(/\s+/g, '');

  listaStrings = listaString.split(",");

  const lista = listaStrings.map(function(elemento) {
    return parseFloat(elemento);
  });

  console.log(lista);

  // Ordenamos la lista de números de menor a mayor
  lista.sort(function(a, b) {
    return a - b; // Función de comparación para ordenar la lista de números
  });

  // Calculamos la mediana
  let mediana;
  let mitad = Math.floor(lista.length / 2); // Indice de la mitad de la lista

  if (lista.length % 2 === 0) {  // Si la lista es de longitud par
    mediana = (lista[mitad - 1] + lista[mitad]) / 2; // Promedio de los dos valores centrales
  } else {
    mediana = lista[mitad]; // Valor central si la lista es de longitud impar
  }

  // Calculamos la moda
  let moda = [];
  let contador = {}; // Objeto para contar la frecuencia de cada número
  let maximo = 0; // Valor máximo de frecuencia

  for (let i = 0; i < lista.length; i++) {
    let numero = lista[i];
    contador[numero] = (contador[numero] || 0) + 1;  // Incrementamos la frecuencia del número en el objeto contador

    if (contador[numero] > maximo) { // Si encontramos una frecuencia mayor que el valor máximo actual
      maximo = contador[numero]; // Actualizamos el valor máximo
    }
  }

  if (maximo === 1) {  // Si el valor máximo es 1, no hay moda
    document.getElementById("resultado_mediana").textContent = String(mediana);
    document.getElementById("resultado_moda").textContent = "No hay moda";
    return;
  } else {
    for (let clave in contador) { // Iteramos por cada propiedad del objeto contador
      if (contador.hasOwnProperty(clave)) { 
        if (contador[clave] === maximo) { // Si la frecuencia de la propiedad es igual al valor máximo
          moda.push(parseInt(clave)); // Añadimos el número correspondiente al array moda
        }
      }
    }
  }

  document.getElementById("resultado_mediana").textContent = String(mediana);
  document.getElementById("resultado_moda").textContent = moda.join(", ");
}

function cadenaMasFrecuente() {
  let listaCadenas = document.getElementById("textinput_masfrecuente").value.replace(/\s+/g, '').split(",");
  
  const frecuencias = {};
  let cadenaMasFrecuente = "";
  let maxFrecuencia = 0;

  // Contar la frecuencia de cada cadena
  listaCadenas.forEach(function(cadena) {
    frecuencias[cadena] = (frecuencias[cadena] || 0) + 1;
    if (frecuencias[cadena] > maxFrecuencia) {
      maxFrecuencia = frecuencias[cadena];
      cadenaMasFrecuente = cadena;
    }
  });

  document.getElementById("resultado_masfrecuente").textContent = cadenaMasFrecuente;
}

function esPotenciaDeDos() {
  let num = 0;
  try {
    num = Number(document.getElementById("textinput_potenciados").value);
  } catch {
    console.log("Eso no es un numero!")
  }
    // Si el número es 0, no es potencia de dos
    if (num === 0) {
      document.getElementById("resultado_potenciados").textContent = "No";
      return;
    }
  
    // Comprueba si el número es una potencia de dos
    while (num !== 1) {
      // Si el número no es divisible por 2, no es potencia de dos
      if (num % 2 !== 0) {
        document.getElementById("resultado_potenciados").textContent = "No";
        return;
      }
      num /= 2;
    }
  
    // Si llegamos aquí, el número es una potencia de dos
    document.getElementById("resultado_potenciados").textContent = "Si";
}

function ordenDescendente() {
  listaString = document.getElementById("textinput_ordenDescendente").value.replace(/\s+/g, '');

  listaStrings = listaString.split(",");

  const lista = listaStrings.map(function(elemento) {
    return parseFloat(elemento);
  });

  lista.sort((a, b) => b - a);

  document.getElementById("resultado_ordenDescendente").textContent = lista.join(", ");
}

// Ejercicio 11 JS
function ordenarAZPalabra() {
  const inputText = document.getElementById("myInput").value;
  const caracteres = inputText.split(""); // Para dividir string en char
  caracteres.sort(); // Para ordenar en orden alfabetico
  const orderText = caracteres.join("");
  document.getElementById("myList").textContent=orderText;
}