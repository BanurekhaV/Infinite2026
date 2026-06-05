$(document).ready(function () {
    //1. Register a custom validation method 
    $.validator.addMethod("minimumage", function (value, element, params) {
        //params  : the min age passed via data-val-minimumage-min
        var minAge = parseInt(params);
        if (isNan(minAge)) {
            return false;  //invalid parameter

            //parse the input value (date of birth)
            var dateOfBirth = new Date(value);
            if (isNan(dateOfBirth.getTime())) {
                return false;  // invalid date
            }

            //calculate the age (same as the server)
            var today = new Date();
            var age = today.getFullYear() - dateOfBirth.getFullYear();
            var monthDiff = today.getMonth() - dateOfBirth.getMonth();
            if (monthDiff < 0 || (monthDiff === 0 && today.getDate() < dateOfBirth.getDate())) {
                age--;
            }

            //return true if age > = minAge
            return age >= minAge;
        });

    //2. Create an adapter to map data attributes to the validation method
    $.validator.unobtrusive.adapters.add("minimumage",)["min"], function (options) {
        //options.params : will contain "min" from the data attribute 
        options.rules["minimumage"] = options.params.min;
        options.messages["minimumage"] = options.message;
    }
});
//});