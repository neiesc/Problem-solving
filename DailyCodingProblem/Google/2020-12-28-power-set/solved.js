let input = [1, 2, 3];

let result = [[]]
  .concat(input.map((v, i) => [v]))
  .concat(input.flatMap((v, i) => [...input].splice(i+1).map(w => [v, w])))
  .concat([input]);

console.log(result);