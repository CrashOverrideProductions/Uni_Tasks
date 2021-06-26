#   Unit:       SIT384 - Cyber Security Analytics
#   Task:       Pass Task 4.1p
#   Author:     Justin Bland
#   Date:       01/04/2020

# Imports Required
import numpy as np
import matplotlib.pyplot as plt

# Attack Variables
Attack_Types = ('Cyber Incident', 'Theft of Paperwork or Data Storage Device', 'Rouge Employee / Insider Threat', 'Social Engineering / Impersonation')
AttackT_Data = [108,32,26,11]

Attack_Industry = ('Health Service Providers', 'Finance', 'Education', 'Legal, Accounting and Managment Services', 'Personal Services')
AttackI_Data = [63, 40, 30, 30, 14]

# Definition for Bar Chart - Usage= Generate_BarChart((Label Array),(Data Array))
def Generate_BarChart(x, y):
    fig, ax = plt.subplots(figsize=(7,5), dpi=100)

    ax.set_title('Number of Malicious or Criminal Attack - July to December 2019')
    ax.set_xlabel('Attack Type')
    ax.set_ylabel('Number of Attacks Per Type')
    fig

    Bar_Colours = ('Blue','Red','Green','Yellow')
    y_pos = np.arange(len(Attack_Types))

    plt.xticks(y_pos, x, rotation=90)
    plt.bar(y_pos, y, align='center', color=Bar_Colours)   



# Pie Chart
def Generate_PieChart(x, y):
    Colours = ('Blue','Orange','Green', 'Red','Purple')
    fig1, ax1 = plt.subplots(figsize=(10,10))
    ax1.pie(y, labels=x, autopct='%1.1f%%', colors=Colours)

# Program Start - Call Definitions
Generate_BarChart(Attack_Types, AttackT_Data)
Generate_PieChart(Attack_Industry, AttackI_Data)