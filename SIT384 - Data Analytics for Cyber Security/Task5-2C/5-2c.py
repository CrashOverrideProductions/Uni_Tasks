#   Unit:       SIT384 - Cyber Security Analytics
#   Task:       Credit Task 5.2c
#   Author:     Justin Bland
#   Date:       12/04/2020

# Imports Required
import numpy as np
import matplotlib.pyplot as plt
import pandas as pd

# Import and Prepare Data
Data = pd.read_csv('admission_predict.csv')

Train_Data = Data[0:299]
Test_Data = Data[len(Data)-100:len(Data)]

# Settings for layout
fig,ax = plt.subplots(nrows=2, ncols=2, figsize=(14,10),dpi=100)

# Linear Regression with Test Data
def Test_LinearRegression (pos, x, y, x_Label, y_Label, title):
    Train_X = x
    Train_X = np.c_[Train_X]
    Train_Y = y

    from sklearn import linear_model
    lr = linear_model.LinearRegression()
    lr.fit(Train_X, Train_Y)
    
    # plot training data
    scales = 20*np.ones(len(Train_Y))
    ax[pos].scatter(Train_X,Train_Y,color='b',s=scales,alpha=0.7,edgecolor='r')
    ax[pos].set_xlabel(x_Label)
    ax[pos].set_ylabel(y_Label)
    ax[pos].set_title(title)
    
    # plot the regression line
    train_Yhat = lr.predict(Train_X)
    ax[pos].plot(Train_X,train_Yhat)

# Linear Regression with True Data
def True_LinearRegression(pos, x, y, x_Label, y_Label, title):

    np.corrcoef(x, y)
    
    x = np.c_[x.values]
    y = y.tolist()
    
    from sklearn import linear_model
    lr = linear_model.LinearRegression()
    lr.fit(x,y)
    
    yhat = lr.predict(x)
    
    #plot the result
    scales = 20*np.ones(len(y))
    
    ax[pos].scatter(x,y,color='b',s=scales,alpha=0.7,edgecolor='r')
    
    ax[pos].set_xlabel(x_Label)
    ax[pos].set_ylabel(y_Label)
    ax[pos].set_title(title)
    
    # plot the regression linear leared
    ax[pos].plot(x,yhat)
    
    tmp = np.reshape(x,[1,len(x)])[0]
    tmp_x = []
    tmp_y = []
    for i in range(len(x)):
        tmp_x = np.append(tmp_x,tmp[i])
        tmp_y = np.append(tmp_y,y[i]) 
        tmp_x = np.append(tmp_x,tmp[i]) 
        tmp_y = np.append(tmp_y,yhat[i]) 
        ax[pos].plot(tmp_x,tmp_y,color='g',linewidth=0.5) 
        tmp_x = []
        tmp_y = []



# Variables for calling functions (inluded this to keep the function call lines short)
        
# Variables for ax at position 0,0
TL_X = Train_Data['Chance of Admit'].values
TL_Y = Train_Data['GRE Score'].tolist()
TL_XLabel = 'X (GRE Score)'
TL_YLabel = 'Y (Chance of Admittance)'
TL_Title = 'Linear Regression with GRE Score and Chance of Admittance'

# Variables for ax at position 0,1
TR_X = Test_Data['Chance of Admit']
TR_Y = Test_Data['GRE Score']
TR_XLabel = 'X (GRE Score)'
TR_YLabel = 'Y (Chance of Admittance)'
TR_Title = 'GRE Score VS Chance of Admit: True Value and Residual'

# Variables for ax at position 1,0
BL_X = Train_Data['Chance of Admit'].values
BL_Y = Train_Data['CGPA'].tolist()
BL_XLabel = 'X (CGPA Score)'
BL_YLabel = 'Y (Chance of Admittance)'
BL_Title = 'Linear Regression with CGPA Score and Chance of Admittance'

# Variables for ax at position 1,1
BR_X = Test_Data['Chance of Admit']
BR_Y = Test_Data['CGPA']
BR_XLabel = 'X (CGPA Score)'
BR_YLabel = 'Y (Chance of Admittance)'
BR_Title = 'CGPA Score VS Chance of Admit: True Value and Residual'


Test_LinearRegression((0,0),TL_X, TL_Y, TL_XLabel, TL_YLabel, TL_Title)
Test_LinearRegression((1,0),BL_X, BL_Y, BL_XLabel, BL_YLabel, BL_Title)

True_LinearRegression((0,1),TR_X, TR_Y, TR_XLabel, TR_YLabel, TR_Title)
True_LinearRegression((1,1),BR_X, BR_Y, BR_XLabel, BR_YLabel, BR_Title)
