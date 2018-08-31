function loadData() {
  fetch("http://localhost:60770/api/Movies")
    .then(response => response.json())
    .then(request => {
      let test = "";
      for (let i = 0; i < request.length; i++) {
        let test = `
        <tr>
        <td>${request[i].Category}</td>
        <td>${request[i].Title}</td>
        <td>${request[i].Rating}</td>
        <td>${request[i].Description}</td>
        </tr>
        `;
        $(test).appendTo("#movies");
      }
    });
}

function loadCategoryData() {
  $("#tableClear")
    .find("tbody")
    .empty();
  fetch("http://localhost:60770/api/Movies")
    .then(response => response.json())
    .then(data => {
      let test = "";
      for (let i = 0; i < data.length; i++) {
        if (
          data[i].Category === document.getElementById("movieCategory").value
        ) {
          let test = `
            <tr>
            <td>${data[i].Category}</td>
            <td>${data[i].Title}</td>
            <td>${data[i].Rating}</td>
            <td>${data[i].Description}</td>
            </tr>
            `;
          $(test).appendTo("#tableCategory");
        }
      }
    });
}

function toggleTable() {
  var x = document.getElementById("tableToggle");
  if (x.style.display === "block") {
    x.style.display = "none";
  } else {
    x.style.display = "block";
  }
}
