$("#CalcBtn").click(function () {

    //calculate the grade based ont he weights given in the syllabus
    var aggGrade =
        ((parseFloat($("#fAssi").val()) * (.5)) +
            + (parseFloat($("#fGrou").val()) * (0.1)) +
            + (parseFloat($("#fQuiz").val()) * (0.1))+
            + (parseFloat($("#fMidt").val()) * (0.1))+
            + (parseFloat($("#fFina").val()) * (0.1))+
            + (parseFloat($("#fINTE").val()) * (0.1)));

    aggGrade = aggGrade.toFixed(2);

    //determine the letter grade

    if (aggGrade < 60) {
        letGrade = "E";
    }
    else if (aggGrade < 64) {
        letGrade = "D-";
    }
    else if (aggGrade < 67){
        letGrade = "D";
    }
    else if (aggGrade < 70) {
        letGrade = "D+";
    }
    else if (aggGrade < 74) {
        letGrade = "C-";
    }
    else if (aggGrade < 77) {
        letGrade = "C";
    }
    else if (aggGrade < 80) {
        letGrade = "C+";
    }
    else if (aggGrade < 84) {
        letGrade = "B-";
    }
    else if (aggGrade < 87) {
        letGrade = "B";
    }
    else if (aggGrade < 90) {
        letGrade = "B+";
    }
    else if (aggGrade < 94) {
        letGrade = "A-";
    }
    else if (aggGrade >= 94) {
        letGrade = "A";
    }
 

    //display the calculate grade to the p tag on the webpage
    $("#grdResult").html("Your grade is: " + String(aggGrade) + "% with a letter grade of " + letGrade + ".");
})


