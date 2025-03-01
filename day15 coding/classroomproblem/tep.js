var names = [];
names.push("sakshi");
names.push("rohan");
console.log(names);
var names1 = [];
names1.push("sakshi");
names1.push(12);
console.log(names1);
var nums = [4, 6, 7, 8];
console.log(nums[3]);
//Tuples types array with predefined length and types for each index
var myTuple;
myTuple = [45, "Ts is superset of js", true];
console.log(myTuple);
var book = {
    name: "typescript programming",
    price: 400,
};
// class SimpleIterator {
//   private current: number;
//   private end: number;
//   constructor(start: number, end: number) {
//       this.current = start;
//       this.end = end;
//   }
//   public next(): IteratorResult<number> {
//       if (this.current <= this.end) {
//           return { value: this.current++, done: false };
//       } else {
//           return { value: null, done: true };
//       }
//   }
// }
// const iterator = new SimpleIterator(1, 5);
// let result = iterator.next();
// while (!result.done) {
//   console.log(result.value);
//   result = iterator.next();
// }
