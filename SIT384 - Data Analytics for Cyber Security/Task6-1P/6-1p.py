#   Unit:       SIT384 - Cyber Security Analytics
#   Task:       Pass Task 6.1p
#   Author:     Justin Bland
#   Date:       12/04/2020

# Imports Required

import numpy as np
import matplotlib.pyplot as plt
import pandas as pd

# Import and Prepare Data
Data = pd.read_csv('task6_1_dataset.csv')

x1 = Data['x1'] #col x1 - X Axis
x2 = Data['x2'] # col x2 - Y Axis
x3 = Data['y'] # y Vars


# Definition for Plotting the First Plot
def First_Plot(x,y,z):
    # Variables 
    colors = ['green', 'blue', 'magenta']
    k = 1
    scale = 75
    alpha = 0.6 
    
    from sklearn import neighbors
    weights='uniform'
    knn = neighbors.KNeighborsClassifier(k,weights=weights)
    
    X_train = np.c_[x, y]
    Y_train = z.values
    
    knn.fit(X_train, Y_train)
    
    X_test = [[-4, 8]]
    Y_pred = knn.predict(X_test)
        
    # Plot Settings
    ig,ax = plt.subplots(figsize=(7, 5), dpi = 100)
    plt.title("3-Class classification (k = {})".format(k))
    ax.set_title("3-Class classification (k = {})\n the test point is predicted as class {}".format(k, colors[Y_pred.astype(int)[0]]))
    
    from matplotlib.colors import ListedColormap
    cmap_bold = ListedColormap(['green', 'blue', 'magenta'])
    
    # Plot
    ax.scatter(X_train[:, 0], X_train[:, 1], c=Y_train, cmap=cmap_bold, alpha=alpha, s=scale)  
    ax.scatter(X_test[0][0], X_test[0][1], marker="x", s=scale, lw=2, c='k')
    
    label = '(' + str(X_test[0][0]) + ', ' + str(X_test[0][1]) + ')' + 'Test Point'
    ax.text(X_test[0][0] + 0.5, X_test[0][1], label, fontsize=12)   
    
    
# Definition for Plotting the Second Plot
def Second_Plot(x,y,z):
    # Variables
    colors = ['green', 'blue', 'magenta']
    scale = 75
    alpha = 0.6
    
    from sklearn import neighbors
   
    weights='uniform'
    k = 15
    knn = neighbors.KNeighborsClassifier(k,weights=weights)
        
    X_train = np.c_[x1, x2]
    
    Y_train = z.values
    
    knn.fit(X_train, Y_train)
    
    from matplotlib.colors import ListedColormap
    h = 0.05
    
    cmap_light = ListedColormap(['#AAFFAA', '#AAAAFF', '#FFAAAA'])
    cmap_bold = ListedColormap(['green', 'blue', 'magenta'])
    
    x1_min, x1_max = X_train[:, 0].min() - 1, X_train[:, 0].max() + 1
    x2_min, x2_max = X_train[:, 1].min() - 1, X_train[:, 1].max() + 1
    xx1, xx2 = np.meshgrid(np.arange(x1_min, x1_max, h), np.arange(x2_min, x2_max, h))
    
    knn = neighbors.KNeighborsClassifier(k, weights=weights)
    knn.fit(X_train, Y_train)
    
    Z = knn.predict(np.c_[xx1.ravel(), xx2.ravel()])
    Z = Z.reshape(xx1.shape)
        
    plt.xlim(xx1.min(), xx1.max())
    plt.ylim(xx2.min(), xx2.max())
    
    X_test = [[-2, 5]]
    Y_pred = knn.predict(X_test)
    
    # Plot Settings 
    fig,ax = plt.subplots(figsize=(7, 5), dpi = 100)
    ax.pcolormesh(xx1, xx2, Z, cmap=cmap_light)

    plt.title("3-Class classification (k = {})".format(k))
    ax.set_title("3-Class classification (k = {})\n the test point is predicted as class {}".format(k, colors[Y_pred.astype(int)[0]]))   

    # Plot
    ax.scatter(X_train[:, 0], X_train[:, 1], c=Y_train, cmap=cmap_bold, alpha=alpha, s=scale)
    ax.scatter(X_test[0][0], X_test[0][1], marker="x", s=scale, lw=2, c='k')
    
    label = '(' + str(X_test[0][0]) + ', ' + str(X_test[0][1]) + ')' + 'Test Point'
    ax.text(X_test[0][0] + 0.5, X_test[0][1], label, fontsize=12)


# Program Run
First_Plot(x1,x2,x3)
Second_Plot(x1,x2,x3)
   






