// validation logic
$.validator.addMethod("employeecode", function (value, element) {

    if (!value) {
        return false;
    }

    return value.startsWith("EMP");
});

// connect MVC data attributes to jQuery validation
$.validator.unobtrusive.adapters.add(
    "employeecode",
    [],
    function (options) {

        options.rules["employeecode"] = true;

        options.messages["employeecode"] =
            options.message;
    });