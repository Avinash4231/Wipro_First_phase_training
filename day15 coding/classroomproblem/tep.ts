const names: string[] = [];
names.push("sakshi");
names.push("rohan");
console.log(names);


const names1: any[] = [];
names1.push("sakshi");
names1.push(12);
console.log(names1);

const nums: number[] = [4,6,7,8];
console.log(nums[3]);


//Tuples types array with predefined length and types for each index


let myTuple: readonly [number,string, boolean];

myTuple=[45, "Ts is superset of js" , true];

console.log(myTuple);

const book: { name: string, price: number, publisher?: string } = {
  
  name: "typescript programming",
  price:  400,
 
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