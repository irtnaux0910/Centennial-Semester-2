const user = document.getElementById("userName");
const courseList = document.getElementById("courseList");
const mission = document.getElementById("mission");
const skillList = document.getElementById("skillList");


window.onload = function() {
  let userName = prompt("What's your name?");
  user.textContent = userName;
}


let limit1 = false;
let ul = document.createElement('ul')
const showPCourses = document.getElementById("showPCourses");
showPCourses.addEventListener("click", function() {
    if (!limit1)
      {
        const previousCourses = ["COMM-160_161 College Communication 1", "COMP-100 Programming I","COMP-120 Software Engineering Fundamentals",
          "COMP-213 Web Interface Design","GNED-226 Video Games","MATH-175 Functions and Number Systems"
        ]; 
        previousCourses.forEach(course => {
          const courseListItem = document.createElement("li");
          courseListItem.textContent = course;
          ul.appendChild(courseListItem);
        });
        courseList.appendChild(ul);
        limit1 = true;    
      }
});
  


const changeColor = document.getElementById("changeTextColor");
changeColor.addEventListener("click", function() {
  mission.style.color = "red";
});

let limit = false
const addReactButton = document.getElementById("addReact");
addReactButton.addEventListener("click", function() {
  if (!limit)
    {
    const newSkill = document.createElement("li");
    newSkill.textContent = "React";
    skillList.insertBefore(newSkill, skillList.firstChild);
    limit = true;
    }
});
