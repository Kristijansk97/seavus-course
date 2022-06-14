$(document).ready(function () {
  fetch("https://api.coingecko.com/api/v3/coins/markets?vs_currency=eur&order=market_cap_desc%2C%20gecko_desc%2C%20gecko_asc%2C%20market_cap_asc%2C%20market_cap_desc%2C%20volume_asc%2C%20volume_desc%2C%20id_asc%2C%20id_desc&per_page=100&page=1&sparkline=true&price_change_percentage=1h%2C%2024h%2C%207d%2C%2014d%2C%2030d%2C%20200d%2C%201y", {
    method: "GET",
    mode: "cors",
    headers: ({
      'Access-Control-Allow-Origin': '*'
    })
  })
    .then(response => response.json())
    .then(data => {
      let coinsTable = $('#growingTable');
      for (x of data) {
        if (x.price_change_percentage_24h > 0) {
          let row = "";
          row = `<tr>
                <td>${x.name}</td>
                <td>${x.symbol}</td>
                <td><img src="${x.image} width="18" height="18"/></td>
                <td>${x.price_change_percentage_24h}%</td>
                <td>${x.current_price}$</td>
                <td><canvas id="${x.name + "chart"}" width="120" height="36"></canvas></td>
                </tr>`
          coinsTable.append(row);
          const ctx = document.getElementById(x.name + "chart").getContext('2d');
          const myChart = new Chart(ctx, {
            type: 'line',
            data: { datasets: [{ data: x.sparkline_in_7d.price }], labels: [...Array(x.sparkline_in_7d.price.length).keys()] },
            options: {
              responsive: false,
              legend: {
                display: false
              },
              elements: {
                line: {
                  borderColor: '#2EFF1D',
                  borderWidth: 1
                },
                point: {
                  radius: 0
                }
              },
              tooltips: {
                enabled: false
              },
              scales: {
                yAxes: [
                  {
                    display: false
                  }
                ],
                xAxes: [
                  {
                    display: false
                  }
                ]
              }
            }
          });
        }
      }
    })
    .catch(err => {
      console.log(err);
    });
});
