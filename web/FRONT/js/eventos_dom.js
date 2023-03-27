document.addEventListener("mousemove", function(event) {
  let x = event.clientX;
  let y = event.clientY;
  let mousePosition = "Posición del mouse: " + x + ", " + y;
  document.getElementById("mousePosition").innerHTML = mousePosition;
});

document.getElementById("form1-submit").addEventListener("click", function(event) {
  event.preventDefault();
  let firstName = document.getElementById("form-fname").value;
  let lastName = document.getElementById("form-lname").value;
  let fullName = firstName + " " + lastName;
  let nameElement = document.createElement("p");
  let nameText = document.createTextNode(fullName);
  nameElement.appendChild(nameText);
  document.getElementById("form1").appendChild(nameElement);
});
  
document.getElementById("btn-insert-r").addEventListener("click", function(event) {
  let table = document.getElementById("sampleTable");
  let row = table.insertRow(1);
  let cell1 = row.insertCell(0);
  let cell2 = row.insertCell(1);
  cell1.innerHTML = "New row column 1";
  cell2.innerHTML = "New row column 2";
});

document.getElementById("btn-insert-c").addEventListener("click", function(event) {
  let table = document.getElementById("sampleTable");
  for (let i = 0; i < table.rows.length; i++) {
    let cell = table.rows[i].insertCell(1);
    cell.innerHTML = "New column";
  }
});

document.getElementById("btn-change").addEventListener("click", function(event) {
  var rowIndex = document.getElementById("rowIndex").value;
  var colIndex = document.getElementById("colIndex").value;
  var newValue = document.getElementById("newValue").value;
  var table = document.getElementById("myTable");
  table.rows[rowIndex-1].cells[colIndex-1].innerHTML = newValue;
});

const colorSelect = document.querySelector('#colorSelect');
const btnAddColor = document.querySelector('#btn-add-color');
const btnRmvColor = document.querySelector('#btn-rmv-color');

const colors = ['Red', 'Green', 'White', 'Black'];

btnAddColor.addEventListener('click', () => {
  // Generar un color aleatorio de la lista de colores predefinidos
  const randomColor = colors[Math.floor(Math.random() * colors.length)];
  
  // Crear un nuevo elemento de opción y agregarlo a la lista de opciones
  const option = document.createElement('option');
  option.textContent = randomColor;
  colorSelect.appendChild(option);
});

btnRmvColor.addEventListener('click', () => {
  // Obtener el índice del elemento seleccionado y removerlo de la lista de opciones
  const selectedIndex = colorSelect.selectedIndex;
  if (selectedIndex !== -1) {
    colorSelect.remove(selectedIndex);
  }
});

document.getElementById("imagenGato").addEventListener("mouseenter", function(event) {
    // Generar dos números aleatorios entre 300 y 600
    var width = Math.floor(Math.random() * (600 - 300 + 1) + 300);
    var height = Math.floor(Math.random() * (600 - 300 + 1) + 300);
    
    // Crear una nueva URL con los valores aleatorios de ancho y alto
    var url = "http://placekitten.com/" + width + "/" + height;
    
    // Actualizar el atributo src de la imagen
    document.getElementById("imagenGato").setAttribute("src", url);
  });

