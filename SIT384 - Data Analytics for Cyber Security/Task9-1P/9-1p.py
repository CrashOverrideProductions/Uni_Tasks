#   Unit:       SIT384 - Cyber Security Analytics
#   Task:       Pass Task 9.1p
#   Author:     Justin Bland
#   Date:       12/05/2020

# Imports Required
from sklearn.model_selection import GridSearchCV
from sklearn.svm import SVC
from sklearn.model_selection import train_test_split
from sklearn.datasets import load_digits

# Load Datasets / Set Vars
digits = load_digits()
x = digits.data
y = digits.target

param_grid = {'C':[0.001,0.01,0.1,1,10,100],
              'gamma':[0.001,0.01,0.1,1,10,100]}

# Manipulate Data
grid_search = GridSearchCV(SVC(), param_grid, cv = 5, return_train_score = True)

X_train, X_test, y_train, y_test = train_test_split(x, y, random_state=0)

grid_search.fit(X_train, y_train)

# Generate Output - Usage = Generate_Output(param_grid,grid_search)
def Generate_Output(pg, gs):
    print('Parameter Grid: ')
    print(pg)
    print("Test set score: {:.2f}".format(gs.score(X_test, y_test)))
    print("Best parameters: {}".format(gs.best_params_))
    print("Best cross-validation score: {:.2f}".format(gs.best_score_))
    print("Best estimator:\n{}".format(gs.best_estimator_))
    
    
Generate_Output(param_grid, grid_search)