const user = document.getElementById("userName");
const productsList = document.getElementById("productsList");
const missionText = document.getElementById('missionText');
const changeColor = document.getElementById('changeColor');

window.onload = function() {
    let userName = prompt("What's your name?");
    user.textContent = userName;
  }

  let limit1 = false;
  let ul = document.createElement('ul')
  const showProducts = document.getElementById("showProducts");
  showProducts.addEventListener("click", function() {
      if (!limit1)
        {
          const unshowedProducts = ["Headphones","Gaming mouse","Custom Keyboard"];
          unshowedProducts.forEach(course => {
            const products = document.createElement("li");
            products.textContent = course;
            ul.appendChild(products);
          });
          productsList.appendChild(ul);
          limit1 = true;    
        }
  });

changeColor.addEventListener('click', function() {
  missionText.style.color = 'red';
});


