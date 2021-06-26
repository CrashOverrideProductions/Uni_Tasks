#   Unit:       SIT384 - Cyber Security Analytics
#   Task:       Pass Task 3.1P
#   Author:     Justin Bland
#   Date:       22/03/2020

# Imports Required
import pandas as pd

# Read Input File (.csv)
Student_Results = pd.read_csv (r'E:\result1.csv')

# Definition for Calculating Avg, Min, Max
def Data_Set(Assesment):
    print(Assesment, " Avg. ", Student_Results[Assesment].mean())
    print(Assesment, " Min: ", Student_Results[Assesment].min())
    print(Assesment, " Max: ", Student_Results[Assesment].max())
    print()

# Definition for Student with the highest total
def High_Total():
    print("Student with the highest total")
    print(Student_Results[Student_Results['Total']==Student_Results['Total'].max()])

# Calulate and Print
Data_Set('Ass1')
Data_Set('Ass2')
Data_Set('Ass3')
Data_Set('Ass4')
Data_Set('Exam')

High_Total()