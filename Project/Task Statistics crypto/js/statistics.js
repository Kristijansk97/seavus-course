$(document).ready(function(){
fetch("https://api.coingecko.com/api/v3/coins/markets?vs_currency=eur&order=market_cap_desc%2C%20gecko_desc%2C%20gecko_asc%2C%20market_cap_asc%2C%20market_cap_desc%2C%20volume_asc%2C%20volume_desc%2C%20id_asc%2C%20id_desc&per_page=100&page=1&sparkline=true&price_change_percentage=1h%2C%2024h%2C%207d%2C%2014d%2C%2030d%2C%20200d%2C%201y",{
  method : "GET",
  mode : "cors",
  headers: ({
    'Access-Control-Allow-Origin':'*'
  })
})
.then(response => response.json())
.then(data => {
     console.log(data);
     for (x of data) {
      $("#coin").append(`<tr><td>${x.name}</td></tr>`);
      $("#symbol").append(`<tr><td>${x.symbol}</td></tr>`);
      $("#logo").append(`<tr><td><img src="${x.image} width="18" height="18"/></td></tr>`);
      $("#currentPrice").append(`<tr><td>${x.current_price}$</td></tr>`);
      $("#24hStatistics").append(`<tr><td>${x.price_change_percentage_24h}%</td></tr>`);
      $("#volume").append(`<tr><td>${x.total_volume}</td></tr>`);
      $("#cap").append(`<tr><td>${x.market_cap}</td></tr>`);
      $("#7d").append(`<tr><td><canvas id="${x.name + "chart"}" width="280" height="23"></canvas></td></tr>`);
      const ctx = document.getElementById(x.name + "chart").getContext('2d');
      const myChart = new Chart(ctx, { 
        type: 'line',
            data: {datasets:[{data:x.sparkline_in_7d.price}],labels:[...Array(x.sparkline_in_7d.price.length).keys()]},
            options: {
              responsive: false,
              legend: {
                display: false
              },
              elements: {
                line: {
                  borderColor: x.sparkline_in_7d.price[0]>x.sparkline_in_7d.price[1] ? '#2EFF1D':'#FF1D1D',
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

      })
.catch (err=> {
   console.log(err);
     });
});
