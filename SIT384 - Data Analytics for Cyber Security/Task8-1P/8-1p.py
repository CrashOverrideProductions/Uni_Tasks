#   Unit:       SIT384 - Cyber Security Analytics
#   Task:       Pass Task 8.1p
#   Author:     Justin Bland
#   Date:       10/05/2020

# Imports Required
import numpy as np
import matplotlib.pyplot as plt
from sklearn.decomposition import PCA
from mpl_toolkits.mplot3d import Axes3D 
from sklearn.preprocessing import StandardScaler


# Import Data
from sklearn.datasets import load_breast_cancer
cancer = load_breast_cancer()
y = cancer.target

# Data Minipulation
scaler = StandardScaler()
Scale = scaler.fit_transform(cancer.data)

pca = PCA(n_components=2)
pca.fit(Scale)
PCA_Data = pca.transform(Scale)


# Print PCA Data
def Print_PCA_Data():
    print('Original Shape: ', cancer.data.shape)
    print('Reduced Shape: ', Scale.shape)
    print('PCA Component Shape: ', pca.components_.shape)
    print('PCA Components')
    print(pca.components_)


# 2D Plot
def Generate_2D_Plot(Data, y):
    
    plt.subplots(figsize=(10, 8))
    plt.title('Principal Components')
    plt.xlabel('First Principal Component')
    plt.ylabel('Second Principal Component')
    
    colors = ['blue', 'red']
    lw = 2
    
    i = 0
    z = ["o","^"]
    for color, i, target_name in zip(colors, [0, 1], cancer.target_names):
        plt.scatter(Data[y == i, 0], Data[y == i, 1], color=color, alpha=.8, 
                    lw=lw,label=target_name, marker=z[i], edgecolors='k')
  
    plt.legend()
        

## First 3D Plot
def Generate_3D_Plot_A(Data, y):  
    
    fig = plt.figure(figsize=(10, 8))
    ax = Axes3D(fig, rect=[0, 0, .95, 1], elev=10, azim=10)
    cmap = plt.cm.get_cmap("Spectral")    
    
    y = np.choose(y, [1, 2, 0]).astype(np.float)
    ax.scatter(Data[:, 0], Data[:, 1], Data[:, 2], c=y, cmap=cmap,edgecolor='g')
    
    plt.title('First 3 Features of Scaled X')
    
    plt.show()
      

## Second 3D Plot
def Generate_3D_Plot_B(Data, y):

    fig = plt.figure(figsize=(10, 8))
    ax = Axes3D(fig, rect=[0, 0, .95, 1], elev=10, azim=10)
    cmap = plt.cm.get_cmap("Spectral")
    
    y = np.choose(y, [1, 2, 0]).astype(np.float)
    ax.scatter(Data[:, 0], Data[:, 1], c=y, cmap=cmap,edgecolor='b')
 
    plt.title('First 2 Principal Components of X after PCA Transformation')

    plt.show()
    
Print_PCA_Data()
Generate_2D_Plot(PCA_Data, y)
Generate_3D_Plot_A(Scale, y)
Generate_3D_Plot_B(PCA_Data, y)

