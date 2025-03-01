// Example of rest and spread operator
const summ = (...nums) => nums.reduce((acc, curr) => acc + curr, 0);
console.log(`Sum using rest operator : ${summ(2, 4, 5, 6, 8)}`);
//spread operator
const arr1 = [2, 3, 4];
const arr2 = [5, 6, 8];
const summing = [...arr1, ...arr2]; //  is used to expand the contents of an iterable (arrays , string  ) into individual elements.
console.log("array combination :", summing);

// combining array , copying an array  , combining objects , passing multiple arguments to a function , converting string to an array

const originalArr = [1, 2, 3];
const copiedArr = [...originalArr];
console.log(copiedArr); // [1, 2, 3]


const obj1 = { name: "Alice", age: 25 };
const obj2 = { city: "New York", country: "USA" };
const combinedObj = { ...obj1, ...obj2 };
console.log(combinedObj); // { name: "Alice", age: 25, city: "New York", country: "USA" }

const str = "hello world";
const arr = str.split(" ");
console.log(arr); // ["hello", "world"]
