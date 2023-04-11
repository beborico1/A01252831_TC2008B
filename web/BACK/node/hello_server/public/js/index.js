async function fetchData() {
  const request = await fetch('http://127.0.0.1:5000/api/hello', {
    method: 'GET',
  });
 
  if (request.ok) {
    const message = await request.text();
 
    console.log(message);
 
    const resultDiv = document.getElementById('response-placeholder');
    resultDiv.innerHTML = message;
  }
}
 
// Llamar a la función
fetchData();
  