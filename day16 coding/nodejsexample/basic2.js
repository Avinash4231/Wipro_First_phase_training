async function fetchUser() {
  console.log("fetching data...");
  let response = await fetch("https://jsonplaceholder.typicode.com/users/1");
  let user = await response.json();
  console.log("User data : ", user);
}
console.log("Initiate the process");
fetchUser();
console.log("process completed");
//using .then
console.log("Initiate the process");
async function fetchUser() {
  console.log("fetching data...");
  fetch("https://jsonplaceholder.typicode.com/users/1")
    .then((response) => response.json())
    .then((user) => console.log("User Data ...", user));
}
fetchUser();
console.log("process completed");