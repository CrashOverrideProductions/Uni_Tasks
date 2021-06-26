#   Unit:       SIT384 - Cyber Security Analytics
#   Task:       Pass Task 4.2c
#   Author:     Justin Bland
#   Date:       04/04/2020

# Imports Required
import numpy as np
import matplotlib.pyplot as plt
import pandas as pd

# Import CSV File
Data_Input = pd.read_csv(r'E:\file.csv', index_col=0, engine='python')
data = np.array(Data_Input)

# Function to Generate Bar Graphs
def Generate_Graphs(data):

    # Set Variables for both graphs
    Sector = Data_Input.columns
    Type = Data_Input.index
    
    fig, ax = plt.subplots(nrows=1, ncols=2, figsize=(14, 5), dpi=100)
    
    colors = ['Red', 'Yellow','Blue','Green']
    
    title = 'Type of Attack by Top Five Industry Sectors'
    xaxis = 'Top Five Industry Sectors'
    yaxis = 'Number of Attacks'
    
    # Bar Chart - Grouped
    n_groups, n_colours = data.shape
    width = 0.175
    x_pos = np.arange(n_colours)
    
    for i in range(n_groups):
        ax[0].bar(x_pos + i*width, data[i, :], width, align='center', label=Type[i], color=colors[i])
    
    ax[0].set_title(title)
    ax[0].set_xlabel(xaxis)
    ax[0].set_ylabel(yaxis)
    
    ax[0].set_xticks(x_pos+width/2)
    
    ax[0].set_xticks(x_pos+width/2)
    ax[0].set_xticklabels(Sector, rotation=90)
    
    ax[0].legend()
    
    
    
    # Bar Chart - Stacked
    
    Cyber = data[0]
    Theft = data[1]
    Rouge = data[2]
    Social = data[3]
    
    i = np.arange(len(data[0]))
    
    barWidth = 0.35
    Btm = 0
    
    ax[1].bar(x=i, height=Cyber, width=barWidth, color=colors[0], label=Type[0])
    Btm = Btm+Cyber
    
    ax[1].bar(x=i, height=Theft, width=barWidth, bottom=Btm, color=colors[1], label=Type[1])
    Btm = Btm+Theft
    
    ax[1].bar(x=i, height=Rouge, width=barWidth, bottom=Btm, color=colors[2], label=Type[2])
    Btm = Btm+Rouge
    
    ax[1].bar(x=i, height=Social, width=barWidth, bottom=Btm, color=colors[3], label=Type[3])
    
    ax[1].set_xticks(x_pos+width/2)
    ax[1].set_xticklabels(Sector, rotation=90)
    
    
    ax[1].set_title(title)
    ax[1].set_xlabel(xaxis)
    ax[1].set_ylabel(yaxis)
    
    ax[1].legend()


# Program Start - Call Definitions
Generate_Graphs(data)
