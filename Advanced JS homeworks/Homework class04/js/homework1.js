let page = 1;
$('#next').hide();
$('#previous').hide();

$('#btn').click(() => {
    $('#next').show();
    $('#btn').hide();
    fetchData();
    page++;
});

$('#next').click(() => {
    $('#previous').show();
    $('#next').hide();
    fetchData();
    page--;
});

$('#previous').click(() => {
    $('#previous').hide();
    $('#next').show();
    fetchData();
    page++;
});

const fetchData = () => {
    let url = `https://swapi.dev/api/planets/?page=${page}`;
    fetch(url)
        .then(res => res.json())
        .then(r => {
            updateHTML(r.results);
        });
}

const updateHTML = planets => {
    $('#planet-info').empty();
    planets.forEach((planet, index) => {
        let html = '';
        html += `
            <tr>
                <td>${index + 1}</td>
                <td>${planet.name}</td>
                <td>${planet.population}</td>
                <td>${planet.climate}</td>
                <td>${planet.gravity}</td>
            </tr>`

        $('#planet-info').append(html)
    })
}