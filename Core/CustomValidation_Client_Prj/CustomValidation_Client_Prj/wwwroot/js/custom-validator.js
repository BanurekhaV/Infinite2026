// Wait for the document to be fully loaded
$(document).ready(function () {
    // 1. Register a custom validation method named "minimumage"
    $.validator.addMethod("minimumage", function (value, element, params) {
        console.log("Reached Client Validation");
        // params: The minimum age passed via data-val-minimumage-min
        var minAge = parseInt(params);
        if (isNaN(minAge)) {
            return false; // Invalid parameter
        }

        // Parse the input value (date of birth)
        var dateOfBirth = new Date(value);
        if (isNaN(dateOfBirth.getTime())) {
            return false; // Invalid date
        }

        // Calculate age (same logic as server-side)
        var today = new Date();
        var age = today.getFullYear() - dateOfBirth.getFullYear();
        var monthDiff = today.getMonth() - dateOfBirth.getMonth();
        if (monthDiff < 0 || (monthDiff === 0 && today.getDate() < dateOfBirth.getDate())) {
            age--;
        }

        // Return true if age >= minAge
        return age >= minAge;
    });

    // 2. Create an adapter to map data attributes to the validation method
    $.validator.unobtrusive.adapters.add("minimumage", ["min"], function (options) {
        // options.params: Will contain "min" (from data-val-minimumage-min)
        options.rules["minimumage"] = options.params.min;
        options.messages["minimumage"] = options.message; // Error message from data-val-minimumage
    });
});