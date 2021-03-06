// JavaScript source code
$("#submitButton").click ( function () {
    //assign numbers in input fields to variables and calculate grade weight
    var assignmentsPercent = $("#assignments").val() * 0.5;
    var groupProjectPercent = $("#groupProject").val() * 0.1;
    var quizzesPercent = $("#quizzes").val() * 0.1;
    var examsPercent = $("#exams").val() * 0.2;
    var intexPercent = $("#intex").val() * 0.1;

    //calculate final grade percent 
    var percentCalculated = assignmentsPercent + groupProjectPercent + quizzesPercent + examsPercent + intexPercent;

    //determine letter grade using if function for each range of grades
    var letterCalculated = '';
    if (percentCalculated < 60.0) {
        letterCalculated = 'E';
    }
    else if (percentCalculated >= 60.0 && percentCalculated < 64.0) {
        letterCalculated = 'D-';
    }
    else if (percentCalculated >= 64.0 && percentCalculated < 67.0) {
        letterCalculated = 'D';
    }
    else if (percentCalculated >= 67.0 && percentCalculated < 70.0) {
        letterCalculated = 'D+';
    }
    else if (percentCalculated >= 70.0 && percentCalculated < 74.0) {
        letterCalculated = 'C-';
    }
    else if (percentCalculated >= 74.0 && percentCalculated < 77.0) {
        letterCalculated = 'C';
    }
    else if (percentCalculated >= 77.0 && percentCalculated < 80.0) {
        letterCalculated = 'C+';
    }
    else if (percentCalculated >= 80.0 && percentCalculated < 84.0) {
        letterCalculated = 'B-';
    }
    else if (percentCalculated >= 84.0 && percentCalculated < 87.0) {
        letterCalculated = 'B';
    }
    else if (percentCalculated >= 87.0 && percentCalculated < 90.0) {
        letterCalculated = 'B+';
    }
    else if (percentCalculated >= 90.0 && percentCalculated < 94.0) {
        letterCalculated = 'A-';
    }
    else {
        letterCalculated = 'A';
    }

    //round percent to two decimals and add % sign
    percentCalculated = (percentCalculated.toFixed(2) + "%");

    alert("Percent Grade: " + percentCalculated + "\nLetter Grade: " + letterCalculated);

    //return results to p tags in html page
    $("#percentCalculated").html("Percent Grade: " + percentCalculated);
    $("#letterCalculated").html("Letter Grade: " + letterCalculated);
});