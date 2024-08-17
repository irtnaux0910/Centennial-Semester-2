function generateTable(rows, cols) {    
    const table = document.createElement("table");
  
  
    const headerRow = document.createElement("tr");
    headerRow.insertCell().textContent = "";
    for (let col = 1; col <= cols; col++) {
      const headerCell = headerRow.insertCell();
      headerCell.textContent = `Column ${col}`;
    }
    table.appendChild(headerRow);
  
    
    for (let row = 1; row <= rows; row++) {
      const dataRow = document.createElement("tr");
      const rowCell = dataRow.insertCell();
      rowCell.textContent = `Row ${row}`;
  
      for (let col = 1; col <= cols; col++) {
        const dataCell = dataRow.insertCell();
        dataCell.textContent = `${row},${col}`;
      }
      table.appendChild(dataRow);
    }
  
 
    const container = document.getElementById("table-container");
    container.innerHTML = ""; 
    container.appendChild(table);
  }
  
  const form = document.getElementById("table-form");
  form.addEventListener("submit", function(event) {
    event.preventDefault();
  
    const rows = parseInt(document.getElementById("rows").value);
    const cols = parseInt(document.getElementById("cols").value);
  
    generateTable(rows, cols);
  });