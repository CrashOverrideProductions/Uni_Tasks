#   Unit:       SIT384 - Cyber Security Analytics
#   Task:       Credit Task 8.2c
#   Author:     Justin Bland
#   Date:       10/05/2020

# Imports Required
import numpy as np
import csv
import matplotlib.pyplot as plt
from sklearn.feature_extraction.text import CountVectorizer
from sklearn.cluster import KMeans
from sklearn.manifold import TSNE

#minimum lenght of a dns name
MIN_LEN=10

#random state
random_state = 170
#random_state = 1


def load_alexa(filename):
    domain_list=[]
    csv_reader = csv.reader(open(filename))
    for row in csv_reader:
        domain=row[1]
        #print(domain)
        if len(domain) >= MIN_LEN:
            domain_list.append(domain)
    return domain_list

def domain2ver(domain):
    ver=[]
    for i in range(0,len(domain)):
        ver.append([ord(domain[i])])
    return ver


def load_dga(filename):
    domain_list=[]
    #xsxqeadsbgvpdke.co.uk,Domain used by Cryptolocker - Flashback DGA for 13 Apr 2017,2017-04-13,
    # http://osint.bambenekconsulting.com/manual/cl.txt
    with open(filename) as f:
        for line in f:
            domain=line.split(",")[0]
            if len(domain) >= MIN_LEN:
                domain_list.append(domain)
    return  domain_list


#load dns data
x1_domain_list = load_alexa("./dga/top-100.csv")
x2_domain_list = load_dga("./dga/dga-cryptolocke-50.txt")
x3_domain_list = load_dga("./dga/dga-post-tovar-goz-50.txt")

x_domain_list=np.concatenate((x1_domain_list, x2_domain_list,x3_domain_list))


y1=[0]*len(x1_domain_list)
y2=[1]*len(x2_domain_list)
y3=[1]*len(x3_domain_list)

y=np.concatenate((y1, y2,y3))

#print (x_domain_list)

cv = CountVectorizer(ngram_range=(2, 2), decode_error="ignore",
                                      token_pattern=r"\w", min_df=1)
X= cv.fit_transform(x_domain_list).toarray()

# apply KMeans and TSNE ...

#--------------------------------- END SUPPLIED CODE --------------------------

# KMeans
k_means = KMeans(n_clusters = 2, random_state = random_state)
k_means.fit(X)
k_means_labels = k_means.labels_
k_means_cluster_centers = k_means.cluster_centers_
y_pred = k_means.predict(X)

# TNSE
X_embedded = TSNE(n_components = 2, learning_rate = 100, random_state = 170).fit_transform(X)


# Definition for Final Output
def Generate_Output(D_Shape,Y_P,E_Shape):
    print('Before TSNE: ', D_Shape)
    z = np.mean(Y_P==y)*100
    print('Accuracy: ', z)
    print('After TSNE: ', E_Shape)
    
def Generate_Plot(Data, y):
    plt.figure(figsize=(10, 8))
    plt.title('DGA Clustering - KMeans') 
    
    #plt.scatter(Data[:,0], Data[:,1], c=y, s=60)
    
    colors = ['blue', 'red']
    lw = 2
    
    i = 0
    z = ["x","o"]
    for color, i, target_name in zip(colors, [0, 1], y):
        plt.scatter(Data[y == i, 0], Data[y == i, 1], color=color, alpha=.8, 
                    lw=lw,label=target_name, marker=z[i], edgecolors='k')
    
  
Generate_Output(X.shape,y_pred,X_embedded.shape)
Generate_Plot(X_embedded, y_pred)