#   Unit:       SIT384 - Cyber Security Analytics
#   Task:       Pass Task 7.1p
#   Author:     Justin Bland
#   Date:       04/05/2020

# Imports Required
import numpy as np
import matplotlib.pyplot as plt
from sklearn.datasets import make_blobs
from sklearn.cluster import KMeans 
from scipy.cluster.hierarchy import dendrogram, ward
from sklearn.cluster import AgglomerativeClustering 


# Data Config
np.random.seed(0)
x =200 # n_samples
y = [3,2], [6,4], [10,5] # centres
z = 0.9 # cluster_std

X, y = make_blobs(n_samples = x, centers = y, cluster_std = z)

def Generate_KMeans(X, y):
    k_means = KMeans(init = "k-means++", n_clusters = 3, n_init = 12)
    k_means.fit(X)
    k_means_labels = k_means.labels_
    k_means_cluster_centers = k_means.cluster_centers_
    
    fig = plt.figure(figsize=(10, 10))
    
    colors = plt.cm.Spectral(np.linspace(0, 1, len(set(k_means_labels))))
   
    ax = fig.add_subplot(1, 1, 1, facecolor = 'black')
    
    for k, col in zip(range(len([[2, 2], [-2, -1], [4, -3], [1, 1]])), colors):
        my_members = (k_means_labels == k)
        cluster_center = k_means_cluster_centers[k]
        ax.plot(X[my_members, 0], X[my_members, 1], 'w', markerfacecolor=col, marker='.')
        ax.plot(cluster_center[0], cluster_center[1], 'o', markerfacecolor=col, markeredgecolor='k', markersize=6)
    
    ax.set_title('KMeans')
    ax.set_xticks(())
    ax.set_yticks(())
    plt.show()
    plt.scatter(X[:, 0], X[:, 1], marker='.')
        
# AgglomerativeClustering
def Generate_AgglomerativeClustering(X, y):
    agglom = AgglomerativeClustering(n_clusters = 4, linkage = 'average')
    agglom.fit(X,y)
    
    plt.figure(figsize=(6,4))
    x_min, x_max = np.min(X, axis=0), np.max(X, axis=0)
    X = (X - x_min) / (x_max - x_min)
    cmap = plt.cm.get_cmap("Spectral")
    
    for i in range(X.shape[0]):       
        plt.text(X[i, 0], X[i, 1], str(y[i]),
                 color=cmap(agglom.labels_[i] / 10.), 
                 fontdict={'weight': 'bold', 'size': 9})
    
    plt.show()
    plt.scatter(X[:, 0], X[:, 1], marker='.')

       
def Generate_Dendrogram(X, y):

    fig,ax = plt.subplots(figsize=(10, 10))

    linkage_array = ward(X)
    dendrogram(linkage_array)
    
    ax = plt.gca()
    bounds = ax.get_xbound()
    ax.plot(bounds, [7.25, 7.25], '--', c='k')
    ax.plot(bounds, [4, 4], '--', c='k')
  


Generate_KMeans(X, y)
Generate_AgglomerativeClustering(X, y)
Generate_Dendrogram(X, y)