using System;

int currentAssignement = 5;

int[] sophiaNote = new int[] {90, 86, 87, 98, 100, 90, 94};
int[] andrewNote = new int[] {92, 89, 81, 96, 90, 89};
int[] emmaNote = new int[] {90, 85, 87, 98, 68, 89, 89, 89};
int[] loganNote = new int[] {90, 95, 87, 88, 96, 96};
int[] beckyNote = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisNote = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericNote = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorNote = new int[] { 91, 91, 91, 91, 91, 91, 91 };

string[] studentNames = new string[] {"sophia", "andrew", "emma", "logan", "becky", "chris", "eric", "gregor"};
int[] studentsNote= new int[10];
string currentLetter = "";

Console.WriteLine("Student\t\tExam Score\t\tOverall\t\tGrade\t\tExtra Credit\n");
foreach (string name in studentNames)
{
    string student = name;
    if (student == "sophia")
    {
        studentsNote = sophiaNote;
    }
    else if (student == "andrew")
    {
          studentsNote = andrewNote;
    }
    else if (student == "emma")
    {
          studentsNote = emmaNote;
    }
    else if (student == "logan")
    {
          studentsNote = loganNote;
    }
    else if (student == "becky")
    {
          studentsNote = beckyNote;
    }
    else if (student == "chris")
    {
          studentsNote = chrisNote;
    }
    else if (student == "eric")
    {
          studentsNote = ericNote;
    }
    else if (student == "gregor")
    {
          studentsNote = gregorNote;
    }
    else
       continue;
    int sumNotesStudents = 0;
    int extraSumCurrent = 0 ;
    decimal studentsScore = 0;
    decimal extra = 0;
    decimal scoreNote = 0;
    decimal credit = 0;

    int gradedAssignement = 0;
    int gradedAssignementExtra =0;
    foreach (int score in studentsNote)
    {
        gradedAssignement += 1;
        if (gradedAssignement <= currentAssignement)
            sumNotesStudents += score;
        else
        {
            gradedAssignementExtra += 1;
            extraSumCurrent += score ;
        }    
    }
    scoreNote = (decimal)(sumNotesStudents) / currentAssignement;
    studentsScore =  ((decimal)(sumNotesStudents) + ((decimal)(extraSumCurrent) / 10))/currentAssignement;
    extra = (decimal)(extraSumCurrent) / gradedAssignementExtra;
    credit = (decimal)(((decimal)(extraSumCurrent)/10) / currentAssignement);


    if (studentsScore >= 97)
    currentLetter = "A+";
    else if (studentsScore >= 93)
    currentLetter = "A";
    else if (studentsScore >= 90)
    currentLetter = "A-";
    else if (studentsScore >= 87)
    currentLetter = "B+";
    else if (studentsScore >= 83)
    currentLetter = "B";
     else if (studentsScore >= 80)
    currentLetter = "B-";
     else if (studentsScore >= 77)
    currentLetter = "C+";
     else if (studentsScore >= 73)
    currentLetter = "C";
     else if (studentsScore >= 70)
    currentLetter = "C-";
     else if (studentsScore >= 67)
    currentLetter = "D+";
     else if (studentsScore >= 63)
    currentLetter = "D";
     else if (studentsScore >= 60)
    currentLetter = "D-";
     else 
    currentLetter = "F";
    
    Console.WriteLine($"{name}\t\t{scoreNote}\t\t\t{studentsScore}\t\t{currentLetter}\t\t{extra} ({credit} pts)");

}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
