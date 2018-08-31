function loadData() {
  $("#tableClear")
    .find("tbody")
    .empty();
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
  fetch(
    `http://localhost:60770/api/Movies?Category=${
      document.getElementById("movieCategory").value
    }`
  )
    .then(response => response.json())
    .then(data => {
      let test = "";
      for (let i = 0; i < data.length; i++) {
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
    });
}

function loadRandomMovieData() {
  $("#tableClear")
    .find("tbody")
    .empty();
  let random = getRandomIntInclusive(1, 10);
  fetch(`http://localhost:60770/api/Movies/${random}`)
    .then(response => response.json())
    .then(request => {
      let test = "";
      let movieArray = [
        request.Category,
        request.Title,
        request.Rating,
        request.Description
      ];
      movieArray.forEach(item => {
        test += `
      <td>${item}</td>
      `;
        document.querySelector("#random").innerHTML = test;
      });
    });
}

function getRandomIntInclusive(min, max) {
  min = Math.ceil(min);
  max = Math.floor(max);
  return Math.floor(Math.random() * (max - min + 1)) + min;
}

function toggleTable() {
  var x = document.getElementById("tableToggle");
  if (x.style.display === "block") {
    x.style.display = "none";
  } else {
    x.style.display = "block";
  }
}
