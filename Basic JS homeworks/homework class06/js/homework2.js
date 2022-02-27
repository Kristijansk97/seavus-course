function weighInChickens() {
    let weight = prompt('Enter weight in kilograms:');
    let totalChickens = weight / 0.5;

    let title = document.createElement('h3');
    title.innerHTML = 'Weight conversion';
    document.body.appendChild(title);

    let result = document.createElement('p');
    result.innerHTML = totalChickens;

    document.body.appendChild(result);
}
document.body.addEventListener('load', weighInChickens());