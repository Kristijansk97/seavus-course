function factorialize(num) {
    if (num < 0) 
          return -1;
    else if (num == 0) 
        return 1;
     {
     return (num * factorialize(num - 1));
  }
};
console.log(factorialize(5));
console.log(factorialize(7));
console.log(factorialize(4));