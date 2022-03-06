let products = [
    {name: 'Milk', category: 'Food', hasDiscount: false, price: 47},
    {name: 'Cheese', category: 'Food', hasDiscount: true, price: 170},
    {name: 'Bread', category: 'Food', hasDiscount: false, price: 17},
    {name: 'Almonds', category: 'Food', hasDiscount: true, price: 90},
    {name: 'Coca-Cola', category: 'Drinks', hasDiscount: true, price: 25},
    {name: 'Water', category: 'Drinks', hasDiscount: true, price: 18},
    {name: 'Cigarettes', category: 'Drugs', hasDiscount: false, price: 120},
    {name: 'Chips', category: 'Food', hasDiscount: false, price: 70},
    {name: 'Jameson', category: 'Drinks', hasDiscount: true, price: 250},
    {name: 'Beer', category: 'Drinks', hasDiscount: true, price: 37},
    {name: 'Snickers', category: 'Food', hasDiscount: true, price: 15},
    {name: 'Dorina', category: 'Food', hasDiscount: false, price: 55},
    {name: 'Colgate', category: 'Hygiene', hasDiscount: false, price: 85},
    {name: 'Orbit', category: 'Food', hasDiscount: false, price: 12},
    {name: 'Head&Shoulders', category: 'Hygiene', hasDiscount: false, price: 110}
];

function beginsWithVowel(word) {
    return ['a', 'e', 'i', 'o', 'u'].indexOf(word[0].toLowerCase()) !== -1;
}

function Product(products) {
    this.highFunc = (cb) => {
        cb(products);
    }
}

const getProducts = (products) => {
    for (const product of products) {
        if (product.price > 20) {
            console.log(product.name);
        }
    }
}

const getFoodCategory = (products) => {
    for (product of products) {
        if (product.hasDiscount && product.category === 'Food') {
            console.log(product.name);
        }
    }

}

const averagePrice = (products) => {
    let avg = 0;
    let counter = 0;
    for (product of products) {
        if (product.hasDiscount) {
            avg += product.price;
            counter++;
        }
    }
    console.log(avg / counter);
}

const vowelProducts = (products) => {
    for (const product of products) {
        if (beginsWithVowel(product.name) && !product.hasDiscount)
            console.log(product.name)
    }
}

const sortProducts = (products) => {
    let pricesArr = [];

    for (product of products) {
        pricesArr.push(product.price);
        pricesArr.sort((a, b) => a - b);
    }

    console.log(pricesArr);
}
let pro = new Product(products);
pro.highFunc(getProducts);
// pro.highFunc(getFoodCategory);
// pro.highFunc(averagePrice);
// pro.highFunc(vowelProducts);
// pro.highFunc(sortProducts);