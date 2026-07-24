// Constants
const eventName = "Music Festival";
const eventDate = "25 July 2026";

// Variable
let seats = 50;

// Display event details
function displayEvent() {
    document.getElementById("eventInfo").innerHTML = `
        <h2>${eventName}</h2>
        <p><strong>Date:</strong> ${eventDate}</p>
        <p><strong>Available Seats:</strong> ${seats}</p>
    `;
}

// Register a user
function registerUser() {

    if (seats > 0) {
        seats--;
        alert("Registration Successful!");
        displayEvent();
    } else {
        alert("Sorry! No seats available.");
    }

}

// Display details when page loads
displayEvent();
