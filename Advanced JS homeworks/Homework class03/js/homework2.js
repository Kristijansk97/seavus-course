
$(document).ready(function () {
    $("button").click(function () {
        fetch("https://jsonplaceholder.typicode.com/users/1")
          .then(response => {
            response.json()
            .then(data => {
                console.log(data);
                $("#resultTable").append(`<tr><td>Id:</td><td>${data.id}</td></tr>`);
                $("#resultTable").append(`<tr><td>Name:</td><td>${data.name}</td></tr>`);
                $("#resultTable").append(`<tr><td>Username:</td><td>${data.username}</td></tr>`);
                $("#resultTable").append(`<tr><td>Email:</td><td>${data.email}</td></tr>`);
                $("#resultTable").append(`<tr><td>Address:</td><td>${data.address.street}</td></tr>`);
                $("#resultTable").append(`<tr><td></td><td>${data.address.suite}</td></tr>`);
                $("#resultTable").append(`<tr><td></td><td>${data.address.city}</td></tr>`);
                $("#resultTable").append(`<tr><td></td><td>${data.address.zipcode}</td></tr>`);
                $("#resultTable").append(`<tr><td>Geo:</td><td>${data.address.geo.lat}</td></tr>`);
                $("#resultTable").append(`<tr><td></td><td>${data.address.geo.lng}</td></tr>`);
                $("#resultTable").append(`<tr><td>Phone:</td><td>${data.phone}</td></tr>`);
                $("#resultTable").append(`<tr><td>Website:</td><td>${data.website}</td></tr>`);
                $("#resultTable").append(`<tr><td>Company:</td><td>${data.company.name}</td></tr>`);
                $("#resultTable").append(`<tr><td></td><td>${data.company.catchPhrase}</td></tr>`);
                $("#resultTable").append(`<tr><td></td><td>${data.company.bs}</td></tr>`);
                    });
            })
            .catch(err => {
                console.log(err);
            });
    });
});
