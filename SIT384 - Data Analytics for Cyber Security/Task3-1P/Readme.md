# Task 3.1P (Pass Task) - Process data from file

## Overview
You are given a student result data file (result.csv). It has columns:  
ID: student id
Ass1 ~ Ass4: assignment scores (out of 100); weight of ass1, ass2, ass3 and ass4 is 5%, 15%, 5%, and 15%, respectively.
Exam: examination score (out of 120); weight is 60%. Hurdle is 40% of exam total (48)
Total: weighted total result (5%*(ass1+ass3) + 15%*(ass2+ass4) + 60%*exam)

ID Ass1 Ass2 Ass3 Ass4 Exam Total
1 89.1 50 85 88.9 65 66
2 95.1 82.5 90.5 94.5 52 63
3 74.3 54.4 63 63.9 31 42
4 89.8 81.3 82 90.4 37 53
5 91.3 98.8 92.5 95.9 79 77

(The above data is for demonstration purposes only. Please download the full version of result.csv.)
To pass the unit, a student must achieve at least total >= 50 and exam score > 48. Total score has been provided in the .csv. There is no need for you to re‐calculate it.
Read students’ result data from file result.csv, calculate and print:  
- [x] Average of ass1, ass2, ass3, ass4, exam and total column, respectively.  
- [x] Min of ass1, ass2, ass3, ass4, exam and total column, respectively.
- [x] Max of ass1, ass2, ass3, ass4, exam and total column, respectively.


## Submission Details
You must submit following files to onTrack:
- [x] Your program source code (e.g. task3‐1.py)
- [x] A screen shot of your program running
