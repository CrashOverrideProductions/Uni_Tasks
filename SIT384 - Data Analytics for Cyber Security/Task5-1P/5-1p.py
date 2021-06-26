#   Unit:       SIT384 - Cyber Security Analytics
#   Task:       Pass Task 5.1p
#   Author:     Justin Bland
#   Date:       12/04/2020

# Imports Required
import numpy as np
import matplotlib.pyplot as plt
import pandas as pd

# DataFrame
df = pd.DataFrame({'a': np.random.randint(0, 50, size=100)})
df['b'] = df['a'] + np.random.normal(0,10,size=100)
df['c'] = 100 - 2* df['a'] + np.random.normal(0,10,size=100)
df['d'] = np.random.normal(0,50,100)

# Settings for Plots
color = ['Red', 'Green', 'Blue']

# Function to Generate Coefficent
def Gen_CoEff(x,y, ylabel):
    pearson_r = np.cov(y, x)[0, 1] / (y.std() * x.std())
    coeff = np.corrcoef(x,y)

    print('A and ', ylabel, ' Pearson_r: ', pearson_r)
    print('A and ', ylabel, ' Corrcoef:  ', coeff)

# Function for Plotting Correlation Data - Usage Plot_Corel(Integer, X Axis, Y Axis, Y Label)
def Plot_Corel(i,x, y, ylabel):
    fig, ax = plt.subplots(figsize=(7, 5), dpi=100)
    np.corrcoef(y,x)
    ax.scatter(x,y, alpha=0.6, edgecolor='none', s=100)
    ax.set_xlabel('A')
    ax.set_ylabel(ylabel)
    line_coef = np.polyfit(x, y, 1)
    xx = np.arange(1, 50, 0.1)
    yy = line_coef[0]*xx + line_coef[1]
    ax.plot(xx, yy, color[i], lw=2)
   
# Call Function
Plot_Corel(0, df['a'], df['b'], 'B')
Plot_Corel(1, df['a'], df['c'], 'C')
Plot_Corel(2, df['a'], df['d'], 'D')

# Generate Coefficent
Gen_CoEff(df['a'], df['b'], 'B')
Gen_CoEff(df['a'], df['c'], 'C')
Gen_CoEff(df['a'], df['d'], 'D')