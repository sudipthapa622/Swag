document.addEventListener("DOMContentLoaded", function () {
    const toggleButton = document.getElementById("darkModeToggle");
    const body = document.body;

    // Check saved preference
    const isDarkMode = localStorage.getItem("dark-mode") === "true";
    if (isDarkMode) {
        body.classList.add("dark-mode");
        toggleButton.textContent = "Light Mode";
    }

    // Toggle dark mode
    toggleButton.addEventListener("click", function () {
        body.classList.toggle("dark-mode");

        const isDark = body.classList.contains("dark-mode");
        toggleButton.textContent = isDark ? "Light Mode" : "Dark Mode";

        // Save preference
        localStorage.setItem("dark-mode", isDark);
    });
});
