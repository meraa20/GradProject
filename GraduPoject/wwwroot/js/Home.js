document.addEventListener('DOMContentLoaded', function () {
    // Event listener for the signup button
    var signupBtn = document.getElementById("signup-btn");
    if (signupBtn) {
        signupBtn.addEventListener("click", function (event) {
            event.preventDefault(); // Prevent form from submitting
            window.location.href = '@Url.Action("login", "Account")'; // استخدم الـ ASP.NET URL هنا
        });
    }

    // Event listener for the login button
    var loginBtn = document.getElementById("login-btn");
    if (loginBtn) {
        loginBtn.addEventListener("click", function (event) {
            event.preventDefault(); // Prevent form from submitting
            window.location.href = '@Url.Action("Login", "Account")'; 
        });
    }

    // Event listener for the log button
    var logBtn = document.getElementById("log");
    if (logBtn) {
        logBtn.addEventListener("click", function (event) {
            event.preventDefault(); // Prevent form from submitting
            window.location.href = '@Url.Action("login", "AccountController")'; 
        });
    }
});
